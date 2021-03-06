﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class IOinsertForm : Form
    {
        public IOinsertForm(string user)
        {
            this.Tag = user;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int INgoodsId = (int)numericUpDown1.Value;
            int INquantities = (int)numericUpDown2.Value;
            string INstate;
            if (radioButton0.Checked == true)
                INstate = String.Format("in");
            else
                INstate = String.Format("out");
            string INoperator = (string)this.Tag;
            string sql = String.Format("INSERT INTO tb_InOutInfo VALUES ('{0}','{1}',getdate(),'{2}','{3}')", INgoodsId, INstate, INoperator, INquantities);

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void IOinsertForm_Load(object sender, EventArgs e)
        {
            string sql = "select Id from tb_goodsinfo";
            DataSet LoadComboxDataset = CLDataBase.CDataBase.GetDataFromDB(sql);
            comboBox1.DataSource = LoadComboxDataset.Tables[0];
            comboBox1.DisplayMember = "Id";
        }
    }
}
