/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7     a = 2 b = 10 -> max = 10       a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
if (num_1 > num_2)
{
    Console.WriteLine("Первое число "  +num_1+ " больше чем второе "  +num_2);
}
else
{
    Console.WriteLine("Второе число "  +num_2+ " больше чем первое "  +num_1);
}
