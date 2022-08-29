// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным(делится ли оно на два без остатка).

Console.Clear ();

Console.Write("Введите Ваше число: ");
int number = Convert.ToInt32(Console.ReadLine());

string yes = ("Число является чётным.");
string no = ("Число является нечётным.");

if (number%2 == 0)
{
    Console.WriteLine (yes);
}
else
{
    Console.WriteLine (no);
}
