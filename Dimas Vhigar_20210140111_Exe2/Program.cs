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
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine("Masukkan element Array");
            Console.WriteLine("----------------------");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                dimas[1] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Element array yang telah tersusun");
            Console.WriteLine("---------------------------------");
            for (int dv = 0; dv < n; dv++)
            {
                Console.WriteLine(dimas[dv]);
            }
            Console.WriteLine("");

        }
        public void Method1()
        {
            for (int i = 1; i < n; i++)
            {
                for (int dv = 0; dv < n - i; dv++)
                {
                    if (dimas[dv] < dimas[dv + 1])
                    {
                        int temp;
                        temp = dimas[i];
                        dimas[dv] = dimas[i - 1];
                        dimas[dv + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program MyList = new Program();

            MyList.read();
            
        }
    }
}


