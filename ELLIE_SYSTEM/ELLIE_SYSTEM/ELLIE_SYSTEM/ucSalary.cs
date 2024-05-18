using ELLIE_SYSTEM.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;

namespace ELLIE_SYSTEM
{
    public partial class ucSalary : UserControl
    {
        string sqlQuery, sqlQuery1, sqlQuery2, sqlQuery3;
        DataSet ds = new DataSet();
        public ucSalary()
        {
            InitializeComponent();
        }

        public void refreshuser() {
            cbx_s_teacher.Items.Clear();

            sqlQuery = getSQL.getTeacherList((string)ucLogin.currentUser);
            Form1.con.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, Form1.con))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        cbx_t_salary.Items.Add(reader.GetString(0));
                    }
                }
                reader.Close();
            }
            Form1.con.Close();
        }
    }
}
