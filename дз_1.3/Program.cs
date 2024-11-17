using static System.Math;
Console.Write("Введите коэффициент a: ");
float a = (float)Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент b: ");
float b = (float)Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент c: ");
float c = (float)Convert.ToDouble(Console.ReadLine());
if (a == 0)
{
    if (b == 0)
    {
        if (c == 0)
        {
            Console.WriteLine("Бескoнечно много решений");
        }
        else
        {
            Console.WriteLine($"корень = {c}");
        }
    }
    else
    {
        double x = (double)((-c) / b);
        Console.WriteLine($"корень = {x}");
    }


}
else
{
    double d = b * b - 4 * a * c;
    Console.WriteLine($"Дискриминaнт = {d}");
    if (d > 0)
    {
        double x1 = (double)((-b + Math.Sqrt(d)) / (2 * a));
        double x2 = (double)((-b - Math.Sqrt(d)) / (2 * a));
        Console.WriteLine($"2 корня: {x1} и {x2}");
    }
    if (d == 0)
    {
        double x = (double)((-b) / (2 * a));
        Console.WriteLine($"1 корeнь:{x}");
    }
    if (d < 0)
    {
        Console.WriteLine("корней нет");
    }

}



    