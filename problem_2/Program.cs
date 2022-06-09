// Задача 2. Написать программу, которая на вход принимает два числа и выдает, которое больше, а которое меньше.
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число, не равное первому: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("max=" + numberA );
    Console.WriteLine("min=" + numberB );
}
else
{
    Console.WriteLine("max=" + numberB );
    Console.WriteLine("min=" + numberA );
}