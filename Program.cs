using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TersReqem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin");//5reqemli ededin tersini tapin
            int a = int.Parse(Console.ReadLine());
            int b = (a % 10);//son reqem
            int c = (a / 10) % 10;//4cu reqem
            int d = (a / 100) % 10;//3cu reqem
            int e = (a / 1000) % 10;//2ci reqem
            int f = (a / 10000) % 10;//1ci reqem
            int ters = b * 10000 + c * 1000 + d * 100 + e * 10 + f;
            Console.WriteLine(ters);
            Console.ReadLine();
        }
    }
}
