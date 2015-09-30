using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_exercice_3
{
    public partial class Form1 : Form
    {
        List<Control> listeDesControles = new List<Control>();
        List<Button> listeDesBoutons = new List<Button>();
        double total = 0;
        bool nextOperation;
        bool multiply;
        bool divide;
        bool add;
        bool soustract;

        void cleanCalc(){
            multiply = false;
            divide = false;
            add = false;
            soustract = false;
            nextOperation = false;
        }

        void doCalc(){
            if (multiply) 
            {
                multiplication();
                cleanCalc();
            }
            else if (divide)
            {
                division();
                cleanCalc();
            }
            else if (add)
            {
                addition();
                cleanCalc();
            }
            else if (soustract)
            {
                soustraction();
                cleanCalc();
            }
        }



        public void RecupererLesControles(Control c, List<Control> l)
        {
            foreach (Control control in c.Controls)
            {
                l.Add(control);
            }
        }
        public Form1()
        {
            InitializeComponent();
            RecupererLesControles(this, listeDesControles);
            foreach (Object o in listeDesControles)
            {
                if (o.GetType().Equals(typeof(Button)))
                {
                    listeDesBoutons.Add((Button)o);
                }
            }
            foreach (Button b in listeDesBoutons)
            {
                b.Click += calculatrice;               
            }
        }

        private void multiplication()
        {
            ecran.Text = ""+total * double.Parse(ecran.Text);
        }
        private void division()
        {
            ecran.Text = "" + total / double.Parse(ecran.Text);
        }
        private void soustraction()
        {
            double x = total - double.Parse(ecran.Text);
            ecran.Text = ""+x;
        }
        private void addition()
        {
            ecran.Text = "" + (total + double.Parse(ecran.Text));
        }


        private void calculatrice(Object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Text)
            {
                case "1":
                    if (nextOperation)
                        ecran.Text = "1";
                    else
                        ecran.Text += "1";
                    nextOperation = false;
                    break;
                case "2":
                    if (nextOperation)
                        ecran.Text = "2";
                    else
                        ecran.Text += "2";
                    nextOperation = false;
                    break;
                case "3":
                    if (nextOperation)
                        ecran.Text = "3";
                    else
                        ecran.Text += "3";
                    nextOperation = false;
                    break;
                case "4":
                    if (nextOperation)
                        ecran.Text = "4";
                    else
                        ecran.Text += "4";
                    nextOperation = false;
                    break;
                case "5":
                    if (nextOperation)
                        ecran.Text = "5";
                    else
                        ecran.Text += "5";
                    nextOperation = false;
                    break;
                case "6":
                    if (nextOperation)
                        ecran.Text = "6";
                    else
                        ecran.Text += "6";
                    nextOperation = false;
                    break;
                case "7":
                    if (nextOperation)
                        ecran.Text = "7";
                    else
                        ecran.Text += "7";
                    nextOperation = false;
                    break;
                case "8":
                    if (nextOperation)
                        ecran.Text = "8";
                    else
                        ecran.Text += "8";
                    nextOperation = false;
                    break;
                case "9":
                    if (nextOperation)
                        ecran.Text = "9";
                    else
                        ecran.Text += "9";
                    nextOperation = false;
                    break;
                case "0":
                    if (ecran.Text == "")
                    {
                    }
                    else
                    {
                        if (nextOperation)
                            ecran.Text = "0";
                        else
                            ecran.Text += "0";
                        nextOperation = false;
                    }
                    break;
                case "C":
                    total = 0;
                    cleanCalc();
                    ecran.Text = "";
                    break;
                case "x":
                    total = double.Parse(ecran.Text);
                    cleanCalc();
                    multiply = true;
                    nextOperation = true;
                    break;
                case "+":
                    total = double.Parse(ecran.Text);
                    cleanCalc();
                    add = true;
                    nextOperation = true;
                    break;
                case "-":
                    total = double.Parse(ecran.Text);
                    cleanCalc();
                    soustract = true;
                    nextOperation = true;
                    break;
                case "/":
                    total = double.Parse(ecran.Text);
                    cleanCalc();
                    divide = true;
                    nextOperation = true;
                    break;
                case "=":
                    doCalc();
                    cleanCalc();
                    break;

            }
        }


    }
}
