using NUnit.Framework;
using System;

namespace Homework2.Tests
{
    public class Tests
    {
        private HW2 _hw2;

        [SetUp]
        public void Setup()
        {
            _hw2 = new HW2();
        }

        

        [TestCase(4, 2, 6)]
        [TestCase(1, 5, -4)]
        [TestCase(5, 5, 25)]
        public void CalkFormulaThreeIfTest(int operand1, int operand2, int expected)
        {
            

            //act
            int actual = _hw2.CalkFormulaThreeIf(operand1, operand2);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }


        //QuarterPoint(int operandX, int operandY)

        [TestCase(55, 0, "точка лежит на оси")]
        public void QuarterPointNegativeTest(int operandX, int operandY, string expectedMessage)
        {
            //arrange


            //act, assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw2.QuarterPoint(operandX, operandY));
            Assert.AreEqual(expectedMessage, ex.Message);

        }

        
        [TestCase(10, 4, 1)]
        [TestCase(10, -2, 4)]
        [TestCase(-4, -2, 3)]
        [TestCase(-10, 2, 2)]

        public void QuarterPointTest(int operandX, int operandY, double expected2)
        {
            //arrange
            //act
            double actual2 = _hw2.QuarterPoint(operandX, operandY);



            //assert

            Assert.AreEqual(expected2, actual2);

            Assert.Pass();
        }

        //GetRootsOfEquation(int a, int b, int c)

        
        [TestCase(2, 3, 4, "Дискриминант меньше 0, поэтому уравнение не имеет корней")]
        [TestCase(1, 4, 3, "Дискриминант равен 4, поэтому уравнение имеет два корня, х1 = -1, х2 = -3")]
        [TestCase(1, -4, 4, "Дискриминант равен 0, поэтому уравнение имеет один корень, х1 = 2")]
        public void GetRootsOfEquationTest(int a, int b, int c, string expected2)
        {
            //arrange
            //act
            string actual2 = _hw2.GetRootsOfEquation(a,b,c);



            //assert

            Assert.AreEqual(expected2, actual2);

            Assert.Pass();
        }

       
        
        [TestCase(21, "Двадцать один")]
        [TestCase(14, "Четырнадцать")]
        public void GetRootsOfEquation5(int peremenA, string expected2)
        {
            //arrange
            //act
            string actual2 = _hw2.GetRootsOfEquation5(peremenA);



            //assert

            Assert.AreEqual(expected2, actual2);

            Assert.Pass();
        }

        [TestCase(5, "Введите двузначное число!")]
        public void GetRootsOfEquation5NegativeTest(int operemenA, string expectedMessage)
        {
            //arrange


            //act, assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw2.GetRootsOfEquation5(operemenA));
            Assert.AreEqual(expectedMessage, ex.Message);

        }

        //SortArrayThreeNumbersByDescing(int[] myArray)
        [TestCase(new int[] { 1, 5, 2 }, new int[] { 5, 2, 1 })]
        [TestCase(new int[] {2,5,7,1 }, new int[] {7, 5, 2, 1 })]
        [TestCase(new int[] { 0,4,2}, new int[] { 4, 2, 0})]
        
        public void SortArrayThreeNumbersByDescingTests(int[] myArray, int[]  expected)
        {
            //arrange
            //act
           _hw2.SortArrayThreeNumbersByDescing( myArray);



            //assert

            Assert.AreEqual(expected, myArray);

            Assert.Pass();
        }

    }
}