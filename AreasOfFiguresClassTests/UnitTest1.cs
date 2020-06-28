using AreasOfFiguresLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace AreaOfFiguresClass.Tests
{
    public class AreaOfFiguresTest
    {
        [Test]
        public void CircleArea_1_returned_PI()
        {
            //arrange
            double expeted = Math.PI;

            //act
            double actual = AreaOfFigures.CircleArea(1);

            //assert
            Assert.AreEqual(expeted, actual);
        }

        [Test]
        public void SimpleRectangleArea_2_4_returned_8()
        {
            //arrange 
            double expected = 8.0;
            double[] sides = { 2.0, 4.0 };

            //act 
            double actual = AreaOfFigures.SimpleRectangleArea(sides);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TriangleArea_3_4_5_returned_3()
        {
            //arrange 
            double expected = 6.0;
            double[] sides = { 3.0, 4.0, 5.0 };

            //act 
            double actual = AreaOfFigures.TriangleArea(sides);

            //assert
            Assert.AreEqual(expected, actual);
        }

        public void IsTriangleStrait_3_4_5_returned_true()
        {
            //arrange
            bool expected = true;
            double[] sides = { 3.0, 4.0, 5.0 }; //classic strait triangle

            //act
            bool actual = AreaOfFigures.IsTriangleStrait(sides[0], sides[1], sides[2]);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}