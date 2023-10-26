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


    public partial class Form10 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456789ls");

     
      

        public Form10()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }


        private void Form10_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader mdr;
                string query = "Select fname,fathersname,gfname,lname,ssn,phonenum, age,sex,address from  clinichospitaldb.patients where ssn = " + Form5.ssn;
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                mdr = command.ExecuteReader();
                // reads the data and fills the combo box and listbox

                while (mdr.Read())
                {
                    var fname = mdr.GetString(0);
                    var fathersname = mdr.GetString(1);
                    var gfname = mdr.GetString(2);
                    var lname = mdr.GetString(3);
                    var ssn = mdr.GetString(4);
                    var phonenum = mdr.GetString(5);
                    var age = mdr.GetString(6);
                    var sex = mdr.GetString(7);
                    var address = mdr.GetString(8);
                    richTextBox1.AppendText(fname);
                    richTextBox2.AppendText(fathersname);
                    richTextBox3.AppendText(gfname);
                    richTextBox4.AppendText(lname);
                    richTextBox5.AppendText(ssn);
                    richTextBox6.AppendText(phonenum);
                    richTextBox7.AppendText(age);
                    richTextBox8.AppendText(sex);
                    richTextBox9.AppendText(address);
                }
                connection.Close();

                string query2 = "Select medications,blood_works,allergies,majorhz,medicalhistory,chronicdis from  clinichospitaldb.generalmedicalinfopatient where ssn_patients = " + Form5.ssn;
                MySqlCommand command2 = new MySqlCommand(query2, connection);
                MySqlDataReader mdr2;
                connection.Open();
                mdr2 = command2.ExecuteReader();
                // reads the data and fills the combo box and listbox
                while (mdr2.Read())
                {
                    //var ssn_patients = mdr2.GetString(0);
                    var medications = mdr2.GetString(0);
                    var blood_works = mdr2.GetString(1);
                    var allergies = mdr2.GetString(2);
                    var majorhz = mdr2.GetString(3);
                    var medicalhistory = mdr2.GetString(4);
                    var chronicdis = mdr2.GetString(5);

                    textBox9.AppendText(medications);
                    textBox10.AppendText(blood_works);
                    textBox11.AppendText(allergies);
                    richTextBox11.AppendText(majorhz);
                    richTextBox10.AppendText(medicalhistory);
                    textBox12.AppendText(chronicdis);
                }
                connection.Close();
                string selectQuery4 = "SELECT * FROM clinichospitaldb.session_notes where ssn = " + Form5.ssn;
                connection.Open();
                MySqlCommand command4 = new MySqlCommand(selectQuery4, connection);
                MySqlDataReader reader4 = command4.ExecuteReader();
                while (reader4.Read())
                {

                    comboBox1.Items.Add(reader4.GetString("dateandtime"));
                }
                connection.Close();
            }


            catch (Exception)
            {
                MessageBox.Show("Patient not found.");
            }
        }

        

            //try
            //{
             
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //connection.Close();
            


        

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.Text;
            string query3 = "SELECT ssn, dateandtime,sessionnotes FROM clinichospitaldb.session_notes where dateandtime='" + selected + "';";
            MySqlCommand command3 = new MySqlCommand(query3, connection);
            MySqlDataReader mdr3;
            connection.Open();
            mdr3 = command3.ExecuteReader();
            while (mdr3.Read())
            {

                var dateandtime = mdr3.GetString(1);
                var sessionnotes = mdr3.GetString(2);
                richTextBox12.Text=sessionnotes;

            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form5 parent = new Form5(); //creating instance of class Form1
            parent.ShowDialog();// shows form 1 which is parent form with show dialogue function
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form5 parent = new Form5(); //creating instance of class Form1
            parent.ShowDialog();// shows form 1 which is parent form with show dialogue function
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form5 parent = new Form5(); //creating instance of class Form1
            parent.ShowDialog();// shows form 1 which is parent form with show dialogue function
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



