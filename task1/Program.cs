﻿// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.

// Console.WriteLine("Введите первое число: ");
// int num_A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int num_B = Convert.ToInt32(Console.ReadLine());

// if (num_A > num_B)
// {
//     Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
// }
// else
// {
//     Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A);
// }

Console.WriteLine("Введите 3 числа:");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());
int max = num_1;
if (num_2 > max)
{
    max = num_2;
}
if (num_3 > max)
{
    max = num_3;
}
Console.WriteLine("Наибольшее из введённых чисел -> " + max);
