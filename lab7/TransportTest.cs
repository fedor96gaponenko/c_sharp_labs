namespace lab7
{
    using System;
    using NUnit.Framework;
    /// <summary>
    /// Tests Transport
    /// </summary>
    ///
    [TestFixture]
    public class TransportTest
    {
        private IVehicle tram;
        private int capacity = 10;

        /// <summary>
        /// Initializes Tram test objects
        /// </summary>
        /// 
        [SetUp]
        protected void SetUp()
        {
            tram = new Tram(capacity);
        }

        /// <summary>
		/// Assert that Tram is PublicTransport
		/// </summary>
        ///
        [Test]
        public void TramIsPublicTransportTest()
        {
            Assert.IsTrue(tram.GetType().IsSubclassOf(typeof(PublicTransport)));
        }

        /// <summary>
        /// Assert that Tram has Move method from IVehicle
        /// </summary>
        ///
        [Test]
        public void MoveTest()
        {
            var dist = 10;

            tram.Move(dist);

            Assert.IsTrue(tram.distance.Equals(dist));
        }


    }
}