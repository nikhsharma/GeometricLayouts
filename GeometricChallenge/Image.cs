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

        public List<Triangle> Triangles
        {
            get
            {
                return this.triangles;
            }
        }

        public Image()
        {
            this.resolution = new int[2];
            this.resolution[0] = 60;
            this.resolution[1] = 60;

            this.triangles = new List<Triangle>();

            this.GenerateTriangles();
        }

        public int TriangleCount()
        {
            return this.triangles.Count;
        }

        private void GenerateTriangles()
        {
            int x = 0;
            int y = 0;
            int column = 1;

            while (y <= 50)
            {
                
                // Generate row
                string row = "";
                switch (y)
                {
                    case 0:
                        row = "A";
                        break;
                    case 10:
                        row = "B";
                        break;
                    case 20:
                        row = "C";
                        break;
                    case 30:
                        row = "D";
                        break;
                    case 40:
                        row = "E";
                        break;
                    case 50:
                        row = "F";
                        break;
                }


                List<int> t1c1 = new List<int>() { x, y };
                List<int> t1c2 = new List<int>() { x + 10, y + 10 };
                List<int> t1c3 = new List<int>() { x, y + 10 };

                Triangle t1 = new Triangle(row + column, t1c1, t1c2, t1c3);
                this.triangles.Add(t1);

                column++;



                List<int> t2c1 = new List<int>() { x, y };
                List<int> t2c2 = new List<int>() { x + 10, y };
                List<int> t2c3 = new List<int>() { x + 10, y + 10 };

                Triangle t2 = new Triangle(row + column, t2c1, t2c2, t2c3);
                this.triangles.Add(t2);

                column++;


                if (x == 50)
                {
                    x = 0;
                    y += 10;
                    column = 1;
                }
                else
                {
                    x += 10;
                }

            }
        }
    }
}


