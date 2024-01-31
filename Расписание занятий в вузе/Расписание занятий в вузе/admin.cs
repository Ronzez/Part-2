using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Расписание_занятий_в_вузе
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void Disciplina_Click(object sender, EventArgs e)
        {
            Disciplina a = new Disciplina();
            a.Show();
            this.Hide();
        }

        private void Prepodavatel_Click(object sender, EventArgs e)
        {
            Prepodavatel b = new Prepodavatel();
            b.Show();
            this.Hide();
        }

        private void Auditoria_Click(object sender, EventArgs e)
        {
            Auditoriya c = new Auditoriya();
            c.Show();
            this.Hide();
        }

        private void Gruppa_Click(object sender, EventArgs e)
        {
            Gruppa d = new Gruppa();
            d.Show();
            this.Hide();
        }

        private void Raspisanie_Click(object sender, EventArgs e)
        {
            Raspisanie t = new Raspisanie();
            t.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }
    }
}
