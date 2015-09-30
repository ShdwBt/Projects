using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_exercice_5
{
    public partial class Form1 : Form
    {
        StreamReader reader;
        StreamWriter writer;
        string fichier = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writer = new StreamWriter(fichier);
            writer.Write(textBox1.Text);
            writer.Close();
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            reader = new StreamReader(openFileDialog1.OpenFile());
            textBox1.Text = reader.ReadToEnd();
            reader.Close();
            fichier = openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            
        }
    }
}
