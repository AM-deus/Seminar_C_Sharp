﻿// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear ();
Console.Write("Введите Ваш номер: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int i=0; i<=number; i++){
    if(i%2==0){
        Console.Write (i);
        Console.Write (", ");}
}
