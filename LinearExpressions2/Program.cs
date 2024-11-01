using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        double m, n,z1,z2;
        Console.WriteLine("enter n: ");
        string input = Console.ReadLine();
        n = double.Parse(input);
        Console.WriteLine("enter m: ");
        string input1 = Console.ReadLine();
        m = double.Parse(input1);
        z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) /
                     Math.Sqrt(Math.Pow(m, 3) * n + n * m + Math.Pow(m, 2) - m);
        Console.WriteLine(z1);
        z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
        Console.WriteLine(z2);
        double  x, b, a;
        Console.WriteLine("enter x: ");
        string input2 = Console.ReadLine();
        x = double.Parse(input2);
        Console.WriteLine("enter b: ");
        string input3 = Console.ReadLine();
        b = double.Parse(input3);
        Console.WriteLine("enter n: ");
        string input4 = Console.ReadLine();
        a = double.Parse(input4);
        double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) +
                      (a - b) * Math.Pow(Math.Sin(a - b), 2) +
                      Math.Pow(10, -2) * (x - b);
        Console.WriteLine(y);
    }
}
       