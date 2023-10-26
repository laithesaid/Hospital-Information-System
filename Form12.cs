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
    public partial class Form12 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456789ls");
       
        public Form12()
        {
            InitializeComponent();
            this.CenterToScreen(); //centers form in middle of screen
        }

        private void Form12_Load(object sender, EventArgs e)
        {       connection.Open();

            //if (Form6.chosen == "doctors_nurses")
            //{
                MySqlDataReader mdr;
                string query = "Select employees_id,fname,lname,degrees, experience,jobtitle from clinichospitaldb.employees where employees_id = " + Form6.id;
                MySqlCommand command = new MySqlCommand(query, connection);
               
                mdr = command.ExecuteReader();
                // reads the data and fills the combo box and listbox

                while (mdr.Read())
                {
                    var fname = mdr.GetString(1);
                    var lname = mdr.GetString(2);
                    var degrees = mdr.GetString(3);
                    var experience = mdr.GetString(4);
                    var jobtitle = mdr.GetString(5);

                    textBox1.AppendText(jobtitle);
                    textBox2.AppendText(fname);
                    textBox3.AppendText(lname);
                    richTextBox1.AppendText(degrees);
                    richTextBox2.AppendText(experience);

                }
              
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form6 parent = new Form6(); //creating instance of class Form1
            parent.ShowDialog();// shows form 1 with show dialogue function
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
