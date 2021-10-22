using System;

namespace Homework4
{
    public class HW4
    {



        
        //1 // Найти минимальный элемент массива

        public void SolveTask1()
        {

            int arrayLenght = GetNumberOfUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            array = RandomizeArray(array);
            ShowArray(array);
            int min = SearchMinInArray(array);
            Console.WriteLine($"\nМинимальное число в массиве: {min}");
        }
        void ShowArray(int[] arr)
        {
            foreach (int el in arr)
            {
                Console.Write(el + "\t");
            }
            Console.WriteLine();
        }

        private int[] RandomizeArray(int[] arr)
        {
            Random rnd = new Random();
            for (int i =0; i<arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 20);
            }
            return arr;
        }
        private int GetNumberOfUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public int SearchMinInArray(int[] array)
            {
                int min = array[0];
                for (int index = 0; index < array.Length; index++)
                {
                    if (array[index] < min)
                    {
                        min = array[index];
                    }
                }
                return min;
            }

        public void SolveTask2() //Найти максимальный элемент массива

        {
            int arrayLenght = GetNumberOfUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            array = RandomizeArray(array);
            ShowArray(array);
            int max = SearchMaxInArray(array);
            Console.WriteLine($"\n Максимальное число в массиве: {max}");
        }
        public int SearchMaxInArray(int[] array)
        {
            int max = array[0];
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] > max)
                {
                    max = array[index];
                }
            }
            return max;
        }

        public void SolveTask3() // Найти индекс минимального элемента массива
        {
            int arrayLenght = GetNumberOfUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            array = RandomizeArray(array);
            ShowArray(array);
            int index = SearchMinIndexInArray(array);
            Console.WriteLine($"\n индекс минимального числа в массиве: {index}");


        }

        public int SearchMinIndexInArray(int[] array)
        {
            int minValue = array[0];
            int index =0;
            for ( int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                     index=i ;
                }
            }
            return index;
        }

        public void SolveTask4() // Найти индекс максимального элемента массива
        {
            int arrayLenght = GetNumberOfUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            array = RandomizeArray(array);
            ShowArray(array);
            int index = SearchMaxIndexInArray(array);
            Console.WriteLine($"\n индекс максимального числа в массиве: {index}");


        }

        public int SearchMaxIndexInArray(int[] array)
        {
            int minValue = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > minValue)
                {
                    minValue = array[i];
                    index = i;
                }
            }
            return index;
        }

        public void SolveTask5() //Посчитать сумму элементов массива с нечетными индексами
        {
            int arrayLenght = GetNumberOfUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            array = RandomizeArray(array);
            ShowArray(array);
            int sum = SumElementOddIndex(array);
            Console.WriteLine($"\n сумму элементов массива с нечетными индексами: {sum}");
        }

        public int SumElementOddIndex(int[] array)
        {
            int sum = 0;
            for (int index = 0; index < array.Length; index++)
            {

                if (index % 2 != 0)
                {
                    sum=array[index]++;

                }
            }
            return sum;
           
        }

        public void SolveTask6() ////Сделать реверс массива (массив в обратном направлении)
        {
            int arrayLenght = GetNumberOfUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            array = RandomizeArray(array);
            ShowArray(array);
             ReverseArray(ref array);
            Console.WriteLine("\n реверс массива ");
            foreach (var item in array)
            {
                Console.Write(item +"\t");
            }
        }

        public void ReverseArray(ref int[] array)
        {
            


            for (  int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = tmp;
            }

            


        }

        public void SolveTask7() ////Посчитать количество нечетных элементов массива
        {
            int arrayLenght = GetNumberOfUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            array = RandomizeArray(array);
            ShowArray(array);
            int sum = SumOddElements(array);
            Console.WriteLine($"\n количество нечетных элементов массива {sum}");
        }

        public int SumOddElements(int[] array)
        {
            int sum = 0;
            for (int index = 0; index < array.Length; index++)
            {

                if (array[index] % 2 != 0)
                {
                    sum++;

                }
            }
            return sum;

        }

        public void SolveTask8() //Поменять местами 1ю и 2ю половину массива, для массива 1234 результат 3421 для 12345-45312

        {
            int arrayLenght = GetNumberOfUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            array = RandomizeArray(array);
            ShowArray(array);
            Console.WriteLine("\n замена второй половины массива первой ");
            ChangeHalfArray(array);
        }

        void ChangeHalfArray(int[] array)
        {

            int half = array.Length / 2;
            
            for (int i = 0; i < half; i++)
            {
                int tmp = array[i];
                array[i] = array[i + array.Length - half];
                array[i + array.Length - half] = tmp;

            }

            for (int index = 0; index < array.Length; index++)
            {

                Console.Write(array[index] + " ");
            }

        }
        public void SolveTask9() // //Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble), выбором (Select) или вставками (Insert)) 
                                 //пузырьком(Bubble)
        {
            int arrayLenght = GetNumberOfUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            array = RandomizeArray(array);
            ShowArray(array);
            Console.WriteLine("\n сортировка массива по возрастанию пузырьком ");
            BubleSortArray(array);
        }
        public int[] BubleSortArray(int[] array)
        {

            Boolean needSort = true;
            for (int i = 0; i < array.Length && needSort; i += 1)
            {

                needSort = false;
                for (int j = 0; j < array.Length - 1; j += 1)
                {

                    if (array[j + 1] < array[j])
                    {
                        int change = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = change;
                        needSort = true;
                    }
                }
            }
            return array;

        }

        public void SolveTask10() ////Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании) :  пузырьком(Bubble), выбором (Select) или вставками (Insert))
                                  // выборка
        {
            int arrayLenght = GetNumberOfUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            array = RandomizeArray(array);
            ShowArray(array);
            Console.WriteLine("\n сортировка массива по убыванию выборкой ");
            ChoiceSortArray(array);
        }
        void ChoiceSortArray(int[] array)
        {
            int indMax;
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                indMax = i;

                for (int j = i + 1; j < array.Length; j++)
                {

                    if (array[j] > array[indMax])
                    {
                        indMax = j;

                    }
                }

                temp = array[indMax];
                array[indMax] = array[i];
                array[i] = temp;


            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");

            }
         }

    }

}
