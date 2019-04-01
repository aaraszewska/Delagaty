using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Some sm = new Some();
            sm.SomeMethod(CallBackMethod);
            Console.ReadKey();
           
        }
        static void CallBackMethod(int i)
        {
            Console.WriteLine(i);
        }

        class Some
        {
            public delegate void CallBac(int i);
            public void SomeMethod(CallBac obj)
            {
                for (int i = 0; i <1000; i++)
                {
                    obj(i);
                   // Console.WriteLine(i.ToString()); robi sie cos w tle
               }

                Console.ReadKey();
            }
        }
        


       
    }
}
