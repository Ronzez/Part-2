using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Расписание_занятий_в_вузе
{
    class DB
    {
        SqlConnection myConnection = new SqlConnection("data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user67_db;persist security info=True;user id=user67_db;password=user67;MultipleActiveResultSets=True;App=EntityFramework");
        public void openConnection()
        {
            if (myConnection.State == System.Data.ConnectionState.Closed)
            {
                myConnection.Open();
            }

        }
        public void closeConnection()
        {
            if (myConnection.State == System.Data.ConnectionState.Open)
            {
                myConnection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return myConnection;
        }
    }
}
