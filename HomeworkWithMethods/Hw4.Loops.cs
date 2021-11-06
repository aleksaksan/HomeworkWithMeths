using System;
using Core;

namespace MyMethods
{
    public class Hw4
    {
       
        // task 1
        public void SolveTask1()
        {
            Console.WriteLine("Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.");
            int numA = DataInput.GetIntNumFromUser("Введите число А: ");
            Helper.PrintIntArr(ReturnNumsWitchDivA(numA));
        }
        public int[] ReturnNumsWitchDivA(int numA)
        {
            if (numA == 0)
                throw new DivideByZeroException();
            int count = 0;
            //для увеличения быстродействия вместо цикла можно было бы просто создать массив на 1000 эл
            //экономил память
            for (int i = 1; i <= 1000; i++)  
            {
                if (i % numA == 0)
                    count++;
            }
            int[] arr = new int[count];
            for (int i = 1, j = 0; i <= 1000; i++)
            {
                if (i % numA == 0)
                {
                    arr[j] = i;
                    j++;
                }
            }
            return arr;
        }
        // task 2
        public void SolveTask2()
        {
            Console.WriteLine("Пользователь вводит 1 число (A). " +
                "Найдите количество положительных целых чисел, квадрат которых меньше A.");
            int numA = DataInput.GetIntNumFromUser("Введите число А: ");
            Console.WriteLine(GetCountOfPosIfSqrLoverA(numA));
            
        }
        public int GetCountOfPosIfSqrLoverA(int num)
        {
            if (num < 0)
                throw new ArgumentException("вы ввели какую-то дичь! (скорее всего, число отрицательное)");
            int count = 0;
            for (int i = 1; (int)Math.Pow(i, 2) < num; i++)
            {
                count++;
            }
            return count;
        }

