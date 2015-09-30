using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            long b = 5L;
            float c = 1.0f;
            double d = 5.0;

            object[] z = new Object[4];
            z[0] = a;
            z[1] = b;
            z[2] = c;
            z[3] = d;

            foreach(Object o in z){
                 o.GetType().GetProperty("a").GetType() .GetValue(o);
                Console.Write(o.ToString()+" ");
                Console.WriteLine(o.GetType());
            }
            
            
            Console.Read();
        }

    }
}