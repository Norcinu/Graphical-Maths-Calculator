﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphicalMathCalculator
{
    public class Vector3 //: Vector
    {
        public double x = 0;
        public double y = 0;
        public double z = 0;

        public Vector3()
        {
        }

        public Vector3( double x_, double y_, double z_ )
        {
            x = x_;
            y = y_;
            z = z_;
        }

        public void Reset()
        {
            x = y = z = 0;
        }

        public static Vector3 Add( Vector3 lhs, Vector3 rhs )
        {
            Vector3 result = new Vector3();
            result.x = lhs.x + rhs.x;
            result.y = lhs.y + rhs.y;
            result.z = lhs.z + rhs.z;
            return result;
        }

        public static Vector3 Subtract( Vector3 lhs, Vector3 rhs )
        {
            return new Vector3( lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z );
        }

        public static Vector3 Multiply( Vector3 lhs, double scalar )
        {
            return new Vector3( lhs.x * scalar, lhs.y * scalar, lhs.z * scalar );
        }

        public static Vector3 Divide( Vector3 lhs, double scalar )
        {
            return new Vector3( lhs.x / scalar, lhs.y / scalar, lhs.z / scalar );
        }

        public void Normalise()
        {
            double inverse = 1.0f / Magnitude();
            x *= inverse;
            y *= inverse;
            z *= inverse;
        }

        public double Magnitude()
        {
            return Math.Sqrt( ( x * x ) + ( y * y ) + ( z * z ) );
        }

        public double MagnitudeSQ()
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

        public Vector3 Lerp( Vector3 v1, Vector3 v2, double t )
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

        public double Distance( Vector3 v1, Vector3 v2 )
        {
            return Math.Sqrt( DistanceSq( v1, v2 ) );
        }

        public double DistanceSq( Vector3 v1, Vector3 v2 )
        {
            return ( ( v1.x - v2.x ) * ( v1.x - v2.x ) ) + ( ( v1.y - v2.y ) * ( v1.y - v2.y ) );
        }
    }
}
