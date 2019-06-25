namespace Veresiye.UI
{
    partial class FrmCompanyEdit
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
            this.btnCompanyEdit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnActivityEdit = new System.Windows.Forms.Button();
            this.btnActivityAdd = new System.Windows.Forms.Button();
            this.dgwActivities = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCompanyEdit
            // 
            this.btnCompanyEdit.Location = new System.Drawing.Point(538, 68);
            this.btnCompanyEdit.Name = "btnCompanyEdit";
            this.btnCompanyEdit.Size = new System.Drawing.Size(250, 23);
            this.btnCompanyEdit.TabIndex = 38;
            this.btnCompanyEdit.Text = "Değiştir";
            this.btnCompanyEdit.UseVisualStyleBackColor = true;
            this.btnCompanyEdit.Click += new System.EventHandler(this.BtnCompanyEdit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Bölge :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Şehir :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Şirket Adı :";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(538, 42);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(250, 20);
            this.txtRegion.TabIndex = 33;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(538, 16);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(250, 20);
            this.txtCity.TabIndex = 32;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(72, 42);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 20);
            this.txtPhone.TabIndex = 31;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(72, 16);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(250, 20);
            this.txtCompanyName.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnCompanyEdit);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCompanyName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtRegion);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 140);
            this.panel1.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnActivityEdit);
            this.groupBox1.Controls.Add(this.btnActivityAdd);
            this.groupBox1.Location = new System.Drawing.Point(72, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 58);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(181, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnActivityEdit
            // 
            this.btnActivityEdit.Location = new System.Drawing.Point(93, 19);
            this.btnActivityEdit.Name = "btnActivityEdit";
            this.btnActivityEdit.Size = new System.Drawing.Size(75, 23);
            this.btnActivityEdit.TabIndex = 39;
            this.btnActivityEdit.Text = "Düzenle";
            this.btnActivityEdit.UseVisualStyleBackColor = true;
            this.btnActivityEdit.Click += new System.EventHandler(this.BtnActivityEdit_Click);
            // 
            // btnActivityAdd
            // 
            this.btnActivityAdd.Location = new System.Drawing.Point(6, 19);
            this.btnActivityAdd.Name = "btnActivityAdd";
            this.btnActivityAdd.Size = new System.Drawing.Size(75, 23);
            this.btnActivityAdd.TabIndex = 38;
            this.btnActivityAdd.Text = "Yeni İşlem";
            this.btnActivityAdd.UseVisualStyleBackColor = true;
            this.btnActivityAdd.Click += new System.EventHandler(this.BtnActivityAdd_Click);
            // 
            // dgwActivities
            // 
            this.dgwActivities.AllowUserToAddRows = false;
            this.dgwActivities.AllowUserToDeleteRows = false;
            this.dgwActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwActivities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column5,
            this.Column3});
            this.dgwActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwActivities.Location = new System.Drawing.Point(0, 140);
            this.dgwActivities.Name = "dgwActivities";
            this.dgwActivities.ReadOnly = true;
            this.dgwActivities.Size = new System.Drawing.Size(800, 310);
            this.dgwActivities.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ActivityType";
            this.Column4.HeaderText = "İşlem Türü";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Açıklama";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Amount";
            this.Column5.HeaderText = "Miktar";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TransactionDate";
            this.Column3.HeaderText = "İşlem Tarihi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FrmCompanyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwActivities);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCompanyEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şirket Düzenle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCompanyEdit_FormClosing);
            this.Load += new System.EventHandler(this.FrmCompanyEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwActivities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompanyEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnActivityEdit;
        private System.Windows.Forms.Button btnActivityAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwActivities;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}