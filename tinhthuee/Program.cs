using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhthuee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh tinh thue");
            double a, b, tong;
            Console.Write("Nhap thu nhap 1: "); a = int.Parse(Console.ReadLine());
            Console.Write("Nhap thu nhap 2: "); b = int.Parse(Console.ReadLine());
            tong = a+ b;
            Console.WriteLine("Tong sau thue: "+ (tong+(tong*0.1)));
            Console.ReadLine();
        }
    }
}
