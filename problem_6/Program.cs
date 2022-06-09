// Задача 6. Написать программу, которая на вход принимает число и выдает, является ли число четным(делится ли оно на два без остатка).
Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Да, число чётное");
}
else
{
    Console.WriteLine("Нет, число не чётное");
}