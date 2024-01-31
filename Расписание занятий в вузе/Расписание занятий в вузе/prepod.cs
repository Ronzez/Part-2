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
    public partial class prepod : Form
    {
        public prepod()
        {
            InitializeComponent();
        }

        private void prepod_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select Prepodavatel_vuza.FIO AS ФИО, Auditoriya_vuza.Nazvanie_auditorii AS Аудитория, Disciplina.Nazvanie_disciplini AS Дисциплина, Gruppa_vuza.Nazvanie_gruppi AS Группа From Raspisanie_vuza Join Prepodavatel_vuza on Raspisanie_vuza.id_prepodavatelya = Prepodavatel_vuza.id_prepodavatelya Join Auditoriya_vuza on Raspisanie_vuza.id_auditorii = Auditoriya_vuza.id_auditorii Join Disciplina on Raspisanie_vuza.id_disciplini = Disciplina.id_disciplini Join Gruppa_vuza on Raspisanie_vuza.id_gruppi = Gruppa_vuza.id_gruppi", db.getConnection());
            db.openConnection();
            da.Fill(ds, "Raspisanie_vuza");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();

            ds.Dispose();
            db.closeConnection();
        }

        private void vozr_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select Prepodavatel_vuza.FIO AS ФИО, Auditoriya_vuza.Nazvanie_auditorii AS Аудитория, Disciplina.Nazvanie_disciplini AS Дисциплина, Gruppa_vuza.Nazvanie_gruppi AS Группа From Raspisanie_vuza Join Prepodavatel_vuza on Raspisanie_vuza.id_prepodavatelya = Prepodavatel_vuza.id_prepodavatelya Join Auditoriya_vuza on Raspisanie_vuza.id_auditorii = Auditoriya_vuza.id_auditorii Join Disciplina on Raspisanie_vuza.id_disciplini = Disciplina.id_disciplini Join Gruppa_vuza on Raspisanie_vuza.id_gruppi = Gruppa_vuza.id_gruppi order by FIO ASC", db.getConnection());
            db.openConnection();
            da.Fill(ds, "Raspisanie_vuza");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();

            ds.Dispose();
            db.closeConnection();
        }

        private void ub_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select Prepodavatel_vuza.FIO AS ФИО, Auditoriya_vuza.Nazvanie_auditorii AS Аудитория, Disciplina.Nazvanie_disciplini AS Дисциплина, Gruppa_vuza.Nazvanie_gruppi AS Группа From Raspisanie_vuza Join Prepodavatel_vuza on Raspisanie_vuza.id_prepodavatelya = Prepodavatel_vuza.id_prepodavatelya Join Auditoriya_vuza on Raspisanie_vuza.id_auditorii = Auditoriya_vuza.id_auditorii Join Disciplina on Raspisanie_vuza.id_disciplini = Disciplina.id_disciplini Join Gruppa_vuza on Raspisanie_vuza.id_gruppi = Gruppa_vuza.id_gruppi order by FIO DESC", db.getConnection());
            db.openConnection();
            da.Fill(ds, "Raspisanie_vuza");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();

            ds.Dispose();
            db.closeConnection();
        }

        private void poisk_TextChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select Prepodavatel_vuza.FIO AS ФИО, Auditoriya_vuza.Nazvanie_auditorii AS Аудитория, Disciplina.Nazvanie_disciplini AS Дисциплина, Gruppa_vuza.Nazvanie_gruppi AS Группа From Raspisanie_vuza Join Prepodavatel_vuza on Raspisanie_vuza.id_prepodavatelya = Prepodavatel_vuza.id_prepodavatelya Join Auditoriya_vuza on Raspisanie_vuza.id_auditorii = Auditoriya_vuza.id_auditorii Join Disciplina on Raspisanie_vuza.id_disciplini = Disciplina.id_disciplini Join Gruppa_vuza on Raspisanie_vuza.id_gruppi = Gruppa_vuza.id_gruppi where FIO like '"+ poisk.Text + "%' or Nazvanie_auditorii like '"+ poisk.Text + "%' or Nazvanie_disciplini like '" + poisk.Text + "%' or Nazvanie_gruppi like '" + poisk.Text + "%'", db.getConnection());
            db.openConnection();
            da.Fill(ds, "Raspisanie_vuza");
            dataGridView1.DataSource = ds.Tables[0];
            da.Dispose();

            ds.Dispose();
            db.closeConnection();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }
    }
}
