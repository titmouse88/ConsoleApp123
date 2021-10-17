using System;

namespace Homework5
{
    public class HW5
    {

        public void SolveTask1()//Найти минимальный элемент массива
        {

            int arrayLenghtM = GetNumberOfUser("Введите размер массива M: ");
            int arrayLenghtN = GetNumberOfUser("Введите длинну массива N: ");
           
            int[,] array = new int[arrayLenghtM, arrayLenghtN];
            array = RandomizeArray(array);
            PrintMatrix(array);
            int min = SearchMinInMatrix(array);
            Console.WriteLine($"\nМинимальное число в массиве: {min}");
        }

        private int GetNumberOfUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        } 

        public void PrintMatrix(int[,] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t"); 
                }
                Console.WriteLine();
            }
        }


        private int[,] RandomizeArray(int[,] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j< arr.GetLength(1); j++)
                {
                    arr[i,j] = rnd.Next(-10, 10);
                }
            }
            return arr;
        }

        public int SearchMinInMatrix(int[,] arr)
        {
            int min = arr[0,0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
            if (arr[i,j] < min)
                {
                    min = arr[i,j];
                }
            }
                    
               
            }

            return min;
        }

        public void SolveTask2()//Найти максимальный элемент массива
        {
            int arrayLenghtM = GetNumberOfUser("Введите размер массива M: ");
            int arrayLenghtN = GetNumberOfUser("Введите длинну массива N: ");

            int[,] array = new int[arrayLenghtM, arrayLenghtN];
            array = RandomizeArray(array);
            PrintMatrix(array);
            int max = SearchMaxInMatrix(array);
            Console.WriteLine($"\n максимальный элемент массива: {max}");
        }

        public int SearchMaxInMatrix(int[,] arr)
        {
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }


            }

            return max;
        }

        public void SolveTask3()  //Найти индекс минимального элемента массива

        {
            int arrayLenghtM = GetNumberOfUser("Введите размер массива M: ");
            int arrayLenghtN = GetNumberOfUser("Введите длинну массива N: ");

            int[,] array = new int[arrayLenghtM, arrayLenghtN];
            array = RandomizeArray(array);
            PrintMatrix(array);
            string min = SearchMinIndexInMatrix(array);
            Console.WriteLine($"\n максимальный элемент массива: {min}");
        }

        public string SearchMinIndexInMatrix(int[,] array)
        {
            int min = array[0, 0];
            string index = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        index= $"{i},{j}";
                    }
                }


            }

            return index;
        }

        public void SolveTask4()  //Найти индекс максимального элемента массива

        {
            int arrayLenghtM = GetNumberOfUser("Введите размер массива M: ");
            int arrayLenghtN = GetNumberOfUser("Введите длинну массива N: ");

            int[,] array = new int[arrayLenghtM, arrayLenghtN];
            array = RandomizeArray(array);
            PrintMatrix(array);
            string max = SearchMaxIndexInMatrix(array);
            Console.WriteLine($"\n максимальный элемент массива: {max}");
        }

        public string SearchMaxIndexInMatrix(int[,] array)
        {
            int max = array[0, 0];
            string index = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        index = $"{i},{j}";
                    }
                }


            }

            return index;
        }

        public void SolveTask5() //найти количество элементов массива, которые больше всех своих соседей одновременно
        {
            int arrayLenghtM = GetNumberOfUser("Введите размер массива M: ");
            int arrayLenghtN = GetNumberOfUser("Введите длинну массива N: ");

            int[,] array = new int[arrayLenghtM, arrayLenghtN];
            array = RandomizeArray(array);
            PrintMatrix(array);
            int count = MostitemsMatrix(array);
            Console.WriteLine($"\n количество элементов массива, которые больше всех своих соседей одновременно {count}");
        }

        public int MostitemsMatrix(int[,] array)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i == 0 || array[i, j] > array[(i - 1), j])
                        && (j >= array.GetLength(1) - 1 || array[i, j] > array[i, j + 1])
                        && (j == 0 || array[i, j] > array[i, j - 1])
                        && (i >= array.GetLength(0) - 1 || array[i, j] > array[i + 1, j]))
                    {

                        count++;
                    }
                }

            }
            Console.WriteLine($"max:{count}");

            return count;
        }

    }
}
