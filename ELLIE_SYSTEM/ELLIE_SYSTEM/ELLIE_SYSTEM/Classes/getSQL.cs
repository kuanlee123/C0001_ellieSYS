using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;



namespace ELLIE_SYSTEM.Classes
{
    internal class getSQL
    {
       
        // string sqlQuery;
        ////public void test(string input_id, string input_name, string input_password)
        ////{

        ////    sqlQuery = "Insert into MFG_STUDENT_INFO_BT(STUDENT_ID,STUDENT_NAME,STUDENT_PASSWORD) VALUES(@STUDENT_ID,@STUDENT_NAME,@STUDENT_PASSWORD)";
        ////    //SqlConnection con = new SqlConnection(ConnectionStr);
        ////    con.Open();
        ////    SqlCommand sc = new SqlCommand(sqlQuery, con);

        ////    var STUDENT_ID = new SqlParameter("STUDENT_ID", System.Data.SqlDbType.VarChar);
        ////    STUDENT_ID.Value = input_id;
        ////    sc.Parameters.Add(STUDENT_ID);

        ////    var STUDENT_NAME = new SqlParameter("STUDENT_NAME", System.Data.SqlDbType.VarChar);
        ////    STUDENT_NAME.Value = input_name;
        ////    sc.Parameters.Add(STUDENT_NAME);

        ////    var STUDENT_PASSWORD = new SqlParameter("STUDENT_PASSWORD", System.Data.SqlDbType.VarChar);
        ////    STUDENT_PASSWORD.Value = input_password;
        ////    sc.Parameters.Add(STUDENT_PASSWORD);

        ////    sc.ExecuteNonQuery();
        ////    con.Close();
        ////}

        public static String getTeacherList(String input_studentid) {
             return
                "select t.name " +
                 "from ( " +
                 "select case when exists(select 1 " +
                 "from mfg_student_info_bt s " +
                 "where s.id = "+ "'"+input_studentid+"'"+
                 "and s.default_teacher_id = t.id " +
                 ") then 1 else 0 end is_default_teacher, t.* " +
                 "from mfg_teacher_info_bt t " +
                 ")t " +
                 "order by is_default_teacher desc, id asc";
            ////con.Open();    
            //using (SqlCommand cmd = new SqlCommand(sqlQuery, con)) {
            //    SqlDataReader reader = cmd.ExecuteReader();
            //}
        }

        public static String getUserName(String input_studentid)
        {
            return
                "select name from mfg_student_info_bt t where t.id = "+ "'" + input_studentid + "'";
              
        }

        public static String getUserid(String input_studentname)
        {
            return
                "select id from mfg_student_info_bt t where t.name = " + "'" + input_studentname + "'";

        }

        public static String getUserConsumeRecord(String input_studentid)
        {
            return
                "select t.recordtime 消費時間,t.student_name 學生姓名, t.teacher_name 上課老師"+
                ",case when class_type= '0' then '訓練' " +
                "      when class_type= '1' then '放鬆' " +
                "      when class_type= '2' then '共同' " +
                "      else '淋巴' end 課別 " +
                " from mfg_consume_record_ht t where t.student_id = " + "'" + input_studentid + "'"+
                "and t.recordtime > DATEADD(d,-30,GETDATE())"+
                "order by t.recordtime desc"
                ;

        }

        public static String getRemainClassList(String input_studentname, String input_class_type)
        {
            return
                "select t.student_name 學生, t.price 購買價格, t.recordtime 購課時間 from mfg_purcHase_record_bt t " +
                "where t.student_name = " + "'" + input_studentname + "'" +
                " and t.class_type = " + input_class_type +
                " order by t.recordtime asc";

        }

        public static String getUserConsumeClass(String input_studentid, String input_class_type)
        {
            return
                     "select count(1) remain_class from MFG_PURCHASE_RECORD_BT t where t.student_id = " + "'" + input_studentid + "' "+
                     " and t.class_type = " + input_class_type 
                     ;

        }

        public static String getTeacherIDbyName(String input_teacher_name)
        {
            return
                     "select id from mfg_teacher_info_bt t where t.name = " + "'" + input_teacher_name + "'";
        }

