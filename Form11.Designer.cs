
namespace hcgp
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.clinichospitaldbDataSet1 = new hcgp.clinichospitaldbDataSet1();
            this.patientpaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientpaymentsTableAdapter = new hcgp.clinichospitaldbDataSet1TableAdapters.patientpaymentsTableAdapter();
            this.doctorspayamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicinepaymountamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientssnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliesusedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountpayedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountowedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinichospitaldbDataSet2 = new hcgp.clinichospitaldbDataSet2();
            this.employeesfinancialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employees_financialTableAdapter = new hcgp.clinichospitaldbDataSet2TableAdapters.employees_financialTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysshowedupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarybythehourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leavesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountmonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinichospitaldbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientpaymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinichospitaldbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesfinancialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorspayamountDataGridViewTextBoxColumn,
            this.medicinepaymountamountDataGridViewTextBoxColumn,
            this.patientssnDataGridViewTextBoxColumn,
            this.suppliesusedDataGridViewTextBoxColumn,
            this.amountpayedDataGridViewTextBoxColumn,
            this.amountowedDataGridViewTextBoxColumn,
            this.otherDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientpaymentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1082, 306);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_3);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.daysshowedupDataGridViewTextBoxColumn,
            this.salarybythehourDataGridViewTextBoxColumn,
            this.leavesDataGridViewTextBoxColumn,
            this.totalamountmonthDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.employeesfinancialBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1082, 306);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1001, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1052, 24);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search by SSN or ID:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(177, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(144, 22);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Patient Payments";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(344, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(173, 22);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Employees Payments";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // clinichospitaldbDataSet1
            // 
            this.clinichospitaldbDataSet1.DataSetName = "clinichospitaldbDataSet1";
            this.clinichospitaldbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientpaymentsBindingSource
            // 
            this.patientpaymentsBindingSource.DataMember = "patientpayments";
            this.patientpaymentsBindingSource.DataSource = this.clinichospitaldbDataSet1;
            // 
            // patientpaymentsTableAdapter
            // 
            this.patientpaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // doctorspayamountDataGridViewTextBoxColumn
            // 
            this.doctorspayamountDataGridViewTextBoxColumn.DataPropertyName = "doctorspayamount";
            this.doctorspayamountDataGridViewTextBoxColumn.HeaderText = "doctorspayamount";
            this.doctorspayamountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorspayamountDataGridViewTextBoxColumn.Name = "doctorspayamountDataGridViewTextBoxColumn";
            this.doctorspayamountDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicinepaymountamountDataGridViewTextBoxColumn
            // 
            this.medicinepaymountamountDataGridViewTextBoxColumn.DataPropertyName = "medicinepaymountamount";
            this.medicinepaymountamountDataGridViewTextBoxColumn.HeaderText = "medicinepaymountamount";
            this.medicinepaymountamountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicinepaymountamountDataGridViewTextBoxColumn.Name = "medicinepaymountamountDataGridViewTextBoxColumn";
            this.medicinepaymountamountDataGridViewTextBoxColumn.Width = 125;
            // 
            // patientssnDataGridViewTextBoxColumn
            // 
            this.patientssnDataGridViewTextBoxColumn.DataPropertyName = "patientssn";
            this.patientssnDataGridViewTextBoxColumn.HeaderText = "patientssn";
            this.patientssnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patientssnDataGridViewTextBoxColumn.Name = "patientssnDataGridViewTextBoxColumn";
            this.patientssnDataGridViewTextBoxColumn.Width = 125;
            // 
            // suppliesusedDataGridViewTextBoxColumn
            // 
            this.suppliesusedDataGridViewTextBoxColumn.DataPropertyName = "suppliesused";
            this.suppliesusedDataGridViewTextBoxColumn.HeaderText = "suppliesused";
            this.suppliesusedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suppliesusedDataGridViewTextBoxColumn.Name = "suppliesusedDataGridViewTextBoxColumn";
            this.suppliesusedDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountpayedDataGridViewTextBoxColumn
            // 
            this.amountpayedDataGridViewTextBoxColumn.DataPropertyName = "amountpayed";
            this.amountpayedDataGridViewTextBoxColumn.HeaderText = "amountpayed";
            this.amountpayedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountpayedDataGridViewTextBoxColumn.Name = "amountpayedDataGridViewTextBoxColumn";
            this.amountpayedDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountowedDataGridViewTextBoxColumn
            // 
            this.amountowedDataGridViewTextBoxColumn.DataPropertyName = "amountowed";
            this.amountowedDataGridViewTextBoxColumn.HeaderText = "amountowed";
            this.amountowedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountowedDataGridViewTextBoxColumn.Name = "amountowedDataGridViewTextBoxColumn";
            this.amountowedDataGridViewTextBoxColumn.Width = 125;
            // 
            // otherDataGridViewTextBoxColumn
            // 
            this.otherDataGridViewTextBoxColumn.DataPropertyName = "Other";
            this.otherDataGridViewTextBoxColumn.HeaderText = "Other";
            this.otherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.otherDataGridViewTextBoxColumn.Name = "otherDataGridViewTextBoxColumn";
            this.otherDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // clinichospitaldbDataSet2
            // 
            this.clinichospitaldbDataSet2.DataSetName = "clinichospitaldbDataSet2";
            this.clinichospitaldbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesfinancialBindingSource
            // 
            this.employeesfinancialBindingSource.DataMember = "employees_financial";
            this.employeesfinancialBindingSource.DataSource = this.clinichospitaldbDataSet2;
            // 
            // employees_financialTableAdapter
            // 
            this.employees_financialTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // daysshowedupDataGridViewTextBoxColumn
            // 
            this.daysshowedupDataGridViewTextBoxColumn.DataPropertyName = "daysshowedup";
            this.daysshowedupDataGridViewTextBoxColumn.HeaderText = "daysshowedup";
            this.daysshowedupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.daysshowedupDataGridViewTextBoxColumn.Name = "daysshowedupDataGridViewTextBoxColumn";
            this.daysshowedupDataGridViewTextBoxColumn.Width = 125;
            // 
            // salarybythehourDataGridViewTextBoxColumn
            // 
            this.salarybythehourDataGridViewTextBoxColumn.DataPropertyName = "salarybythehour";
            this.salarybythehourDataGridViewTextBoxColumn.HeaderText = "salarybythehour";
            this.salarybythehourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salarybythehourDataGridViewTextBoxColumn.Name = "salarybythehourDataGridViewTextBoxColumn";
            this.salarybythehourDataGridViewTextBoxColumn.Width = 125;
            // 
            // leavesDataGridViewTextBoxColumn
            // 
            this.leavesDataGridViewTextBoxColumn.DataPropertyName = "leaves";
            this.leavesDataGridViewTextBoxColumn.HeaderText = "leaves";
            this.leavesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leavesDataGridViewTextBoxColumn.Name = "leavesDataGridViewTextBoxColumn";
            this.leavesDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalamountmonthDataGridViewTextBoxColumn
            // 
            this.totalamountmonthDataGridViewTextBoxColumn.DataPropertyName = "totalamountmonth";
            this.totalamountmonthDataGridViewTextBoxColumn.HeaderText = "totalamountmonth";
            this.totalamountmonthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalamountmonthDataGridViewTextBoxColumn.Name = "totalamountmonthDataGridViewTextBoxColumn";
            this.totalamountmonthDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form11";
            this.Text = "View Financial History";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinichospitaldbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientpaymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinichospitaldbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesfinancialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private clinichospitaldbDataSet1 clinichospitaldbDataSet1;
        private System.Windows.Forms.BindingSource patientpaymentsBindingSource;
        private clinichospitaldbDataSet1TableAdapters.patientpaymentsTableAdapter patientpaymentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorspayamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicinepaymountamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientssnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliesusedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountpayedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountowedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private clinichospitaldbDataSet2 clinichospitaldbDataSet2;
        private System.Windows.Forms.BindingSource employeesfinancialBindingSource;
        private clinichospitaldbDataSet2TableAdapters.employees_financialTableAdapter employees_financialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysshowedupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarybythehourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leavesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountmonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
    }
}