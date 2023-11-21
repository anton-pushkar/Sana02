using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Enter num (int):");
        num = int.Parse(Console.ReadLine());
        Program program = new Program();
        Console.WriteLine("Result of first function = {0}",program.firstFunction(num));
        Console.WriteLine("Result of second function = {0}", program.secondFunction(num));
        Console.WriteLine("Result of third function = {0}", program.thirdFunction(num));
    }

     double firstFunction(int n)
    {
        int i = 1;
        double res = 0;
        while (i != n + 1)
        {
            res += Math.Pow(-1, i) / (2*i + 1);
            i++;
        }
        return res;
    }
     double secondFunction(int n)
    {
        int i = 1;
        double res = 0;
        while (i != n + 1) {
            res += 1 + 1 / Math.Pow(i, 2);
            i++;
        }
        return res;
    }
    double thirdFunction(int n)
    {
        int i = 1, factorial = 1; 
        double res = 0;
        while (i != n + 1)
        {
            res += factorial * i;
            factorial *= i;
            i++;
        }
        return res;
    }
}