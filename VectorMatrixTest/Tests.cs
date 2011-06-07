using NUnit.Framework;
using GraphicalMathCalculator;

namespace VectorMatrixTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void AddVector2()
        {
            Vector2 v1 = new Vector2( 1, 2 );
            Vector2 v2 = new Vector2( 1, 3 );
            Vector2 v3 = new Vector2();
            Vector2 v4 = new Vector2( 2, 5 );
            v3 = v1.Add( v2 );
            Assert.That( v3 == v4 );    
        }
        
        [Test]
        public void SubtractVector2()
        {
            Vector2 v1 = new Vector2( 1, 2 );
            Vector2 v2 = new Vector2( 1, 3 );
            Vector2 v3 = new Vector2();
            Vector2 v4 = new Vector2( 0, -1 );
            v3 = v1.Subtract( v2 );
            Assert.That( v3 != v4 );  
        }
    }
}
