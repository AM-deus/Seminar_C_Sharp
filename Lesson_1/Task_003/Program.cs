// Задача 3: Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Clear ();
Console.Write("Введите Ваш номер дня недели: ");
//int number = Convert.ToInt32(Console.ReadLine());
int number = new Random().Next(1, 6);//1 2 3 4 ...5
Console.WriteLine(number);
string Monday = ("О нет! Сегодня - Понедельник");
string Tuesday = ("Вторник");
string Wednesday = ("Среда");
string Thursday = ("Четверг");
string Friday = ("Ура,Пятница!");

// 1 вариант
switch(number){
    case 1:
    Console.WriteLine (Monday);
break;
    case 2:
    Console.WriteLine (Tuesday);
break;
    case 3:
    Console.WriteLine (Wednesday);
break;
    case 4:
    Console.WriteLine (Thursday);
break;
    case 5:
    Console.WriteLine (Friday);
break;
}

// 2 вариант
// if(number == 1){
//     Console.WriteLine (Monday);}
// if(number == 2){
//     Console.WriteLine (Tuesday);}
// if(number == 3){
//     Console.WriteLine (Wednesday);}
// if(number == 4){
//     Console.WriteLine (Thursday);}
// if(number == 5){
//     Console.WriteLine (Friday);}

// 3 вариант
// if (number == 1)
// {
//     Console.WriteLine (Monday);
// }
// else
// {
//     if (number == 2)
//    {
//         Console.WriteLine (Tuesday);
//     }
//     else
//     {
//         if (number == 3)
//         {
//             Console.WriteLine (Wednesday);
//         }
//         else
//         {
//             if (number == 4)
//             {
//                 Console.WriteLine (Thursday);
//             }
//             else
//             {
//                 Console.WriteLine (Friday);
//             }
//         }
//     }
// }