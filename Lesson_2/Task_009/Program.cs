// Задача 9. Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.

Console.Clear ();

/*
dotnet new console
dotnet run 
*/

int number = GetMaxNumberRandomValue();

Console.WriteLine(number);

int GetMaxNumberRandomValue(){

int randomValue = new Random().Next(10,100);

Console.WriteLine($"Randon value - {randomValue}");

int LastNumber = randomValue % 10;
int FirstNumber = randomValue / 10;

int Max = LastNumber;
if (Max<FirstNumber){
    Max = FirstNumber;
    Console.WriteLine($"Max = {Max}");
}
else{
    if (LastNumber == FirstNumber){
    Console.WriteLine($"Числа равны");}
    else{
        Console.WriteLine($"Max = {Max}");
    }
}

Console.WriteLine($"FirstNumber = {FirstNumber}");
Console.WriteLine($"LastNumber = {LastNumber}");
Console.WriteLine(randomValue);
//Console.WriteLine($"{randomValue},{randomValue}");
//Console.WriteLine($"{0},{1}");
    return randomValue;
}

/*
Random random = new Random();
int randomValue = random.Next(10,100);
int LastNumber = randomValue % 10;
int FirstNumber = randomValue / 10;

int Max = LastNumber;
if (Max<FirstNumber){
    Max = FirstNumber;
    Console.WriteLine($"Max = {Max}");
}
else{
    if (LastNumber == FirstNumber){
    Console.WriteLine($"Числа равны");}
    else{
        Console.WriteLine($"Max = {Max}");
    }
}

Console.WriteLine($"FirstNumber = {FirstNumber}");
Console.WriteLine($"LastNumber = {LastNumber}");
Console.WriteLine(randomValue);
//Console.WriteLine($"{randomValue},{randomValue}");
//Console.WriteLine($"{0},{1}");
*/