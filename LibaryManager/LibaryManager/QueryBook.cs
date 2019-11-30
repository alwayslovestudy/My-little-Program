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
    public partial class QueryBook : Form
    {


        static string ConnectString = "Data Source=.;Initial Catalog=LibraryManageSystem;User ID=Admin;Pwd=123456";     //登录数据库时的用户名及密码
        static SqlConnection connection;
        static SqlCommand sc;
        void Init()
        {
            connection = new SqlConnection(ConnectString);

        }
        public QueryBook()
        {
            InitializeComponent();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void QueryBook_Load(object sender, EventArgs e)
        {

        }

        private void Bt_query_Click(object sender, EventArgs e)
        {
            string sqlquery = "select * from BookTable where ID=" + BkID_query.Text.Trim();
            string sqltest = "select count(*) from BookTable where ID=" + BkID_query.Text.Trim();
            Init();
            connection.Open();
            if (BkID_query.Text!="")  //精确查找
            {
                sc = new SqlCommand(sqltest, connection);
                if ((int)sc.ExecuteScalar() == 0)
                {
                    MessageBox.Show(this, "查询失败，无此图书");


                }
                else
                {

                    sc = new SqlCommand(sqlquery, connection);
                    SqlDataReader sdr = sc.ExecuteReader();
                    sdr.Read();
                    BkQuery_result.Text = sdr["ID"].ToString() + "  " + sdr["BookName"] + "  " + sdr["StoreNumber"] + "  " + sdr["BorrowNumber"] + "  " + sdr["Location"] + "\r\n";

                }

            }
            else     //模糊查找
            {
                sqlquery = "select * from BookTable where BookName like" + "'" + "%" + BK_Name.Text.Trim() + "%" + "'";
                sqltest = "select count(*) from BookTable where BookName like" + "'" + "%" + BK_Name.Text.Trim() + "%" + "'";
                sc = new SqlCommand(sqltest, connection);
                if ((int)sc.ExecuteScalar() == 0)
                {
                    MessageBox.Show(this, "查询失败，无此图书");


                }
                else
                {

                    sc = new SqlCommand(sqlquery, connection);
                    SqlDataReader sdr = sc.ExecuteReader();
                    while (sdr.Read())
                    {
                        BkQuery_result.AppendText(sdr["ID"].ToString() + "  " + sdr["BookName"] + "  " + sdr["StoreNumber"] + "  " + sdr["BorrowNumber"] + "  " + sdr["Location"] + "\r\n");
                    }

                }

            }

          


            connection.Close();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
