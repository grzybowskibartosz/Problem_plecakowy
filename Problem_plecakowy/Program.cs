using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("TestProject1")]
[assembly: InternalsVisibleTo("WinFormsApp1"), InternalsVisibleTo("GUI")]
namespace Problem_plecakowy
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the seed value: ");
            int seed = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Enter the number of items: ");
            int n = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Enter the capacity of backpack: ");
            int capacity = Convert.ToInt32(Console.ReadLine());

            Problem problem = new Problem(n, seed);
            Console.WriteLine(problem.ToString());
   
            Result result = problem.Solve(capacity);
            Console.WriteLine(result.ToString());
        }
    }
}
