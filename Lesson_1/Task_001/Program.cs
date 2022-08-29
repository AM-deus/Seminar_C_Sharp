// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли перевое число квадратом второго.

Console.Clear ();

Console.Write("Введите Ваше первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Ваше второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int sqrdB = numberB*numberB;
string yes = ("Первое число является квадратом второго.");
string no = ("Первое число не является квадратом второго!");

if (numberA == sqrdB)
{
    Console.WriteLine (yes);
}
else
{
    Console.WriteLine (no);
}
