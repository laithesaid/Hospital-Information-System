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
    public partial class newuser : Form
    {
        public newuser()
        {
            InitializeComponent();
            this.CenterToScreen(); //centers form in middle of screen
        }

        private void newuser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

       
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("New user name empty.");
                label7.Visible = true;
            }
            else if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Password empty.");
                label8.Visible = true;
            }
            else if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Employeed ID empty.");
                label10.Visible = true;
            }
           
            else
            {
                try
                {

                    string Connection1 = "datasource=localhost;port=3306;username=root; password=123456789ls";

                    string Query = "insert into clinichospitaldb.login(username,password,idlogin)values" +
                        "('" + this.textBox3.Text + "'," + "md5('"+this.textBox4.Text  + "'),'" + this.textBox5.Text + "');";

                    MySqlConnection Conn1 = new MySqlConnection(Connection1);
                    MySqlCommand Command1 = new MySqlCommand(Query, Conn1);
                    MySqlDataReader Reader1;
                    Conn1.Open();
                    Reader1 = Command1.ExecuteReader();
                    Conn1.Close();
                    MessageBox.Show("Data Saved!");


                    this.Close();
                    Login l1 = new Login(); //creating instance of class Form1
                    l1.ShowDialog();// shows form 1 with show dialogue function
                    this.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("User already exists.");
                }
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Admin user name empty.");
                label9.Visible = true;
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Admin password empty.");
                label6.Visible = true;
            }

            else
            {
                string query = "SELECT username, password FROM clinichospitaldb.login where username=" +
         "'" + textBox1.Text + "'and password = md5('" + textBox2.Text + "')";
                MySqlConnection connection2 = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456789ls");
                MySqlDataReader mdr;
                MySqlCommand command = new MySqlCommand(query, connection2);
                connection2.Open();
                var username = "";
                var password = "";


                mdr = command.ExecuteReader();
                // reads the data and fills the combo box and listbox

                if (mdr.HasRows)
                {
                    while (mdr.Read())
                    {
                        username = mdr["username"].ToString();
                        password = mdr["password"].ToString();

                    }

                    MessageBox.Show("Validated!!!");
                    connection2.Close();
                    button1.Visible = true;
                    label9.Visible = false;
                    label6.Visible = false;
                    linkLabel2.Visible = true;
                }
                else
                {
                    MessageBox.Show("Invalid admin username or password.");
                }
            }
            
           
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l1 = new Login(); //creating instance of class Form1
            l1.ShowDialog();// shows form 1 with show dialogue function
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form13 f13 = new Form13(); //creating instance of class Form1
            f13.ShowDialog();// shows form 1 with show dialogue function
        }
    }
    }

