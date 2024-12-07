using static System.Math;
class ComplexNumber
{
    public double realPart;
    public double imagPart;
    public ComplexNumber(double real, double imag)
    {
        realPart = real;
        imagPart = imag;
    }
    public ComplexNumber Add (ComplexNumber other)
    {
        return new ComplexNumber(realPart + other.realPart, imagPart + other.imagPart);
    }

    public ComplexNumber Multiply(ComplexNumber other)
    {
        double real = (realPart * other.realPart) - (imagPart * other.imagPart);
        double imag = (realPart * other.imagPart) + (imagPart * other.realPart);
        return new ComplexNumber(real, imag);
    }

    public ComplexNumber Divide(ComplexNumber other)
    {
        double znam = (other.realPart * other.realPart) + (other.imagPart * other.imagPart);
        double real = ((realPart * other.realPart) + (imagPart * other.imagPart)) / znam;
        double imag = ((imagPart * other.realPart) - (realPart * other.imagPart)) / znam;
        return new ComplexNumber(real, imag);
    }

    public ComplexNumber Stepen(int exp)
    {
        ComplexNumber res = new ComplexNumber(1, 0);
        for (int i = 0; i < exp; i++)
        {
            res = res.Multiply(this);
        }
        return res;
    }
    public double Mod()
    {
        return Math.Sqrt((realPart * realPart) + (imagPart * imagPart));
    }

    public double Angle()
    {
        return Math.Atan2(imagPart, realPart);
    }

    public ComplexNumber Sqrt()
    {
        double real = Math.Sqrt(Mod()) * Math.Cos(Angle() / 2);
        double imag = Math.Sqrt(Mod()) * Math.Sin(Angle() / 2);
        return new ComplexNumber(real, imag);
    }
    public override string ToString()
    {
        return $"{realPart}+{imagPart}i";
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите действительную и мнимую часть числа a через Enter:");
        ComplexNumber num_a = ReadComplexNumber();

        Console.WriteLine("Введите действительную и мнимую часть числа b через Enter:");
        ComplexNumber num_b = ReadComplexNumber();

        Console.WriteLine("Введите номер степени:");
        int exp = int.Parse(Console.ReadLine());

        ComplexNumber add = num_a.Add(num_b);
        Console.WriteLine($"a+b= {add}");

        ComplexNumber multiply = num_a.Multiply(num_b);
        Console.WriteLine($"a*b= {multiply}");

        ComplexNumber divide1 = num_a.Divide(num_b);
        Console.WriteLine($"a/b= {divide1}");

        ComplexNumber divide2 = num_b.Divide(num_a);
        Console.WriteLine($"b/a= {divide2}");

        ComplexNumber stepen1 = num_a.Stepen(exp);
        Console.WriteLine($"Возведение числа a в степень {exp}: {stepen1}");

        ComplexNumber stepen2 = num_b.Stepen(exp);
        Console.WriteLine($"Возведение числа b в степень {exp}: {stepen2}");

        ComplexNumber sqrt1 = num_a.Sqrt();
        Console.WriteLine($"Квадратный корень числа a: {sqrt1}");

        ComplexNumber sqrt2 = num_b.Sqrt();
        Console.WriteLine($"Квадратный корень числа b: {sqrt2}");

        double mod1 = num_a.Mod();
        Console.WriteLine($"Модуль числа a: {mod1}");

        double mod2 = num_b.Mod();
        Console.WriteLine($"Модуль числа b: {mod2}");

        double angle1 = num_a.Angle();
        Console.WriteLine($"Угол числа a: {angle1}");

        double angle2 = num_b.Angle();
        Console.WriteLine($"Угол числа b: {angle2}");
    }

    static ComplexNumber ReadComplexNumber()
    {
        double real = double.Parse(Console.ReadLine());
        double imag = double.Parse(Console.ReadLine());
        return new ComplexNumber(real, imag);
    }
}


