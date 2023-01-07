﻿using System;

namespace ConsoleApp
{
class Program
{
static void Main(string[] args)
{

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int x = 1;
for(int i = 0; i < n; i++)
{
    if (x % 2 == 0)
    {
        Console.WriteLine(x);
    }
    x++;
}
    
}
}
}