using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphical_Math_Calculator
{
    enum VectorType { TWO = 1, THREE, FOUR };
    
    class Vector
    {
        private int x = 0;
        private int y = 0;
        private int z = 0;
        private int w = 0;
        private VectorType type;

        #region PROPERTIES
        
        internal VectorType Type
        {
            get { return type; }
            set { type = value; }
        }
        
        public int X 
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

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public int W
        {
            get { return w; }
            set { w = value; }
        }
        #endregion
        
        public void Reset()
        {
            x = y = z = w = 0;
        }

        public Vector Add( ref Vector other )
        {
            Vector result = new Vector();
            
            result.X = this.x + other.X;
            result.Y = this.y + other.Y;
            result.Z = this.z + other.Z;
            result.w = this.w + other.W;
            
            return result;
        }
    }
}
