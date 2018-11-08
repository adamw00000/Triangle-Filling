using System;

namespace Triangle_Filling
{
    public struct Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public double Length => Math.Sqrt(X * X + Y * Y + Z * Z);

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void Normalize()
        {
            double l = Length;
            X /= l;
            Y /= l;
            Z /= l;
        }

        public void NormalizeByZ()
        {
            if (Z == 0)
            {
                Normalize();
            }
            X /= Z;
            Y /= Z;
            Z /= Z;
        }

        public static Vector3D operator+(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector3D operator*(Vector3D v1, double a)
        {
            return new Vector3D(v1.X * a, v1.Y * a, v1.Z * a);
        }

        public static Vector3D operator*(double a, Vector3D v1)
        {
            return new Vector3D(v1.X * a, v1.Y * a, v1.Z * a);
        }

        public static double DotProduct(Vector3D v1, Vector3D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }
    }
}