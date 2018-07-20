using System;

namespace GeometricChallenge
{
    public class Image
    {
        int[] resolution;

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
        }
    }
}
