// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear ();
Console.Write("Введите Ваше первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Ваше второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int Max = numberA;
if(numberB>Max){
    Max = numberB;
    Console.Write ("Первое число (");
    Console.Write (numberA);
    Console.Write (")");
    Console.Write (" меньше (<) второго (");
    Console.Write (numberB);
    Console.Write (")");
}
else
{
   Console.Write ("Первое число (");
    Console.Write (numberA);
    Console.Write (")");
    Console.Write (" больше (>) второго (");
    Console.Write (numberB);
    Console.Write (")");
}
