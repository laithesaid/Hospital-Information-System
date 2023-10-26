using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hcgp
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            this.CenterToScreen(); //centers form in middle of screen
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();// hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form4 f4 = new Form4(); //creating instance of class Form4
            f4.ShowDialog();// shows form 4 with show dialogue function
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();// hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form2 f2 = new Form2(); //creating instance of class Form4
            f2.ShowDialog();// shows form 4 with show dialogue function
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form1 parent = new Form1(); //creating instance of class Form1
            parent.ShowDialog();// shows form 1 which is parent form with show dialogue function
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form11 parent = new Form11(); //creating instance of class Form1
            parent.ShowDialog();// shows form 1 which is parent form with show dialogue function
        }
    }
}
