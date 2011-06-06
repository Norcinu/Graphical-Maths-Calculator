using NUnit.Framework;
using GraphicalMathCalculator;

namespace VectorMatrixTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void AddVectors()
        {
            Vector v1 = new Vector( 1, 2, 3, 1 );
            Vector v2 = new Vector( 1, 3, -2, 1 );
            Vector v3 = new Vector();
            Vector v4 = new Vector( 2, 5, 1, 2 );
            v3 = v1.Add( v2 );
            Assert.That( v3 == v4 );    
        }
        
        [Test]
        public void SubtractVectors()
        {
            Vector v1 = new Vector( 1, 2, 3, 1 );
            Vector v2 = new Vector( 1, 3, -2, 1 );
            Vector v3 = new Vector();
            Vector v4 = new Vector( 0, -1, 1, 0 );
            v3 = v1.Subtract( v2 );
            Assert.That( v3 != v4 );  
        }
    }
}
