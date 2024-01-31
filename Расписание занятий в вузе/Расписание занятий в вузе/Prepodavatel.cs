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

namespace Расписание_занятий_в_вузе
{
    public partial class Prepodavatel : Form
    {
        public Prepodavatel()
        {
            InitializeComponent();
        }

        private void Prepodavatel_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select id_prepodavatelya as ID,FIO as ФИО,Specialnost as Специальность from Prepodavatel_vuza", db.getConnection());
            db.openConnection();
            da.Fill(ds, "Prepodavatel_vuza");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();

            ds.Dispose();
            db.closeConnection();
            dataGridView1.ClearSelection();
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Fam.Text) && !string.IsNullOrWhiteSpace(Spec.Text))
            {
                DB db = new DB();

                var f = Fam.Text;
                var s = Spec.Text;

                string querystring = $"insert into Prepodavatel_vuza(FIO,Specialnost) values('{f}','{s}')";

                SqlCommand command = new SqlCommand(querystring, db.getConnection());
                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try { command.ExecuteNonQuery(); }
                catch { MessageBox.Show("Данный ID уже существует"); }

                string sql = "Select id_prepodavatelya as ID,FIO as ФИО,Specialnost as Специальность from Prepodavatel_vuza";
                command.CommandText = sql;
                DataSet m_set = new DataSet();
                adapter.Fill(m_set);
                dataGridView1.DataSource = m_set.Tables[0];
                db.closeConnection();
            }
            else
            {
                MessageBox.Show("Заполните поля");
            }
        }

        private void red_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DB db = new DB();
                string id;
                id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                if (!string.IsNullOrWhiteSpace(Fam.Text) || !string.IsNullOrWhiteSpace(Spec.Text))
                {
                    if (!string.IsNullOrWhiteSpace(Fam.Text))
                    {

                        var f = Fam.Text;

                        string querystring = $"update Prepodavatel_vuza set FIO ='{f}' where id_prepodavatelya = '{id}'";

                        SqlCommand command = new SqlCommand(querystring, db.getConnection());
                        db.openConnection();
                        SqlDataAdapter adapter2 = new SqlDataAdapter(command);
                        command.ExecuteNonQuery();

                    }
                    if (!string.IsNullOrWhiteSpace(Spec.Text))
                    {

                        var s = Spec.Text;

                        string querystring = $"update Prepodavatel_vuza set Specialnost ='{s}' where id_prepodavatelya = '{id}'";

                        SqlCommand command = new SqlCommand(querystring, db.getConnection());
                        db.openConnection();
                        SqlDataAdapter adapter3 = new SqlDataAdapter(command);
                        command.ExecuteNonQuery();

                    }
                }
                else
                {
                    MessageBox.Show("Заполните поля");
                }
                string sql = "Select id_prepodavatelya as ID,FIO as ФИО,Specialnost as Специальность from Prepodavatel_vuza";
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

                DataTable dataTable = new DataTable();

                string querystring = $"delete from Prepodavatel_vuza where id_prepodavatelya = '{id}'";
                SqlCommand command = new SqlCommand(querystring, db.getConnection());
                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.ExecuteNonQuery();

                string sql = "Select id_prepodavatelya as ID,FIO as ФИО,Specialnost as Специальность from Prepodavatel_vuza";
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

        private void Fam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Spec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
