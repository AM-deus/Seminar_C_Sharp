// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear ();
Console.Write("Введите Ваше первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Ваше второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Ваше третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int Max = numberA;
if(numberB>Max){
    Max = numberB;}
if(numberC>Max){
    Max = numberC;}
Console.Write ("Максимальное число = ");
Console.Write (Max);