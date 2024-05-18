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
using System.Diagnostics;

namespace ELLIE_SYSTEM
{
    public partial class ucNewMember : UserControl
    {
        string is_user_exists;
        public ucNewMember()
        {
            InitializeComponent();
        }

        string sqlQuery;
        public void refreshumember()
        {


            tbAccount.Text = "";
            tbName.Text = "";
            tbPassword.Text = "";
            tbPWassure.Text = "";
            tbcell.Text = "";
            is_user_exists = "1";
            cbxMbrTeacher.Text = "";
            cbxMbrTeacher.Items.Clear();

            sqlQuery = getSQL.getTeacherList((string)ucLogin.currentUser);
            Form1.con.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, Form1.con))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        cbxMbrTeacher.Items.Add(reader.GetString(0));
                    }
                }
                reader.Close();
            }
            Form1.con.Close();



        }
        private void button1_Click(object sender, EventArgs e)
        {
            //chk if all ipput done
            if (tbAccount.Text == "")
            {
                MessageBox.Show("請輸入會員帳號");
                return;
            }

            if (tbName.Text == "")
            {
                MessageBox.Show("請輸入會員姓名");
                return;
            }

            if (tbPassword.Text == "")
            {
                MessageBox.Show("請輸入會員密碼");
                return;
            }


            if (tbPWassure.Text == "")
            {
                MessageBox.Show("請輸入密碼確認");
                return;
            }

            if (tbcell.Text == "")
            {
                MessageBox.Show("請輸入會員電話");
                return;
            }

            if (cbxMbrTeacher.Text == "")
            {
                MessageBox.Show("請選擇預設上課老師");
                return;
            }



            //chk if alreadiy exists
            check_valid(tbAccount.Text);
            if (is_user_exists == "1") {
                MessageBox.Show("此會員帳號已存在");
                return;
            }

            //chk if password eqaul
            if (tbPassword.Text != tbPWassure.Text) {
                MessageBox.Show("密碼輸入不一致");
                return;
            }

            addMemberInfo();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //chk if all ipput done
            if (tbAccount.Text == "")
            {
                MessageBox.Show("請輸入會員帳號");
                return;
            }

            if (tbName.Text == "")
            {
                MessageBox.Show("請輸入會員姓名");
                return;
            }

            if (tbPassword.Text == "")
            {
                MessageBox.Show("請輸入會員密碼");
                return;
            }


            if (tbPWassure.Text == "")
            {
                MessageBox.Show("請輸入密碼確認");
                return;
            }

            if (tbcell.Text == "")
            {
                MessageBox.Show("請輸入會員電話");
                return;
            }

            //chk if alreadiy exists
            check_valid_teacher(tbAccount.Text);
            if (is_user_exists == "1")
            {
                MessageBox.Show("此會員帳號已存在");
                return;
            }

            //chk if password eqaul
            if (tbPassword.Text != tbPWassure.Text)
            {
                MessageBox.Show("密碼輸入不一致");
                return;
            }

            addteacherInfo();
        }
        public void addteacherInfo()
        {

            SqlTransaction transaction = null;

            //del from purchase bt 
            sqlQuery = getSQL.Add_teacher_Info(tbAccount.Text, tbName.Text, tbPassword.Text, tbcell.Text);
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
                MessageBox.Show("註冊成功 :)");
            }
            catch (Exception error)
            {

                transaction.Rollback();
                MessageBox.Show("會員註冊過程發生問題,請至登入頁確認");

            }


        }

        public void addMemberInfo() {

            SqlTransaction transaction = null;

            //del from purchase bt 
            sqlQuery = getSQL.Add_Member_Info(tbAccount.Text,tbName.Text,tbPassword.Text,tbcell.Text, cbxMbrTeacher.Text);
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
                MessageBox.Show("註冊成功 :)");
            }
            catch (Exception error)
            {

                transaction.Rollback();
                MessageBox.Show("會員註冊過程發生問題,請至登入頁確認");

            }


        }
        public void check_valid(string input_id)
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
                        is_user_exists = "1";
                    }
                }
                else
                {
                    is_user_exists = "0";
                }
                reader.Close();
            }
            Form1.con.Close();

        }

        public void check_valid_teacher(string input_id)
        {
            sqlQuery = getSQL.Check_teacher_Duplicate(input_id);
            Form1.con.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, Form1.con))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        is_user_exists = "1";
                    }
                }
                else
                {
                    is_user_exists = "0";
                }
                reader.Close();
            }
            Form1.con.Close();

        }









        //no need
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucNewMember_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
