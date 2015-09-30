using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billy_test_1
{
    class Voiture : Roue
    {
        protected string marque;
        protected string cv;

        public Voiture(string marque, string cv) {
            this.marque = marque;
            this.cv = cv;
        }

        public void ToString(){
            Console.Write(marque + " cv: " + cv+" roue:"+base.marque+","+ base.taille+"\"");
            Console.Read();
        }
    }
}
