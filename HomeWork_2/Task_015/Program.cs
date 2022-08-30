// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным
// 6 -> да; 7 -> да; 1 -> нет



Console.Clear ();

/*
dotnet new console
dotnet run 
*/

//1 вариант

GetNumber();
GetNumber();
GetNumber();
GetNumber();
GetNumber();
GetNumber();
GetNumber();
GetNumber();
void GetNumber()
{
Console.Write("Введите число дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number>=8){
    Console.WriteLine($"Парень ты пьян, иди проспись!");
}
else{
    if(number>5 & number<8){
        Console.WriteLine($"Ура, ВЫХОДНОЙ день");
        }
        else{
            Console.WriteLine($"Работай негр, до выходных еще далеко(");
        }
}
}