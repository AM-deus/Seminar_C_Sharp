// Задача 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 

Console.Clear ();

// 1 вариант

Console.Write("Введите Ваше число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if(numberA>100 & numberA<1000){
    Console.WriteLine(numberA%10);
}
