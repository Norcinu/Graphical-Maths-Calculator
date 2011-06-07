using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphicalMathCalculator
{
    public class Vector3 : Vector
    {
        public Vector3()
        {
        }

        public Vector3( double x_, double y_, double z_ )
        {
            x = x_;
            y = y_;
            z = z_;
        }

        public override void Reset()
        {
            x = y = z = 0;
        }

        public override Vector Add( Vector other )
        {
            Vector3 result = new Vector3();
            result.x = x + other.x;
            result.y = y + other.y;
            result.z = z + other.z;
            return result;
        }

        public override Vector Subtract( Vector other )
        {
            return new Vector3( x - other.x, y / other.y, z / other.z );
        }

        public override Vector Multiply( double scalar )
        {
            return new Vector3( x * scalar, y * scalar, z * scalar );
        }

        public override Vector Divide( double scalar )
        {
            return new Vector3( x / scalar, y / scalar, z / scalar );
        }

        public override void Normalise()
        {
            double inverse = 1.0f / Magnitude();
            x *= inverse;
            y *= inverse;
            z *= inverse;
        }

        public override double Magnitude()
        {
            return Math.Sqrt( ( x * x ) + ( y * y ) + ( z * z ) );
        }

        public override double MagnitudeSQ()
        {
            return ( x * x ) + ( y * y ) + ( z * z );
        }

        public static Vector3 operator +( Vector3 v1, Vector3 v2 )
        {
            return new Vector3( v1.x + v2.x, v1.y + v2.y, v1.z + v2.z );
        }

        public static Vector3 operator *( Vector3 v1, double v2 )
        {
            return new Vector3( v1.x * v2, v1.y * v2, v1.z * v2 );
        }

        public static Vector3 operator -( Vector3 v1, Vector3 v2 )
        {
            return new Vector3( v1.x - v2.x, v1.y - v2.y, v1.z - v2.z );
        }

        public Vector Lerp( Vector3 v1, Vector3 v2, double t )
        {
            Vector3 result = new Vector3();
            result = v1 + ( v1 - v2 ) * t;
            return result;
        }

        public static bool operator ==( Vector3 lhs, Vector3 rhs )
        {
            return ( lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z );
        }

        public static bool operator !=( Vector3 lhs, Vector3 rhs )
        {
            return !( lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z );
        }

        public override bool Equals( object o )
        {
            return this == (Vector3)o;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override double Distance( Vector v1, Vector v2 )
        {
            return Math.Sqrt( DistanceSq( v1, v2 ) );
        }

        public override double DistanceSq( Vector v1, Vector v2 )
        {
            return ( ( v1.x - v2.x ) * ( v1.x - v2.x ) ) + ( ( v1.y - v2.y ) * ( v1.y - v2.y ) );
        }
    }
}
