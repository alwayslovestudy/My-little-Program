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
    public partial class ChangePw : Form
    {
        static string ConnectString = "Data Source=.;Initial Catalog=LibraryManageSystem;User ID=Admin;Pwd=123456";     //登录数据库时的用户名及密码
        static SqlConnection connection;
        static SqlCommand sc;
        void Init()
        {
            connection = new SqlConnection(ConnectString);

        }
        public ChangePw()
        {
            InitializeComponent();
        }

        private void ChangePw_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql_test = "select Password from AdminTable where UserName=" + "'" + username.Text.Trim() + "'";
            string sql_update = "update AdminTable set Password =" + "'" + newPw.Text.Trim() + "'";
            Init();
            connection.Open();
            sc = new SqlCommand(sql_test, connection);
            if ((string)sc.ExecuteScalar() == oldPw.Text.Trim())  //判断用户名与旧密码是否匹配，不匹配则不修改
            {
                sc = new SqlCommand(sql_update, connection);
                sc.ExecuteNonQuery();
                MessageBox.Show(this, "修改成功");
            }
            else
            {
                MessageBox.Show(this, "旧密码错误，修改失败");

            }
            
            connection.Close();



        }
    }
}
