namespace BaseBAse
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridViewRecep = new System.Windows.Forms.DataGridView();
            this.idRecep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRecep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRecep
            // 
            this.dataGridViewRecep.AllowUserToAddRows = false;
            this.dataGridViewRecep.AllowUserToDeleteRows = false;
            this.dataGridViewRecep.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.dataGridViewRecep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRecep,
            this.idDoc,
            this.idPatient,
            this.dateRecep});
            this.dataGridViewRecep.Location = new System.Drawing.Point(208, 12);
            this.dataGridViewRecep.Name = "dataGridViewRecep";
            this.dataGridViewRecep.ReadOnly = true;
            this.dataGridViewRecep.RowHeadersVisible = false;
            this.dataGridViewRecep.Size = new System.Drawing.Size(324, 235);
            this.dataGridViewRecep.TabIndex = 0;
            this.dataGridViewRecep.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecep_CellContentClick);
            // 
            // idRecep
            // 
            this.idRecep.HeaderText = "id";
            this.idRecep.Name = "idRecep";
            this.idRecep.ReadOnly = true;
            this.idRecep.Width = 20;
            // 
            // idDoc
            // 
            this.idDoc.HeaderText = "Фамилия доктора";
            this.idDoc.Name = "idDoc";
            this.idDoc.ReadOnly = true;
            // 
            // idPatient
            // 
            this.idPatient.HeaderText = "Фамилия пациента";
            this.idPatient.Name = "idPatient";
            this.idPatient.ReadOnly = true;
            // 
            // dateRecep
            // 
            this.dateRecep.HeaderText = "Дата заявки";
            this.dateRecep.Name = "dateRecep";
            this.dateRecep.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Пациенты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(489, 380);
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 452);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewRecep);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRecep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRecep;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRecep;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}