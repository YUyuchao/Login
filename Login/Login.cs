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
namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            string username = tUsername.Text;
            string password = tPassword.Text;   //获取数据

            //CLDateBase.CDataBase cDataBase = new CLDateBase.CDataBase(); 
            //string connString = @"Data Source=.;Initial Catalog=Demo2;Integrated Security=true"; 
            //SqlConnection conn = new SqlConnection(connString);     //创建链接对象

            string sql = String.Format("select count (*) from tb_user where username='{0}' and password='{1}'", username, password);
            //获取用户名和密码匹配的行的数量的sql语句
            
            try
            {
                //conn.Open();                                    //打开数据库连接
                //SqlCommand comm = new SqlCommand(sql, conn);    //创建command对象
                //int n = (int)comm.ExecuteScalar();              //执行查询语句，返回匹配的行数
                DataSet loginData = CLDataBase.CDataBase.GetDataFromDB(sql);
                if (loginData != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                //conn.Close();   //关闭数据库连接
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
            this.Close();
        }
    }
}
