﻿// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
} 
Console.ReadKey();