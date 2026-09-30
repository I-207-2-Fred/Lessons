using System;

namespace Lesson3
{
    #region Class
    public static class MathWork
    {
        public static double Percent(double number, double percentage)
        {
            return number * percentage / 100;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            return a / b;
        }

        public static double Substract(double a, double b)
        {
            return a - b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static int SumArray(int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
                sum += item;

            return sum;
        }

        public static int MaxArray(int[] arr)
        {
            if (arr.Length == 0) throw new ArgumentException("Массив пуст");
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            return max;
        }

        public static int MinArray(int[] arr)
        {
            if (arr.Length == 0) throw new ArgumentException("Массив пуст");
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }

            return min;
        }

        public static long Factorial(int n)
        {
            long result = 1;

            for (int i = 1; i <= n; i++)
                result *= i;

            return result;
        }

        public static (int quotient, int remainder) DivRem(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            return (a / b, a % b);
        }

        public static double RevercePercent(double total, double percent)
        {
            return total / (1 + percent / 100);
        }

        public static void SortArray(int[] arr)
        {
            Array.Sort(arr);
        }

        public static int[] InputArray()
        {
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите элемент [{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        public static void PrintArray(int[] arr)
        {
            Console.WriteLine("Элементы массива: " + string.Join(", ", arr));
        } 
    }
    #endregion
}