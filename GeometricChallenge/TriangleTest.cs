using System;
using NUnit.Framework;

namespace GeometricChallenge
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void TestHasCoodinates()
        {
            Triangle triangle = new Triangle(0, 10, 10);
            Assert.AreEqual(0, triangle.Coords[0]);
            Assert.AreEqual(10, triangle.Coords[1]);
            Assert.AreEqual(10, triangle.Coords[2]);
        }
    }
}
