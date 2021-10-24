using NUnit.Framework;

namespace Homework3.Tests
{
    public class Tests
    {
        private HW3 _hw3;

        [SetUp]
        public void Setup()
        {
            _hw3 = new HW3();
        }

        //ExponentiationNomber(int peremenA, int peremenB)

        [TestCase(2, 2, 4)]
        [TestCase(-1, 5, -1)]
        [TestCase(0, 5, 0)]
        public void ExponentiationNomberTest(int peremenA, int peremenB, double expected)
        {


            //act
            double actual = _hw3.ExponentiationNomber(peremenA,  peremenB);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }


        public void Test1()
        {
            Assert.Pass();
        }


        //CalkFormulaDivisionIntoOneself(int peremenA)

        [TestCase(900, "900 ")]
        [TestCase(500, "500 1000 ")]
        [TestCase(-400, "-400 0 400 800 ")]
        public void CalkFormulaDivisionIntoOneselfTests(int peremenA, string expected)
        {


            //act
            string actual = _hw3.CalkFormulaDivisionIntoOneself(peremenA);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }
        //PositiveInteger(int peremenA)
        [TestCase(4, "1")]
        [TestCase(10, "3")]
        [TestCase(5, "2")]
        public void PositiveIntegerTests(int peremenA, string expected)
        {


            //act
            string actual = _hw3.PositiveInteger(peremenA);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }

        //GreatestDivisor(int peremenA)

        [TestCase(8, "4")]
        [TestCase(56, "28")]
        [TestCase(0, "0")]
        public void GreatestDivisorTests(int peremenA, string expected)
        {


            //act
            string actual = _hw3.GreatestDivisor(peremenA);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }

        //string GetSumOfNomberOfDevisor7(int peremenA, int peremenB)

        [TestCase(6,7, "7")]
        [TestCase(0,45, "147")]
        [TestCase(-5,15, "21")]
        public void GetSumOfNomberOfDevisor7Tests(int peremenA, int peremenB, string expected)
        {


            //act
            string actual = _hw3.GetSumOfNomberOfDevisor7(peremenA, peremenB);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }

        // FibonacciNumber(int peremenA)
        [TestCase(3, 2)]
        [TestCase(16, 987)]
        [TestCase(10,55)]
        public void FibonacciNumberTests(int peremenA, int expected)
        {


            //act
            int actual = _hw3.FibonacciNumber(peremenA);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }

        //DivisionWithoutRemainderBy7(int peremenA, int peremenB)

        [TestCase(1,1, 1)]
        [TestCase(156,25, 1)]
        [TestCase(21,63,21)]
        public void DivisionWithoutRemainderBy7Tests(int peremenA, int peremenB, int expected)
        {


            //act
            int actual = _hw3.DivisionWithoutRemainderBy7(peremenA,  peremenB);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }

        [TestCase(90, 9.4866943359375)]
        [TestCase(15, 3.87451171875)]
        public void SearchSqareTests(double number, double expected)
        {


            //act
            double actual = _hw3.SearchSqare(number);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }

        ////TheNumberOfOddDigitsOfANumber(int num)
        [TestCase(15, "Количество не четных цифр в числе равно 8 !")]
        [TestCase(45, "Количество не четных цифр в числе равно 23 !")]
        [TestCase(-5, "Количество не четных цифр в числе равно 3 !")]
        public void TheNumberOfOddDigitsOfANumberTests(int num, string expected)
        {


            //act
            string actual = _hw3.TheNumberOfOddDigitsOfANumber(num);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }


       
        [TestCase(11,11)]
        [TestCase(156,651)]
        [TestCase(21,12)]
        public void PrintTheMirroredNumberTests(int a, int expected)
        {


            //act
            int actual = _hw3.PrintTheMirroredNumber(a);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }


        //OddNumbersInTheInputNumber(int peremenA)

        [TestCase(21, "вот незадача- кажется сумма нечетных победила")]
        [TestCase(4, "3 1 ")]
        [TestCase(10, "9 7 5 3 1 ")]
        public void OddNumbersInTheInputNumberTests(int peremenA, string expected)
        {


            //act
            string actual = _hw3.OddNumbersInTheInputNumber(peremenA);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }

        //FindTheSameNumbers(int a, int b)

        [TestCase(21, 112, "Да")]
        [TestCase(4,55, "Нет")]
        [TestCase(10, 100, "Да")]
        public void FindTheSameNumbersTests(int a, int b, string expected)
        {


            //act
            string actual = _hw3.FindTheSameNumbers(a,b);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }
    }
}