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
    public partial class Login : Form
    {
        public static string idlogin;
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            newuser nu = new newuser();
            nu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string result = "Please Enter ";
            if (textBox1.Text == string.Empty)
            {
                result += "User Name,";
                label10.Visible = true;
            }
            if (textBox2.Text == string.Empty)
            {
                result += "Password,";
                label3.Visible = true;
            }
            if (result != "Please Enter ")
            {
                result = result.Remove(result.LastIndexOf(","));
                MessageBox.Show(result + '.');
            }
            else
            {
               

                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456789ls");
                MySqlDataReader mdr;
                var username = "";
                var password = "";
               
                string query = "SELECT username, password, idlogin FROM clinichospitaldb.login where username='" + textBox1.Text + "'and password=md5('" + textBox2.Text + "')";
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                mdr = command.ExecuteReader();
                // reads the data and fills the combo box and listbox

                if (mdr.HasRows)
                {
                    while (mdr.Read())
                    {

                        username = mdr["username"].ToString();
                        password = mdr["password"].ToString();
                        idlogin = mdr["idlogin"].ToString();

                    }

                    this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
                    Form1 f1 = new Form1(); //creating instance of class Form1
                    f1.ShowDialog();// shows form 1 with show dialogue function

                }
                else
                {
                    MessageBox.Show("Incorrect login info.");
                }
            }
            



        }
    }
}

