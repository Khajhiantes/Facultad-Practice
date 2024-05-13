// See https://aka.ms/new-console-template for more information
double[] heights = new double[10];
double sum = 0;
double prom = 0;
int counter = 0;
double variance = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write($"Give me your height person {i+1}: ");
    heights[i] = Convert.ToInt32(Console.ReadLine());
    sum += heights[i];
}
prom = sum / 10;
foreach (double h in heights)
{   
     counter+= 1;
    Console.WriteLine($"Person {counter}, Height: {h}");
    variance += Math.Pow((h - prom),2);
}
double devStandar = Math.Sqrt((variance / 10));
Console.WriteLine($"The average height is: {prom}");
Console.WriteLine($"The standar deviation is: {devStandar}");
foreach (double h in heights)
{
    if (h > prom)
    {
        Console.WriteLine($"The height {h} is above the average");
    }
}
foreach (double h in heights)
{
    if (h < prom)
    {
        Console.WriteLine($"The height {h} is below the average");
    }
}
foreach (double h in heights)
{
    if (h > prom - devStandar && h < prom + devStandar)
    {
        Console.WriteLine($"The height {h} is within the standard deviation");
    }
}

