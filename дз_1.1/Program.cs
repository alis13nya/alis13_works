﻿using static System.Math;
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i < n; i++)
{
    bool isPrime = true;

    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        if (i % j == 0) 
        {
            isPrime = false;
            break; 
        }
    }

    if (isPrime) 
    {
        Console.WriteLine(i);
    }
}


