using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба х=");
            double x = Convert.ToDouble(Console.ReadLine());
            double Sqr, Vol;
            CulcVol(x, out Sqr, out Vol);
            Console.WriteLine("Площадь куба равна {0:f2}\nОбъем куба равен {1:f2}", Sqr, Vol);            
            Console.ReadKey();
        }
        static void CulcVol(double x, out double Sqr, out double Vol)
        {
            Sqr = 6 * Math.Pow(x, 2);
            Vol = Math.Pow(x, 3);
        }
    }
}
