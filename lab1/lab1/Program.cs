using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value: ");
            double m;
            double x = Convert.ToDouble(Console.ReadLine());
            m = Math.Pow(x, 2) + 2 * x + Math.Atan(x / 2);
            Console.WriteLine($"m = {m}");
        }
    }
}
