// See https://aka.ms/new-console-template for more information
using Metodo_Modificadores;
Statistics statistics = new Statistics();
var (moda, valorMin, valorMax) = statistics.ModaMinMax(38, 2, 34, 24, 46, 37, 44, 28, 35, 24, 13, 31, 31, 7, 31, 43, 26, 23, 50, 39, 6, 37, 17, 38, 36, 39, 41, 25, 22, 17, 8, 1, 9, 33, 43, 43, 12, 13, 7, 1, 35, 25, 18, 14, 38, 35, 8, 43, 17, 8, 44, 24, 5, 6, 8, 27, 42, 24, 47, 40, 43, 13);
Console.WriteLine($"The moda is:{moda}");
Console.WriteLine($"The max valor is:{valorMax}");
Console.WriteLine($"The min valor is:{valorMin}");

