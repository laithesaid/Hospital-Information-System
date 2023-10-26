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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            this.CenterToScreen(); //centers form in middle of screen
        }
        string MyConnection = "datasource=localhost;port=3306;username=root; password=123456789ls";
        private void button1_Click(object sender, EventArgs e)
        {
        
            string result = "Please Enter ";
            if (textBox7.Text == string.Empty)
            {
                result += "Job Title,";
                label6.Visible = true;
            }
            if (textBox1.Text == string.Empty)
            {
                result += "ID,";
                label7.Visible = true;
            }
            if (textBox2.Text == string.Empty)
            {
                result += "Grandfather's Name,";
                label8.Visible = true;
            }
            if (textBox6.Text == string.Empty)
            {
                result += "Last Name,";
                label9.Visible = true;
            }
            if (richTextBox1.Text == string.Empty)
            {
                result += "Date,";
                label12.Visible = true;
            }
            if (richTextBox2.Text == string.Empty)
            {
                result += "Time,";
                label13.Visible = true;
            }
            if (result != "Please Enter ")
            {
                result = result.Remove(result.LastIndexOf(","));
                MessageBox.Show(result + '.'+" If nothing to be filled in degrees or expriences please enter none.");
            }
            else
            {
                try
                {
                    
                    string Query = "insert into clinichospitaldb.employees (employees_id,fname,lname,degrees,experience,jobtitle)values" +
                        "('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox6.Text + "','" + this.richTextBox1.Text + "','" + this.richTextBox2.Text + "','" + textBox7.Text + "');";
                    MySqlConnection MyConn = new MySqlConnection(MyConnection);
                    MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = MyCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Data Saved");
                    while (MyReader.Read())
                    {
                        Console.WriteLine(String.Format("{0}", MyReader[0]));
                    }
                    MyConn.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("ID already exists!");
                }
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label12.Visible = false;
                label13.Visible = false;

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form6 parent = new Form6(); //creating instance of class Form1
            parent.ShowDialog();// shows form 1 which is parent form with show dialogue function
        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
        }

    }
}
