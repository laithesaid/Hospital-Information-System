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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen(); //centers form in middle of screen
        }
       // Form2 f2;
        private void button1_Click(object sender, EventArgs e)
        {   
            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form5 f5 = new Form5();//creating instance of class Form2
            f5.ShowDialog();//shows form 2 with show dialogue function

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();// hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form6 f6 = new Form6(); //creating instance of class Form3
            f6.ShowDialog();// shows form 3 with show dialogue function
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();// hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form9 f9 = new Form9(); //creating instance of class Form4
            f9.ShowDialog();// shows form 4 with show dialogue function
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456789ls");
            MySqlDataReader mdr;
            var first_name = "";
            var last_name = "";

            string query = "SELECT fname, lname FROM clinichospitaldb.employees where employees_id='" + Login.idlogin + "'";
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            mdr = command.ExecuteReader();
            // reads the data and fills the combo box and listbox

            if (mdr.HasRows)
            {
                while (mdr.Read())
                {

                    first_name = mdr["fname"].ToString();
                    last_name = mdr["lname"].ToString();
                    label1.Text = "WELCOME "+ first_name.ToUpper() + " " + last_name.ToUpper()+"!";

                }
            }
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();// hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form3 f3 = new Form3(); //creating instance of class Form4
            f3.ShowDialog();// shows form 4 with show dialogue function
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }


