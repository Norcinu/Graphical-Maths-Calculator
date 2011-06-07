using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphicalMathCalculator
{
    enum MathType { VECTOR_TWO = 1, VECTOR_THREE, VECTOR_FOUR,
        MATRIX_TWO, MATRIX_THREE, MATRIX_FOUR, NONE };
    
    //public abstract class 
    public abstract class Vector
    {
        public double x = 0;
        public double y = 0;
        public double z = 0;
        public double w = 0;
        
        public abstract Vector Add( Vector other );
        public abstract Vector Subtract( Vector other );
        public abstract Vector Multiply( double scalar );
        public abstract Vector Divide( double scalar );
        public abstract void Normalise();
        public abstract void Reset();
        public abstract double Magnitude();
        public abstract double MagnitudeSQ();
        public abstract double Distance( Vector v1, Vector v2 );
        public abstract double DistanceSq( Vector v1, Vector v2 );
    }
}
