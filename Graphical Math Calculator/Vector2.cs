using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphicalMathCalculator
{
    public class Vector2 //: Vector
    {
        public double x = 0;
        public double y = 0;

        public Vector2()
        {
        }

        public Vector2( double x_, double y_ )
        {
            x = x_;
            y = y_;
        }

        public void Reset()
        {
            x = y = 0;
        }

        public static Vector2 Add( Vector2 lhs, Vector2 rhs )
        {
            Vector2 result = new Vector2();
            result.x = lhs.x + rhs.x;
            result.y = lhs.y + rhs.y;
            return result;
        }

        public static Vector2 Subtract( Vector2 lhs, Vector2 rhs )
        {
            return new Vector2( lhs.x - rhs.x, lhs.y - rhs.y );
        }

        public static Vector2 Multiply( Vector2 v, double scalar )
        {
            return new Vector2( v.x * scalar, v.y * scalar );
        }

        public Vector2 Divide( double scalar )
        {
            return new Vector2( x / scalar, y / scalar );
        }

        public void Normalise()
        {
            double inverse = 1.0f / Magnitude();
            x *= inverse;
            y *= inverse;
        }

        public static Vector2 operator +( Vector2 v1, Vector2 v2 )
        {
            return new Vector2( v1.x + v2.x, v1.y + v2.y );
        }

        public static Vector2 operator *( Vector2 v1, double v2 )
        {
            return new Vector2( v1.x * v2, v1.y * v2 );
        }

        public static Vector2 operator -( Vector2 v1, Vector2 v2 )
        {
            return new Vector2( v1.x - v2.x, v1.y - v2.y );
        }

        public Vector2 Lerp( Vector2 v1, Vector2 v2, double t )
        {
            Vector2 result = new Vector2();
            result = v1 + ( v1 - v2 ) * t;
            return result;
        }

        public static bool operator ==( Vector2 lhs, Vector2 rhs )
        {
            return ( lhs.x == rhs.x && lhs.y == rhs.y );
        }

        public static bool operator !=( Vector2 lhs, Vector2 rhs )
        {
            return !( lhs.x == rhs.x && lhs.y == rhs.y );
        }

        public override bool Equals( object o )
        {
            return this == (Vector2)o;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public double Magnitude()
        {
            return Math.Sqrt( ( x * x ) + ( y * y ) );
        }

        public double MagnitudeSQ()
        {
            return ( x * x ) + ( y * y );
        }

        public double Distance( Vector2 v1, Vector2 v2 )
        {
            return Math.Sqrt( DistanceSq( v1, v2 ) );
        }

        public double DistanceSq( Vector2 v1, Vector2 v2 )
        {
            return ( ( v1.x - v2.x ) * ( v1.x - v2.x ) ) + ( ( v1.y - v2.y ) * ( v1.y - v2.y ) );
        }

        #region old
        //public override void Reset()
        //{
        //    x = y = 0;
        //}

        //public override Vector Add( Vector other )
        //{
        //    Vector result = new Vector2();
        //    result.x = x + other.x;
        //    result.y = y + other.y;
        //    return result;
        //}

        //public override Vector Subtract( Vector other )
        //{
        //    Vector result = new Vector2();
        //    result.x = x - other.x;
        //    result.y = y - other.y;
        //    return result;
        //    //return new Vector( x - other.x, y - other.y );
        //}

        //public override Vector Multiply( double scalar )
        //{
        //    return new Vector2( x * scalar, y * scalar );
        //}

        //public override Vector Divide( double scalar )
        //{
        //    return new Vector2( x / scalar, y / scalar );
        //}

        //public override void Normalise()
        //{
        //    double inverse = 1.0f / Magnitude();
        //    x *= inverse;
        //    y *= inverse;
        //}

        //public static Vector2 operator +( Vector2 v1, Vector2 v2 )
        //{
        //    return new Vector2( v1.x + v2.x, v1.y + v2.y );
        //}

        //public static Vector2 operator *( Vector2 v1, double v2 )
        //{
        //    return new Vector2( v1.x * v2, v1.y * v2 );
        //}

        //public static Vector2 operator -( Vector2 v1, Vector2 v2 )
        //{
        //    return new Vector2( v1.x - v2.x, v1.y - v2.y );
        //}

        //public Vector2 Lerp( Vector2 v1, Vector2 v2, double t )
        //{
        //    Vector2 result = new Vector2();
        //    result = v1 + ( v1 - v2 ) * t;
        //    return result;
        //}

        //public static bool operator ==( Vector2 lhs, Vector2 rhs )
        //{
        //    return ( lhs.x == rhs.x && lhs.y == rhs.y );
        //}

        //public static bool operator !=( Vector2 lhs, Vector2 rhs )
        //{
        //    return !( lhs.x == rhs.x && lhs.y == rhs.y );
        //}

        //public override bool Equals( object o )
        //{
        //    return this == (Vector2)o;
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        //public override double Magnitude()
        //{
        //    return Math.Sqrt( ( x * x ) + ( y * y ) );
        //}

        //public override double MagnitudeSQ()
        //{
        //    return ( x * x ) + ( y * y );
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
