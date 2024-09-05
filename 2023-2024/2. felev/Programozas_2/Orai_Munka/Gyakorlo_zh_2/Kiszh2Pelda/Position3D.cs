using System;


namespace Kiszh2Pelda
{
    internal class Position3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Position3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Position3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double DistanceTo(Position3D other)
        {
            return Math.Sqrt((this.X - other.X) * (this.X - other.X) + (this.Y - other.Y) * (this.Y - other.Y) + (this.Z - other.Z) * (this.Z - other.Z));
        }

        public override string ToString()
        {
            return $"({X};{Y};{Z})";
        }
    }
}
