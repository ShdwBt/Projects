using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_exercice_6
{
    interface ICalculator {
        double Add();
        double Multiply();
        double Substract();
        double Divide();
    }

    class Ouvrier : Employe
    {

    }
    class Manager : Employe
    {

    }
    class Employe
    {
        public Employe()
        {
            Tools.screen("Création employé");
        }

        ~Employe()
        {
            Tools.screen("Destructeur employé");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Employe emp1 = new Employe();
            Tools.screenBreak();
            Manager man1 = new Manager();
            Tools.screenBreak();
            Ouvrier ouv1 = new Ouvrier();*/
            Employe emp1 = new Employe();
            Tools.screenBreak();
            Tools.screenStop("Done");
        }
    }
}