using System;
using NUnit.Framework;
using System.Collections.Generic;


namespace GeometricChallenge
{
    [TestFixture]
    public class TriangleTest
    {
        Triangle triangle;
        List<int> c1;
        List<int> c2;
        List<int> c3;

        [SetUp]
        public void Init()
        {
            c1 = new List<int>(){ 0, 0 };
            c2 = new List<int>() { 10, 10 };
            c3 = new List<int>() { 0, 10 };
            triangle = new Triangle("A0", c1, c2, c3);
        }

        [Test]
        public void TestHasCoodinates()
        {
            Assert.AreEqual(c1, triangle.Coords[0]);
            Assert.AreEqual(c2, triangle.Coords[1]);
            Assert.AreEqual(c3, triangle.Coords[2]);
        }

    }
}
