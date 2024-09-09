using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tinhthues_sudung_thuvien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh tinh thue");
            double a, b;
            Console.Write("Nhap thu nhap 1: "); a = int.Parse(Console.ReadLine());
            Console.Write("Nhap thu nhap 2: "); b = int.Parse(Console.ReadLine());

            tinhthue_dll.TaxCalculator sum;
            sum = new tinhthue_dll.TaxCalculator();
            sum.tien1 = a;
            sum.tien2 = b;
            sum.tinhtoathue();
            Console.WriteLine("Tong sau thue: " + sum.sum);
            Console.ReadLine();
        }
    }
}
