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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vhod_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(logBox.Text) || !string.IsNullOrWhiteSpace(passBox.Text))
            {
                String LoginUser = logBox.Text;
                String PassUser = passBox.Text;

                DB db = new DB();

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand command = new SqlCommand("SELECT * FROM prepod WHERE login = @login1 AND password = @kod1 And Rol = 'Teacher' ", db.getConnection());
                command.Parameters.Add("@login1", SqlDbType.VarChar).Value = LoginUser;
                command.Parameters.Add("@kod1", SqlDbType.VarChar).Value = PassUser;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    prepod a = new prepod();
                    a.Show();
                    this.Hide();
                }

                else
                {
                    String LoginUser2 = logBox.Text;
                    String PassUser2 = passBox.Text;

                    DataTable table2 = new DataTable();
                    SqlDataAdapter adapter2 = new SqlDataAdapter();

                    SqlCommand command2 = new SqlCommand("SELECT * FROM prepod WHERE login = @login2 AND password = @kod2 And Rol = 'Admin' ", db.getConnection());
                    command2.Parameters.Add("@login2", SqlDbType.VarChar).Value = LoginUser2;
                    command2.Parameters.Add("@kod2", SqlDbType.VarChar).Value = PassUser2;

                    adapter2.SelectCommand = command2;
                    adapter2.Fill(table2);

                    if (table2.Rows.Count > 0)
                    {
                        admin b = new admin();
                        b.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните поля");
            }
        }
    }
}
