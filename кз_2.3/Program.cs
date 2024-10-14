using static System.Math;
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
for (; n!= 1; i++)
{
    if ((int)n % 2 == 0)
    {
        n = n / 2;
    }
    else
    {
        n = 3 * n + 1;
    }
    Console.WriteLine(n);
}
Console.WriteLine($"число замен {i}");