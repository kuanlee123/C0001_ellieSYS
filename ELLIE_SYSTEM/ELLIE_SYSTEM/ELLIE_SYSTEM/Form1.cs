using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using ELLIE_SYSTEM.Classes;

namespace ELLIE_SYSTEM
{
    public partial class Form1 : Form
    {
        ucLogin myUcLogin = new ucLogin();
        ucConsume myUcConsume = new ucConsume();
        ucAddClass myUcAddClass = new ucAddClass();
        ucEmploySalary myUcEmploySalary = new ucEmploySalary();
        ucNewMember myUcNewMember = new ucNewMember();
        ucForgotPw myUcForgotPW = new ucForgotPw();


        public static string ConnectionStr = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public static SqlConnection con = new SqlConnection(ConnectionStr);
        public static bool sentfromlogout;

            
        

        public Form1()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);

            //Initial tab page and corresponding uc control
            myUcLogin.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(myUcLogin);
            myUcConsume.Dock = DockStyle.Fill;
            tabPage2.Controls.Add(myUcConsume);
            myUcAddClass.Dock = DockStyle.Fill;
            tabPage3.Controls.Add(myUcAddClass);
            myUcEmploySalary.Dock = DockStyle.Fill;
            tabPage4.Controls.Add(myUcEmploySalary);
            myUcNewMember.Dock = DockStyle.Fill;
            tabPage5.Controls.Add(myUcNewMember);
            myUcForgotPW.Dock = DockStyle.Fill;
            tabPage6.Controls.Add(myUcForgotPW);



            //initial page
            button2.Visible = false;
            ucLogin.changeTabpageEvent += new ucLogin.changeTabPage(selectedTabpage);



        }

        

        public void selectedTabpage(int input) {
            this.tabControl1.SelectedIndex = input;
        }
        

        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            SolidBrush _Brush = new SolidBrush(Color.RosyBrown);
            RectangleF _TabTextArea = (RectangleF)tabControl1.GetTabRect(e.Index);
            StringFormat _sf = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            _sf.LineAlignment = StringAlignment.Center;
            _sf.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(tabControl1.Controls[e.Index].Text, SystemInformation.MenuFont, _Brush, _TabTextArea, _sf);

        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    testInsertData();
           
            
        //}

        void testInsertData()
        {
            string stu_id = "AAA";
            string stu_name = "BBB";
            string stu_password = "CCC";

            getSQL logintest = new getSQL();
           // logintest.test(stu_id, stu_name, stu_password);

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex) { 
                case 0:
                    button2.Visible = false;
                    myUcLogin.ucLogin_Load();
                    myUcConsume.refreshuser();
                    myUcEmploySalary.set_gui_by_priv();
                    break;
                case 1:
                    button2.Visible = true;
                    myUcConsume.refreshuser();
                    break;
                case 2:
                    button2.Visible = true;
                    break;
                case 3:
                    button2.Visible = true;
                    myUcEmploySalary.set_gui_by_priv();
                    break;
                case 4:
                    myUcNewMember.refreshumember();
                    button2.Visible = true;
                    break;
                case 5:
                    myUcForgotPW.refreshReset();
                    break;


                    //break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sentfromlogout=true;
            selectedTabpage(0);
            //ucLogin.changeTabpageEvent += new ucLogin.changeTabPage(0);
        }
    }
}