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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ELLIE_SYSTEM
{

    public partial class ucEmploySalary : UserControl
    {
        string sqlQuery;
        string starttime, endtime;
        DataSet ds = new DataSet();
        int total_class_number, relax_class_number, relax_income, massage_class_number, massage_income, train_class_number;
        public ucEmploySalary()
        {
            InitializeComponent();
            get_all_employ();
            cbx_employee.SelectedIndex = 0;
        }
        public void get_all_employ() {
            cbx_employee.Items.Clear();
            sqlQuery = getSQL.getTeacherList("noneed");
            Form1.con.Open();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, Form1.con))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        cbx_employee.Items.Add(reader.GetString(0));
                    }
                }
                reader.Close();
            }
            Form1.con.Close();
        }

        private void cbx_employee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void set_gui_by_priv() {

            //dgvSalaryCnt.Rows.Clear();
            //dgvSalaryCnt.Refresh();
            cbx_employee.Enabled = false;
            label2.Visible = false;
            lbRelaxIncome.Visible = false;
            labelMA.Visible = false;
            lbMassageA.Visible = false;
            cbx_employee.Text = ucLogin.currentUserName;
            if (ucLogin.user_privilege == "ADMIN") {
                cbx_employee.Enabled = true;
                label2.Visible = true;
                lbRelaxIncome.Visible = true;
                labelMA.Visible = true;
                lbMassageA.Visible = true;
            }
            button1_Click(this, new EventArgs());

        }

        private void button1_Click(object sender, EventArgs e)
        {

            lbtrainN.Text ="";
            lbRelaxN.Text = "";
            lbRelaxIncome.Text = "";
            lbMassageA.Text = "";
            lbMassage.Text ="";
            starttime = dtp_start.Text + " 00:00:00";
            endtime = dtp_end.Text + " 23:59:59";

            if (ucLogin.user_privilege == "ADMIN")
            {
                ds.Clear();
                sqlQuery = getSQL.GetEmploySalary(cbx_employee.Text, starttime, endtime);
                Form1.con.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, Form1.con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dataTable = new DataTable())
                        {

                            sda.Fill(dataTable);
                            dgvSalaryCnt.DataSource = dataTable;

                            if (dataTable.Rows.Count == 0)
                            {
                                //MessageBox.Show("無資料");
                                Form1.con.Close();
                            }
                            else
                            {
                                //presum
                                total_class_number = Convert.ToInt32(dataTable.Compute("COUNT(時間)", null));
                                relax_class_number = Convert.ToInt32(dataTable.Compute("SUM(is_relax)", null));
                                relax_income = Convert.ToInt32(dataTable.Compute("SUM(relax_salary)", null));
                                massage_class_number = Convert.ToInt32(dataTable.Compute("SUM(is_massage)", null));
                                massage_income = Convert.ToInt32(dataTable.Compute("SUM(massage_salary)", null));
                                train_class_number = Convert.ToInt32(dataTable.Compute("SUM(is_train)", null));

                                lbtrainN.Text = train_class_number.ToString();
                                lbRelaxN.Text = relax_class_number.ToString();
                                lbRelaxIncome.Text = (relax_income).ToString();
                                lbMassage.Text = (massage_class_number).ToString();
                                lbMassageA.Text= (massage_income).ToString();

                            }


                        }
                    }
                }
                Form1.con.Close();
                // MessageBox.Show(dtp_start.Text);
                dgvSalaryCnt.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            else {

                ds.Clear();
                sqlQuery = getSQL.GetEmploySalarywithoutPrice(cbx_employee.Text, starttime, endtime);
                Form1.con.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, Form1.con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dataTable = new DataTable())
                        {

                            sda.Fill(dataTable);
                            dgvSalaryCnt.DataSource = dataTable;

                            if (dataTable.Rows.Count == 0)
                            {
                                //MessageBox.Show("無資料");
                                Form1.con.Close();
                            }
                            else
                            {
                                //presum
                                total_class_number = Convert.ToInt32(dataTable.Compute("COUNT(時間)", null));
                                relax_class_number = Convert.ToInt32(dataTable.Compute("SUM(is_relax)", null));
                                massage_class_number = Convert.ToInt32(dataTable.Compute("SUM(is_massage)", null));
                                train_class_number = Convert.ToInt32(dataTable.Compute("SUM(is_train)", null));

                                lbtrainN.Text = train_class_number.ToString();
                                lbRelaxN.Text = relax_class_number.ToString();
                                lbMassage.Text = (massage_class_number).ToString();
                              
                            }


                        }
                    }
                }
                Form1.con.Close();
                dgvSalaryCnt.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            }
            
        }
    }
}
