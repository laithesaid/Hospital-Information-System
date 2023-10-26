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
   
    public partial class Form6 : Form
    {
        public static string id; 
        
        public Form6()
        {
            InitializeComponent();
            this.CenterToScreen(); //centers form in middle of screen
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form1 parent = new Form1(); //creating instance of class Form1
            parent.ShowDialog();// shows form 1 with show dialogue function
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form7 f7 = new Form7();//creating instance of class Form7
            f7.ShowDialog();//shows form 7 with show dialogue function

        }

        private void button1_Click(object sender, EventArgs e)
        {

                id = textBox1.Text;
                this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
                Form12 f12 = new Form12();//creating instance of class Form7
                f12.ShowDialog();//shows form 7 with show dialogue function
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
    }
}
