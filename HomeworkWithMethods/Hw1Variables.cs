using System;
using Core;

namespace MyMethods
{
    public class Hw1Variables
    {
        //task1
        public void SolveTask1()
        {
            Console.WriteLine("Задача №1\n");
            int a;
            double b;
            a = Core.DataInput.GetIntNumFromUser("введите число типа int: ");
            Console.WriteLine($"привет, {a}!");
            b = Core.DataInput.GetDoubleNumFromUser("введите число типа double: ");
            Console.WriteLine($"a + b = {a+b}");
            Console.WriteLine($"пока, {b}...");
        }
        //task2
        public void SolveTask2()
        {
            Console.WriteLine("Пользователь вводит 2 числа (a и b). Выведите в консоль решение\n");
            double numA = DataInput.GetDoubleNumFromUser("Введите число A: ");
            double numB = DataInput.GetDoubleNumFromUser("Введите число B: ");
            double result = GetMathCalc(numA, numB);
            Console.WriteLine("result = " + result);
            Console.ReadKey();
        }
        double GetMathCalc(double numA, double numB)
        {
            if (numA == numB || numA == 0 && numB == 0) 
                throw new DivideByZeroException("на ноль делить нельзя!");
            double result = (5 * numA + Math.Pow(numB, 4)) / (numB - numA);
            return result;
        }
        //task3
        public void SolveTask3()
        {
            Console.WriteLine("Пользователь вводит 2 строковых значения(s1 и s2).\nПоменяйте содержимое переменных s1 и s2 местами.\n");
            string str1 = DataInput.GetStringFromUser("Введите первую строку: ");
            string str2 = DataInput.GetStringFromUser("Введите вторую строку: ");
            Helper.MySwap(ref str1, ref str2);
            Console.WriteLine("строка A после изменений: \t" + str1);
            Console.WriteLine("строка B после изменений: \t" + str2);
            Console.ReadKey();
        }
        // task 4
        public void SolveTask4()
        {
            Console.WriteLine("Пользователь вводит 3 не равных 0 числа (A, B и С).\n" +
                "Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.\n");
            int numA = DataInput.GetIntNumFromUser("Введите число А: ");
            int numB = DataInput.GetIntNumFromUser("Введите число B: ");
            int numC = DataInput.GetIntNumFromUser("Введите число C: ");
            Console.WriteLine();
            if (GetX(numA, numB, numC) != double.NaN)
                Console.WriteLine($"A*X+B=C\nX = {GetX(numA, numB, numC)}");
            else Console.WriteLine("нет корней");
            Console.ReadKey();
        }
        double GetX(int numA, int numB, int numC)
        {
            if (numA == 0) 
                return double.NaN;
            return (numC - numB) / (double)numA;
        }
    }
}