        public static String updateRemainClass(String input_student_id, string input_new_remain_class) {
            return "UPDATE mfg_student_info_bt SET remain_class = " + input_new_remain_class+  " WHERE id = " + "'" + input_student_id + "'";
        }

        public static String InsertConsumeRecord(String input_student_id, String input_student_name, String input_teacher_id, String input_teacher_name,string input_price,string input_class_type)
        {
            return 

            "insert into mfg_consume_record_ht(student_id, student_name, teacher_id, teacher_name, recordtime,price,class_type) " +
            "values( " +
                "'" + input_student_id + "', " +
                "'" + input_student_name + "', " +
                "'" + input_teacher_id + "', " +
                "'" + input_teacher_name + "', " +
                "GETDATE(), " +
                "'" + input_price + "', " +
                "'" + input_class_type + "'" +
                ")";
        }

        public static String DeleteOnePurchaseBt(String input_student_id, string input_price, string input_class_type)
        {
            return

                    "WITH del as " +
                    "( " +
                    " select TOP 1 * " +
                    " from( " +
                              "select " +
                               "ROW_NUMBER() over(partition by 1 order by recordtime asc) del_order " +
                               ", t.* from mfg_purchase_record_bt t " +
                               "where t.student_id = " + "'" + input_student_id + "' "+
                               " and t.price = " + input_price+
                               " and t.class_type = " + input_class_type +
                               ")t " +
                               "ORDER BY del_order ASC " +
                               ") " +
                               "DELETE del ";
        }

        public static String UpdateOnePurchaseHt(String input_student_id, string input_price, string input_class_type)
        {
            return

                    "WITH UPDATE_INFO as " +
                    "( " +
                    " select TOP 1 * " +
                    " from( " +
                              "select " +
                               "ROW_NUMBER() over(partition by 1 order by recordtime asc) update_order " +
                               ", t.* from mfg_purchase_record_ht t " +
                               "where t.student_id = " + "'" + input_student_id + "' " +
                               " and t.price = " + input_price +
                               " and t.class_type = " + input_class_type +
                               " and t.status = 'INI'"+
                               ")t " +
                               "ORDER BY update_order ASC " +
                               ") " +
                               "UPDATE UPDATE_INFO SET STATUS = 'SPENT', USE_TIME = GETDATE() ";
        }

        public static String GetBuyPrice(String input_student_id, String input_class_type)
        {
            return

             "select price " +
             "from " +
             "( " +
                 " select" +
                 " ROW_NUMBER() over(partition by 1 order by recordtime asc) consume_order" +
                 ", t.* from mfg_purchase_record_bt t" +
                 "  where t.student_id = " + "'" + input_student_id + "'" +
                 " and t.class_type = " + input_class_type +
             ")t " +
                 "where t.consume_order = 1 ";
        }

        public static String InsertPurchaseRecord(String input_student_id, String input_student_name, String input_price, String input_class_type, String input_record_time)
        {
            return

            "insert into mfg_purchase_record_bt(student_id, student_name, price, class_type, recordtime) " +
            "values( " +
                "'" + input_student_id + "', " +
                "'" + input_student_name + "', " 
                    + input_price + ", " +
                      input_class_type + ", "+
                "'" + input_record_time + "' " +
                ")";
        }

        public static String InsertPurchaseRecordHistory(String input_student_id, String input_student_name, String input_price, String input_class_type, String input_record_time)
        {
            return

            "insert into mfg_purchase_record_ht(student_id, student_name, price, class_type, recordtime,status) " +
            "values( " +
                "'" + input_student_id + "', " +
                "'" + input_student_name + "', "
                    + input_price + ", " +
                      input_class_type + ", "+
                "'" + input_record_time + "' " +
                     ", 'INI'" +
                ")";
        }

