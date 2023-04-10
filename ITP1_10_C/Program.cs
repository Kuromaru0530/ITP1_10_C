using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while(true)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0) break;

            List<double> s = new List<double>();

            var input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length; i++)
            {
                s.Add(int.Parse(input[i]));
            }
            var ave = s.Average();

            List<double> diff = new List<double>();

            s.ForEach(x => diff.Add(Math.Pow(x - ave, 2)));
            var v = Math.Sqrt(diff.Sum() / n);
            Console.WriteLine(v);
        }
        
    }
}