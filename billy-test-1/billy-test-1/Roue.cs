using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billy_test_1
{
    class Roue
    {
        protected string marque;
        protected string taille;

        public Roue() {
            this.marque = "Dunlop";
            this.taille = "18";
        }

        public Roue(string marque, string taille) {
            this.marque = marque;
            this.taille = taille;
        }
        
    }
}
