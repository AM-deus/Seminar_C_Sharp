// Задача 0. Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя)

// 1 вариант
// int numberA = -3;
// Console.WriteLine(numberA*numberA);

// 2 вариант
Console.Clear ();
Console.Write("Введите Ваше число: ");
//string number = Console.ReadLine();
int number = Convert.ToInt32(Console.ReadLine());
int result = number*number;
Console.WriteLine(result);