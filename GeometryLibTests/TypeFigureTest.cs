using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GeometryLib;

namespace GeometryLibTests
{
    [TestClass]
    public class TypeFigureTest
    {
        [TestMethod]
        public void TypeTriangle_1and2_and3_0Return()
        {
            double a = 1;
            double b = 2;
            double c = 3;
            int expected = 0;
            int actual = TypeFigure.TypeTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TypeTriangle_2and2and6_0Return()
        {
            double a = 2;
            double b = 2;
            double c = 6;
            int expected = 0;
            int actual = TypeFigure.TypeTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TypeTriangle_Minus4and5and3_0Return()
        {
            double a = -4;
            double b = 5;
            double c = 3;
            int expected = 0;
            int actual = TypeFigure.TypeTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TypeTriangle_4and4and6_2Return()
        {
            double a = 4;
            double b = 4;
            double c = 6;
            int expected = 2;
            int actual = TypeFigure.TypeTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TypeTriangle_4and4and4_1Return()
        {
            double a = 4;
            double b = 4;
            double c = 4;
            int expected = 1;
            int actual = TypeFigure.TypeTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TypeTriangle_4and5and3_3Return()
        {
            double a = 4;
            double b = 5;
            double c = 3;
            int expected = 3;
            int actual = TypeFigure.TypeTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }
    }
}
