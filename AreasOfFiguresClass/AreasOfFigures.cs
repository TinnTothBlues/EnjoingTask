using System;

namespace AreasOfFiguresLib
{
    public class AreaOfFigures
    {
        /// <summary>
        /// Automatic difinition and processing the area of a figure
        /// </summary>
        /// <param name="figureSides">Array of sides</param>
        /// <returns></returns>
        public double FigureArea(double[] figureSides)
        {
            foreach (double side in figureSides)
            {
                if (side <= 0)
                {
                    throw new ArgumentException("Sides should be > 0");
                }
            }

            int sideCount = figureSides.Length;
            if (sideCount == 1)
            {
                return CircleArea(figureSides[0]);
            }
            else if (sideCount == 2)
            {
                return SimpleRectangleArea(figureSides);
            }
            else if (sideCount == 3)
            {
                return TriangleArea(figureSides);
            }
            else
            {
                throw new ArgumentException("Too many sides");
            }
        }


        /// <summary>
        /// Processing circle area
        /// </summary>
        public static double CircleArea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Sides should be > 0");
            }

            return Math.PI * radius * radius;
        }


        /// <summary>
        /// Processing simple rectangle area
        /// </summary>
        /// <param name="simpleRectangleSides">array of sides</param>
        public static double SimpleRectangleArea(double[] simpleRectangleSides)
        {
            foreach (double side in simpleRectangleSides)
            {
                if (side <= 0)
                {
                    throw new ArgumentException("Sides should be > 0");
                }
            }
            return simpleRectangleSides[0] * simpleRectangleSides[1];
        }


        /// <summary>
        /// Processing triangle area
        /// </summary>
        /// <param name="triangleSides">array of sides</param>
        public static double TriangleArea(double[] triangleSides)
        {
            foreach (double side in triangleSides)
            {
                if (side <= 0)
                {
                    throw new ArgumentException("Sides should be > 0");
                }
            }
            Array.Sort(triangleSides);

            double p = (triangleSides[0] + triangleSides[1] + triangleSides[2]) / 2;
            double S = Math.Sqrt(p * (p - triangleSides[0]) * (p - triangleSides[1]) * (p - triangleSides[2]));

            return S;
        }


        /// <summary>
        /// Identifying straitness of a triangle
        /// </summary>
        public static bool IsTriangleStrait(double side1, double side2, double side3)
        {
            double[] sides = { side1, side2, side3 };

            foreach (double side in sides)
            {
                if (side <= 0)
                {
                    throw new ArgumentException("Sides should be > 0");
                }
            }

            Array.Sort(sides);

            if ((sides[2] * sides[2]) == (sides[1] * sides[1] + sides[0] * sides[0]))
            {
                return true;
            }
            else return false;

        }
    }
}

