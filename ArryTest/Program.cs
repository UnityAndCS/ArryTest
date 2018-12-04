using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string []arry = new string[4];
            arry[0] = "111";
            arry[3] = "111";
            for(int i = 0; i <=3; i++)
            {
                Console.WriteLine(arry[i]);
            }
            Console.ReadKey();
        }
    }
}
