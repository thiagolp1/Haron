﻿double Lado1, Lado2, Lado3;
double p; // semiperimetro
double area;

Console.WriteLine("Digite os lados do triângulo desejado.\n");

Console.Write("Lado 1..: ");
Lado1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Lado 2..: ");
Lado2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Lado 3..: ");
Lado3 = Convert.ToDouble(Console.ReadLine());

p = (Lado1 + Lado2 + Lado3) / 2;
 area = Math.Sqrt(p * (p - Lado1) * (p - Lado2) * (p - Lado3));

Console.WriteLine($"Semiperímetro..: {p}");
Console.WriteLine($"Área...........: {area}");