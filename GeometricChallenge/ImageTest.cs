using System;
using NUnit.Framework;

namespace GeometricChallenge
{

    [TestFixture]
    public class ImageTest
    {
        Image image;

        [SetUp]
        public void Init() {
            image = new Image(60, 60);
        }

        [Test]
        public void TestHasResolution() {
            Assert.AreEqual(60, image.Resolution[0]);
            Assert.AreEqual(60, image.Resolution[1]);
        }

        [Test]
        public void TestHasListOfTriangles() {
            Assert.AreEqual(0, image.TriangleCount());
        }

    }
}
