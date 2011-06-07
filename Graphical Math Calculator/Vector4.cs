using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphicalMathCalculator
{
    public class Vector4 //: Vector
    {
        public double x = 0;
        public double y = 0;
        public double z = 0;
        public double w = 0;

        public Vector4( double x_, double y_, double z_, double w_ )
        {
            x = x_;
            y = y_;
            z = z_;
            w = w_;
        }

        public Vector4()
        {
            // TODO: Complete member initialization
        }

        public void Reset()
        {
            x = y = z = w = 0;
        }

        public Vector4 Add( Vector4 other )
        {
            Vector4 result = new Vector4();

            result.x = x + other.x;
            result.y = y + other.y;
            result.z = z + other.z;
            result.w = w + other.w;

            return result;
        }

        public Vector4 Subtract( Vector4 other )
        {
            return new Vector4( x - other.x, y - other.y, z - other.z, w - other.w );
        }

        public Vector4 Multiply( double scalar )
        {
            return new Vector4( x * scalar, y * scalar, z * scalar, w * scalar );
        }

        public Vector4 Divide( double scalar )
        {
            return new Vector4( x / scalar, y / scalar, z / scalar, w / scalar );
        }

        public void Normalise()
        {
            double inverse = 1.0f / Magnitude();
            x *= inverse;
            y *= inverse;
            z *= inverse;
            w *= inverse;
        }

        public static Vector4 operator +( Vector4 v1, Vector4 v2 )
        {
            return new Vector4( v1.x + v2.x, v1.y + v2.y, v1.z + v2.z, v1.w + v2.w );
        }

        public static Vector4 operator *( Vector4 v1, double v2 )
        {
            return new Vector4( v1.x * v2, v1.y * v2, v1.z * v2, v1.w * v2 );
        }

        public static Vector4 operator -( Vector4 v1, Vector4 v2 )
        {
            return new Vector4( v1.x - v2.x, v1.y - v2.y, v1.z - v2.z, v1.w - v2.w );
        }

        public Vector4 Lerp( Vector4 v1, Vector4 v2, double t )
        {
            Vector4 result = new Vector4();
            result = v1 + ( v1 - v2 ) * t;
            return result;
        }

        public static bool operator ==( Vector4 lhs, Vector4 rhs )
        {
            return ( lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z && lhs.w == rhs.w );
        }

        public static bool operator !=( Vector4 lhs, Vector4 rhs )
        {
            return !( lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z && lhs.w == rhs.w );
        }

        public override bool Equals( object o )
        {
            return this == (Vector4)o;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public double Magnitude()
        {
            return Math.Sqrt( ( x * x ) + ( y * y ) + ( z * z ) + ( w * w ) );
        }

        public double MagnitudeSQ()
        {
            return ( x * x ) + ( y * y ) + ( z * z ) + ( w * w );
        }

        public double Distance( Vector4 v1, Vector4 v2 )
        {
            return Math.Sqrt( DistanceSq( v1, v2 ) );
        }

        public double DistanceSq( Vector4 v1, Vector4 v2 )
        {
            return ( ( v1.x - v2.x ) * ( v1.x - v2.x ) ) + ( ( v1.y - v2.y ) * ( v1.y - v2.y ) );
        }

        #region old
        //public override void Reset()
        //{
        //    x = y = z = w = 0;
        //}

        //public override Vector Add( Vector other )
        //{
        //    Vector4 result = new Vector4();

        //    result.x = x + other.x;
        //    result.y = y + other.y;
        //    result.z = z + other.z;
        //    result.w = w + other.w;

        //    return result;
        //}

        //public override Vector Subtract( Vector other )
        //{
        //    return new Vector4( x - other.x, y / other.y, z / other.z, w / other.w );
        //}

        //public override Vector Multiply( double scalar )
        //{
        //    return new Vector4( x * scalar, y * scalar, z * scalar, w * scalar );
        //}

        //public override Vector Divide( double scalar )
        //{
        //    return new Vector4( x / scalar, y / scalar, z / scalar, w / scalar );
        //}

        //public override void Normalise()
        //{
        //    double inverse = 1.0f / Magnitude();
        //    x *= inverse;
        //    y *= inverse;
        //    z *= inverse;
        //    w *= inverse;
        //}

        //public static Vector4 operator +( Vector4 v1, Vector4 v2 )
        //{
        //    return new Vector4( v1.x + v2.x, v1.y + v2.y, v1.z + v2.z, v1.w + v2.w );
        //}

        //public static Vector4 operator *( Vector4 v1, double v2 )
        //{
        //    return new Vector4( v1.x * v2, v1.y * v2, v1.z * v2, v1.w * v2 );
        //}

        //public static Vector4 operator -( Vector4 v1, Vector4 v2 )
        //{
        //    return new Vector4( v1.x - v2.x, v1.y - v2.y, v1.z - v2.z, v1.w - v2.w );
        //}

        //public Vector Lerp( Vector4 v1, Vector4 v2, double t )
        //{
        //    Vector4 result = new Vector4();
        //    result = v1 + ( v1 - v2 ) * t;
        //    return result;
        //}

        //public static bool operator ==( Vector4 lhs, Vector4 rhs )
        //{
        //    return ( lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z && lhs.w == rhs.w );
        //}

        //public static bool operator !=( Vector4 lhs, Vector4 rhs )
        //{
        //    return !( lhs.x == rhs.x && lhs.y == rhs.y && lhs.z == rhs.z && lhs.w == rhs.w );
        //}

        //public override bool Equals( object o )
        //{
        //    return this == (Vector4)o;
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        //public override double Magnitude()
        //{
        //    return Math.Sqrt( ( x * x ) + ( y * y ) + ( z * z ) + ( w * w ) );
        //}

        //public override  double MagnitudeSQ()
        //{
        //    return ( x * x ) + ( y * y ) + ( z * z ) + ( w * w );
        //}

        //public override double Distance( Vector v1, Vector v2 )
        //{
        //    return Math.Sqrt( DistanceSq( v1, v2 ) );
        //}

        //public override double DistanceSq( Vector v1, Vector v2 )
        //{
        //    return ( ( v1.x - v2.x ) * ( v1.x - v2.x ) ) + ( ( v1.y - v2.y ) * ( v1.y - v2.y ) );
        //}
        #endregion
    }
}
