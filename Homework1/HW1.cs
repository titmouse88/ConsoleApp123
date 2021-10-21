using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class HW1
    {
        public void SolveTask1()
        {
            int operand1 = GetNumberOfUser("Введите число А");
            int operand2 = GetNumberOfUser("Введите число B");
            double resalt = CalkFormula(operand1, operand2);
            Console.WriteLine($"Результат первой задачи; {resalt}");
        }

        private int GetNumberOfUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public double CalkFormula(int operand1, int operand2)
        {
           if (operand1==operand2)
            {
                throw new ArgumentException("Значения чисел должны быть разными");
            }
            
            double resalt = (operand1 * 5 + operand2 * operand2*1.0) / (operand2 - operand1);
            return resalt;
        }

        public void SolveTask2()
        {
            string word1 = GetWorldOfUser("введите первое слово");
            string word2 = GetWorldOfUser("введите второе слово");
            SwapStrings(ref word1, ref word2);
            Console.WriteLine(word1+ " "+ word2);
            Console.WriteLine();
        }


        string GetWorldOfUser(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }

        public void SwapStrings(ref string word1, ref string word2)
        {
            string tmp = word1;
            word1 = word2;
            word2 = tmp;
     
        }



        public void SolveTask3() //Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления.

        {
            int operand1 = GetNumberOfUser("Введите число А");
            int operand2 = GetNumberOfUser("Введите число B");
            int result1 = DivisionResult(operand1, operand2);
            Console.WriteLine($"целая часть: {result1}");
            double result2 = RemainderOfTheDivision(operand1, operand2);
            Console.WriteLine($"остаток от деления: {result2}");
        }



        public int DivisionResult(int operand1, int operand2)
        {
            if (operand2==0)
            {
                throw new ArgumentException("Деление на 0!");
            }
            int result1 = (operand1) / (operand2);
            return result1;
        }

        public double RemainderOfTheDivision(int operand1, int operand2)
        {
            double result2 = (operand1) % (operand2)*1.0;
            return result2;
        }

        public void SolveTask4() //Пользователь вводит 3 не равных 0 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.

        {
            int operand1 = GetNumberOfUser("Введите число А");
            int operand2 = GetNumberOfUser("Введите число B");
            int operand3 = GetNumberOfUser("Введите число С");
            double result = LinearEquation(operand1, operand2, operand3);
            Console.WriteLine($"результат четвертой задачи {result}");
            
        }



        public double LinearEquation(int operand1, int operand2, int operand3)
        {
            if (operand1 == 0)
            {
                throw new ArgumentException("Деление на 0!");
            }

            double result = (operand3 - operand2)*1.0 / operand1;
            return result;
        }

        public void SolveTask5()
        {
            int coordX1 = GetNumberOfUser("введите координату Х1");
            int coordX2 = GetNumberOfUser("введите координату Х2");
            int coordY1 = GetNumberOfUser("введите координату Y1");
            int coordY2 = GetNumberOfUser("введите координату Y2");
            int resultX = EquationStraightLineArgX(coordX1, coordX2, coordY1, coordY2);
            int result = EquationStraightLineArgY(coordX1, coordX2, coordY1, coordY2);
            Console.WriteLine($"y= {resultX} *x + {result}");

        }



        public int EquationStraightLineArgX(int coordX1, int coordX2, int coordY1, int coordY2) 
            //Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости.
            //Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки
        {
            if (coordX2 == coordX1)
            {
                throw new ArgumentException("Деление на 0!");
            }

            int resultX = (coordY2 - coordY1) / (coordX2 - coordX1);
            
            
            return resultX;
           
        }

        public int EquationStraightLineArgY(int coordX1, int coordX2, int coordY1, int coordY2)
        {
            
            int calcu = (coordY2 - coordY1) / (coordX2 - coordX1);
            int result = (coordY1 - calcu * coordX1);
            
            return result;
        }

        

    }
}
