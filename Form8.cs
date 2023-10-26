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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            this.CenterToScreen(); //centers form in middle of screen
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456789ls");
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }



        private void Form8_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456789ls");
            MySqlDataReader mdr;
            var first_name = "";
            var last_name = "";
            var jobtit = "";
            string query = "SELECT jobtitle, fname, lname FROM clinichospitaldb.employees where employees_id='" + Login.idlogin + "'";
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            mdr = command.ExecuteReader();
            // reads the data and fills the combo box and listbox

            if (mdr.HasRows)
            {
                while (mdr.Read())
                {
                    jobtit = mdr["jobtitle"].ToString();
                    first_name = mdr["fname"].ToString();
                    last_name = mdr["lname"].ToString();
                    richTextBox4.AppendText(jobtit+ " " + first_name.ToUpper() + " " + last_name.ToUpper()+" ,Employee ID: "+Login.idlogin+"\r\n");

                }
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form5 parent = new Form5(); //creating instance of class Form1
            parent.ShowDialog();// shows form 1 which is parent form with show dialogue function
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try { 
            //This is my connection string i have assigned the database file address path  
            string connect = "datasource=localhost;port=3306;username=root; password=123456789ls";
            //This is my update query in which i am taking input from the user through windows forms and update the record.  
            string q = "update clinichospitaldb.generalmedicalinfopatient set medications='" + this.textBox9.Text  + "',blood_works='" + this.textBox10.Text + "',allergies='" + this.textBox11.Text + "',majorhz='" + this.richTextBox3.Text + "',medicalhistory='" + this.richTextBox2.Text + "', chronicdis = '" + this.textBox12.Text + "' where ssn_patients='" + this.textBox5.Text + "';";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            MySqlConnection MyCon = new MySqlConnection(connect);
            MySqlCommand MyComm = new MySqlCommand(q, MyCon);
            MySqlDataReader MyRead;
            MyCon.Open();
            MyRead = MyComm.ExecuteReader();
            while (MyRead.Read())
            {
            }
                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string q1 = "update clinichospitaldb.patients set fname='" + this.textBox1.Text + "',fathersname= '" + this.textBox2.Text + "',gfname ='" + this.textBox3.Text +
                 "',lname='" + this.textBox4.Text + "',ssn='" + this.textBox5.Text + "',phonenum='" +
                 this.textBox6.Text + "',age='" + this.textBox7.Text + "',sex='" + this.comboBox1.SelectedItem + "',address='" + this.richTextBox1.Text +
                "' where ssn='" + this.textBox5.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyCon1 = new MySqlConnection(connect);
                MySqlCommand MyComm1 = new MySqlCommand(q1, MyCon1);
                MySqlDataReader MyRead1;
                MyCon1.Open();
                MyRead1 = MyComm1.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyRead1.Read())
                {
                }
                MyCon1.Close();
            } //Connection closed here  
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }  
    
        private void button6_Click(object sender, EventArgs e)
        {
           
            string result = "Please Enter ";
            if (textBox1.Text == string.Empty)
            {
                result += "First Name,";
                label21.Visible = true;
            }
            if (textBox2.Text == string.Empty)
            {
                result += "Father's Name,";
                label22.Visible = true;
            }
            if (textBox3.Text == string.Empty)
            {
                result += "Grandfather's Name,";
                label23.Visible = true;
            }
            if (textBox4.Text == string.Empty)
            {
                result += "Last Name,";
                label24.Visible = true;
            }
            if (textBox5.Text == string.Empty)
            {
                result += "SSN,";
                label25.Visible = true;
            }
            if (textBox6.Text == string.Empty)
            {
                result += "Phone Number,";
                label26.Visible = true;
            }
            if (textBox7.Text == string.Empty)
            {
                result += "Age,";
                label27.Visible = true;
            }
            if (comboBox1.SelectedItem==null)
            {
                result += "Sex,";
                label28.Visible = true;
            }
            if (richTextBox1.Text == string.Empty)
            {
                result += "Address,";
                label29.Visible = true;
            }
            if (textBox9.Text == string.Empty)
            {
                result += "Medications,";
                label30.Visible = true;
            }
            if (textBox10.Text == string.Empty)
            {
                result += "Blood Works,";
                label31.Visible = true;
            }
            if (textBox11.Text == string.Empty)
            {
                result += "Allergies,";
                label32.Visible = true;
            }
            if (textBox12.Text == string.Empty)
            {
                result += "Chronic Diseases,";
                label33.Visible = true;
            }
            if (richTextBox3.Text == string.Empty)
            {
                result += "Major Hospitlization,";
                label34.Visible = true;
            }
            if (richTextBox2.Text == string.Empty)
            {
                result += "Medical History Notes,";
                label35.Visible = true;
            }
     
            if (result != "Please Enter ")
            {
                result = result.Remove(result.LastIndexOf(","));
                MessageBox.Show(result + ". If no data please specify as none.");
            }
            else

            {
                try
                {
                    string MyConnection1 = "datasource=localhost;port=3306;username=root; password=123456789ls";
                    string Query = "insert into clinichospitaldb.patients(fname, fathersname, gfname, lname, ssn, phonenum, age, sex, address)values" +
                 "('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text +
                 "','" + this.textBox4.Text + "'," + this.textBox5.Text + "," +
                 this.textBox6.Text + "," + this.textBox7.Text + ",'" + this.comboBox1.SelectedItem + "','" + this.richTextBox1.Text + "');";

                    
                    MySqlConnection MyConn1 = new MySqlConnection(MyConnection1);
                    MySqlCommand MyCommand1 = new MySqlCommand(Query, MyConn1);
                    MySqlDataReader MyReader1;
                    MyConn1.Open();
                    MyReader1 = MyCommand1.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    while (MyReader1.Read())
                    {
                        Console.WriteLine(String.Format("{0}", MyReader1[0]));
                    }
                    MyConn1.Close();
                    string MyConnection2 = "datasource=localhost;port=3306;username=root; password=123456789ls";

                    string q2 = "insert into clinichospitaldb.generalmedicalinfopatient (ssn_patients, medications,blood_works,chronicdis,allergies,majorhz,medicalhistory)values" +
                        "('" + this.textBox5.Text + "','" + this.textBox9.Text + "','" + this.textBox10.Text + "','" + this.textBox11.Text +
                        "','" + this.textBox12.Text + "','" + this.richTextBox3.Text + "','" + this.richTextBox2.Text + "');";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(q2, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Medical and General Data Saved.");
                    while (MyReader2.Read())
                    {
                        Console.WriteLine(String.Format("{0}", MyReader2[0]));
                    }

                    MyConn2.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("SSN already exixts!");

                }

             
            }
        }
  

  

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                              tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string result = "Please Enter ";
                if (textBox13.Text == string.Empty)
                {
                    result += "Patient's SSN or ";
                    label36.Visible = true;
                }
                if (richTextBox4.Text == string.Empty)
                {
                    result += "Session Notes or";
                    
                }
                if (result != "Please Enter ")
                {
                    result = result.Remove(result.LastIndexOf(" or"));
                    MessageBox.Show(result + '.');
                }
                else
                {
                    string MyConnection1 = "datasource=localhost;port=3306;username=root; password=123456789ls";
                    string dt = dateTimePicker1.Value.ToString("MM/dd/yyyy hh:mm:ss");
                    string Queryy = "insert into clinichospitaldb.session_notes(ssn, sessionnotes,dateandtime)values" +
                        "('" + textBox13.Text + "','" + this.richTextBox4.Text + "','" + dt + "');";

                    //Console.WriteLine(Query);
                    MySqlConnection MyConn1 = new MySqlConnection(MyConnection1);
                    MySqlCommand MyCommand1 = new MySqlCommand(Queryy, MyConn1);
                    MySqlDataReader MyReader1;
                    MyConn1.Open();
                    MyReader1 = MyCommand1.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Session notes saved!");
                    while (MyReader1.Read())
                    {
                        Console.WriteLine(String.Format("{0}", MyReader1[0]));
                    }
                    MyConn1.Close();
                    textBox13.Clear();
                    richTextBox4.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Patient not found.");
            }
         
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox7.Text = textBox7.Text.Remove(textBox7.Text.Length - 1);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form5 f5 = new Form5(); //creating instance of class Form1
            f5.ShowDialog();// shows form 1 with show dialogue function
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form5 parent = new Form5(); //creating instance of class Form1
            parent.ShowDialog();// shows form 1 which is parent form with show dialogue function
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox13.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox13.Text = textBox13.Text.Remove(textBox13.Text.Length - 1);
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("ssn empty!!");
            }
            else
            {
                string ss = textBox5.Text;
                MySqlDataReader mdrr;
                string q3 = "Select fname,fathersname,gfname,lname,ssn,phonenum,age,sex,address from  clinichospitaldb.patients where ssn = " + ss;/*textBox5.Text + "';";*/
                MySqlCommand commandd = new MySqlCommand(q3, connection);
                connection.Open();
                mdrr = commandd.ExecuteReader();
                // reads the data and fills the combo box and listbox

                while (mdrr.Read())
                {
                    var fname = mdrr.GetString(0);
                    var fathersname = mdrr.GetString(1);
                    var gfname = mdrr.GetString(2);
                    var lname = mdrr.GetString(3);
                    var ssn = mdrr.GetString(4);
                    var phonenum = mdrr.GetString(5);
                    var age = mdrr.GetString(6);
                    var sex = mdrr.GetString(7);
                    var address = mdrr.GetString(8);

                    textBox1.Text = fname;
                    textBox2.Text = fathersname;
                    textBox3.Text = gfname;
                    textBox4.Text = lname;
                    textBox6.Text = phonenum;
                    textBox7.Text = age;
                    comboBox1.Text = sex;
                    richTextBox1.Text = address;



                }

                connection.Close();

                MySqlDataReader mdrrr;
                string qq = "Select ssn_patients,medications,blood_works,allergies,majorhz,medicalhistory,chronicdis from  clinichospitaldb.generalmedicalinfopatient where ssn_patients = " + ss; /*textBox5.Text + "';";*/
                MySqlCommand command2d = new MySqlCommand(qq, connection);
                connection.Open();
                mdrrr = command2d.ExecuteReader();
                // reads the data and fills the combo box and listbox

                while (mdrrr.Read())
                {
                    var ssn_patients = mdrrr.GetString(0);
                    var medications = mdrrr.GetString(1);
                    var blood_works = mdrrr.GetString(2);
                    var allergies = mdrrr.GetString(3);
                    var majorhz = mdrrr.GetString(4);
                    var medicalhistory = mdrrr.GetString(5);
                    var chronicdis = mdrrr.GetString(6);

                    textBox9.Text = medications;
                    textBox10.Text = blood_works;
                    textBox11.Text = allergies;
                    richTextBox3.Text = majorhz;
                    richTextBox2.Text = medicalhistory;
                    textBox12.Text = chronicdis;
                }
                connection.Close();
                button4.Visible = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("ssn empty!!");
            }
            else
            {
            string ss = textBox5.Text;
            MySqlDataReader mdrr;
            string q3 = "Select fname,fathersname,gfname,lname,ssn,phonenum,age,sex,address from  clinichospitaldb.patients where ssn = " + ss;/*textBox5.Text + "';";*/
            MySqlCommand commandd = new MySqlCommand(q3, connection);
            connection.Open();
            mdrr = commandd.ExecuteReader();
            // reads the data and fills the combo box and listbox

            while (mdrr.Read())
            {
                var fname = mdrr.GetString(0);
                var fathersname = mdrr.GetString(1);
                var gfname = mdrr.GetString(2);
                var lname = mdrr.GetString(3);
                var ssn = mdrr.GetString(4);
                var phonenum = mdrr.GetString(5);
                var age = mdrr.GetString(6);
                var sex = mdrr.GetString(7);
                var address = mdrr.GetString(8);

                textBox1.Text = fname;
                textBox2.Text = fathersname;
                textBox3.Text = gfname;
                textBox4.Text = lname;
                textBox6.Text = phonenum;
                textBox7.Text = age;
                comboBox1.SelectedItem = sex;
                richTextBox1.Text = address;



            }

            connection.Close();

            MySqlDataReader mdrrr;
            string qq = "Select ssn_patients,medications,blood_works,allergies,majorhz,medicalhistory,chronicdis from  clinichospitaldb.generalmedicalinfopatient where ssn_patients = " + ss; /*textBox5.Text + "';";*/
            MySqlCommand command2d = new MySqlCommand(qq, connection);
            connection.Open();
            mdrrr = command2d.ExecuteReader();
            // reads the data and fills the combo box and listbox

            while (mdrrr.Read())
            {
                var ssn_patients = mdrrr.GetString(0);
                var medications = mdrrr.GetString(1);
                var blood_works = mdrrr.GetString(2);
                var allergies = mdrrr.GetString(3);
                var majorhz = mdrrr.GetString(4);
                var medicalhistory = mdrrr.GetString(5);
                var chronicdis = mdrrr.GetString(6);

                textBox9.Text = medications;
                textBox10.Text = blood_works;
                textBox11.Text = allergies;
                richTextBox3.Text = majorhz;
                richTextBox2.Text = medicalhistory;
                textBox12.Text = chronicdis;
            }
            connection.Close();
            button4.Visible = true;
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
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            comboBox1.SelectedIndex = -1;
            button4.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
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
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            comboBox1.SelectedIndex =-1;
            button4.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form5 parent = new Form5(); //creating instance of class Form1
            parent.ShowDialog();// shows form 1 which is parent form with show dialogue function
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox13.Clear();
            richTextBox4.Clear();
        }
    }
}
    

