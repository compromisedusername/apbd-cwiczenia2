﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Goodbye World!");
Console.WriteLine("And Hello World!");
Console.WriteLine("And Again Hello World!");



static double GetAverage(int[] numbers)
{
    int sum = 0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return (double) sum / numbers.Length;
}