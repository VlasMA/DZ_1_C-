// Задача 8. Напишите программу, которая на вход принимает число (N), а на выход показывает все четные чтслаот 1 до N.
Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int firstNumber = 2;

while (firstNumber <= number)
{
    Console.Write( firstNumber + " " ) ;
    firstNumber = (firstNumber + 2);
}
