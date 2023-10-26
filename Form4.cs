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

    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
            this.CenterToScreen(); //centers form in middle of screen
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form9 parent = new Form9(); //creating instance of class Form1
            parent.ShowDialog();// shows form 1 which is parent form with show dialogue function
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = "Please Enter ";
            if (textBox1.Text == string.Empty)
            {
                result += "SSN,";
                label10.Visible = true;
            }
            if (textBox2.Text == string.Empty)
            {
                result += "Doctor's Pay,";
                label9.Visible = true;
            }
            if (textBox3.Text == string.Empty)
            {
                result += "Supplies Cost,";
                label11.Visible = true;
            }
            if (textBox4.Text == string.Empty)
            {
                result += "Medicine Price,";
                label12.Visible = true;
            }
            if (textBox5.Text == string.Empty)
            {
                result += "Other Fees,";
                label13.Visible = true;
            }
            if (textBox6.Text == string.Empty)
            {
                result += "Payed,";
                label14.Visible = true;
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
                    double owed = (Convert.ToDouble(this.textBox2.Text) + Convert.ToDouble(this.textBox3.Text) + Convert.ToDouble(this.textBox4.Text) + Convert.ToDouble(this.textBox5.Text)) - Convert.ToDouble(this.textBox6.Text);
                   
                    string MyConnection1 = "datasource=localhost;port=3306;username=root; password=123456789ls";
                    string query = "insert into clinichospitaldb.patientpayments (patientssn,doctorspayamount,suppliesused,medicinepaymountamount,Other,amountpayed,amountowed,date)values('" + this.textBox1.Text + "', '" + this.textBox2.Text + "', '" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" +
                    this.textBox6.Text + "','" + owed + "','" + DateTime.Now.ToString("yyyy-MM-dd")/*date*/ + "');";
                   
                    MySqlConnection MyConn1 = new MySqlConnection(MyConnection1);
                    MySqlCommand MyCommand1 = new MySqlCommand(query, MyConn1);
                    MySqlDataReader MyReader1;
                    MyConn1.Open();
                    MyReader1 = MyCommand1.ExecuteReader();     // Here our query will be executed and data saved into the database.  

                    while (MyReader1.Read())
                    {
                        Console.WriteLine(String.Format("{0}", MyReader1[0]));
                    }
                    textBox7.Text = Convert.ToString(owed);
                    MessageBox.Show("Payment data saved!!");
                    MyConn1.Close();


                    this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
                    Form9 parent = new Form9(); //creating instance of class Form1
                    parent.ShowDialog();// shows form 1 which is parent form with show dialogue function
                }
                catch (Exception)
                {
                    MessageBox.Show("SSN not Found.");
                }

            }
        }

        private void label7_Click(object sender, EventArgs e)
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
            label10.Visible = false;
            label9.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label11.Visible = false;
          
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
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

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            float value;
            if (!float.TryParse(textBox2.Text, out value)) { textBox2.Text = ""; }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
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

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            float value;
            if (!float.TryParse(textBox4.Text, out value)) { textBox4.Text = ""; }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
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

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            float value;
            if (!float.TryParse(textBox5.Text, out value)) { textBox5.Text = ""; }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
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

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            float value;
            if (!float.TryParse(textBox6.Text, out value)) { textBox6.Text = ""; }
        }
    }
}
