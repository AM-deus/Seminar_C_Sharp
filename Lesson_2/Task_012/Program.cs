// Задача 11. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//  Если число 2 не кратно числу1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4, 16, 4 -> кратно

Console.Clear ();

/*
dotnet new console
dotnet run 
*/

// 1 вариант
GetNumbersDif();
GetNumbersDif();
GetNumbersDif();

void GetNumbersDif()
{
Console.Write("Введите Ваше первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Ваше второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA%numberB==0){
    Console.WriteLine($"Кратно!");
}
else{
    if(numberA%numberB != 0){
        int dif = numberA%numberB;
        Console.WriteLine($"Не кратно, остаток - {dif}");
}
}
}
