using System;

namespace Homework3
{
    public class HW3
    {
        
        
        
        public void SolveTask1()//Пользователь вводит 2 числа (A и B). Возвести число A в степень B
        {
            int peremenA = GetNumberOfUser("Введите число ");
            int peremenB = GetNumberOfUser("Введите степень, в которую необходимо возвести число");
            double result1 = ExponentiationNomber(peremenA, peremenB);
            Console.WriteLine($"число {peremenA} в степени {peremenB} будет {result1}");
            
        }

        private int GetNumberOfUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public double ExponentiationNomber(int peremenA, int peremenB)
        {
            double result1 = Math.Pow(peremenA, peremenB);
            return result1;
        }



        public void SolveTask2()//Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
        {
            int peremenA = GetNumberOfUser("Введите число А");
            
            string result= CalkFormulaDivisionIntoOneself(peremenA);
            
            Console.WriteLine($" все числа от 1 до 1000, которые делятся на A   {result}");
        }


        public string CalkFormulaDivisionIntoOneself(int peremenA)
        {
            string result = "";
            for (int i = peremenA; i < 1001; i++)
            {
                int i1 = i % peremenA;

                if (i1 == 0)
                {
                    result +=  i +" ";
                }

            }
            return result;



        }

        



        public void SolveTask3()// Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
        {
            int peremenA = GetNumberOfUser("Введите число А");

           string result= PositiveInteger(peremenA);
            Console.WriteLine($"количество положительных целых чисел, квадрат которых меньше A {result}");
        }



        public string PositiveInteger(int peremenA)
        {
            string result = "";
            int i2 = 0;
            for (int i = 0; i < peremenA; i++)
            {
                int i1;

                i1 = i * i;
                if ((i1 < peremenA) && (i > 0))

                {

                    i2++;
                    result = $"{i2}";

                }

            }
            

            return result;

        }

        
        public void SolveTask4()// Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
        {
            int peremenA = GetNumberOfUser("Введите число А");

            string result = GreatestDivisor(peremenA);
            Console.WriteLine($"наибольший делитель (кроме самого A) числа A {result} ");
        }



        public string GreatestDivisor(int peremenA)
        {
            string result = "";
            int i2 = 0;
            int i;
            for (i = 1; i < peremenA; i++)
            {


                if (peremenA % i == 0)

                {

                    i2 = i;
                }

            }
            result = $"{i2}";

            return result;

        }

        
        public void SolveTask5()
        //Пользователь вводит 2 числа (A и B).
        //Вывести сумму всех чисел из диапазона от A до B,
        //которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).
        {
            int peremenA = GetNumberOfUser("Введите число А");
            int peremenB = GetNumberOfUser("Введите число B");


            string result= GetSumOfNomberOfDevisor7(peremenA, peremenB);
            Console.WriteLine($"сумма всех чисел из диапазона от A до B, которые делятся без остатка на 7 {result}");
        }



        public string GetSumOfNomberOfDevisor7(int peremenA, int peremenB)
        {
            string result = "";
            int sum = 0;
            if (peremenA < peremenB)
            {
                for (int i = peremenA; i <= peremenB; i++)
                {
                    if (i % 7 == 0)
                        sum += i;
                }
            }

            else
            {
                for (int i = peremenB; i <= peremenA; i++)
                {
                    if (i % 7 == 0)
                        sum += i;
                }
            }
            result= $"{sum}";

            return result;
        }

        //Пользователь вводит 1 число (N).
        //Выведите N-ое число ряда фибоначчи.
        //В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.
        public void SolveTask6()
        {
            int peremenA = GetNumberOfUser("Введите числоряда фибаначи");

           int result= FibonacciNumber(peremenA);
            Console.WriteLine($"это число:{result}");
        }

       

        private int FibonacciNumber(int peremenA)
        {
            int result;
            
            int first = 1;
            int second = 1;
            int sum;
            int i2 = 0;
            for (int i = 0; true; i++)
            {
                sum = first;
                first = second;
                second += sum;
                i2++;

                if (i2 == peremenA)
                {
                    result = sum;
                    break;
                }
            }
            
            return result;

        }

        

        public void SolveTask7()
        //наибольший делитель по евклиду
        {
            int peremenA = GetNumberOfUser("Введите число А");
            int peremenB = GetNumberOfUser("Введите число B");


            int result= DivisionWithoutRemainderBy7(peremenA, peremenB);
            Console.WriteLine($"наибольший общий делитель {result}") ; 
        }

        

