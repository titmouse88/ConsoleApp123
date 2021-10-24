using NUnit.Framework;

namespace Homework5.Tests
{
    public class Tests
    {
        private HW5 _hw5;

        [SetUp]
        public void Setup()
        {
            _hw5 = new HW5();
        }

        //SearchMinInMatrix

        public static int[,] GetArrayTests(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1 }, { 1 } },
                1 => new int[,] { { 1, 2, 3 }, { 3, 2, 1 }, { 3, 2, 1 } },
                2 => new int[,] { { 1, 2 }, { 2, 1 } },
                3 => new int[,] { { 1, 2 } },
                _ => new int[,] { { } },

            };
        }
        


        [TestCase(0,1)]
        [TestCase(1,1)]
        [TestCase(2,1)]
        
        
        public void TransformSearchMinInMatrixTest(int arrayIndex, int expected)
        {
            //arrange
            int[,] arrayToTest = GetArrayTests(arrayIndex);


            //act
            
            int actual = _hw5.SearchMinInMatrix(arrayToTest);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase(0, 1)]
        [TestCase(1, 3)]
        [TestCase(2, 2)]


        public void TransformSearchMaxInMatrixTest(int arrayIndex, int expected)
        {
            //arrange
            int[,] arrayToTest = GetArrayTests(arrayIndex);


            //act

            int actual = _hw5.SearchMaxInMatrix(arrayToTest);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase(0, new int[] { 0, 0 })]
        [TestCase(1, new int[] { 0, 0 })]
        [TestCase(2, new int[] { 0, 0 })]


        public void TransformSearchMinIndexInMatrixTest(int arrayIndex,int[] expected)
        {
            //arrange
            int[,] arrayToTest = GetArrayTests(arrayIndex);


            //act
            
            int[] actual = _hw5.SearchMinIndexInMatrix(arrayToTest);

            //assert
            Assert.AreEqual(expected, actual);

        }

        //SearchMaxIndexInMatrix
        [TestCase(0, new int[] { 0, 0 })]
        [TestCase(1, new int[] { 0, 2 })]
        [TestCase(2, new int[] { 0, 1 })]


        public void TransformSearchMaxIndexInMatrixTest(int arrayIndex, int[] expected)
        {
            //arrange
            int[,] arrayToTest = GetArrayTests(arrayIndex);


            //act

            int[] actual = _hw5.SearchMaxIndexInMatrix(arrayToTest);

            //assert
            Assert.AreEqual(expected, actual);

        }


        //MostitemsMatrix
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]


        public void TransformMostitemsMatrixTest(int arrayIndex, int expected)
        {
            //arrange
            int[,] arrayToTest = GetArrayTests(arrayIndex);


            //act

            int actual = _hw5.MostitemsMatrix(arrayToTest);

            //assert
            Assert.AreEqual(expected, actual);

        }

    }
}