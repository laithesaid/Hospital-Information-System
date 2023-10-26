using MySql.Data.MySqlClient;
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
    public partial class Form5 : Form
    {
 
        public static string ssn;

        public Form5()
        {
            InitializeComponent();
            this.CenterToScreen(); //centers form in middle of screen
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form1 parent = new Form1(); //creating instance of class Form1
            parent.ShowDialog();// shows form 1 with show dialogue function
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is General info page, click on medical info button to add medical info");
            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form8 f8 = new Form8();//creating instance of class Form7
            f8.ShowDialog();//shows form 7 with show dialogue function
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ssn = textBox1.Text;

            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form10 f10 = new Form10();//creating instance of class Form7
            f10.ShowDialog();//shows form 7 with show dialogue function

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
