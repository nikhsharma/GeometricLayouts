using System;
using System.Collections.Generic;


namespace GeometricChallenge
{
    public class Triangle
    {
        private List<List<int>> coords;
        private string id;

        public List<List<int>> Coords 
        {
            get
            {
                return this.coords;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
        }

        public Triangle(String id, List<int> c1, List<int> c2, List<int> c3)
        {
            this.coords = new List<List<int>>();
            this.coords.Add(c1);
            this.coords.Add(c2);
            this.coords.Add(c3);

            this.id = id;
        }

    }
}
