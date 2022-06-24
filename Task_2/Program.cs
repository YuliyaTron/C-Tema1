// Задача 2: 
// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"Первое число {num1} больше, а второе число {num2} меньше ");
}
else
{
    Console.WriteLine($"Второе число {num2} больше, а первое число {num1} меньше ");
}