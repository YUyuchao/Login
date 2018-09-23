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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "select * from tb_InOutInfo";
            DataSet da = CLDataBase.CDataBase.GetDataFromDB(sql);
            dgvInOut.DataSource = da;
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“demoDataSet.tb_InOutInfo”中。您可以根据需要移动或删除它。
            this.tb_InOutInfoTableAdapter.Fill(this.demoDataSet.tb_InOutInfo);

        }
    }
}
