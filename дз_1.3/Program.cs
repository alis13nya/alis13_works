using static System.Math;
Console.Write("Введите коэффициент a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент c: ");
int c = Convert.ToInt32(Console.ReadLine());
int d = b * b - 4 * a * c;
Console.WriteLine($"Дескриминaнт = {d}");
if (a == 0)
{
    Console.WriteLine("ПЕРВЫЙ КОЭФФИЦИЕНТ НЕ ДОЛЖЕН БЫТЬ РАВЕН НУЛЮ!!!");
}
else
{
    if (d > 0)
    {
        int x1 = (int)((-b + Math.Sqrt(d)) / (2 * a));
        int x2 = (int)((-b - Math.Sqrt(d)) / (2 * a));
        Console.WriteLine($"2 корня: {x1} и {x2}");
    }
    if (d == 0)
    {
        int x = (int)((-b) / (2 * a));
        Console.WriteLine($"1 корeнь:{x}");
    }
    if (d < 0)
    {
        Console.WriteLine("корней нет");
    }

}



    