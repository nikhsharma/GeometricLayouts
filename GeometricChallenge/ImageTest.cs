using System;
using NUnit.Framework;

namespace GeometricChallenge
{

    [TestFixture]
    public class ImageTest
    {
        [Test]
        public void TestHasResolution() {
            Image image = new Image(60, 60);
            Assert.AreEqual(60, image.Resolution[0]);
            Assert.AreEqual(60, image.Resolution[1]);
        }
    }
}
