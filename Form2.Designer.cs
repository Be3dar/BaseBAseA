namespace BaseBAse
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridViewPatient = new System.Windows.Forms.DataGridView();
            this.idPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientFam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientOtch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPatient
            // 
            this.dataGridViewPatient.AllowUserToAddRows = false;
            this.dataGridViewPatient.AllowUserToDeleteRows = false;
            this.dataGridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPatient,
            this.patientFam,
            this.patientName,
            this.PatientOtch,
            this.patientBirthday});
            this.dataGridViewPatient.Location = new System.Drawing.Point(186, 12);
            this.dataGridViewPatient.Name = "dataGridViewPatient";
            this.dataGridViewPatient.ReadOnly = true;
            this.dataGridViewPatient.RowHeadersVisible = false;
            this.dataGridViewPatient.Size = new System.Drawing.Size(541, 211);
            this.dataGridViewPatient.TabIndex = 0;
            // 
            // idPatient
            // 
            this.idPatient.HeaderText = "id";
            this.idPatient.Name = "idPatient";
            this.idPatient.ReadOnly = true;
            this.idPatient.Width = 20;
            // 
            // patientFam
            // 
            this.patientFam.HeaderText = "Фамилия";
            this.patientFam.Name = "patientFam";
            this.patientFam.ReadOnly = true;
            this.patientFam.Width = 150;
            // 
            // patientName
            // 
            this.patientName.HeaderText = "Имя";
            this.patientName.Name = "patientName";
            this.patientName.ReadOnly = true;
            // 
            // PatientOtch
            // 
            this.PatientOtch.HeaderText = "Отчество";
            this.PatientOtch.Name = "PatientOtch";
            this.PatientOtch.ReadOnly = true;
            this.PatientOtch.Width = 150;
            // 
            // patientBirthday
            // 
            this.patientBirthday.HeaderText = "Дата рождения";
            this.patientBirthday.Name = "patientBirthday";
            this.patientBirthday.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Заявки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(634, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Докторы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(943, 524);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 519);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewPatient);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Пациенты";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientFam;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientOtch;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientBirthday;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}