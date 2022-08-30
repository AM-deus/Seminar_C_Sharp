// Задача 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> не кратно; 46 -> не кратно; 161 -> кратно

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
Console.Write("Введите Ваше число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if((numberA%7==0) & (numberA%23==0)){
    Console.WriteLine($"Кратно!");
}
else{
    Console.WriteLine($"Не кратно!");
}
}
*/

// 2 вариант

/*
GetNumber();
GetNumber();
GetNumber();

void GetNumber()
{
Console.Write("Введите Ваше число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if(numberA%7==0){
    if((numberA)%23==0){
        Console.WriteLine($"Кратно!");
    }
    else{
    Console.WriteLine($"Не кратно!");
    }
}
else{
    Console.WriteLine($"Не кратно!");
}
}
*/

// 3 вариант

Console.Write("Введите Ваше число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

void GetNumber(int number)
{
if((number%7==0)&(number%23==0)){
    Console.WriteLine($"Кратно!");
}
else{
    Console.WriteLine($"Не кратно!");
}
}
GetNumber(numberA);