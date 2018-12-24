namespace lab3
{
    using System;
    using NUnit.Framework;
    /// <summary>
    /// Tests Vector
    /// </summary>
    ///
    [TestFixture]
    public class VectorTest
    {
        private Vector v1;
        private Vector v2;
        private Vector v3;
        private Vector v4;

        /// <summary>
        /// Initializes Vector test objects
        /// </summary>
        /// 
        [SetUp]
        protected void SetUp()
        {
            v1 = new Vector(1, 2, 3);
            v2 = new Vector(-2, 4, -2);
            v3 = new Vector(4, 8, 12);
            v4 = new Vector(12, -42, 11);
        }

        /// <summary>
		/// Assert that AreOrthogonal is correct
		/// </summary>
        ///
        [Test]
        public void OrthogonalTest()
        {
            Assert.IsTrue(Vector.AreOrthogonal(v1, v2));
            Assert.IsFalse(Vector.AreOrthogonal(v1, v3));
        }

        /// <summary>
        /// Assert that AreCoplanar is correct
        /// </summary>
        ///
        [Test]
        public void CoplanarTest()
        {
            Assert.IsTrue(Vector.AreCoplanar(v1, v2, v3));
            Assert.IsFalse(Vector.AreCoplanar(v1, v2, v4));
        }

        /// <summary>
        /// Assert that BuildArray is correct
        /// </summary>
        ///
        [Test]
        public void BuildArrayTest()
        {
            int size = 42;
            var vectors = Vector.BuildArray(size);
            Assert.IsInstanceOf<Vector[]>(vectors);
            Assert.IsTrue(vectors.Length == size);
        }

        /// <summary>
        /// Assert that CompareTo is correct
        /// </summary>
        ///
        [Test]
        public void CompareToTest()
        {
            Assert.IsTrue(v1.CompareTo(v2) == -1);
            Assert.IsTrue(v1.CompareTo(v1) == 0);
        }


    }
}