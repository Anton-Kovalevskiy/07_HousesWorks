//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число -> ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число -> ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число -> ");
int c = Convert.ToInt32(Console.ReadLine());
//Ввели три числа
int max = a;
if (b > max) max = b;
else if (c > max) max = c;
Console.Write("Максимальное число -> "); 
Console.WriteLine(max);
//Поиск и вывод максимального числа