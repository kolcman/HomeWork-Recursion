﻿//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void Main()
{
    int M = 5;
    int N = 23;
    printIntervalOfNumbers(M, N);

}

void printIntervalOfNumbers(int M, int N)
{
    if (M > N) return;
    System.Console.Write(M + " ");
    printIntervalOfNumbers(M + 1, N);
}


Main();