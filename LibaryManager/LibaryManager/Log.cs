using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LibaryManager
{
    public partial class Log : Form
    {
        static string ConnectString = "Data Source=.;Initial Catalog=LibraryManageSystem;User ID=Admin;Pwd=123456";     //登录数据库时的用户名及密码
        static SqlConnection connection;
        static SqlCommand sc;
        void Init()
        {
            connection = new SqlConnection(ConnectString);

        }
        //public bool SqlExec(string sql)   //数据的update delete insert 
        //{
        //    Init();
        //    sql = string.Format(sql);    //格式化
        //    sc = new SqlCommand(sql, connection);
        //    connection.Open();
        //    int rows = sc.ExecuteNonQuery();
        //    connection.Close();
        //    if (rows > 0)
        //        return true;
        //    else
        //    {
        //        return false;
        //    }


        //}
        //public DataSet SqlQuery(string sql)    //用户数据库的查询
        //{
        //    Init();
        //    sda = new SqlDataAdapter(sql, connection);
        //    DataSet ds = new DataSet();
        //    sda.Fill(ds);
        //    connection.Close();
        //    return ds;

        //}
        public Log()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = username_tx.Text.Trim();
            username = "'" + username + "'";
            Init();
            string sql = "select Password from AdminTable where UserName=" + username;
            sc = new SqlCommand(sql, connection);
            connection.Open();
            string Userpw = (string)sc.ExecuteScalar();
            if (Userpw == null)
            {
                MessageBox.Show(this, "无效用户名");

            }
            else if (Userpw == Pw_tx.Text.Trim())      //登录成功
            {
                Main_window Main_window = new Main_window(this);
                Main_window.Show(); 

                this.Visible = false;
            }
            else
            {
                MessageBox.Show("密码错误");

            }

            connection.Close();
        }

        private void Reg_Bt_Click(object sender, EventArgs e)
        {
            string sql_query, sql_reg;
            int UserCount;
            sql_query = "select Count(*) from AdminTable where UserName=" + "'" + username_tx.Text.Trim() + "'";
            sql_reg = "insert AdminTable values(" + "'" + username_tx.Text.Trim() + "'" + "," + "'" + Pw_tx.Text.Trim() + "'" + ")";
            Init();
            connection.Open();
            sc = new SqlCommand(sql_query, connection);     //先执行查询，看用户名是否被注册，若被注册则提示注册失败
            UserCount = (int)sc.ExecuteScalar();
            if (UserCount > 0)
            {

                MessageBox.Show("此用户名已存在，请重新输入");

            }
            else
            {
                SqlCommand sc_1;
                sc_1 = new SqlCommand(sql_reg, connection);
                sc_1.ExecuteNonQuery();
                MessageBox.Show("注册成功 请重新登录");
            }

            connection.Close();
        }
    }
}
