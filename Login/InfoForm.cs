using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class InfoForm : Form
    {
        public InfoForm(string user)
        {
            this.Tag = user;
            InitializeComponent();
        }
        //出入库信息管理
        #region

        private void IOallbtn_Click(object sender, EventArgs e)//出入库信息总览按钮
        {   
            string sql = "select orderNumber , goodsId , state , time , operator , quantities  from tb_InOutInfo";
            DataSet dataSetALL = CLDataBase.CDataBase.GetDataFromDB(sql);
            if (dataSetALL == null)
                MessageBox.Show("查询结果为空", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                dgvInOut.DataSource = dataSetALL.Tables[0];
        }

        private void IOcanclebtn_Click(object sender, EventArgs e)//取消按钮
        {
            string sql = "select orderNumber , goodsId , state , time , operator , quantities  from tb_InOutInfo";
            dgvInOut.DataSource = CLDataBase.CDataBase.GetDataFromDB(sql).Tables[0];
        }

        private void InfoForm_Load(object sender, EventArgs e)//窗体加载事件
        {
            panel1.BorderStyle = BorderStyle.FixedSingle;
            string sql = "select username from tb_user";

            DataSet LoadComboxDataset = CLDataBase.CDataBase.GetDataFromDB(sql);
            LoadComboxDataset.Tables[0].Rows.Add("all");
            operatorCombox.DataSource = LoadComboxDataset.Tables[0];
            operatorCombox.DisplayMember = "username";
            
            sql = "select name from tb_goodsinfo";
            LoadComboxDataset.Clear();
            LoadComboxDataset = CLDataBase.CDataBase.GetDataFromDB(sql);
            LoadComboxDataset.Tables[0].Rows.Add("all");
            GnameCombox.DataSource = LoadComboxDataset.Tables[0];
            GnameCombox.DisplayMember = "name";

        }

        private void IOinsertbtn_Click(object sender, EventArgs e)//添加按钮
        {
            IOinsertForm Iinsert = new IOinsertForm((string)this.Tag);
            Iinsert.ShowDialog();
        }

        private void IOdeletebtn_Click(object sender, EventArgs e)//删除按钮
        {
            if ((dgvInOut.CurrentRow != null)&&(MessageBox.Show("确定删除?","删除提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK))
            {
                string sql = String.Format("DELETE from tb_InOutInfo where orderNumber={0}",dgvInOut.CurrentRow.Cells["orderNumber"].Value);
                
                if (CLDataBase.CDataBase.UpdateDB(sql) == true)
                    MessageBox.Show("删除成功", "删除成功", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("删除失败", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DataRowView drv = dgvInOut.CurrentRow.DataBoundItem as DataRowView;
                drv.Delete();
            }
        }

        private void IOselectbtn_Click(object sender, EventArgs e)//查询按钮
        {
            string sql = String.Format("select * from tb_InOutInfo where time >= '{0}' AND time<='{1}'", dateTimePicker1.Value.ToString("yyyy'-'MM'-'dd' '00':'00':'00"), dateTimePicker2.Value.ToString("yyyy'-'MM'-'dd' '23':'59':'59"));
            
            //查询判断语句
            #region
            if (ordNumTextbox.Text != "")
            {
                sql += String.Format("and orderNumber={0}", ordNumTextbox.Text);
            }
            if (goodsIdTextbox.Text != "")
            {
                sql += String.Format("and goodsId={0}", goodsIdTextbox.Text);
            }
            if (comboBox2.Text != "" && comboBox2.Text != "all")
            {
                sql += String.Format("and state='{0}'", comboBox2.Text);
            }
            if (operatorCombox.Text != "" && operatorCombox.Text != "all")
            {
                sql += String.Format("and operator='{0}'", operatorCombox.Text);
            }
            if (quantitiesTextbox.Text != "")
            {
                sql += String.Format("and quantities={0}", quantitiesTextbox.Text);
            }
            #endregion

            try//执行查询
            {
                DataSet selectData = CLDataBase.CDataBase.GetDataFromDB(sql);
                if (selectData == null)
                    MessageBox.Show("查询结果为空", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    dgvInOut.DataSource = selectData.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }//执行查询
        }

        private void IOsavebtn_Click(object sender, EventArgs e)//保存修改按钮
        {
            if (dgvInOut.DataSource != null)
            {
                int row = dgvInOut.Rows.Count;//得到总行数
                for (int i = 0; i < row; i++)
                {
                    string sql = String.Format("UPDATE tb_InOutInfo SET goodsId = {0},state ='{1}',operator = '{2}',quantities = {3} WHERE orderNumber = {4}",
                        dgvInOut.Rows[i].Cells["goodsId"].Value,
                        dgvInOut.Rows[i].Cells["state"].Value,
                        dgvInOut.Rows[i].Cells["operators"].Value,
                        dgvInOut.Rows[i].Cells["quantities"].Value,
                        dgvInOut.Rows[i].Cells["orderNumber"].Value);
                    try
                    {
                        if (CLDataBase.CDataBase.UpdateDB(sql) != true)
                        {
                            MessageBox.Show("保存失败", "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                MessageBox.Show("保存成功", "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        private void GinsertBtn_Click(object sender, EventArgs e)//商品信息添加按钮
        {
            GoodsInsertForm Ginsertform = new GoodsInsertForm();
            Ginsertform.ShowDialog();
        }

        private void GallBtn_Click(object sender, EventArgs e)//商品信息总览按钮
        {
            string sql = "select Id,price,classifications,name,producedate,guaranteeperiod,company  from tb_goodsinfo";
            DataSet dataSetALL = CLDataBase.CDataBase.GetDataFromDB(sql);
            if (dataSetALL == null)
                MessageBox.Show("查询结果为空", "查询失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                dgvGoodsInfo.DataSource = dataSetALL.Tables[0];
        }

        private void GdeleteBtn_Click(object sender, EventArgs e)//商品信息删除按钮
        {
            if ((dgvGoodsInfo.CurrentRow != null) && (MessageBox.Show("确定删除?", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK))
            {
                string sql = String.Format("DELETE from tb_goodsinfo where Id={0}", dgvGoodsInfo.CurrentRow.Cells["GgoodsID"].Value);
                try
                {
                    if (CLDataBase.CDataBase.UpdateDB(sql) == true)
                    {
                        MessageBox.Show("删除成功", "删除成功", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("删除失败", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
                DataRowView drv = dgvGoodsInfo.CurrentRow.DataBoundItem as DataRowView;
                drv.Delete();
            }
        }

    }
}
