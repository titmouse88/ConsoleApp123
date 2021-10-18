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

        private double CalkFormula(int operand1, int operand2)
        {
            double resalt = (operand1 * 5 + operand2 * operand2) / (operand2 - operand1);
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

        private void SwapStrings(ref string word1, ref string word2)
        {
            string tmp = word1;
            word1 = word2;
            word2 = tmp;
     
        }



        public void SolveTask3()
        {
            int operand1 = GetNumberOfUser("Введите число А");
            int operand2 = GetNumberOfUser("Введите число B");
            int result1 = CalkFormula3(operand1, operand2);
            Console.WriteLine($"целая часть: {result1}");
            double result2 = CalkFormula4(operand1, operand2);
            Console.WriteLine($"остаток от деления: {result2}");
        }

        

        private int CalkFormula3(int operand1, int operand2)
        {
            int result1 = (operand1) / (operand2);
            return result1;
        }

        private double CalkFormula4(int operand1, int operand2)
        {
            double result2 = (operand1) % (operand2);
            return result2;
        }

        public void SolveTask4()
        {
            int operand1 = GetNumberOfUser("Введите число А");
            int operand2 = GetNumberOfUser("Введите число B");
            int operand3 = GetNumberOfUser("Введите число С");
            double result = CalkFormula4(operand1, operand2, operand3);
            Console.WriteLine($"результат четвертой задачи {result}");
            
        }

       

        private double CalkFormula4(int operand1, int operand2, int operand3)
        {
            double result = (operand3 - operand2) / operand1;
            return result;
        }

        public void SolveTask5()
        {
            int coordX1 = GetNumberOfUser("введите координату Х1");
            int coordX2 = GetNumberOfUser("введите координату Х2");
            int coordY1 = GetNumberOfUser("введите координату Y1");
            int coordY2 = GetNumberOfUser("введите координату Y2");
            int calculationResult1 = CalkFormula5(coordX1, coordX2, coordY1, coordY2);
            int calculationResult2 = CalkFormula6(coordX1, coordX2, coordY1, coordY2);
            Console.WriteLine($"y= {calculationResult1} *x + {calculationResult2}");

        }

        

        private int CalkFormula5(int coordX1, int coordX2, int coordY1, int coordY2)
        {
            int calculationResult1 = (coordY2 - coordY1) / (coordX2 - coordX1);
            
            
            return calculationResult1;
           
        }

        private int CalkFormula6(int coordX1, int coordX2, int coordY1, int coordY2)
        {
            
            int calcu = (coordY2 - coordY1) / (coordX2 - coordX1);
            int calculationResult2 = (coordY1 - calcu * coordX1);
            
            return calculationResult2;
        }

        

    }
}
