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
    public partial class Bor_Ret : Form
    {
        static string ConnectString = "Data Source=.;Initial Catalog=LibraryManageSystem;User ID=Admin;Pwd=123456";     //登录数据库时的用户名及密码
        static SqlConnection connection;
        static SqlCommand sc;
        void Init()
        {
            connection = new SqlConnection(ConnectString);

        }

        public Bor_Ret()
        {
            InitializeComponent();
        }

        private void Bor_Ret_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)   //图书外借
        {
            string sqlUserTable = "insert UserTable values(" + "'" + StuName.Text.Trim() + "'" + "," + Bk_ID.Text.Trim() + ")";
            string sqlupdate = "update BookTable set BorrowNumber+=1,StoreNumber-=1 where ID=" + Bk_ID.Text.Trim();
            Init();
            connection.Open();
            sc = new SqlCommand(sqlUserTable, connection);
            sc.ExecuteNonQuery();
            sc = new SqlCommand(sqlupdate, connection);
            sc.ExecuteNonQuery();
            MessageBox.Show(this, "外借成功");
            connection.Close();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlUserTable = "delete from  UserTable where UserId= " + "'" + StuName.Text.Trim() + "'" + " " + "and BorBookID=" + Bk_ID.Text.Trim();
            string sqlupdate = "update BookTable set BorrowNumber-=1,StoreNumber+=1 where ID=" + Bk_ID.Text.Trim();
            Init();
            connection.Open();
            sc = new SqlCommand(sqlupdate, connection);
            sc.ExecuteNonQuery();
            sc = new SqlCommand(sqlUserTable, connection);
            sc.ExecuteNonQuery();
            MessageBox.Show(this, "归还成功");
            connection.Close();
        }
    }
}
