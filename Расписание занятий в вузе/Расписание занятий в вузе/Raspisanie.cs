using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Расписание_занятий_в_вузе
{
    public partial class Raspisanie : Form
    {
        public Raspisanie()
        {
            InitializeComponent();
            Fam.DropDownStyle = ComboBoxStyle.DropDownList;
            Audit.DropDownStyle = ComboBoxStyle.DropDownList;
            Disc.DropDownStyle = ComboBoxStyle.DropDownList;
            Gruppa.DropDownStyle = ComboBoxStyle.DropDownList;
            DB db = new DB();
            {
                string familiya = "SELECT * FROM Prepodavatel_vuza";
                string audit = "Select * From Auditoriya_vuza";
                string discipl = "Select * From Disciplina";
                string gruppa = "Select * From Gruppa_vuza";

                SqlCommand command = new SqlCommand(familiya, db.getConnection());
                SqlCommand command4 = new SqlCommand(audit, db.getConnection());
                SqlCommand command5 = new SqlCommand(discipl, db.getConnection());
                SqlCommand command6 = new SqlCommand(gruppa, db.getConnection());
                {
                    db.openConnection();

                    SqlDataReader reader = command.ExecuteReader();
                    SqlDataReader reader4 = command4.ExecuteReader();
                    SqlDataReader reader5 = command5.ExecuteReader();
                    SqlDataReader reader6 = command6.ExecuteReader();

                    {
                        Fam.Items.Clear();
                        Audit.Items.Clear();
                        Disc.Items.Clear();
                        Gruppa.Items.Clear();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string f = reader.GetString(1);

                                Fam.Items.Add(f);
                            }
                        }
                        if (reader4.HasRows)
                        {
                            while (reader4.Read())
                            {
                                string a = reader4.GetString(1);

                                Audit.Items.Add(a);
                            }
                        }
                        if (reader5.HasRows)
                        {
                            while (reader5.Read())
                            {
                                string d = reader5.GetString(1);

                                Disc.Items.Add(d);
                            }
                        }
                        if (reader6.HasRows)
                        {
                            while (reader6.Read())
                            {
                                string g = reader6.GetString(1);

                                Gruppa.Items.Add(g);
                            }
                        }
                    }

                    db.closeConnection();
                }
            }
        }

        private void Raspisanie_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select id_raspisanie as ID,Prepodavatel_vuza.FIO AS ФИО, Auditoriya_vuza.Nazvanie_auditorii AS Аудитория, Disciplina.Nazvanie_disciplini AS Дисциплина, Gruppa_vuza.Nazvanie_gruppi AS Группа From Raspisanie_vuza Join Prepodavatel_vuza on Raspisanie_vuza.id_prepodavatelya = Prepodavatel_vuza.id_prepodavatelya Join Auditoriya_vuza on Raspisanie_vuza.id_auditorii = Auditoriya_vuza.id_auditorii Join Disciplina on Raspisanie_vuza.id_disciplini = Disciplina.id_disciplini Join Gruppa_vuza on Raspisanie_vuza.id_gruppi = Gruppa_vuza.id_gruppi", db.getConnection());
            db.openConnection();
            da.Fill(ds, "Raspisanie_vuza");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();

            ds.Dispose();
            db.closeConnection();
            dataGridView1.ClearSelection();
            dataGridView1.Columns[0].ReadOnly = true; 
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true; 
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true; 
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Fam.Text) && !string.IsNullOrWhiteSpace(Audit.Text) && !string.IsNullOrWhiteSpace(Disc.Text) && !string.IsNullOrWhiteSpace(Gruppa.Text))
            {
                DB db = new DB();
                System.Data.DataTable table = new System.Data.DataTable();

                SqlCommand command = new SqlCommand("insert into Raspisanie_vuza(id_prepodavatelya,id_auditorii,id_disciplini,id_gruppi) Select id_prepodavatelya,id_auditorii,id_disciplini,id_gruppi From Prepodavatel_vuza,Auditoriya_vuza,Disciplina,Gruppa_vuza where Prepodavatel_vuza.FIO = @fam and Auditoriya_vuza.Nazvanie_auditorii = @aud and Disciplina.Nazvanie_disciplini = @dis and Gruppa_vuza.Nazvanie_gruppi = @gru", db.getConnection());
                command.Parameters.Add("@fam", SqlDbType.VarChar).Value = Fam.Text;
                command.Parameters.Add("@aud", SqlDbType.VarChar).Value = Audit.Text;
                command.Parameters.Add("@dis", SqlDbType.VarChar).Value = Disc.Text;
                command.Parameters.Add("@gru", SqlDbType.VarChar).Value = Gruppa.Text;

                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.ExecuteNonQuery();


                string sql = "Select id_raspisanie as ID,Prepodavatel_vuza.FIO AS ФИО, Auditoriya_vuza.Nazvanie_auditorii AS Аудитория, Disciplina.Nazvanie_disciplini AS Дисциплина, Gruppa_vuza.Nazvanie_gruppi AS Группа From Raspisanie_vuza Join Prepodavatel_vuza on Raspisanie_vuza.id_prepodavatelya = Prepodavatel_vuza.id_prepodavatelya Join Auditoriya_vuza on Raspisanie_vuza.id_auditorii = Auditoriya_vuza.id_auditorii Join Disciplina on Raspisanie_vuza.id_disciplini = Disciplina.id_disciplini Join Gruppa_vuza on Raspisanie_vuza.id_gruppi = Gruppa_vuza.id_gruppi";
                command.CommandText = sql;
                DataSet m_set = new DataSet();
                adapter.Fill(m_set);
                dataGridView1.DataSource = m_set.Tables[0];
                db.closeConnection();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void red_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DB db = new DB();
                string id;
                id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                if (!string.IsNullOrWhiteSpace(Fam.Text) || !string.IsNullOrWhiteSpace(Audit.Text) || !string.IsNullOrWhiteSpace(Disc.Text) || !string.IsNullOrWhiteSpace(Gruppa.Text))
                {
                    if (!string.IsNullOrWhiteSpace(Fam.Text))
                    {

                        SqlCommand command = new SqlCommand($"update Raspisanie_vuza set id_prepodavatelya = Prepodavatel_vuza.id_prepodavatelya From Prepodavatel_vuza where Prepodavatel_vuza.FIO = '" + Fam.Text + "' and Raspisanie_vuza.id_raspisanie = '" + id + "'", db.getConnection());

                        db.openConnection();
                        SqlDataAdapter adapter2 = new SqlDataAdapter(command);
                        command.ExecuteNonQuery();

                    }
                    if (!string.IsNullOrWhiteSpace(Audit.Text))
                    {

                        SqlCommand command = new SqlCommand($"update Raspisanie_vuza set id_auditorii = Auditoriya_vuza.id_auditorii From Auditoriya_vuza where Auditoriya_vuza.Nazvanie_auditorii = '" + Audit.Text + "' and Raspisanie_vuza.id_raspisanie = '" + id + "'", db.getConnection());

                        db.openConnection();
                        SqlDataAdapter adapter3 = new SqlDataAdapter(command);
                        command.ExecuteNonQuery();

                    }
                    if (!string.IsNullOrWhiteSpace(Disc.Text))
                    {

                        SqlCommand command = new SqlCommand($"update Raspisanie_vuza set id_disciplini = Disciplina.id_disciplini From Disciplina where Disciplina.Nazvanie_disciplini = '" + Disc.Text + "' and Raspisanie_vuza.id_raspisanie = '" + id + "'", db.getConnection());

                        db.openConnection();
                        SqlDataAdapter adapter4 = new SqlDataAdapter(command);
                        command.ExecuteNonQuery();

                    }
                    if (!string.IsNullOrWhiteSpace(Gruppa.Text))
                    {

                        SqlCommand command = new SqlCommand($"update Raspisanie_vuza set id_gruppi = Gruppa_vuza.id_gruppi From Gruppa_vuza where Gruppa_vuza.Nazvanie_gruppi = '" + Gruppa.Text + "' and Raspisanie_vuza.id_raspisanie = '" + id + "'", db.getConnection());

                        db.openConnection();
                        SqlDataAdapter adapter5 = new SqlDataAdapter(command);
                        command.ExecuteNonQuery();

                    }
                }
                else
                {
                    MessageBox.Show("Заполните поля");
                }
                string sql = "Select id_raspisanie as ID,Prepodavatel_vuza.FIO AS ФИО, Auditoriya_vuza.Nazvanie_auditorii AS Аудитория, Disciplina.Nazvanie_disciplini AS Дисциплина, Gruppa_vuza.Nazvanie_gruppi AS Группа From Raspisanie_vuza Join Prepodavatel_vuza on Raspisanie_vuza.id_prepodavatelya = Prepodavatel_vuza.id_prepodavatelya Join Auditoriya_vuza on Raspisanie_vuza.id_auditorii = Auditoriya_vuza.id_auditorii Join Disciplina on Raspisanie_vuza.id_disciplini = Disciplina.id_disciplini Join Gruppa_vuza on Raspisanie_vuza.id_gruppi = Gruppa_vuza.id_gruppi";
                SqlCommand selectCommand = new SqlCommand(sql, db.getConnection());
                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
                DataSet m_set = new DataSet();
                adapter.Fill(m_set);
                dataGridView1.DataSource = m_set.Tables[0];
                db.closeConnection();
            }

            else
            {
                MessageBox.Show("Выделите запись");
            }
            
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DB db = new DB();

                string id;
                id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

                string querystring = $"delete from Raspisanie_vuza where id_raspisanie = '{id}'";
                SqlCommand command = new SqlCommand(querystring, db.getConnection());
                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.ExecuteNonQuery();

                string sql = "Select id_raspisanie as ID,Prepodavatel_vuza.FIO AS ФИО, Auditoriya_vuza.Nazvanie_auditorii AS Аудитория, Disciplina.Nazvanie_disciplini AS Дисциплина, Gruppa_vuza.Nazvanie_gruppi AS Группа From Raspisanie_vuza Join Prepodavatel_vuza on Raspisanie_vuza.id_prepodavatelya = Prepodavatel_vuza.id_prepodavatelya Join Auditoriya_vuza on Raspisanie_vuza.id_auditorii = Auditoriya_vuza.id_auditorii Join Disciplina on Raspisanie_vuza.id_disciplini = Disciplina.id_disciplini Join Gruppa_vuza on Raspisanie_vuza.id_gruppi = Gruppa_vuza.id_gruppi";
                command.CommandText = sql;
                DataSet m_set = new DataSet();
                adapter.Fill(m_set);
                dataGridView1.DataSource = m_set.Tables[0];
                db.closeConnection();
            }
            else
            {
                MessageBox.Show("Выделите запись");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            //Установка фильтра для диалога сохранения файла
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Файлы Excel (*.xls; *.xlsx) | *.xls;*.xlsx";//Отображаютя только файлы Exel


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)//Если пользователь сохранил документ
            {
                //Создание Excel документа
                Microsoft.Office.Interop.Excel._Application app = new
                Microsoft.Office.Interop.Excel.Application();
                // Создание новой рабочей книги в этом документе
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // Создание нового листа в вышесозданной книге
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // Устанавливает свойство видимости документа за программой. Можно

                app.Visible = true;
                worksheet = workbook.ActiveSheet;// Определение значения объекта
                worksheet.Name = "Расписание"; // Изменение имени рабочего листа
                worksheet.Cells[1, 1] = "Расписание:";
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {

                    worksheet.Cells[2, i] = dataGridView1[i - 1, 0].Value;
                    //В некоторых версиях программа может выводить ошибку на 2 следующие

                    //Их можно удалить, они служат лишь для более наглядного

                    worksheet.Columns[i].ColumnWidth = 30;//Установление ширины столбцов
                    worksheet.Cells[2, i].Font.Color = Color.Red;//Установление цвета

                }
                for (int i = 1; i < dataGridView1.RowCount; i++)
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    { worksheet.Cells[i + 2, j + 1] = dataGridView1[j, i].Value; }
                // Сохраняет документ
                workbook.SaveAs(saveFileDialog1.FileName, Type.Missing, Type.Missing,

                Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();// Закрывает документ
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            a.Show();
            this.Hide();
        }
    }
}
