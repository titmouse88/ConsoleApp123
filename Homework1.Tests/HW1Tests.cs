using NUnit.Framework;
using System;

namespace Homework1.Tests
{
    public class Tests
    {
        private HW1 _hw1;
        
        [SetUp]
        public void Setup()
        {
            _hw1 = new HW1 ();
        }

        [TestCase(5,9, 26.5)]
        [TestCase(0, 9, 9.0)]
        [TestCase(5, 0, -5.0)]
        public void CalkFormulaTest(int operand1, int operand2, double expected )
        {
            //arrange
            //int operand1 = 5;
            //int operand2 = 9;
            //double expected = 26.5;

            //act
           double actual = _hw1.CalkFormula(operand1, operand2);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }
        [TestCase(55,55, "Значения чисел должны быть разными")]
        public void CalkFormulaNegativeTest(int operand1, int operand2, string expectedMessage)
        {
            //arrange


            //act, assert
           Exception ex =  Assert.Throws( typeof( ArgumentException), () => _hw1.CalkFormula(operand1, operand2));
            Assert.AreEqual(expectedMessage, ex.Message);
            


        }
        [TestCase(10, 4, 2)]

        public void DivisionResultTest(int operand1, int operand2, double expected2)
        {
            //arrange
          //act
            double actual2 = _hw1.DivisionResult(operand1, operand2);



            //assert

            Assert.AreEqual(expected2, actual2);

            Assert.Pass();
        }
        [TestCase(15, 7, 1)]

        public void RemainderOfTheDivisionTest(int operand1, int operand2, double expected)
        {
            //arrange
            //act
            double actual = _hw1.RemainderOfTheDivision(operand1, operand2);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }

        [TestCase(55, 0, "Деление на 0!")]
        public void DivisionResultNegativeTest(int operand1, int operand2, string expectedMessage)
        {
            //arrange


            //act, assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw1.DivisionResult(operand1, operand2));
            Assert.AreEqual(expectedMessage, ex.Message);



        }

        //LinearEquation(int operand1, int operand2, int operand3)

        [TestCase(5,6,7,0.2)]
        public void LinearEquationTest(int operand1, int operand2, int operand3, double expected)
        {
            //arrange
            //act
            double actual = _hw1.LinearEquation(operand1, operand2, operand3);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }

        [TestCase(0, 5, 0, "Деление на 0!")]
        public void LinearEquationNegativeTest(int operand1, int operand2, int operand3, string expectedMessage)
        {
            //arrange


            //act, assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw1.LinearEquation(operand1, operand2, operand3));
            Assert.AreEqual(expectedMessage, ex.Message);
         }

        //EquationStraightLineArgX(int coordX1, int coordX2, int coordY1, int coordY2) 
       
        
        [TestCase(1, 2, 3,4,1 )]
        public void EquationStraightLineArgXTest(int coordX1, int coordX2, int coordY1, int coordY2, int expected)
        {
            //arrange
            //act
            int actual = _hw1.EquationStraightLineArgX(coordX1,  coordX2,  coordY1,  coordY2);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }

        [TestCase(2,2,4,5, "Деление на 0!")]
        public void EquationStraightLineArgXNegativeTest(int coordX1, int coordX2, int coordY1, int coordY2, string expectedMessage)
        {
            //arrange


            //act, assert
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw1.EquationStraightLineArgX( coordX1,  coordX2, coordY1, coordY2));
            Assert.AreEqual(expectedMessage, ex.Message);
        }
        //EquationStraightLineArgY
        [TestCase(5, 4, 7, 8,12)]
        public void EquationStraightLineArgYTest(int coordX1, int coordX2, int coordY1, int coordY2, int expected)
        {
            //arrange
            //act
            int actual = _hw1.EquationStraightLineArgY(coordX1, coordX2, coordY1, coordY2);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }


    }


    //[Test]
    //public void Test2()
    //{
    //    Assert.Pass();
    //}

    //[Test]
    //public void Test3()
    //{
    //    Assert.Pass();
    //}


}