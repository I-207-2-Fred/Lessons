using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Lesson3
{
    public class GUIConsolApp
    #region GUI
    {
        public static void Run()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                    while (keepRunning)
                    {
                    #region Select
                    Console.Write("\nВыберите задачу: \n" + "0 - счет процентов\n" + "1 - умножение\n" + "2 - деление\n" + "3 - вычитание\n" + "4 - сложение\n" + "5 - сумма\n" + "6 - для массива\n" + "7 - максимум\n" + "8 - минимум\n" + "9 - факториал\n" + "10 - деление на остаток и деление на целое\n" + "11 - обратное процентам\n" + "Выберите номер задачи: ");
                    #endregion
                    #region Case
                    string choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "0":
                                Console.Write("Введите число:");
                                double num0 = double.Parse(Console.ReadLine());
                                Console.Write("Введите процентр:");
                                double prc0 = double.Parse(Console.ReadLine());
                                Console.Write($"Результат ({prc0}% - {num0}) - {MathWork.Percent(num0, prc0)}\n"); break;

                            case "1":
                                Console.Write("Введите первое число:");
                                double a = double.Parse(Console.ReadLine());
                                Console.Write("Введите второе число:");
                                double b = double.Parse(Console.ReadLine());
                                Console.Write($"Результат умножения - {MathWork.Multiply(a, b)}\n"); break;

                            case "2":
                                Console.Write("Введите делимое:");
                                double diva = double.Parse(Console.ReadLine());
                                Console.Write("Введите делитель:");
                                double divb = double.Parse(Console.ReadLine());
                                Console.Write($"Результат деления - {MathWork.Divide(diva, divb)}\n"); break;

                            case "3":
                                Console.Write("Введите первое число:");
                                double minusa = double.Parse(Console.ReadLine());
                                Console.Write("Введите второе число:");
                                double minusb = double.Parse(Console.ReadLine());
                                Console.Write($"Результат вычитания - {MathWork.Substract(minusa, minusb)}\n"); break;

                            case "4":
                                Console.Write("Введите первое число:");
                                double adda = double.Parse(Console.ReadLine());
                                Console.Write("Введите второе число:");
                                double addb = double.Parse(Console.ReadLine());
                                Console.Write($"Результат сложения - {MathWork.Add(adda, addb)}\n"); break;

                            case "5":
                                int[] array1 = MathWork.InputArray();
                                Console.Write($"Сумма элементов массива: {MathWork.SumArray(array1)}\n");
                                break;

                            case "6":
                                int[] array2 = MathWork.InputArray();
                                MathWork.PrintArray(array2);
                                break;

                            case "7":
                                int[] array3 = MathWork.InputArray();
                                Console.Write($"Максимальный элемент: {MathWork.MaxArray(array3)}\n");
                                break;

                            case "8":
                                int[] array4 = MathWork.InputArray();
                                Console.Write($"Минимальный элемент: {MathWork.MinArray(array4)}\n");
                                break;

                            case "9":
                                Console.Write("Введите целое неотрицательное число: ");
                                int factNum = int.Parse(Console.ReadLine());
                                Console.Write($"Факториал {factNum} равен: {MathWork.Factorial(factNum)}\n");
                                break;

                            case "10":
                                Console.Write("Введите делимое (целое): ");
                                int d1 = int.Parse(Console.ReadLine());
                                Console.Write("Введите делитель (целое): ");
                                int d2 = int.Parse(Console.ReadLine());

                                var (quotient, remainder) = MathWork.DivRem(d1, d2);
                                Console.Write($"Целая часть: {quotient}, Остаток: {remainder}\n");
                                break;

                            case "11":
                                Console.Write("Введите общую сумму: ");
                                double revTotal = double.Parse(Console.ReadLine());
                                Console.Write("Введите процент: ");
                                double revPercent = double.Parse(Console.ReadLine());
                                Console.Write($"Результат без процентов - {MathWork.RevercePercent(revTotal, revPercent)}\n");
                                break;

                            case "12":
                                int[] array5 = MathWork.InputArray();
                                MathWork.SortArray(array5);
                                Console.Write("Массив отсортирован. ");
                                MathWork.PrintArray(array5);
                                break;
                        }
                    #endregion
                    Console.Write("Хотите продолжить? y/n: ");
                        string answer = Console.ReadLine();
                        if (answer != "y" && answer != "yes")
                        {
                            keepRunning = false;
                            Console.Write("Программа завершена!\n");
                        }
                        else
                        {
                            keepRunning = true;
                            Console.Clear();
                        }
                }
            }
        }
    }
    #endregion
}