        // task 3
        public void SolveTask3()
        {
            Console.WriteLine("Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.");
            int numA = DataInput.GetIntNumFromUser("Введите число А: ");
            if (GetMaxDivisor(numA) > 0)
                Console.WriteLine("Наибольший делитель = " + GetMaxDivisor(numA));
            else
                Console.WriteLine("нет таких");
        }
        public int GetMaxDivisor(int a)
        {
            int divisor = 0;
            for (int i = a - 1; i > 0; i--)
            {
                if (a % i == 0)
                {
                    divisor = i;
                    break;
                }
            }
            return divisor;
        }
        // task 4
        public void SolveTask4()
        {
            Console.WriteLine("Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B,\n" +
                "которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).");
            int numA = DataInput.GetIntNumFromUser("Введите число А: ");
            int numB = DataInput.GetIntNumFromUser("Введите чиcло B: ");
            if (numB < numA)
                Helper.MySwap(ref numA, ref numB);
            Console.WriteLine("Сумма таких чисел = " + GetSumDivisorOfSevensInRange(numA, numB));
        }
        public int GetSumDivisorOfSevensInRange(int a, int b)
        {
            int sumResult = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0) sumResult += i;
            }
            return sumResult;
        }
        //task 5
        public void SolveTask5()
        {
            Console.WriteLine("Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.");
            int num1 = DataInput.GetIntNumFromUser("Введите число А: ");
            int num2 = DataInput.GetIntNumFromUser("Введите чиcло B: ");
            Console.WriteLine($"НОД = {GetGCD(num1, num2)}");
        }
        public int GetGCD(int num1, int num2)
        {
            int resultNOD = 1;
            while (num1 != num2 && num1 != 0 && num2 != 0)
            {
                if (num1 > num2)
                {
                    resultNOD = num2;
                    num1 %= num2;
                }
                else
                {
                    resultNOD = num1;
                    num2 %= num1;
                }
            }
            return resultNOD;
        }
       
        //task 6
        public void SolveTask6()
        {
            Console.WriteLine("Пользователь вводит целое положительное число, которое является кубом целого числа N.\n" +
                "Найдите число N методом половинного деления");
            int num = DataInput.GetIntNumFromUser("Введите число: ");
            Console.WriteLine($"Результат: {GetCoubByMethOfHalfsDivides(num)}");
            
        }
        public int GetCoubByMethOfHalfsDivides(int num)
        {
            double left = num;
            double mid;
            double right;

            if (num > 0)
            {
                do
                {
                    right = left / 2;
                    mid = right * right * right;
                    left = right;
                }
                while (num != mid);
                return (int)Math.Floor(right);
            }
            else
                throw new ArgumentException("число было меньше или равно нулю");
        }
        //task 7
        public void SolveTask7()
        {
            Console.WriteLine("Пользователь вводит одно число произвольной длины (5-8 цифр). " +
                "Найти количество нечетных цифр этого числа.");
            int userNum = DataInput.GetIntNumFromUser("Введите число: ");
            Console.WriteLine(GetCountOfOdds(userNum));
        }
        public int GetCountOfOdds(int userNum)
        {
            int counter = 0;
            while (userNum % 10 != 0)
            {
                if (userNum % 2 != 0) counter++;
                userNum /= 10;
            }
            return counter;
        }
        //task 8
        public void SolveTask8()
        {
            Console.WriteLine("Пользователь вводит 1 число. Найти число,\n" +
                "которое является зеркальным отображением последовательности цифр заданного числа,\n" +
                "например, задано число 123, вывести 321.");
            int userNum = DataInput.GetIntNumFromUser("Введите число: ");
            Console.Write($"число в обратном порядке: {GetMirrorNum(userNum)}");
        }
        public int GetMirrorNum(int num)
        {
            bool mi = false;
            if (num < 0)
            {
                mi = true;
                num = -num;
            }
            int mirNum = 0;
            while (num > 0)
            {
                mirNum *= 10;
                mirNum += num % 10;
                num /= 10;
            }
            if (mi)
                return -mirNum;
            return mirNum;
        }
        //task 9
        public void SolveTask9()
        {
            Console.WriteLine("Пользователь вводит целое положительное  число (N).\n" +
                "Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных. ");
            int userNum = DataInput.GetIntNumFromUser("Введите число: ");
            Helper.PrintIntArr(GetNumsEvensSumBiggerOdds(userNum));
        }
        public int[] GetNumsEvensSumBiggerOdds(int num)
        {
            int counter = 0;

            for (int i = 1; i <= num; i++)
            {
                int tempVal = i;
                int sumOfOdds = 0;
                int sumOfEvens = 0;

                while (tempVal > 0)
                {
                    if ((tempVal % 10) % 2 == 0)
                        sumOfEvens += tempVal % 10;
                    else
                        sumOfOdds += tempVal %= 10;
                    tempVal /= 10;
                }
                if (sumOfEvens > sumOfOdds)
                    counter++;
            }
            int[] arr = new int[counter];
            for (int i = 1, j = 0; i <= num; i++)
            {
                int tempVal = i;
                int sumOfOdds = 0;
                int sumOfEvens = 0;

                while (tempVal > 0)
                {
                    if ((tempVal % 10) % 2 == 0)
                        sumOfEvens += tempVal % 10;
                    else
                        sumOfOdds += tempVal %= 10;
                    tempVal /= 10;
                }
                if (sumOfEvens > sumOfOdds)
                {
                    arr[j] = i;
                    j++;
                }
            }
            return arr;
        }
        //task 10
        public void SolveTask10()
        {
            Console.WriteLine("Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры.\n" +
                " Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.");
            int firstUserNum = DataInput.GetIntNumFromUser("введите первое число: ");
            int secondUserNum = DataInput.GetIntNumFromUser("введите второе число: ");
            Console.WriteLine(SayYesIfNumbersGotEqualsDigits(firstUserNum, secondUserNum));
        }
        public string SayYesIfNumbersGotEqualsDigits(int num1, int num2)
        {
            bool flag = false;

            while (num1 % 10 > 0)
            {
                int tempNum = num2;
                while (tempNum % 10 > 0)
                {
                    if (num1 % 10 == tempNum % 10)
                    {
                        flag = true;
                        if (flag) break;
                    }
                    tempNum /= 10;
                }
                if (flag) break;
                num1 /= 10;
            }
            if (flag)
                return "ДА";
            else
                return "НЕТ";
        }
    }
}
