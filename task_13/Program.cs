//Задача 13: Напишите программу, которая выводит третью цифру заданного семизначного числа или сообщает, что третьей цифры нет.

int n;
int result;
string line_n;

Console.Write("Введите число: n ");
line_n = Console.ReadLine();
n = Convert.ToInt32(line_n);

if (n >= 1000000 && n < 10000000)
{
  result = n / 10000 - n / 100000 * 10;
  Console.WriteLine( "Третья цифра числа равна: " + result );
}
else if (n > 100 && n < 1000000)
{
 Console.WriteLine( "Данное число не является семизначным: ");
}
else
{
  Console.Write("Третьей цифры у данного числа нет");
}

