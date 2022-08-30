// Задача 11. Напишите программуБ которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
// 456-> 46, 782 -> 72, 918 -> 98

Console.Clear ();

/*
dotnet new console
dotnet run 
*/

// 1 вариант
GetNumber();
GetNumber();
GetNumber();

void GetNumber()
{
    int randomValue = new Random().Next(100,1000);
    if(randomValue>99 & randomValue<1000){
        //Console.WriteLine(randomValue);
        Console.WriteLine($"{randomValue/100}{randomValue%10}");
}
}
/*
{
Console.Write("Введите Ваше число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if(numberA>99 & numberA<10000){
    Console.WriteLine($"{numberA/100}{numberA%10}");
}
}
*/