// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int number = 1;
for (int number =- N; number <=N; number ++)
Console.WriteLine("Чётные числа от 1 до " + N);
if (number % 2 != 1)
{
    Console.Write(number + ", ");
}