﻿// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
Console.Write("Введите первое число -> ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число -> ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) 
{
 Console.Write("Большее число ");
 Console.WriteLine(a);
 Console.Write("Меньшее число ");
 Console.WriteLine(b);
}
else if (a == b) Console.Write("Введённые числа равны!");
else
{
 Console.Write("Большее число ");
 Console.WriteLine(b);
 Console.Write("Меньшее число ");
 Console.WriteLine(a);
}
