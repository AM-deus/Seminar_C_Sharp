// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5; 782 -> 8; 918 -> 1

Console.Clear ();

/*
dotnet new console
dotnet run 
*/

//1 вариант
/*
GetNumber();
GetNumber();
GetNumber();
void GetNumber()
{
Console.Write("Введите Ваше трёхзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int number = ((numberA%100)-(numberA%10))/10;

if((numberA>99) & (numberA<1000)){
    Console.WriteLine($"Вторая цифра числа = {number}");
}
else{
    Console.WriteLine($"Число не трёхзначно!!! Введите другое число!");
}
}
*/

// 2 вариант

Console.Write("Введите Ваше число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

void GetNumber(int number)
{
if((number>99) & (number<1000)){
    int numberB = ((number%100)-(number%10))/10;
    Console.WriteLine($"Вторая цифра числа = {numberB}");
}
else{
    Console.WriteLine($"Число не трёхзначно!!! Введите другое число");
}
}
GetNumber (numberA);

