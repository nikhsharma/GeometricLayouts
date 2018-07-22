using System;
using System.Collections.Generic;
using System.Linq;

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
                string row = this.GenerateRow(y);

                this.CreateAndAddTriangle(1, row + column, x, y);
                column++;

                this.CreateAndAddTriangle(2, row + column, x, y);
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

        private string GenerateRow(int y)
        {
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

            return row;
        }

        private void CreateAndAddTriangle(int triangle, string id, int x, int y)
        {
            switch (triangle)
            {
                case 1:
                    List<int> t1c1 = new List<int>() { x, y };
                    List<int> t1c2 = new List<int>() { x + 10, y + 10 };
                    List<int> t1c3 = new List<int>() { x, y + 10 };

                    Triangle t1 = new Triangle(id, t1c1, t1c2, t1c3);
                    this.triangles.Add(t1);
                    break;
                case 2:
                    List<int> t2c1 = new List<int>() { x, y };
                    List<int> t2c2 = new List<int>() { x + 10, y };
                    List<int> t2c3 = new List<int>() { x + 10, y + 10 };

                    Triangle t2 = new Triangle(id, t2c1, t2c2, t2c3);
                    this.triangles.Add(t2);
                    break;                    
            }
        }

        public List<List<int>> GetCoords(string row, int column)
        {
            string id = row + column;
            foreach (Triangle triangle in this.triangles)
            {
                if (triangle.Id == id)
                {
                    return triangle.Coords;
                }
            }
            return null;
        }

        public string GetId(List<int> c1, List<int> c2, List<int> c3)
        {
            foreach (Triangle triangle in this.triangles)
            {
                if (triangle.Coords[0].SequenceEqual(c1) && triangle.Coords[1].SequenceEqual(c2) && triangle.Coords[2].SequenceEqual(c3))
                {
                    return triangle.Id;
                }
            }
            return null;
        }
    }
}


