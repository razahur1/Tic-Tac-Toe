using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alien_Invaders
{
    
    public partial class Form3 : Form
    {
        public string Player_Name_1;
        public string Player_Name_2;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;
            Form1 form = new Form1(text1,text2);
            form.Show();
            textBox1.Text = "";
            textBox2.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
