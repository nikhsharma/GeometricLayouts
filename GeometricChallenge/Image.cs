using System;
using System.Collections.Generic;

namespace GeometricChallenge
{
    public class Image
    {
        private int[] resolution;
        private List<Triangle> triangles;

        public int[] Resolution
        {
            get
            {
                return this.resolution;
            }
        }

        public Image(int lng, int wdth)
        {
            this.resolution = new int[2];
            this.resolution[0] = lng;
            this.resolution[1] = wdth;

            this.triangles = new List<Triangle>();
        }

        public int TriangleCount() {
            return this.triangles.Count;
        }
    }
}