        private int DivisionWithoutRemainderBy7(int peremenA, int peremenB)
        {
            int result = 1;
            while (peremenA * peremenB != 0)
            {
                if (peremenA > peremenB)
                {
                    peremenA = peremenA % peremenB;

                }
                else
                    peremenB = peremenB % peremenA;
            }
            result=peremenB + peremenA;

            return result;
        }
        //Пользователь вводит целое положительное число, которое является кубом целого числа N. Найдите число N методом половинного деления.

        public void SolveTask8()
        {
            double number;
            do
            {
                 number = GetNumberOfUser("Введите положительное число:");
                
                if (number < 0)
                {
                    Console.WriteLine("Число отрицательное.");
                }
            } while (number < 0);
            Console.WriteLine($"Целое положительное число, которое является кубом целого числа {number} будет равным {SearchSqare(number)}");
        }
        public double SearchSqare(double number)
        {
            double rangeMax = number;
            double rangeMin = 0;
            double result = 0;

            while (rangeMax - rangeMin > 0.01)
            {
                result = (rangeMax + rangeMin) / 2;
                if (result * result > number)
                {
                    rangeMax = result;

                }
                else
                {
                    rangeMin = result;
                }
            }
            return result;
        }



        public void SolveTask9()// Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
        {
            int num = GetNumberOfUser("Введите число А");
            string result = TheNumberOfOddDigitsOfANumber(num);
            Console.WriteLine($" {result}");
        }

       

        private string TheNumberOfOddDigitsOfANumber(int num)
        {
            string result;
            int NomberOfOdd = 0;

            if (num > 0)

            {
                for (int i = num; i != 0; i--)
                {
                    if (i % 2 != 0)
                    {
                        NomberOfOdd++;
                    }

                }
            }
            else
            {
                for (int i = num; i != 0; i++)
                {
                    if (i % 2 != 0)
                    {
                        NomberOfOdd++;
                    }

                }
            }
            result = $"Количество не четных цифр в числе равно { NomberOfOdd} !";

            return result;

        }

        //public void SolveTask10()// Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа,
        //{
        //    int peremenA = GetNumberOfUser("Введите число А");
        //    Console.WriteLine("зеркальное отображение числа А");
        //    NomberReverse(peremenA);
        //}

        //public int NomberReverse(int peremenA)
        //{
        //    Console.Write(peremenA % 10);

        //    while ((peremenA /= 10) != 0)
        //        Console.Write(peremenA % 10);
        //}



        public void SolveTask11()// Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
        {
            int peremenA = GetNumberOfUser("Введите число А");
            string result = CalkFormula11(peremenA);
            Console.WriteLine($" {result}");
        }

        

        private string CalkFormula11(int peremenA)
        {
          string result;
            uint pop = 1;
            uint evencount = 0;
            uint oddcount = 0;
            uint evensum = 0;
            uint oddsum = 0;
            int kolNeChetnih = 0;
            Console.WriteLine("результат");

            while (pop <= peremenA)
            {
                pop++;
                if (pop % 2 == 0)
                {
                    evencount = evencount++;
                    evensum += pop;

                }
                else
                {
                    oddcount = oddcount++;
                    oddsum += pop;
                }
            }
            if (evensum < oddsum)
            {
                for (int i = peremenA; i != 0; i--)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);

                    }
                        
                }
            }
            else
            {
                result = "вот незадача- кажется сумма нечетных победила";

                return result;
                
            }
            return " ";


         }

        public void SolveTask12() //Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры.
        {
            int numberA = GetNumberOfUser("Введите число А");
            int chisloB = GetNumberOfUser("Введите число B");
            string result = CalkFormula12(numberA, chisloB);
            Console.WriteLine($" {result}");
        }
        private string CalkFormula12(int numberA, int chisloB)
        {
                int x = numberA;
                string result = " ";

                while (chisloB != 0)

                {

                    while (numberA != 0)

                    {

                        if (numberA % 10 == chisloB % 10)

                        {

                            result = "Да";

                            break;

                        }

                        numberA /= 10;

                    }

                    chisloB /= 10;

                    numberA = x;

                }

                if (result == "")

                {

                    result = "Нет";

                  }
              
                 return result;
          }
        



    }



}




