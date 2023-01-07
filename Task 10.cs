﻿using System;

namespace ConsoleApp
{
class Program
{
static void Main(string[] args)
{

Console.Write("Введи трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
}
    
}
}