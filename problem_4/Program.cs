Console.Write("Введите число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}
Console.WriteLine("max=" + max);