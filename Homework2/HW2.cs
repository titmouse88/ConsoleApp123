using System;

namespace Homework2
{
    public class HW2
    {
        public void SolveTask1()//1
        {
            int operand1 = GetNumberOfUser("Введите число А");
            int operand2 = GetNumberOfUser("Введите число B");
            int result = CalkFormula(operand1, operand2);
            Console.WriteLine($"Результат первой задачи; {result}");
        }

        private int GetNumberOfUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        private int CalkFormula(int operand1, int operand2)
        {
            int result = 1;
            if (operand1 > operand2)
            {
                result = operand1 + operand2;
            }
            if (operand1 < operand2)
            {
                result = operand1 - operand2;
            }
            if (operand1 == operand2)

            {
                result = operand1 * operand2;
            }

            return result;
        }


        public void SolveTask2()//2
        {
            int operandX = GetNumberOfUser("введите координату Х");
            int operandY = GetNumberOfUser("введите координату Y");
            string result = CalkFormula3(operandX, operandY);
            Console.WriteLine($"Результат второй задачи; {result}");
        }

        

        private string CalkFormula3(int operandX, int operandY)
        {
            string result = " ";
            if ((operandX > 0) && (operandY > 0))
            {
                result = "первая четверть";
            }
            else if ((operandX > 0) && (operandY < 0))
            {
                result = "четвертая четверть";
            }
            else if ((operandX < 0) && (operandY < 0))

            {
                result = "третья четверть";
            }

            else if ((operandX < 0) && (operandY > 0))

            {
                result = "вторая четверть";
            }

            return result;
        }



        public void SolveTask3()//3
        {
            int operandA = GetNumberOfUser("Введите число А");
            int operandB = GetNumberOfUser("Введите число B");
            int operandC = GetNumberOfUser("Введите число C");
            int[] myArray = { operandA, operandB, operandC };
            SortArrayThreeNumbersByDescing(myArray);

            Console.WriteLine($"числа по убыванию ");
            ShowArray(myArray);

        }
       

        private void ShowArray(int[] array)
        {
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write($"{array[i]}\t");
            }

            Console.WriteLine();
        }
         private void SortArrayThreeNumbersByDescing(int[] myArray)
        {
            int operandA = myArray[0];
            int operandB = myArray[1];
            int operandC = myArray[2];

            //6 9 3

            if (operandA > operandB && operandA  > operandC)
            {
                myArray[0] = operandA;
                myArray[1] = Math.Max(operandC, operandB);
                myArray[2] = Math.Min(operandC, operandB);
            }
            else if (operandB > operandA && operandB > operandC)
            {
                myArray[0] = operandB;
                myArray[1] = Math.Max(operandC, operandA);
                myArray[2] = Math.Min(operandC, operandA);
            }
            else if (operandC > operandB && operandC > operandA)
            {
                myArray[0] = operandC;
                myArray[1] = Math.Max(operandA, operandB);
                myArray[2] = Math.Min(operandA, operandB);
            }
        }

        public void SolveTask4() //4

        {

            Console.WriteLine("Задание: Пользователь вводит 3 числа (A, B и С). " +

                "Выведите в консоль решение(значения X) квадратного уравнения стандартного " +

                "вида, где AX2 + BX + C = 0.\n");

            int a = GetNumberFromUser("Введите число A:");

            int b = GetNumberFromUser("Введите число B:");

            int c = GetNumberFromUser("Введите число C:");

            string result = GetRootsOfEquation(a, b, c);

            Console.WriteLine($"Результат четвертой задачи: {result}");

        }



        public int GetNumberFromUser(string message)

        {

            Console.WriteLine(message);

            int number = Convert.ToInt32(Console.ReadLine());

            return number;

        }



        public string GetRootsOfEquation(int a, int b, int c)

        {

            string result;

            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            if (discriminant > 0)

            {

                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);

                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                result = $"Дискриминант равен {discriminant}, поэтому уравнение имеет два корня, х1 = {x1}, х2 = {x2}";

                return result;

            }

            else if (discriminant == 0)

            {

                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);

                result = $"Дискриминант равен {discriminant}, поэтому уравнение имеет один корень, х1 = {x1}";

                return result;

            }

            else

            {

                result = "Дискриминант меньше 0, поэтому уравнение не имеет корней";

                return result;

            }

        }

        public void SolveTask5() 

        {
         int peremenA = GetNumberFromUser("Введите двузначное число:");
          string answer = GetRootsOfEquation5(peremenA);
            Console.WriteLine($"Результат пятой задачи: {answer}");

        }
           public string GetRootsOfEquation5(int peremenA)

            {

            string answer = "";
            int result = peremenA % 10;
            int result2 = peremenA / 10;

            if (peremenA >= 10 && peremenA < 20)
            {
                switch (result)
                {
                    case 0:
                        Console.WriteLine("Десять");
                        break;
                    case 1:
                        Console.WriteLine("Одиннадцать");
                        break;
                    case 2:
                        Console.WriteLine("Двенадцать");
                        break;
                    case 3:
                        Console.WriteLine("Тринадцать");
                        break;
                    case 4:
                        Console.WriteLine("Четырнадцать");
                        break;
                    case 5:
                        Console.WriteLine("Пятнадцать");
                        break;
                    case 6:
                        Console.WriteLine("Шестнадцать");
                        break;
                    case 7:
                        Console.WriteLine("Семнадцать");
                        break;
                    case 8:
                        Console.WriteLine("Восемнадцать");
                        break;
                    case 9:
                        Console.WriteLine("Девятнадцать");
                        break;
                    default:
                        break;
                }

            }
            else
            {
                switch (result2)
                {
                    case 2:
                        answer = "Двадцать ";
                        break;
                    case 3:
                        answer = "Тридцать ";
                        break;
                    case 4:
                        answer = "Сорок ";
                        break;
                    case 5:
                        answer = "Пятьдесят ";
                        break;
                    case 6:
                        answer = "Шестьдесят ";
                        break;
                    case 7:
                        answer = "Семдесят ";
                        break;
                    case 8:
                        answer = "Восемьдесят ";
                        break;
                    case 9:
                        answer = "Девяносто ";
                        break;
                    default:
                        break;
                }
                switch (result)
                {
                    case 1:
                        answer = answer + "один";
                        break;
                    case 2:
                        answer = answer + "два";
                        break;
                    case 3:
                        answer = answer + "три";
                        break;
                    case 4:
                        answer = answer + "четыре";
                        break;
                    case 5:
                        answer = answer + "пять";
                        break;
                    case 6:
                        answer = answer + "шесть";
                        break;
                    case 7:
                        answer = answer + "семь";
                        break;
                    case 8:
                        answer = answer + "восемь";
                        break;
                    case 9:
                        answer = answer + "девять";
                        break;
                    default:
                        break;
                }

            }
                return answer;
        
            }

    }
}
