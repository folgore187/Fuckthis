namespace WindowsFormsAppweek1fix
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlyPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnnualPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monthtaxes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yeartax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to your new tax program ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Address,
            this.MonthlyPay,
            this.AnnualPay,
            this.EmployeeType,
            this.EmployeeAge,
            this.Department,
            this.Type,
            this.Monthtaxes,
            this.Yeartax});
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1419, 464);
            this.dataGridView1.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // MonthlyPay
            // 
            this.MonthlyPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MonthlyPay.HeaderText = "Monthly Pay";
            this.MonthlyPay.Name = "MonthlyPay";
            // 
            // AnnualPay
            // 
            this.AnnualPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AnnualPay.HeaderText = "Annual Pay";
            this.AnnualPay.Name = "AnnualPay";
            // 
            // EmployeeType
            // 
            this.EmployeeType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeType.HeaderText = "EmployeeType";
            this.EmployeeType.Name = "EmployeeType";
            // 
            // EmployeeAge
            // 
            this.EmployeeAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeAge.HeaderText = "Age";
            this.EmployeeAge.Name = "EmployeeAge";
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Dev Type";
            this.Type.Name = "Type";
            // 
            // Monthtaxes
            // 
            this.Monthtaxes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Monthtaxes.HeaderText = "Monthly taxes";
            this.Monthtaxes.Name = "Monthtaxes";
            // 
            // Yeartax
            // 
            this.Yeartax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Yeartax.HeaderText = "Yearly tax";
            this.Yeartax.Name = "Yeartax";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 632);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            
           
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlyPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnnualPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monthtaxes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yeartax;
    }
}

