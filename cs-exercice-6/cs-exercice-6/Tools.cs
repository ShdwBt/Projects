using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_exercice_6
{
    public static class Tools
    {
        public static void screen(string str){
            Console.WriteLine(str);
        }

        public static void screenBreak()
        {
            Console.WriteLine("*****************************");
        }

        public static void screenStop(string str)
        {
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
