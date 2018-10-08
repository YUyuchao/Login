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
        
        private void IOallbtn_Click(object sender, EventArgs e)//查看所有按钮
        {   
            string sql = "select orderNumber , goodsId , state , time , operator , quantities  from tb_InOutInfo";
            dgvInOut.DataSource = CLDataBase.CDataBase.GetDataFromDB(sql).Tables[0];
        }

        private void IOcanclebtn_Click(object sender, EventArgs e)//取消按钮
        {
            string sql = "select orderNumber , goodsId , state , time , operator , quantities  from tb_InOutInfo";
            dgvInOut.DataSource = CLDataBase.CDataBase.GetDataFromDB(sql).Tables[0];
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            panel1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void IOinsertbtn_Click(object sender, EventArgs e)
        {
            IOinsertForm Iinsert = new IOinsertForm((string)this.Tag);
            Iinsert.ShowDialog();
        }

        private void IOdeletebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void IOselectbtn_Click(object sender, EventArgs e)
        {
            string sql = String.Format("select (*) from tb_InOutInfo where time",);
            #region

            if (ordNumTextbox.Text != null)
            {
                sql += String.Format("and orderNumber='{0}'", ordNumTextbox.Text);
            }
            if (goodsIdTextbox.Text != null)
            {
                sql += String.Format("and goodsId='{0}'", goodsIdTextbox.Text);
            }
            if (comboBox2.Text != null)
            {
                sql += String.Format("and state='{0}'", stateCombox.Text);
            }
            if (operatorCombox.Text != null)
            {
                sql += String.Format("and operator='{0}'", operatorCombox.Text);
            }
            if (quantitiesTextbox.Text != null)
            {
                sql += String.Format("and quantities='{0}'", quantitiesTextbox.Text);
            }

            #endregion
        }
    }
}
