using System;
namespace GeometricChallenge
{
    public class Triangle
    {
        int[] coords;

        public int[] Coords 
        {
            get
            {
                return this.coords;
            }
        }

        public Triangle(int c1, int c2, int c3)
        {
            this.coords = new int[3];
            this.coords[0] = c1;
            this.coords[1] = c2;
            this.coords[2] = c3;
        }
    }
}
