﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int n;
string line_n;

Console.WriteLine("Введите число n соответствующее дню недели, исходя из того, что пн - 1, вт - 2 и т.д.:  ");
line_n = Console.ReadLine();
n = Convert.ToInt32(line_n);

if (n > 5 && n < 8)
{
  Console.WriteLine("Введенный день является ВЫХОДНЫМ");
}
else 
{
Console.WriteLine("Введенный день НЕ является выходным");
}