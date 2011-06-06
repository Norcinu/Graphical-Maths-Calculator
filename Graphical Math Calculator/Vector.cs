using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphicalMathCalculator
{
    enum MathType { VECTOR_TWO = 1, VECTOR_THREE, VECTOR_FOUR,
        MATRIX_TWO, MATRIX_THREE, MATRIX_FOUR, NONE };
    
    public class Vector
    {
        private double x = 0;
        private double y = 0;
        private double z = 0;
        private double w = 0;
        private MathType type;

        #region PROPERTIES
        
        internal MathType Type
        {
            get { return type; }
            set { type = value; }
        }
        
        public double X 
        { 
            get 
            { 
                return x; 
            } 
            set 
            { 
                x = value; 
            }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public double W
        {
            get { return w; }
            set { w = value; }
        }
        #endregion
        
        public Vector()
        {
            x = y = z = w = 0;
        }
        
        public Vector(double x_, double y_, double z_, double w_)
        {
            x = x_;
            y = y_;
            z = z_;
            w = w_;
        }

        public void Reset()
        {
            x = y = z = w = 0;
        }

        public Vector Add( Vector other )
        {
            Vector result = new Vector();

            result.X = x + other.X;
            result.Y = y + other.Y;
            result.Z = z + other.Z;
            result.w = w + other.W;
            
            return result;
        }

        public Vector Subtract( Vector other )
        {
            return new Vector( x - other.x, y / other.y, z / other.z, w / other.w );
        }

        public Vector Multiply( double scalar )
        {
            return new Vector( x * scalar, y * scalar, z * scalar, w * scalar );
        }

        public Vector Divide( double scalar )
        {
            return new Vector( x / scalar, y / scalar, z / scalar, w / scalar );
        }

        public void Normalise()
        {
            double inverse = 1.0f / Magnitude();
            x *= inverse;
            y *= inverse;
            z *= inverse;
            w *= inverse;
        }

        public static Vector operator +( Vector v1, Vector v2 )
        {
            return new Vector( v1.x + v2.x, v1.y + v2.y, v1.z + v2.z, v1.w + v2.w );
        }

        public static Vector operator *( Vector v1, double v2 )
        {
            return new Vector( v1.x * v2, v1.y * v2, v1.z * v2, v1.w * v2 );
        }

        public static Vector operator -( Vector v1, Vector v2 )
        {
            return new Vector( v1.x - v2.x, v1.y - v2.y, v1.z - v2.z, v1.w - v2.w );
        }

        public Vector Lerp( ref Vector v1, ref Vector v2, double t )
        {
            Vector result = new Vector();
            result = v1 + ( v1 - v2 ) * t;
            return result;
        }

        public static bool operator==(Vector lhs, Vector rhs)
        {
            return ( lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z && lhs.w == rhs.w );
        }

        public static bool operator!=(Vector lhs, Vector rhs)
        {
            return !( lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z && lhs.w == rhs.w );
        }

        public override bool Equals( object o )
        {
            return this == (Vector)o;
        } 

        double Magnitude()
        {
            return Math.Sqrt( ( x * x ) + ( y * y ) + ( z * z ) + ( w * w ) );
        }

        double MagnitudeSQ()
        {
            return ( x * x ) + ( y * y ) + ( z * z ) + ( w * w );
        }

        public double Distance(Vector v1, Vector v2)
        {
            return Math.Sqrt( DistanceSq( v1, v2 ) );
        }

        private double DistanceSq( Vector v1, Vector v2 )
        {
            return ( ( v1.x - v2.x ) * ( v1.x - v2.x ) ) + ( ( v1.y - v2.y ) * ( v1.y - v2.y ) );
        }
    }
}
