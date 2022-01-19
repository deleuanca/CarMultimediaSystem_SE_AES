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
    public partial class Music : Form
    {
        public Music()
        {
            InitializeComponent();
        }
        //create global variables of string type array to save title or name of the Track and path pf the track
        String[] paths, files;
        int i;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home form1 = new Home();
            form1.ShowDialog();
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

        private void buttonSelectSong_Click(object sender, EventArgs e)
        {
            //code to select song
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //code to select multiple files
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog.SafeFileNames; // save the name of the track in the files array
                paths = openFileDialog.FileNames; // save the path of the track in the path array

                //Display the music title in the listbox
                for (i = 0; i<files.Length;i++)
                {
                    listBoxSongs.Items.Add(files[i]); //display songs in list box
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code to play music
            axWindowsMediaPlayer1.URL = paths[listBoxSongs.SelectedIndex];
        }

      

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Weather form5 = new Weather();
            form5.ShowDialog();
            this.Close();
        }
    }
}

