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
    public partial class ManageBook : Form
    {
        static string ConnectString = "Data Source=.;Initial Catalog=LibraryManageSystem;User ID=Admin;Pwd=123456";     //登录数据库时的用户名及密码
        static SqlConnection connection;
        static SqlCommand sc;
        void Init()
        {
            connection = new SqlConnection(ConnectString);

        }
        public ManageBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqladd = "insert BookTable values(" + BkID.Text.Trim() + "," + "'" + BkName.Text.Trim() + "'" + "," + StoreNum.Text.Trim() + "," + BorrowNum.Text.Trim() + "," + "'" + Location.Text.Trim() + "'" + ")";
            Init();
            sc = new SqlCommand(sqladd, connection);
            connection.Open();
            sc.ExecuteNonQuery();
            MessageBox.Show(this, "添加成功");
            connection.Close();



        }

        private void ManageBook_Load(object sender, EventArgs e)
        {

        }

        private void Bt_Del_Click(object sender, EventArgs e)
        {
            string sqlquery = "select count(*) from BookTable where ID=" + BkID.Text.Trim();
            string sqldel = "delete from  BookTable where ID=" + BkID.Text.Trim();
            Init();
            sc = new SqlCommand(sqlquery, connection);
            connection.Open();
            if ((int)sc.ExecuteScalar() == 0)
                MessageBox.Show(this, "此图书不存在,请重新输入");

            else
            {
                sc = new SqlCommand(sqldel, connection);
                sc.ExecuteNonQuery();
                MessageBox.Show(this, "删除成功");
            }
            connection.Close();


        }
    }
}
