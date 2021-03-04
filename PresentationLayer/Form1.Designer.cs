
namespace PresentationLayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridCustomers = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbStartsWith = new System.Windows.Forms.RadioButton();
            this.rbCity = new System.Windows.Forms.RadioButton();
            this.rbLastName = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCustomers
            // 
            this.gridCustomers.AllowUserToAddRows = false;
            this.gridCustomers.AllowUserToDeleteRows = false;
            this.gridCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomers.Location = new System.Drawing.Point(12, 99);
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.ReadOnly = true;
            this.gridCustomers.RowHeadersVisible = false;
            this.gridCustomers.RowHeadersWidth = 62;
            this.gridCustomers.RowTemplate.Height = 33;
            this.gridCustomers.Size = new System.Drawing.Size(1163, 450);
            this.gridCustomers.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1063, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(633, 27);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(112, 34);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(6, 29);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(281, 31);
            this.txtLastName.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbStartsWith);
            this.groupBox1.Controls.Add(this.rbCity);
            this.groupBox1.Controls.Add(this.rbLastName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 80);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // rbStartsWith
            // 
            this.rbStartsWith.AutoSize = true;
            this.rbStartsWith.Location = new System.Drawing.Point(509, 30);
            this.rbStartsWith.Name = "rbStartsWith";
            this.rbStartsWith.Size = new System.Drawing.Size(118, 29);
            this.rbStartsWith.TabIndex = 8;
            this.rbStartsWith.Text = "StartsWith";
            this.rbStartsWith.UseVisualStyleBackColor = true;
            // 
            // rbCity
            // 
            this.rbCity.AutoSize = true;
            this.rbCity.Location = new System.Drawing.Point(436, 30);
            this.rbCity.Name = "rbCity";
            this.rbCity.Size = new System.Drawing.Size(67, 29);
            this.rbCity.TabIndex = 7;
            this.rbCity.Text = "City";
            this.rbCity.UseVisualStyleBackColor = true;
            // 
            // rbLastName
            // 
            this.rbLastName.AutoSize = true;
            this.rbLastName.Checked = true;
            this.rbLastName.Location = new System.Drawing.Point(307, 30);
            this.rbLastName.Name = "rbLastName";
            this.rbLastName.Size = new System.Drawing.Size(120, 29);
            this.rbLastName.TabIndex = 6;
            this.rbLastName.TabStop = true;
            this.rbLastName.Text = "Last Name";
            this.rbLastName.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridCustomers);
            this.Name = "Form1";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCustomers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbStartsWith;
        private System.Windows.Forms.RadioButton rbCity;
        private System.Windows.Forms.RadioButton rbLastName;
    }
}

