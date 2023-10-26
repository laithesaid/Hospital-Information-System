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
    public partial class Form11 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456789ls");
        public Form11()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
            {
                dataGridView2.Visible = true;
                this.employees_financialTableAdapter.Fill(this.clinichospitaldbDataSet2.employees_financial);


            }
            else
            {
                dataGridView2.Visible = false;
            }
         
            

        }


        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinichospitaldbDataSet2.employees_financial' table. You can move, or remove it, as needed.
            this.employees_financialTableAdapter.Fill(this.clinichospitaldbDataSet2.employees_financial);
            // TODO: This line of code loads data into the 'clinichospitaldbDataSet1.patientpayments' table. You can move, or remove it, as needed.
            this.patientpaymentsTableAdapter.Fill(this.clinichospitaldbDataSet1.patientpayments);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinichospitaldbDataSet1.patientpayments' table. You can move, or remove it, as needed.

            if (radioButton1.Checked==true)
            {
                this.patientpaymentsTableAdapter.Fill(this.clinichospitaldbDataSet1.patientpayments);
                dataGridView1.Visible = true;
             



            }
            else
            {
                dataGridView1.Visible = false;
            }
            
         

        }

        public void searchData(string valueToFind)
        {
           
                string searchQuery = "SELECT * FROM clinichospitaldb.patientpayments WHERE CONCAT(patientssn) LIKE '%" + valueToFind + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            
        }
        public void searchData2(string valueToFind)
        {
                string searchQuery2 = "SELECT * FROM clinichospitaldb.employees_financial WHERE CONCAT(id) LIKE '%" + valueToFind + "%'";
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(searchQuery2, connection);
                DataTable table2 = new DataTable();
                adapter2.Fill(table2);
                dataGridView2.DataSource = table2;
        }


        private void textBox8_Search_Load(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                searchData("");
            }
            else
            {
                 searchData2("");
            }

        
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                searchData(textBox1.Text);
            }
            else
            {
                searchData2(textBox1.Text);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide(); // hide function hides this form. always use hide instead of close function when intending on going back to this form.
            Form9 parent = new Form9(); //creating instance of class Form1
            parent.ShowDialog();// shows form 1 which is parent form with show dialogue function
        }
    }
}
