using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           for (int i=1;i<=9;i++)
            {
                int k=1+i;
                for (int j = 1; j <=k; j++)
                {
                    Console.Write("*");
                    if (i <= 5)
                    {
                        k =i;
                    }
                    else
                    {
                        k = 10 - i;
                    }


                }
                
                Console.WriteLine();
                
            }
          


            Console.ReadKey();

        }
    }
}
