using ELLIE_SYSTEM.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ELLIE_SYSTEM
{
    public partial class ucForgotPw : UserControl
    {
        public ucForgotPw()
        {
            InitializeComponent();
        }

        string sqlQuery, has_user;

        public void refreshReset()
        {

            has_user = "0";
            Ftbac.Text = "";
            FtbPW.Text = "";
            FtbPWA.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chk if all ipput done
            if (Ftbac.Text == "")
            {
                MessageBox.Show("請輸入會員帳號");
                return;
            }

            if (FtbPW.Text == "")
            {
                MessageBox.Show("請輸入會員密碼");
                return;
            }

            if (FtbPWA.Text == "")
            {
                MessageBox.Show("請輸入會員密碼確認");
                return;
            }

            check_reset_valid(Ftbac.Text);
            if (has_user=="0") {
                MessageBox.Show("無此會員");
                return;

            }

            if (FtbPW.Text != FtbPWA.Text)
            {
                MessageBox.Show("密碼輸入不一致");
                return;
            }

            resetPassword();






        }

        public void resetPassword()
        {

            SqlTransaction transaction = null;

            //del from purchase bt 
            sqlQuery = getSQL.updatepassword(Ftbac.Text, FtbPW.Text);
            try
            {
                Form1.con.Open();
                transaction = Form1.con.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, Form1.con))
                {
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
                Form1.con.Close();
                MessageBox.Show("修改成功 請回登入頁測試");
            }
            catch (Exception error)
            {

                transaction.Rollback();
                MessageBox.Show("修改過程出現問題,請至登入頁確認");

            }
        }

            public void check_reset_valid(string input_id)
        {
            sqlQuery = getSQL.Check_User_Duplicate(input_id);
            Form1.con.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, Form1.con))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        has_user = "1";
                    }
                }
                else
                {
                    has_user = "0";
                }
                reader.Close();
            }
            Form1.con.Close();

        }
    }
}
