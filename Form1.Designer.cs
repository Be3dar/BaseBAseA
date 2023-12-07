namespace BaseBAse
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewDoctor = new System.Windows.Forms.DataGridView();
            this.idDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocFam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocOtch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoctor
            // 
            this.dataGridViewDoctor.AllowUserToAddRows = false;
            this.dataGridViewDoctor.AllowUserToDeleteRows = false;
            this.dataGridViewDoctor.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridViewDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDoc,
            this.DocFam,
            this.DocName,
            this.DocOtch,
            this.DocSpec,
            this.price,
            this.procent});
            this.dataGridViewDoctor.Location = new System.Drawing.Point(92, 23);
            this.dataGridViewDoctor.Name = "dataGridViewDoctor";
            this.dataGridViewDoctor.ReadOnly = true;
            this.dataGridViewDoctor.RowHeadersVisible = false;
            this.dataGridViewDoctor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewDoctor.ShowEditingIcon = false;
            this.dataGridViewDoctor.Size = new System.Drawing.Size(724, 199);
            this.dataGridViewDoctor.TabIndex = 0;
            // 
            // idDoc
            // 
            this.idDoc.HeaderText = "id";
            this.idDoc.Name = "idDoc";
            this.idDoc.ReadOnly = true;
            this.idDoc.Width = 20;
            // 
            // DocFam
            // 
            this.DocFam.HeaderText = "Фамилия доктора";
            this.DocFam.Name = "DocFam";
            this.DocFam.ReadOnly = true;
            this.DocFam.Width = 150;
            // 
            // DocName
            // 
            this.DocName.HeaderText = "Имя доктора";
            this.DocName.Name = "DocName";
            this.DocName.ReadOnly = true;
            // 
            // DocOtch
            // 
            this.DocOtch.HeaderText = "Отчество доктора";
            this.DocOtch.Name = "DocOtch";
            this.DocOtch.ReadOnly = true;
            this.DocOtch.Width = 150;
            // 
            // DocSpec
            // 
            this.DocSpec.HeaderText = "Специальность";
            this.DocSpec.Name = "DocSpec";
            this.DocSpec.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // procent
            // 
            this.procent.HeaderText = "процент";
            this.procent.Name = "procent";
            this.procent.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Пациенты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Заявки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(362, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Запросы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(906, 519);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 515);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewDoctor);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Докторы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocFam;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocOtch;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn procent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