        public static String GetEmploySalary(String input_teacher_name, String input_start_time,String input_end_time)
        {
            return
                "select t.teacher_name 老師, t.recordtime 時間, t.student_name 學生, " +
                       "case when t.class_type = 0 then '訓練' " +
                            "when t.class_type = 1 then '放鬆' " +
                            "else '淋巴' end as 課別, " +
                       "(t.price * t.is_relax) relax_salary, " +
                       "(t.price * t.is_massage) massage_salary, " +
                       "t.is_train, t.is_relax,t.is_massage " +
                "from( " +
                        "select t.*, " +
                        "case when t.class_type = '0' then 1 else 0 end is_train, " +
                        "case when t.class_type = '1' then 1 else 0 end is_relax, " +
                        "case when t.class_type = '3' then 1 else 0 end is_massage " +
                        "from mfg_consume_record_ht t " +
                       "where t.teacher_NAME = " + "'" + input_teacher_name + "'" +
                         "and t.recordtime > = convert(datetime, " + "'" + input_start_time + "'" + " , 120)" +
                         "and t.recordtime < convert(datetime, " + "'" + input_end_time + "'" + " , 120) " +
                      ")t "+
                      "order by t.recordtime asc"
                ;
            
        }
        public static String GetEmploySalarywithoutPrice(String input_teacher_name, String input_start_time, String input_end_time)
        {
            return
                      "select t.teacher_name 老師, t.recordtime 時間, t.student_name 學生, " +
                       "case when t.class_type = 0 then '訓練' " +
                            "when t.class_type = 1 then '放鬆' " +
                            "else '淋巴' end as 課別, " +
                            "t.is_train, t.is_relax,t.is_massage " +
                "from( " +
                        "select t.*, " +
                        "case when t.class_type = '0' then 1 else 0 end is_train, " +
                        "case when t.class_type = '1' then 1 else 0 end is_relax, " +
                        "case when t.class_type = '3' then 1 else 0 end is_massage " +
                        "from mfg_consume_record_ht t " +
                       "where t.teacher_NAME = " + "'" + input_teacher_name + "'" +
                         "and t.recordtime > = convert(datetime, " + "'" + input_start_time + "'" + " , 120)" +
                         "and t.recordtime < convert(datetime, " + "'" + input_end_time + "'" + " , 120) " +
                      ")t "+
                         "order by t.recordtime asc"
                ;

        }

        public static String Check_priv(String input_id, String input_password)
        {
            return
                   "SELECT h.id, " +
                   "       case when h.password = " + "'" + input_password + "'" + " then 'pass' else 'fail' end pass_word_ok, " +
                   "       h.privilege, " +
                   "       h.name " +
                   "FROM " +
                   " ( " +
                   "select s.id, s.password, 'STUDENT' privilege,s.name from mfg_student_info_bt s " +
                   "union all " +
                   "select t.id, t.password, t.privilege,t.name from mfg_teacher_info_bt t " +
                   ") h " +
                   "where h.id = " + "'" + input_id + "'"  ;               
 
        }
        public static String Check_User_Duplicate(String input_id)
        {
            return
                   "SELECT *  " +
                   "FROM mfg_student_info_bt t " +
                   "where t.id = " + "'" + input_id + "'";

        }

        public static String Check_teacher_Duplicate(String input_id)
        {
            return
                   "SELECT *  " +
                   "FROM mfg_teacher_info_bt t " +
                   "where t.id = " + "'" + input_id + "'";

        }

        public static String Add_Member_Info(String input_id, String input_name, String input_password, String input_cell,String input_default_teacher)
        {
            return
            "insert into mfg_student_info_bt " +
            "select " + "'" + input_id + "'" + " id, " +
                       "'" + input_name + "'" + " name, " +
                       "'" + input_password + "'" + " password, " +
                       "(" +
                       "select max(k.id) from mfg_teacher_info_bt k " +
                       "where k.name = " + "'" + input_default_teacher + "'" +
                       ") default_teachet_id, "+
                       "'" + input_cell + "'" + " cellphone" ;

        }

        public static String Add_teacher_Info(String input_id, String input_name, String input_password, String input_cell)
        {
            return
            "insert into mfg_teacher_info_bt " +
            "select " + "'" + input_id + "'" + " id, " +
                       "'" + input_name + "'" + " name, " +
                       "'" + input_password + "'" + " password, " +
                       "'NORMAL' privilege, " +
                       "'" + input_cell + "'" + " cellphone";

        }

        public static String updatepassword(String input_id, String input_password)
        {
            return
                    "update mfg_student_info_bt " +
                    "set password = " + "'" + input_password + "'" +
                    "where id = " + "'" + input_id + "'";

        }

    }
}
