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
    public partial class FormRequest : Form
    {
        private SQLiteConnection DB;
        public FormRequest()
        {
            InitializeComponent();
        }

        private async void Form4_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(DataBase.connection);
            await DB.OpenAsync();
        }

        private async void buttonReq1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Специальность";
            dataGridView1.Columns[5].HeaderText = "Цена Услуги";
            dataGridView1.Columns[6].HeaderText = "Процент доктора";
            dataGridView1.Columns[7].HeaderText = "";
            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Doctors.main}] WHERE docSpec = 'Хирург'", DB);
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
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                    
                sqlReader?.Close();
            }

        }

        private async void buttonReq2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Дата рождения";
            dataGridView1.Columns[5].HeaderText = "";
            dataGridView1.Columns[6].HeaderText = "";
            dataGridView1.Columns[7].HeaderText = "";
            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Patient.main}] WHERE patientBirthday < '1980-01-01'", DB);
            List<string[]> data = new List<string[]>(); 
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Patient.id}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Patient.lastName}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Patient.firstName}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Patient.middleName}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{Patient.birthday}"]}");

                }

                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private async void buttonReq3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Специальность";
            dataGridView1.Columns[5].HeaderText = "Цена Услуги";
            dataGridView1.Columns[6].HeaderText = "Процент доктора";
            dataGridView1.Columns[7].HeaderText = "";
            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Doctors.main}] WHERE docSpec = 'Хирург' AND price < '100'", DB);
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
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private async void buttonReq6_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Специальность";
            dataGridView1.Columns[5].HeaderText = "Цена Услуги";
            dataGridView1.Columns[6].HeaderText = "Процент доктора";
            dataGridView1.Columns[7].HeaderText = "Зарплата";

            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Doctors.main}]", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[8]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Doctors.id}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Doctors.lastName}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Doctors.firstName}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Doctors.middleName}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{Doctors.docSpec}"]}");
                    data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{Doctors.price}"]}");
                    data[data.Count - 1][6] = Convert.ToString($"{sqlReader[$"{Doctors.procent}"]}");
                    data[data.Count - 1][7] = Convert.ToString($"{sqlReader[$"{Doctors.salary}"]}");

                }

                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private async void buttonReq7_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Дата приема";
            dataGridView1.Columns[4].HeaderText = "Средняя стоимость приема";
            dataGridView1.Columns[5].HeaderText = "";
            dataGridView1.Columns[6].HeaderText = "";
            dataGridView1.Columns[7].HeaderText = "";

            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT  * FROM [{Doctors.main}] INNER JOIN [{Reception.main}] ON [{Doctors.id}] = [{Reception.idDoc}] GROUP BY dateRecep ", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Doctors.id}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Doctors.lastName}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Doctors.firstName}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Reception.dateRecep}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{Reception.avgPrice}"]}");

                }

                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private async void buttonReq8_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Специальность доктора";
            dataGridView1.Columns[1].HeaderText = "Максимальный процент";
            dataGridView1.Columns[2].HeaderText = "";
            dataGridView1.Columns[3].HeaderText = "";
            dataGridView1.Columns[4].HeaderText = "";
            dataGridView1.Columns[5].HeaderText = "";
            dataGridView1.Columns[6].HeaderText = "";
            dataGridView1.Columns[7].HeaderText = "";

            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT DISTINCT docSpec, max(procent) AS maxProcent FROM doctor GROUP BY docSpec", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[2]);
                    data[data.Count - 1][0] = Convert.ToString(sqlReader["docSpec"]);
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["maxProcent"]);

                }

                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private async void buttonReq9_Click(object sender, EventArgs e)
        {
         SQLiteCommand command1 = new SQLiteCommand($"DROP TABLE Vrachi_terapevti", DB);
            await command1.ExecuteNonQueryAsync();

            SQLiteCommand command = new SQLiteCommand($"CREATE TABLE Vrachi_terapevti as SELECT * FROM doctor WHERE docSpec= 'Терапевт' ", DB);
            await command.ExecuteNonQueryAsync();

            dataGridView1.Columns[0].HeaderText = "Специальность доктора";
            dataGridView1.Columns[1].HeaderText = "Максимальный процент";
            dataGridView1.Columns[2].HeaderText = "";
            dataGridView1.Columns[3].HeaderText = "";
            dataGridView1.Columns[4].HeaderText = "";
            dataGridView1.Columns[5].HeaderText = "";
            dataGridView1.Columns[6].HeaderText = "";
            dataGridView1.Columns[7].HeaderText = "";

            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command2 = new SQLiteCommand($"SELECT DISTINCT docSpec, max(procent) AS maxProcent FROM doctor GROUP BY docSpec", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command2.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[2]);
                    data[data.Count - 1][0] = Convert.ToString(sqlReader["docSpec"]);
                    data[data.Count - 1][1] = Convert.ToString(sqlReader["maxProcent"]);

                }

                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private async void buttonReq10_Click(object sender, EventArgs e)
        {
            SQLiteCommand command = new SQLiteCommand($"CREATE TABLE COPY_DOCTOR AS SELECT * FROM doctor", DB);
            await command.ExecuteNonQueryAsync();
        }

        private async void buttonReq11_Click(object sender, EventArgs e)
        {
            SQLiteCommand command = new SQLiteCommand($"DELETE FROM COPY_DOCTOR WHERE price > 200", DB);
            await command.ExecuteNonQueryAsync();
        }

        private async void buttonReq12_Click(object sender, EventArgs e)
        {
            SQLiteCommand command = new SQLiteCommand($"UPDATE doctor SET procent = procent + 10", DB);
            await command.ExecuteNonQueryAsync();
        }

        private async void buttonReq4_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Дата рождени";
            dataGridView1.Columns[5].HeaderText = "";
            dataGridView1.Columns[6].HeaderText = "";
            dataGridView1.Columns[7].HeaderText = "";

            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Patient.main}] WHERE patientBirthday = @birthday", DB);
            command.Parameters.AddWithValue("@birthday", textBox1.Text);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[5]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Patient.id}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Patient.lastName}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Patient.firstName}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Patient.middleName}"]}");
                    data[data.Count - 1][4] = Convert.ToString(sqlReader["patientBirthday"]);

                }

                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private async void buttonReq5_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "Фамилия доктора";
            dataGridView1.Columns[2].HeaderText = "Фамилия пациента";
            dataGridView1.Columns[3].HeaderText = "Дата приема";
            dataGridView1.Columns[4].HeaderText = "";
            dataGridView1.Columns[5].HeaderText = "";
            dataGridView1.Columns[6].HeaderText = "";
            dataGridView1.Columns[7].HeaderText = "";
            dataGridView1.Columns[7].Visible = false;

            dataGridView1.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Reception.main}] JOIN doctor ON doctor.id = patient_reception.idDoc JOIN patient ON patient.id = patient_reception.idPatient  WHERE dateRecep BETWEEN date(@dateRecepFrom) AND date(@dateRecepTo)   ", DB);
            command.Parameters.AddWithValue("@dateRecepFrom", textBox2.Text);
            command.Parameters.AddWithValue("@dateRecepTo", textBox3.Text);

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
                    data[data.Count - 1][3] = Convert.ToString(sqlReader["dateRecep"]);

                }

                foreach (string[] s in data)
                {
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.ClearSelection();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
