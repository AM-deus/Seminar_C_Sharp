// Задача 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5,25 -> да; -4,16 -> да; 25,5 -> да; 8,9 -> нет;

Console.Clear ();

/*
dotnet new console
dotnet run 
*/

// 1 вариант
GetNumber();
GetNumber();
GetNumber();
GetNumber();

void GetNumber()
{
    Console.Write("Введите Ваше первое число: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Ваше второе число: ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    if(numberA==numberB*numberB){
        Console.WriteLine($"Является квадратом");
    }
    else{
        if(numberB==numberA*numberA){
            Console.WriteLine($"Является квадратом");
        }
        else
        {
            Console.WriteLine($"Не вляется квадратом");
        }
    }
}

// 2 вариант. Внешние входные данные
/*
Console.Write("Введите Ваше первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Ваше второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void GetNumber(int numberA, int numberB)
{
    if(numberA==numberB*numberB){
        Console.WriteLine($"Является квадратом");
    }
    else{
        if(numberB==numberA*numberA){
            Console.WriteLine($"Является квадратом");
        }
        else
        {
            Console.WriteLine($"Не вляется квадратом");
        }
    }
}

GetNumber(number1, number2);

*/
