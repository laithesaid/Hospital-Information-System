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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.CenterToScreen(); //centers form in middle of screen
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form9 parent = new Form9(); //creating instance of class Form1
            parent.ShowDialog();// shows form 1 with show dialogue function
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            string result = "Please Enter ";
            if (textBox1.Text == string.Empty)
            {
                result += "ID,";
                label10.Visible = true;
            }
            if (textBox2.Text == string.Empty)
            {
                result += "Days showed up,";
                label7.Visible = true;
            }
            if (textBox3.Text == string.Empty)
            {
                result += "Salary,";
                label8.Visible = true;
            }
            if (textBox4.Text == string.Empty)
            {
                result += "Leaves,";
                label9.Visible = true;
            }
            if (result != "Please Enter ")
            {
                result = result.Remove(result.LastIndexOf(","));
                MessageBox.Show(result + '.');
            }
            else
            {
                try
                {
                    int days = Convert.ToInt32(this.textBox2.Text);
                    float salary = Convert.ToInt32(this.textBox3.Text);
                    int lvs = Convert.ToInt32(this.textBox4.Text);
                    float tmp = ((days * 8) - lvs) * salary;
                    textBox5.Text = Convert.ToString(tmp);
                    string MyConnection1 = "datasource=localhost;port=3306;username=root; password=123456789ls";
                    string query = "insert into clinichospitaldb.employees_financial (id,daysshowedup,salarybythehour,leaves,totalamountmonth,date) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text +
                            "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd")/*date*/ + "');";
                    MySqlConnection MyConn1 = new MySqlConnection(MyConnection1);
                    MySqlCommand MyCommand1 = new MySqlCommand(query, MyConn1);
                    MySqlDataReader MyReader1;
                    MyConn1.Open();
                    MyReader1 = MyCommand1.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    while (MyReader1.Read())
                    {
                        Console.WriteLine(String.Format("{0}", MyReader1[0]));
                    }
                    MessageBox.Show("Payment data saved!!");
                    MyConn1.Close();
                }

                catch (Exception)
                {

                    MessageBox.Show("ID not Found.");
                }

            }
           
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
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
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
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '.')
            {
                if (this.Text.IndexOf(".") >= 0 || this.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
        else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            float value;
            if (!float.TryParse(textBox3.Text, out value)) { textBox3.Text = ""; }
        }
    }
}
