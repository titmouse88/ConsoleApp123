using NUnit.Framework;

namespace Homework4.Tests
{
    public class Tests
    {
        private HW4 _hw4;

        [SetUp]
        public void Setup()
        {
            _hw4 = new HW4();
        }

        //SearchMinInArray(int[] array)

        [TestCase(new int[] { 1, 5, 2 }, 1)]
        [TestCase(new int[] { 2, 5, 7, 1 }, 1)]
        [TestCase(new int[] { 0, 4, 2 }, 0)]

        public void SearchMinInArrayTests(int[] array, int  expected)
        {
            //arrange
            //act
           int actual= _hw4.SearchMinInArray(array);



            //assert

            Assert.AreEqual(expected, actual);

            
        }
        //SearchMaxInArray
        [TestCase(new int[] { 1, 5, 2 }, 5)]
        [TestCase(new int[] { 2, 5, 7, 1 }, 7)]
        [TestCase(new int[] { 0, 4, 2 }, 4)]

        public void SearchMaxInArrayTests(int[] array, int expected)
        {
            //arrange
            //act
            int actual = _hw4.SearchMaxInArray(array);



            //assert

            Assert.AreEqual(expected, actual);


        }

        //SearchMinIndexInArray
        [TestCase(new int[] { 1, 5, 2 }, 0)]
        [TestCase(new int[] { 2, 5, 7, 1 }, 3)]
        [TestCase(new int[] { 0, 4, 2 }, 0)]

        public void SearchMinIndexInArrayTests(int[] array, int expected)
        {
            //arrange
            //act
            int actual = _hw4.SearchMinIndexInArray(array);



            //assert

            Assert.AreEqual(expected, actual);


        }

        //SearchMaxIndexInArray
        [TestCase(new int[] { 1, 5, 2 }, 1)]
        [TestCase(new int[] { 2, 5, 7, 1 }, 2)]
        [TestCase(new int[] { 0, 4, 2 }, 1)]

        public void SearchMaxIndexInArrayTests(int[] array, int expected)
        {
            //arrange
            //act
            int actual = _hw4.SearchMaxIndexInArray(array);



            //assert

            Assert.AreEqual(expected, actual);


        }

        //MostitemsMatrix

        [TestCase(new int[] { 1, 5, 2 }, 5)]
        [TestCase(new int[] { 2, 5, 7, 1 }, 6)]
        [TestCase(new int[] { 0, 4, 2 }, 4)]

        public void SumElementOddIndexTests(int[] array, int expected)
        {
            //arrange
            //act
            int actual = _hw4.SumElementOddIndex(array);



            //assert

            Assert.AreEqual(expected, actual);


        }

        //ReverseArray
        [TestCase(new int[] { 1, 5, 2 }, new int[] { 2, 5, 1 })]
        [TestCase(new int[] { 2, 5, 7, 1 }, new int[] { 1, 7, 5, 2 })]
        [TestCase(new int[] { 0, 4, 2 }, new int[] { 2, 4, 0 })]

        public void ReverseArrayTests(int[] array, int[] expected)
        {
            //arrange
            //act
            _hw4.ReverseArray(array);



            //assert

            Assert.AreEqual(expected, array);

            Assert.Pass();
        }

        //SumOddElements
        [TestCase(new int[] { 1, 5, 2 }, 2)]
        [TestCase(new int[] { 2, 5, 7, 1 }, 3)]
        [TestCase(new int[] { 0, 4, 2 }, 0)]

        public void SumOddElementsTests(int[] array, int expected)
        {
            //arrange
            //act
            int actual = _hw4.SumOddElements(array);



            //assert

            Assert.AreEqual(expected, actual);


        }

        //

        [TestCase(new int[] { 1, 5, 2 }, new int[] { 2, 5, 1 })]
        [TestCase(new int[] { 2, 5, 7, 1 }, new int[] { 7, 1, 2, 5 })]
        [TestCase(new int[] { 0, 4, 2 }, new int[] { 2, 4, 0 })]

        public void ChangeHalfArrayTests(int[] array, int[] expected)
        {
            //arrange
            //act
            _hw4.ChangeHalfArray(array);



            //assert

            Assert.AreEqual(expected, array);

            Assert.Pass();
        }
        //BubleSortArray
        [TestCase(new int[] { 1, 5, 2 }, new int[] { 1, 2, 5 })]
        [TestCase(new int[] { 2, 5, 7, 1 }, new int[] { 1, 2, 5, 7 })]
        [TestCase(new int[] { 0, 4, 2 }, new int[] { 0, 2, 4 })]

        public void BubleSortArrayTests(int[] array, int[] expected)
        {
            //arrange
            //act
            _hw4.BubleSortArray(array);



            //assert

            Assert.AreEqual(expected, array);

            Assert.Pass();
        }

        //ChoiceSortArray
        [TestCase(new int[] { 1, 5, 2 }, new int[] { 5, 2, 1 })]
        [TestCase(new int[] { 2, 5, 7, 1 }, new int[] { 7, 5, 2, 1 })]
        [TestCase(new int[] { 0, 4, 2 }, new int[] { 4, 2, 0 })]

        public void ChoiceSortArrayTests(int[] array, int[] expected)
        {
            //arrange
            //act
            _hw4.ChoiceSortArray(array);



            //assert

            Assert.AreEqual(expected, array);

            Assert.Pass();
        }
    }
}