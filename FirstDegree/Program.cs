﻿using System.Text;

void fist_degree_solution(double a, double b)
{
    if (a == 0 && b == 0)
    {
        Console.WriteLine("vo so nghiem");
    }
    else if (a == 0 && b == 0)
    {
        Console.WriteLine("Vo nghiem");
    }
    else
    {
        Console.WriteLine("X={0}", -b / a);
    }
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Phuong trinh bac 1: ax+b=0");
Console.WriteLine("nhap he so a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("nhap he so b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("{0}x+{1}=0", a, b);
fist_degree_solution(a, b);
Console.WriteLine();