using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LibaryManager
{
    public partial class Main_window : Form
    {
        private QueryBook querybook = null;         //查询窗口
        private ManageBook managebook = null;       //管理窗口
        private Bor_Ret bor_ret = null;             //外借与归还窗口
        private Log LogWindow = null;               //登录窗口
        private ChangePw changepw = null;           //修改密码窗口
        public Main_window(Log LogWindow)          //初始化时传入父窗口，用于返回登录窗口
        {

            InitializeComponent();
            this.LogWindow = LogWindow;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void ClearWindows()   //隐藏所有窗口 
        {
            if (querybook != null)
            {
              

            }
            if (managebook != null)
            {
                managebook.Visible = false;

            }
            if (bor_ret != null)
            {
                bor_ret.Visible = false;
            }
            if (changepw != null)
            {
                changepw.Visible = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearWindows();
            querybook = new QueryBook();    //生成查询子窗口
            querybook.MdiParent = this;
            querybook.Show();





        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearWindows();
            this.Visible = false;//隐藏当前窗口
            LogWindow.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearWindows();
            managebook = new ManageBook();
            managebook.MdiParent = this;
            managebook.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearWindows();
            bor_ret = new Bor_Ret();
            bor_ret.MdiParent = this;
            bor_ret.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearWindows();
            changepw = new ChangePw();
            changepw.MdiParent = this;
            changepw.Show();

        }
    }
}
