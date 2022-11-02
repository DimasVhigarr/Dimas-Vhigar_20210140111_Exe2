using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimas_Vhigar_20210140111_Exe2
{
    class Program
    {
        private int[] dimas = new int[22];
        private int n;
        public void read()
        {
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 22)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 22 element. \n");
            }
        }
    }
}


