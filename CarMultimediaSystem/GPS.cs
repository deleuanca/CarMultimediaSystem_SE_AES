using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarMultimediaSystem
{
    public partial class GPS : Form
    {
        public GPS()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            form.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Radio form2 = new Radio();
            form2.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GPS form3 = new GPS();
            form3.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Music form4 = new Music();
            form4.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Weather form5 = new Weather();
            form5.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string street = street_txt.Text;
            string city = city_txt.Text;    
            string state = state_txt.Text;
            string zip = zip_txt.Text;

            
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("https://www.google.com/maps?q=");

                if(street != string.Empty)
                {
                    stringBuilder.Append(street + "," + "+");
                }
                if (city != string.Empty)
                {
                    stringBuilder.Append(city + "," + "+");
                }
                if (state != string.Empty)
                {
                    stringBuilder.Append(state + "," + "+");
                }
                if (zip != string.Empty)
                {
                    stringBuilder.Append(zip + "," + "+");
                }

                webBrowser1.Navigate(stringBuilder.ToString());
            
            
        }
    }
}

