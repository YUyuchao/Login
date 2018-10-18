using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class GoodsInsertForm : Form
    {
        public GoodsInsertForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Gprice = (int)numericUpDown1.Value;
            int Gguarantee = (int)numericUpDown2.Value;
            string Gproduce = dateTimePicker1.Value.ToString("yyyy'-'MM'-'dd");
            string Gname = textBox1.Text;
            string Gclassification = textBox2.Text;
            string Gcompany = textBox3.Text;
            if (Gname == "")
                Gname = "null";
            string sql = String.Format("INSERT INTO tb_goodsinfo VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",Gprice,Gclassification,Gname,Gproduce,Gguarantee,Gcompany);
            
            try
            {
                if (CLDataBase.CDataBase.UpdateDB(sql) == true)
                {
                    MessageBox.Show("插入成功", "插入成功", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("插入失败", "插入失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
