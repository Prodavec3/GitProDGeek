// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
float a, b, c;
Console.WriteLine("A + B");
a = new Random().Next(0, 10);
b = new Random().Next(0, 10); //0..9
Console.WriteLine("A: " + a + ", B: " + b);
c = a + b;
Console.WriteLine("Сумма: " + c);
