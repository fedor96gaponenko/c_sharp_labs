using System;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace lab3
{
    public class Vector : IComparable
    {
        private double x;
        private double y;
        private double z;

        public static bool AreOrthogonal(Vector v1, Vector v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z == 0;
        }

        public static Vector[] BuildArray(int size)
        {
            Vector[] vectors = new Vector[size];
            Random rand = new Random();

            for (var i = 0; i < size; i++)
            {
                vectors[i] = new Vector(rand.Next(-size, size), rand.Next(-size, size), rand.Next(-size, size));
            }

            return vectors;
        }

        public static bool AreCoplanar(Vector v1, Vector v2, Vector v3)
        {
            Matrix<double> M = DenseMatrix.OfArray(new double[,] {
                {v1.x, v1.y, v1.z},
                {v2.x, v2.y, v2.z},
                {v3.x, v3.y, v3.z}
            });

            return M.Determinant() == 0;
        }

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int CompareTo(object o)
        {
            Vector p = o as Vector;
            if (p != null)
                return this.Length().CompareTo(p.Length());
            else
                throw new Exception("Couldn't compare");
        }

        public double Length()
        {
            return Math.Pow(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2), 0.5);
        }


    }
}
