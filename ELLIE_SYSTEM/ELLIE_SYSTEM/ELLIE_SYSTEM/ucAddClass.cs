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
using System.Diagnostics.Eventing.Reader;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;

namespace ELLIE_SYSTEM
{
    public partial class ucAddClass : UserControl
    {
        DataSet dsRemainClassList = new DataSet();
        string sqlQuery,sqlQuery1,sqlQuery2;
        string wrong_input_message;
        string current_time, student_id,student_name,price,class_number, class_type;
        bool isIllegal;
        public ucAddClass()
        {
            InitializeComponent();
        }

        public void RefreshAddClassInfo()
        {
            get_class_type();
            dsRemainClassList.Clear();
            sqlQuery = getSQL.getRemainClassList(tbxAdName.Text, class_type);
            Form1.con.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, Form1.con))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (DataTable dataTable = new DataTable())
                    {
                        sda.Fill(dataTable);
                        dgvRemainClassList.DataSource = dataTable;
                    }
                }
            }
            Form1.con.Close();
            dgvRemainClassList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            //==============get all input ================================

            //get class type  
            get_class_type();

            //get student name
            student_name = tbxAdName.Text;

            // chk has this student and get student id
             Check_valid_student(tbxAdName.Text);
            if (Chk_input_illegal(student_id)){
                MessageBox.Show(student_id);
                return;
            }

            //check price and amount 
            class_number = Chk_Price_amount(tbxAmount.Text);
            if (Chk_input_illegal(class_number))
            {
                MessageBox.Show(class_number);
                return;
            }



            price = Chk_Price_amount(tbxPrice.Text);
            if (Chk_input_illegal(price))
            {
                MessageBox.Show(price);
                return;
            }



            //get record time
            DateTime now = DateTime.Now;
            // MessageBox.Show(now.ToString("yyyy-MM-dd H:mm:ss"));
            current_time = now.ToString("yyyy-MM-dd H:mm:ss");


            //============== add data ================================

            for (int i = 0; i < Int32.Parse(class_number); i++)
            {
                try
                {
                    //
                    addOneClass(student_id, student_name, price, class_type, current_time);
                }
                catch (Exception error)
                {
                   // MessageBox.Show
                    MessageBox.Show("注意,本次僅成功新增" + i.ToString() + "堂課,請按查詢檢視結果");
                    Form1.con.Close();
                    return;
                }
            }
            MessageBox.Show("新增完畢");
            // addOneClass(student_id, student_name, price, class_type, current_time);
            RefreshAddClassInfo();

        }
        public bool Chk_input_illegal(string inputstr) {
            return inputstr.Contains("[INVALID]");
          
        }

        private void splitContainer5_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvRemainClassList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
                                                dgvRemainClassList.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                                dgvRemainClassList.RowHeadersDefaultCellStyle.Font,
                                rectangle,
                                dgvRemainClassList.RowHeadersDefaultCellStyle.ForeColor,
                                TextFormatFlags.VerticalCenter | TextFormatFlags.Right
                                );

        }

        private void dgvRemainClassList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string Chk_Price_amount(string input_amount) {
            if (input_amount.IsNullOrEmpty())
            {
                return "[INVALID]請輸入金額或堂數";
            }
            else if (!(check_valid_int(input_amount))) {
                return "[INVALID]金額或堂數非整數";
            }
             else {
                return input_amount;

            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshAddClassInfo();
        }

        public void get_class_type() {

            if (rbtraining.Checked)
            {
                class_type = "0";
            }
            else if (rbrelax.Checked)
            {
                class_type = "1";
            }
            else if (rbcommon.Checked)
            {
                class_type = "2";
            }
            else {
                class_type = "3";
            }

        }
        public bool check_valid_int(string input_amount) {

           return  int.TryParse(input_amount, out int n);
        }
        public void Check_valid_student(string input_student_name) {
            //getUserid
            //label
            student_id = null;
            sqlQuery = getSQL.getUserid(input_student_name);
            Form1.con.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, Form1.con))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                int ttt = reader.FieldCount;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        student_id = reader.GetString(0);
                    }
                }
                else{
                    student_id = "[INVALID] No registered student, please check input name";
                }
                reader.Close();
            }
            Form1.con.Close();
           
        }

      


        public void addOneClass(String input_student_id, String input_student_name, String input_price, String input_class_type, String input_record_time)
        {
            //add one class to addclass bt and add class bth
            //when consume del 1 class from add class bt and add 1 class to record
            SqlTransaction transaction = null;
            sqlQuery1 = getSQL.InsertPurchaseRecord(input_student_id, input_student_name, input_price, input_class_type, input_record_time);
            sqlQuery2 = getSQL.InsertPurchaseRecordHistory(input_student_id, input_student_name, input_price, input_class_type, input_record_time);
            //try
            //{
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
                transaction.Commit();
                Form1.con.Close();
           // }
            //catch (Exception error)
            //{

            //    transaction.Rollback();
            //    MessageBox.Show("加課失敗");
            //    Form1.con.Close();

            //}


        }

        public void Check_valid_input(string input_price, string input_amount)
        {
        
        }

    }
}
