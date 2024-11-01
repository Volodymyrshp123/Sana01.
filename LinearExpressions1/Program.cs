using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c, d,z,r,x,y;
        Console.WriteLine("enter a: ");
        string input = Console.ReadLine();
        a = double.Parse(input);
        Console.WriteLine("enter b: ");
        string input1 = Console.ReadLine();
        b = double.Parse(input1);
        Console.WriteLine("enter c: ");
        string input2 = Console.ReadLine();
        c = double.Parse(input2);
        Console.WriteLine("enter d: ");
        string input3 = Console.ReadLine();
        d = double.Parse(input3);
       x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - Math.Pow(a, 2) / Math.Pow(b, 2);
        Console.WriteLine(x);
        y = (5 * (a + b) * (c - d)) / (0.5 * c) + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);
        Console.WriteLine(y);
        z = (Math.Pow((Math.Pow(x, 2) - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b)) / (5 * a + 3 * b);
        Console.WriteLine(z);
        r = (0.5 * a + 0.75 * b - 1.4) / (3 * c + 1) + 1 / (a - c);
        Console.WriteLine(r);

    }
}