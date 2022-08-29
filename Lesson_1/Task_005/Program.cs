// Задача 5. Напишите программу, которая на вход принимает одно число(N), а на выходе показывает все целые числа в промежутке от -N до N.

// 1 вариант
// Console.Clear ();
// Console.Write("Введите Ваш номер: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int number_minus = -number;
// while(number_minus<=number){
//     Console.Write (number_minus);
//     Console.Write (", ");
//     
//     number_minus++;
// }

// 2 вариант
Console.Clear ();
Console.Write("Введите Ваш номер: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int i=-number; i<=number; i++){
    Console.Write (i);
    Console.Write (", ");
}