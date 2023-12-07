using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseBAse
{
    public partial class Form3 : Form
    {
        private SQLiteConnection DB;
        public Form3()
        {
            InitializeComponent();
        }

        private async  void Form3_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.connection);
            await DB.OpenAsync();
            LoadingReception();
        }

        private async void LoadingReception()
        {
            dataGridViewRecep.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM patient_reception INNER JOIN doctor ON doctor.id = patient_reception.idDoc JOIN patient ON patient.id = patient_reception.idPatient ", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[4]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Reception.id}"]}");
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["docFam"]);
                    data[data.Count - 1][2] = Convert.ToString(sqlReader["patientFam"]);
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Reception.dateRecep}"]}");

                }

                foreach (string[] s in data)
                {
                    dataGridViewRecep.Rows.Add(s);
                }
                dataGridViewRecep.ClearSelection();

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
            var DoctorsForm = new Form1();
            DoctorsForm.Show();
            this.Hide();
        }

        private void dataGridViewRecep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
