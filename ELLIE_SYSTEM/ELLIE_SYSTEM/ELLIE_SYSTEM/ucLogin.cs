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
using System.Configuration;
using ELLIE_SYSTEM.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ELLIE_SYSTEM
{
    public partial class ucLogin : UserControl
    {
        public static string currentUser, currentUserName, user_chk, password_chk, user_privilege;
        public delegate void changeTabPage(int pageid);
        public static event changeTabPage changeTabpageEvent;
        string sqlQuery;



        public ucLogin()
        {
            InitializeComponent();

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Form1.DisableSalaryPage();
            //Form1.EnableTab(Form1.tabControl1.TabPages[1], false);
            user_chk = "no_account";
            password_chk = "fail"; user_privilege = "";
            currentUserName = "";
            currentUser = tbaccount.Text;
            check_privilege(currentUser, textBox1.Text);

            if (user_chk == "no_account") {
                MessageBox.Show("無此使用者,請確認輸入");
                return;
            }

            if (password_chk == "fail") {
                MessageBox.Show("密碼錯誤");
                return;
            }

            if (user_privilege == "STUDENT")
            {
                changeTabpageEvent(1);
            }
            else {
                changeTabpageEvent(3);
            }

        }
    

        public void check_privilege(string input_id,string input_password)
        {
            sqlQuery = getSQL.Check_priv(input_id, input_password);
            Form1.con.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, Form1.con))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user_chk = "pass";
                        password_chk = reader.GetString(1);
                        user_privilege = reader.GetString(2);
                        currentUserName= reader.GetString(3);
                    }
                }
                else {
                    user_chk = "no_account";
                }
                reader.Close();
            }
            Form1.con.Close();

        }

        public void ucLogin_Load()
        {
            if (Form1.sentfromlogout) {
                tbaccount.Text = "";
                textBox1.Text = "";
                currentUser = "";
                currentUserName = "no_account";
                user_chk = "fail";
                user_privilege = "";
                password_chk = "fail";

            }

            Form1.sentfromlogout = false;

        }
    }
}
