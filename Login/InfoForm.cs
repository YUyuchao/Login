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
        public InfoForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "select orderNumber , goodsId , state , time , operator , quantities  from tb_InOutInfo";

            dgvInOut.DataSource = CLDataBase.CDataBase.GetDataFromDB(sql).Tables[0];


        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
        }
    }
}
