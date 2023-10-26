using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace hcgp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.CenterToScreen(); //centers form in middle of screen
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456789ls");
        private void df_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinichospitaldbDataSet.appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.clinichospitaldbDataSet.appointments);
            // TODO: This line of code loads data into the 'clinichospitaldbDataSet.appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.clinichospitaldbDataSet.appointments);
            // TODO: This line of code loads data into the 'clinichospitaldbDataSet.appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.clinichospitaldbDataSet.appointments);
            try
            {
                string selectQuery4 = "SELECT * FROM clinichospitaldb.employees where jobtitle ='Doctor';";
                connection.Open();
                MySqlCommand command4 = new MySqlCommand(selectQuery4, connection);
                MySqlDataReader reader4 = command4.ExecuteReader();
                while (reader4.Read())
                {
                   
                    comboBox1.Items.Add("Dr."+reader4.GetString("Fname"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form1 parent = new Form1(); //creating instance of class Form1
            parent.ShowDialog();// shows form 1 with show dialogue function
        }

        private void button2_Click(object sender, EventArgs e)
        {

            


        }

  

       

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }
        private void textBox8_Search_Load(object sender, EventArgs e)
        {
            searchData("");
        }

        public void searchData(string valueToFind)
        {

            string searchQuery = "SELECT * FROM clinichospitaldb.appointments WHERE CONCAT(first_name,fathers_name,grandfathers_name,last_name) LIKE '%" + valueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }



        private void button6_Click(object sender, EventArgs e)
        {

            DataRow row = (dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row;

            using (MySqlConnection sqlConn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456789ls"))
            {
                sqlConn.Open();

                using (MySqlCommand sqlCommand = new MySqlCommand("DELETE FROM clinichospitaldb.appointments WHERE columnid = " + row ["columnid"], sqlConn))
                {
                    sqlCommand.ExecuteNonQuery();
                }
            }
            dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            MessageBox.Show("Appointment deleted.");
        }
        
        private void textBox8_TextChanged(object sender, EventArgs e)
        { 
            
            searchData(textBox8.Text);
           
            
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string result = "Please Enter ";
            if (textBox1.Text == string.Empty)
            {
                result += "First Name,";
                label10.Visible = true;
            }
            if (textBox2.Text == string.Empty)
            {
                result += "Father's Name,";
                label11.Visible = true;
            }
            if (textBox3.Text == string.Empty)
            {
                result += "Grandfather's Name,";
                label12.Visible = true;
            }
            if (textBox4.Text == string.Empty)
            {
                result += "Last Name,";
                label13.Visible = true;
            }
            if (textBox5.Text == string.Empty)
            {
                result += "Date,";
                label14.Visible = true;
            }
            if (textBox6.Text == string.Empty)
            {
                result += "Time,";
                label15.Visible = true;
            }
            //if (textBox9.Text == string.Empty)
            //{
            //    result += "SSN,";
            //    label18.Visible = true;
            //}
            if (comboBox1.SelectedItem == null)
            {
                result += "Doctor's Name,";
                label16.Visible = true;
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
                    string MyConnection2 = "datasource=localhost;port=3306;username=root; password=123456789ls";
                    if (radioButton1.Checked)
                    {
                        
                        string Q = "insert into clinichospitaldb.patients(fname,fathersname,gfname,lname,ssn)values" +
                        "('" + this.textBox1.Text + " " + "','" + this.textBox2.Text + " " + "','" +
                        this.textBox3.Text + " " + "','" + this.textBox4.Text + " " + "','" + this.textBox9.Text + "');";
                        MySqlConnection MyConn3 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand3 = new MySqlCommand(Q, MyConn3);
                        MySqlDataReader MyReader3;
                        MyConn3.Open();
                        MyReader3 = MyCommand3.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                        MessageBox.Show("New patient added!");
                        while (MyReader3.Read())
                        {
                         Console.WriteLine(String.Format("{0}", MyReader3[0]));
                         }
                         MyConn3.Close();
                        string Query = "insert into clinichospitaldb.appointments(first_name,fathers_name,grandfathers_name,last_name,date,time,doctorsname)values" +
                       "('" + this.textBox1.Text + " " + "','" + this.textBox2.Text + " " + "','" +
                       this.textBox3.Text + " " + "','" + this.textBox4.Text + " " + "','" + this.textBox5.Text +
                       "','" + this.textBox6.Text + "','" + this.comboBox1.SelectedItem + "');";
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                        MessageBox.Show("Appointment booked!");
                        while (MyReader2.Read())
                        {
                            Console.WriteLine(String.Format("{0}", MyReader2[0]));
                        }
                        MyConn2.Close();
                    }
                    else
                    {
                        string q45 = "insert into clinichospitaldb.appointments(first_name,fathers_name,grandfathers_name,last_name,date,time,doctorsname)values" +
                        "('" + this.textBox1.Text + " " + "','" + this.textBox2.Text + " " + "','" +
                        this.textBox3.Text + " " + "','" + this.textBox4.Text + " " + "','" + this.textBox5.Text +
                        "','" + this.textBox6.Text + "','" + this.comboBox1.SelectedItem + "');";
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand2 = new MySqlCommand(q45, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                        MessageBox.Show("Appointment booked!");
                        while (MyReader2.Read())
                        {
                            Console.WriteLine(String.Format("{0}", MyReader2[0]));
                        }
                        MyConn2.Close();
                    }
                    
    
                }
                catch (Exception)
                {
                    MessageBox.Show("Patient already exists!");
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox5.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.appointmentsTableAdapter.Fill(this.clinichospitaldbDataSet.appointments);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();// hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form1 f1 = new Form1(); //creating instance of class Form4
            f1.ShowDialog();// shows form 4 with show dialogue function
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
            comboBox1.SelectedIndex = -1;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader mdr;
                string query = "Select fname,fathersname,gfname,lname from  clinichospitaldb.patients where ssn = " + textBox7.Text;
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

                    textBox1.AppendText(fname);
                    textBox2.AppendText(fathersname);
                    textBox3.AppendText(gfname);
                    textBox4.AppendText(lname);
                }
                connection.Close();
                textBox7.Visible = false;
                label9.Visible = false;
                button5.Visible = false;
             

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                comboBox1.Visible = true;
                dateTimePicker1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
              
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter SSN.");
                connection.Close();
            }
           
        }

       

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Visible = false;
            label9.Visible = false;
            button5.Visible = false;
           

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            comboBox1.Visible = true;
            dateTimePicker1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            textBox9.Visible = true;
            label17.Visible = true;
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
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Visible = true;
            label9.Visible = true;
            button5.Visible = true;

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            comboBox1.Visible = false;
            dateTimePicker1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox9.Visible = false;
            label17.Visible = false;
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
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
        }
    }

}








