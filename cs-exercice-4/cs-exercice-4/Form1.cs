using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_exercice_4
{
    public partial class Form1 : Form
    { 
        string favorisImage = "C:\\Users\\Bilal\\Desktop\\etoileF.jpg";
        
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            resize();
            
        }

        public void resize() {
            pictureBox1.Image = resizeImage(pictureBox1.Image, new Size(21, 18));
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
           return (Image)(new Bitmap(imgToResize, size));
        }

    
        private void go_Click(object sender, EventArgs e)
        {
            string newUrl = "";

            if (url.Text.Substring(0, 4).ToLower() != "http")
            {
                newUrl = url.Text.Insert(0, "http://");
            }
            else {
                newUrl = url.Text;
            }

            Uri mUrl = new Uri(newUrl);
            navigateur.Url = mUrl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            navigateur.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            navigateur.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            navigateur.GoHome();
        }

        private void url_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newUrl = "";

                if (url.Text.Substring(0, 4).ToLower() != "http")
                {
                    newUrl = url.Text.Insert(0, "http://");
                }
                else
                {
                    newUrl = url.Text;
                }

                Uri mUrl = new Uri(newUrl);
                navigateur.Url = mUrl;

                for (i = 0; i < comboBox1.Items.Count; i++) {
                    if (comboBox1.Items[i].ToString().Contains(navigateur.Url.OriginalString)) {
                        pictureBox1.ImageLocation = favorisImage;
                        isFavoris(true);
                    }
                }
            }
        }

        private void isFavoris(bool b) {
            if(b)
            {
                pictureBox1.ImageLocation = favorisImage;
                resize();
            }
            else {
                pictureBox1.Image = pictureBox1.InitialImage;
                resize();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(navigateur.Url.OriginalString);
            isFavoris(true);
        }
    }
}
