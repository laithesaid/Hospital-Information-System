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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456789ls");
        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinichospitaldbDataSet3.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.clinichospitaldbDataSet3.employees);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.clinichospitaldbDataSet3.employees);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow row = (dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row;

            using (MySqlConnection sqlConn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=123456789ls"))
            {
                sqlConn.Open();

                using (MySqlCommand sqlCommand = new MySqlCommand("DELETE FROM clinichospitaldb.employees  WHERE employees_id = " + row["employees_id"], sqlConn))
                {
                    sqlCommand.ExecuteNonQuery();
                }
            }
            dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            MessageBox.Show("User deleted.");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            newuser nw = new newuser(); //creating instance of class Form1
            nw.ShowDialog();// shows form 1 with show dialogue function
        }
       
        private void textBox1_Search_Load(object sender, EventArgs e)
        {
            searchData("");
        }

        public void searchData(string valueToFind)
        {

            string searchQuery = "SELECT * FROM clinichospitaldb.employees WHERE CONCAT(employees_id) LIKE '%" + valueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            searchData(textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
