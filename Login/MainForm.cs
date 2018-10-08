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
    public partial class MainForm : Form
    {
        
        public MainForm(string user)
        {
            this.Tag = user;
            InitializeComponent();
        }
        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void 商品信息管理ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InfoForm info = new InfoForm((string)this.Tag);
            info.MdiParent = this;
            info.WindowState = FormWindowState.Maximized; //最大化子窗体
            info.Show();

        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = (string)this.Tag;
        }
    }
}
