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
            Vector2 v1 = new Vector2( 1, 1 );
            Vector2 v2 = new Vector2( 2, 2 );
            Vector2 v3 = new Vector2();
            v3 = Vector2.Add( v1, v2 );
            Assert.That( v3, Is.EqualTo( new Vector2( 3, 3 ) ) );
        }
        
        [Test]
        public void SubtractVector2()
        {
            Vector2 v1 = new Vector2( 1, 2 );
            Vector2 v2 = new Vector2( 1, 3 );
            Vector2 v3 = new Vector2();
            v3 = Vector2.Subtract( v1, v2 );
            Assert.That( v3, Is.EqualTo( new Vector2( 0, -1 ) ) );
        }

        [Test]
        public void MultiplyVector2()
        {
            Vector2 v1 = new Vector2( 1, 1 );
            Vector2 v2 = new Vector2( 2, 2 );
            Vector2 v3 = new Vector2();
            v3 = Vector2.Multiply( v2, 2 );
            Assert.That( v3, Is.EqualTo( new Vector2( 4, 4 ) ) );
        }

        [Test]
        public void AddVector3()
        {
            Vector3 v1 = new Vector3();
            Vector3 v2 = new Vector3( 1, 2, 3 );
            Vector3 v3 = new Vector3();
            v3 = Vector3.Add( v1, v2 );
            Assert.That( v3, Is.EqualTo( new Vector3( 1, 2, 3 ) ) );
        }

        [Test]
        public void SubtractVector3()
        {
            Vector3 v1 = new Vector3( 3, 1, 2 );
            Vector3 v2 = new Vector3( 2, 1, 1 );
            Vector3 v3 = new Vector3();
            v3 = Vector3.Subtract( v1, v2 );
            Assert.That( v3, Is.EqualTo( new Vector3( 1, 0, 1 ) ) );

            v3.Reset();
            v3 = v1 - v2;
            Assert.That( v3, Is.EqualTo( new Vector3( 1, 0, 1 ) ) );
        }

        [Test]
        public void MultiplyVector3()
        {
            Vector3 v1 = new Vector3( 3, 1, 2 );
            Vector3 v2 = new Vector3();
            v2 = Vector3.Multiply( v1, 2 );
            Assert.That( v2, Is.EqualTo( new Vector3( 6, 2, 4 ) ) );

            Vector3 v3 = new Vector3( 2, 3, 2 );
            v2.Reset();
            v2 = v1 * 3;
            Assert.That( v2, Is.EqualTo( new Vector3( 9, 3, 6 ) ) );
        }
    }
}
