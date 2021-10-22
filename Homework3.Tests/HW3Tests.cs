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
        public void GetSumOfNomberOfDevisor7(int peremenA, int peremenB, string expected)
        {


            //act
            string actual = _hw3.GetSumOfNomberOfDevisor7(peremenA, peremenB);



            //assert

            Assert.AreEqual(expected, actual);

            Assert.Pass();
        }



    }
}