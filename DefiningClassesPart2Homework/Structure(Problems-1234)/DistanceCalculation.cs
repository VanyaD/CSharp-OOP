using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public static class DistanceCalculation
    {
        public class Path
        {
            private List<Point3D> points;

            public Path()
            {
                this.Points = points;
            }

            public List<Point3D> Points
            {
                get
                {
                    return this.points;
                }
                set
                {
                    this.points = value;
                }
            }

            public List<Point3D> AddPoint(Point3D points)
            {
                this.points.Add(new Point3D());
                return this.points;
            }

        }

        public struct Point3D
        {
            private static readonly Point3D startPoint = new Point3D(0, 0, 0);

            private int x;
            private int y;
            private int z;

            public Point3D(int x, int y, int z)
                : this()
            {
                this.X = x;
                this.Y = y;
                this.Z = z;
            }

            public static Point3D StartPoint
            {
                get
                {
                    return startPoint;
                }
            }
            public int X
            {
                get
                {
                    return this.x;
                }
                set
                {
                    this.x = value;
                }
            }

            public int Y
            {
                get
                {
                    return this.y;
                }
                set
                {
                    this.y = value;
                }
            }

            public int Z
            {
                get
                {
                    return this.z;
                }
                set
                {
                    this.z = value;
                }
            }
            public override string ToString()
            {
                string x = this.X.ToString();
                string y = this.Y.ToString();
                string z = this.Z.ToString();
                return "P = {" + x + ", " + y + ", " + z + "}";
            }
        }

        private static float distance;

        public static float Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
            }
        }
        public static float CalculateDistance(Point3D point1, Point3D point2)
        {
            float deltaX = point1.X - point2.X;
            float deltaY = point1.Y - point2.Y;
            float deltaZ = point1.Z - point2.Z;

            float distance = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalculateDistance(new Point3D(5, 6, 2), new Point3D(1, 2, 3)));
        }
    }
}
