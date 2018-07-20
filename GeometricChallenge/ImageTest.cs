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
            image = new Image();
        }

        [Test]
        public void TestHasResolution() {
            Assert.AreEqual(60, image.Resolution[0]);
            Assert.AreEqual(60, image.Resolution[1]);
        }

        [Test]
        public void TestCanGenerateTriangles() {
            Assert.AreEqual(72, image.TriangleCount());
        }

        [Test]
        public void TestGeneratedTrianglesHaveCorrectId()
        {
            Assert.AreEqual("A1", image.Triangles[0].Id);
            Assert.AreEqual("A2", image.Triangles[1].Id);
            Assert.AreEqual("A3", image.Triangles[2].Id);
            Assert.AreEqual("A4", image.Triangles[3].Id);
            Assert.AreEqual("A12", image.Triangles[11].Id);
            Assert.AreEqual("B1", image.Triangles[12].Id);
            Assert.AreEqual("F12", image.Triangles[71].Id);
        }

    }
}
