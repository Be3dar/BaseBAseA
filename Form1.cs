using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing.Text;
using System.Net.Http.Headers;

namespace BaseBAse
{
    public partial class Form1 : Form
    {
        private SQLiteConnection DB;
        public Form1()
            
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.connection);
            await DB.OpenAsync();
            LoadingDoctors();
        }

        private async void LoadingDoctors()
        {
            dataGridViewDoctor.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Doctors.main}]", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Doctors.id}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Doctors.lastName}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Doctors.firstName}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Doctors.middleName}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{Doctors.docSpec}"]}");
                    data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{Doctors.price}"]}");
                    data[data.Count - 1][6] = Convert.ToString($"{sqlReader[$"{Doctors.procent}"]}");

                }

                foreach (string[] s in data)
                {
                    dataGridViewDoctor.Rows.Add(s);
                }
                dataGridViewDoctor.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var PatientForm = new Form2();
            PatientForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var RecepForm = new Form3();
            RecepForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var zaprosi = new FormRequest();
            zaprosi.Show();
        }
    }
}
