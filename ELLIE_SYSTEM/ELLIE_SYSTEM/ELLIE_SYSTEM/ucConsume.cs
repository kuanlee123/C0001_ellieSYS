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
    public partial class ucConsume : UserControl
    {
        string sqlQuery, sqlQuery1,sqlQuery2,sqlQuery3 ;
        DataSet ds = new DataSet();
        int current_remain_class,current_remain_class_relax,current_remain_class_common;
        string teacher_id, buy_price;
        string consume_class_type = "0";
        string real_class_type;
        DialogResult dr;
       
        public ucConsume()
        {
            InitializeComponent();
        }

        public void refreshuser() {
            
            lbCurUser.Text ="";
            cbxTeacherList.Text = "";


            //label
            sqlQuery = getSQL.getUserName((string)ucLogin.currentUser);
            Form1.con.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, Form1.con))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                int ttt = reader.FieldCount;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lbCurUser.Text = reader.GetString(0);
                    }
                }
                reader.Close();
            }
            Form1.con.Close();


            refresh_remain_class_label();

            //cbx
            cbxTeacherList.Items.Clear();

            sqlQuery = getSQL.getTeacherList((string)ucLogin.currentUser);
            Form1.con.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, Form1.con)) {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                        cbxTeacherList.Items.Add(reader.GetString(0));
                    }
                }
                reader.Close();
            }
            Form1.con.Close();

            if (lbCurUser.Text != "")
            { cbxTeacherList.SelectedIndex = 0; }

            //DGV
            refresh_record();

        }

        public void MinusOneClass(string student_id,string student_name, string teacher_id, string teacher_name, string price, string class_type, string input_real_class_type)
        { 
             SqlTransaction transaction = null;

            //del from purchase bt 
            sqlQuery1 = getSQL.DeleteOnePurchaseBt(student_id, price, class_type);

            //update purchase ht
            sqlQuery2 = getSQL.UpdateOnePurchaseHt(student_id, price, class_type);
           
            //add consume record
            sqlQuery3 = getSQL.InsertConsumeRecord(student_id, student_name, teacher_id, teacher_name, price, input_real_class_type);
                   

                try
                {
                    Form1.con.Open();
                    transaction = Form1.con.BeginTransaction();
                    using (SqlCommand cmd = new SqlCommand(sqlQuery1, Form1.con))
                    {
                      cmd.Transaction = transaction;
                      cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd = new SqlCommand(sqlQuery2, Form1.con))
                    {
                       cmd.Transaction = transaction;
                       cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd = new SqlCommand(sqlQuery3, Form1.con))
                    {
                        cmd.Transaction = transaction;
                        cmd.ExecuteNonQuery();
                    }
                transaction.Commit();
                  Form1.con.Close();
            }
                catch(Exception error) {

                        transaction.Rollback();
                        MessageBox.Show("扣課失敗");

                }
              
        }

        public int get_RemainClass(string inpur_class_type)
        {
            int rc = 0;
            sqlQuery = getSQL.getUserConsumeClass((string)ucLogin.currentUser, inpur_class_type);
            Form1.con.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, Form1.con))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        rc = reader.GetInt32(0);
                    }
                }
                reader.Close();
            }
            Form1.con.Close();
            return rc;

        }

        public void refresh_remain_class_label() {


            //remain class
            lbRemainClass_t.Text = "0";
            current_remain_class = get_RemainClass("0");
            lbRemainClass_t.Text = current_remain_class.ToString();

            lbRemainClass_r.Text = "0";
            current_remain_class_relax = get_RemainClass("1");
            lbRemainClass_r.Text = current_remain_class_relax.ToString();

            lbRemainClass_c.Text = "0";
            current_remain_class_common = get_RemainClass("2");
            lbRemainClass_c.Text = current_remain_class_common.ToString();

            lbRemainClass_M.Text = "0";
            current_remain_class_common = get_RemainClass("3");
            lbRemainClass_M.Text = current_remain_class_common.ToString();

        }

        public void refresh_record() {

            ds.Clear();
            sqlQuery = getSQL.getUserConsumeRecord((string)ucLogin.currentUser);
            Form1.con.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, Form1.con))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (DataTable dataTable = new DataTable())
                    {
                        sda.Fill(dataTable);
                        dgvConsume.DataSource = dataTable; 
                    }
                } 
            }
            Form1.con.Close();


        }
        public void get_consume_class_type()
        {

            if (rbc_t.Checked)
            {
                real_class_type = "0";
                consume_class_type = "0";
            }
            else if (rbc_r.Checked)
            {
                real_class_type = "1";
                consume_class_type = "1";
            }
            else if (rbc_c.Checked)
            {

                CreateMyForm();
                consume_class_type = "2";
            }
            else {
                real_class_type = "3";
                consume_class_type = "3";


            }

        }
        private void cbxTeacherList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void lbRemainClass_r_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void update_remain_class(string input_user_name, int input_remain_class) { 
        
        
        }

        public string Get_Buy_Price(string input_stu_id, string input_class_type)
        {
            //getUserid
            //label
            buy_price = null;
            sqlQuery = getSQL.GetBuyPrice(input_stu_id, input_class_type);
            Form1.con.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, Form1.con))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                int ttt = reader.FieldCount;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        buy_price = reader.GetInt32(0).ToString();
                    }
                }
                else
                {
                    buy_price = "[INVALID] No record";
                }
                reader.Close();
            }
            Form1.con.Close();

            return buy_price;


        }

        public void CreateMyForm()
        {
            // Create a new instance of the form.
            Form form1 = new Form();
            form1.ControlBox = false;
            //form1.StartPosition = ContentAlignment.MiddleCenter;
            // Create two buttons to use as the accept and cancel buttons.
            Button button1 = new Button();
            Button button2 = new Button();
            Label label1 = new Label();
            // Set the text of button1 to "OK".
            button1.Text = "訓練";
            // Set the position of the button on the form.
            button1.AutoSize = true;
            button1.Left = (form1.Width - button1.Width) / 2-10;
            button1.Top = (form1.Height - button1.Height) /3;

            button2.Text = "放鬆";
            button2.AutoSize = true;
            button2.Location// = new Point(x,y-5);
            = new Point(button1.Left, button1.Height + button1.Top + 20);

            //  label position
            label1.Text = "請選擇上課內容";
            label1.AutoSize = true;

            // x = (int)(0.5 * (form1.Width - label1.Width)); // - button1.Width;
            // y = (int)(0.3 * (form1.Height - label1.Height));
            label1.Location
             = new Point(button1.Left - label1.Width/2+15, (int)(0.2 * (form1.Height - label1.Height)));
            //label1.TextAlign = ContentAlignment.MiddleCenter;
            // Make button1's dialog result OK.
            button1.DialogResult = DialogResult.OK;
            // Make button2's dialog result Cancel.
            button2.DialogResult = DialogResult.Cancel;
            // Set the caption bar text of the form.   
           // form1.Text = "選擇上課內容";

            // Define the border style of the form to a dialog box.
            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the accept button of the form to button1.
            form1.AcceptButton = button1;
            // Set the cancel button of the form to button2.
            form1.CancelButton = button2;
            // Set the start position of the form to the center of the screen.
            form1.StartPosition = FormStartPosition.CenterParent;

            // Add button1 to the form.
            form1.Controls.Add(button1);
            // Add button2 to the form.
            form1.Controls.Add(button2);

            form1.Controls.Add(label1);

            // Display the form as a modal dialog box.
            form1.ShowDialog();

            // Determine if the OK button was clicked on the dialog box.
            if (form1.DialogResult == DialogResult.OK)
            {
                // Display a message box indicating that the OK button was clicked.
                // MessageBox.Show("The OK button on the form was clicked.");
                real_class_type = "0";
                // Optional: Call the Dispose method when you are finished with the dialog box.
                form1.Dispose();
            }
            else
            {
                // Display a message box indicating that the Cancel button was clicked.
                real_class_type = "1";
                // Optional: Call the Dispose method when you are finished with the dialog box.
                form1.Dispose();
            
            }
        }

        private void btnConsumeClass_Click(object sender, EventArgs e)
        {
            
  
            //class type
            get_consume_class_type();
       
            //if (consume_class_type == "2") {
              

            //    dr= MessageBox.Show("Are you happy now?","Mood Test", MessageBoxButtons.YesNo);
            //    switch (dr)
            //    {
            //        case DialogResult.Yes:
            //            break;
            //        case DialogResult.No:
            //            break;
            //    }
            //}
            int remain_class_before_consume = 0;
            remain_class_before_consume = get_RemainClass(consume_class_type); 
            if (remain_class_before_consume <= 0) {
                MessageBox.Show("目前無剩餘堂數");
                return;
            }
          

            //get SP input
            //get teacher id
            
            sqlQuery = getSQL.getTeacherIDbyName((string)cbxTeacherList.Text);
            Form1.con.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, Form1.con))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        teacher_id  = reader.GetString(0);
                    }
                }
                reader.Close();
            }
            Form1.con.Close();

            //get buy price
            Get_Buy_Price((string)ucLogin.currentUser, consume_class_type);

            //update  remain class and insert log
            MinusOneClass((string)ucLogin.currentUser, lbCurUser.Text, teacher_id,cbxTeacherList.Text,buy_price, consume_class_type, real_class_type);
            //lbRemainClass_t.Text= get_RemainClass().ToString();
            refresh_remain_class_label();
            refresh_record();




        }
    }
}
