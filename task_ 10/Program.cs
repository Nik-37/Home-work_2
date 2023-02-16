//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int n;
int result;
string line_n;

Console.Write("Введите число: n ");
line_n = Console.ReadLine();
n = Convert.ToInt32(line_n);

if (n >= 100 && n <= 999)
{
  result = n / 10 - n / 100 * 10;
  Console.WriteLine( "Вторая цифра числа равна: " + result );
}
else
{
  Console.Write("Число: n не является трехзначным");
}

