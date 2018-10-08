namespace Login
{
    partial class InfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvInOut = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.operatorCombox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.quantitiesTextbox = new System.Windows.Forms.TextBox();
            this.goodsIdTextbox = new System.Windows.Forms.TextBox();
            this.ordNumTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IOselectbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.IOinsertbtn = new System.Windows.Forms.Button();
            this.IOdeletebtn = new System.Windows.Forms.Button();
            this.IOallbtn = new System.Windows.Forms.Button();
            this.IOcanclebtn = new System.Windows.Forms.Button();
            this.IOsavebtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sordernumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sstate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Squantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operators = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInOut)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(935, 558);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "出入库信息管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Controls.Add(this.dgvInOut, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(921, 523);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvInOut
            // 
            this.dgvInOut.AllowUserToAddRows = false;
            this.dgvInOut.AllowUserToDeleteRows = false;
            this.dgvInOut.AllowUserToResizeRows = false;
            this.dgvInOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sel,
            this.orderNumber,
            this.goodsId,
            this.state,
            this.time,
            this.operators,
            this.quantities});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvInOut, 2);
            this.dgvInOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInOut.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvInOut.Location = new System.Drawing.Point(2, 2);
            this.dgvInOut.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInOut.Name = "dgvInOut";
            this.tableLayoutPanel1.SetRowSpan(this.dgvInOut, 2);
            this.dgvInOut.RowTemplate.Height = 27;
            this.dgvInOut.Size = new System.Drawing.Size(816, 319);
            this.dgvInOut.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.operatorCombox);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.quantitiesTextbox);
            this.panel1.Controls.Add(this.goodsIdTextbox);
            this.panel1.Controls.Add(this.ordNumTextbox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.IOselectbtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 194);
            this.panel1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "入库",
            "出库"});
            this.comboBox2.Location = new System.Drawing.Point(470, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(78, 20);
            this.comboBox2.TabIndex = 12;
            // 
            // operatorCombox
            // 
            this.operatorCombox.FormattingEnabled = true;
            this.operatorCombox.Location = new System.Drawing.Point(613, 43);
            this.operatorCombox.Name = "operatorCombox";
            this.operatorCombox.Size = new System.Drawing.Size(121, 20);
            this.operatorCombox.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 21);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // quantitiesTextbox
            // 
            this.quantitiesTextbox.Location = new System.Drawing.Point(515, 119);
            this.quantitiesTextbox.Name = "quantitiesTextbox";
            this.quantitiesTextbox.Size = new System.Drawing.Size(90, 21);
            this.quantitiesTextbox.TabIndex = 9;
            // 
            // goodsIdTextbox
            // 
            this.goodsIdTextbox.Location = new System.Drawing.Point(321, 43);
            this.goodsIdTextbox.Name = "goodsIdTextbox";
            this.goodsIdTextbox.Size = new System.Drawing.Size(84, 21);
            this.goodsIdTextbox.TabIndex = 7;
            // 
            // ordNumTextbox
            // 
            this.ordNumTextbox.Location = new System.Drawing.Point(111, 43);
            this.ordNumTextbox.Name = "ordNumTextbox";
            this.ordNumTextbox.Size = new System.Drawing.Size(133, 21);
            this.ordNumTextbox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "数量：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "操作员：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "操作日期：";
            // 
            // IOselectbtn
            // 
            this.IOselectbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IOselectbtn.Location = new System.Drawing.Point(670, 116);
            this.IOselectbtn.Margin = new System.Windows.Forms.Padding(2);
            this.IOselectbtn.Name = "IOselectbtn";
            this.IOselectbtn.Size = new System.Drawing.Size(64, 26);
            this.IOselectbtn.TabIndex = 1;
            this.IOselectbtn.Text = "查询";
            this.IOselectbtn.UseVisualStyleBackColor = true;
            this.IOselectbtn.Click += new System.EventHandler(this.IOselectbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "出入库：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单号：";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.IOinsertbtn);
            this.panel4.Controls.Add(this.IOdeletebtn);
            this.panel4.Controls.Add(this.IOallbtn);
            this.panel4.Controls.Add(this.IOcanclebtn);
            this.panel4.Controls.Add(this.IOsavebtn);
            this.panel4.Location = new System.Drawing.Point(823, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(95, 294);
            this.panel4.TabIndex = 8;
            // 
            // IOinsertbtn
            // 
            this.IOinsertbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IOinsertbtn.Location = new System.Drawing.Point(15, 16);
            this.IOinsertbtn.Margin = new System.Windows.Forms.Padding(2);
            this.IOinsertbtn.Name = "IOinsertbtn";
            this.IOinsertbtn.Size = new System.Drawing.Size(64, 26);
            this.IOinsertbtn.TabIndex = 2;
            this.IOinsertbtn.Text = "添加";
            this.IOinsertbtn.UseVisualStyleBackColor = true;
            this.IOinsertbtn.Click += new System.EventHandler(this.IOinsertbtn_Click);
            // 
            // IOdeletebtn
            // 
            this.IOdeletebtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IOdeletebtn.Location = new System.Drawing.Point(15, 72);
            this.IOdeletebtn.Margin = new System.Windows.Forms.Padding(2);
            this.IOdeletebtn.Name = "IOdeletebtn";
            this.IOdeletebtn.Size = new System.Drawing.Size(64, 26);
            this.IOdeletebtn.TabIndex = 4;
            this.IOdeletebtn.Text = "删除";
            this.IOdeletebtn.UseVisualStyleBackColor = true;
            this.IOdeletebtn.Click += new System.EventHandler(this.IOdeletebtn_Click);
            // 
            // IOallbtn
            // 
            this.IOallbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IOallbtn.Location = new System.Drawing.Point(15, 249);
            this.IOallbtn.Margin = new System.Windows.Forms.Padding(2);
            this.IOallbtn.Name = "IOallbtn";
            this.IOallbtn.Size = new System.Drawing.Size(64, 26);
            this.IOallbtn.TabIndex = 5;
            this.IOallbtn.Text = "总览";
            this.IOallbtn.UseVisualStyleBackColor = true;
            this.IOallbtn.Click += new System.EventHandler(this.IOallbtn_Click);
            // 
            // IOcanclebtn
            // 
            this.IOcanclebtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IOcanclebtn.Enabled = false;
            this.IOcanclebtn.Location = new System.Drawing.Point(15, 189);
            this.IOcanclebtn.Margin = new System.Windows.Forms.Padding(2);
            this.IOcanclebtn.Name = "IOcanclebtn";
            this.IOcanclebtn.Size = new System.Drawing.Size(64, 26);
            this.IOcanclebtn.TabIndex = 6;
            this.IOcanclebtn.Text = "取消";
            this.IOcanclebtn.UseVisualStyleBackColor = true;
            this.IOcanclebtn.Click += new System.EventHandler(this.IOcanclebtn_Click);
            // 
            // IOsavebtn
            // 
            this.IOsavebtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IOsavebtn.Location = new System.Drawing.Point(15, 127);
            this.IOsavebtn.Margin = new System.Windows.Forms.Padding(2);
            this.IOsavebtn.Name = "IOsavebtn";
            this.IOsavebtn.Size = new System.Drawing.Size(64, 26);
            this.IOsavebtn.TabIndex = 3;
            this.IOsavebtn.Text = "保存";
            this.IOsavebtn.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(927, 529);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "库存信息管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(923, 525);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.goodsName,
            this.Sordernumber,
            this.Sstate,
            this.intime,
            this.Sprice,
            this.Squantity,
            this.Scategory,
            this.Scompany});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.tableLayoutPanel2.SetRowSpan(this.dataGridView1, 7);
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(818, 534);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "商品编号";
            this.Id.Name = "Id";
            // 
            // goodsName
            // 
            this.goodsName.HeaderText = "商品名称";
            this.goodsName.Name = "goodsName";
            // 
            // Sordernumber
            // 
            this.Sordernumber.HeaderText = "订单号";
            this.Sordernumber.Name = "Sordernumber";
            // 
            // Sstate
            // 
            this.Sstate.HeaderText = "操作";
            this.Sstate.Name = "Sstate";
            this.Sstate.Width = 70;
            // 
            // intime
            // 
            this.intime.HeaderText = "操作时间";
            this.intime.Name = "intime";
            // 
            // Sprice
            // 
            this.Sprice.HeaderText = "价格";
            this.Sprice.Name = "Sprice";
            // 
            // Squantity
            // 
            this.Squantity.HeaderText = "存货数量";
            this.Squantity.Name = "Squantity";
            // 
            // Scategory
            // 
            this.Scategory.HeaderText = "类别";
            this.Scategory.Name = "Scategory";
            // 
            // Scompany
            // 
            this.Scompany.HeaderText = "所属公司";
            this.Scompany.Name = "Scompany";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(840, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(840, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "统计";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(927, 529);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "商品信息管理";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(927, 529);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "人员信息管理";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(280, 117);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(136, 21);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "到";
            // 
            // sel
            // 
            this.sel.HeaderText = "勾选";
            this.sel.Name = "sel";
            this.sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sel.Width = 60;
            // 
            // orderNumber
            // 
            this.orderNumber.DataPropertyName = "orderNumber";
            this.orderNumber.HeaderText = "订单号";
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.ReadOnly = true;
            // 
            // goodsId
            // 
            this.goodsId.DataPropertyName = "goodsId";
            this.goodsId.HeaderText = "商品编号";
            this.goodsId.Name = "goodsId";
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.state.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.state.HeaderText = "出入库";
            this.state.Items.AddRange(new object[] {
            "in",
            "out"});
            this.state.Name = "state";
            this.state.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.state.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "操作日期";
            this.time.Name = "time";
            // 
            // operators
            // 
            this.operators.DataPropertyName = "operator";
            this.operators.HeaderText = "操作员";
            this.operators.Name = "operators";
            // 
            // quantities
            // 
            this.quantities.DataPropertyName = "quantities";
            this.quantities.HeaderText = "数量";
            this.quantities.Name = "quantities";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 558);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InfoForm";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInOut)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvInOut;
        private System.Windows.Forms.Button IOselectbtn;
        private System.Windows.Forms.Button IOinsertbtn;
        private System.Windows.Forms.Button IOsavebtn;
        private System.Windows.Forms.Button IOdeletebtn;
        private System.Windows.Forms.Button IOallbtn;
        private System.Windows.Forms.Button IOcanclebtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sordernumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sstate;
        private System.Windows.Forms.DataGridViewTextBoxColumn intime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Squantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scompany;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox operatorCombox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox quantitiesTextbox;
        private System.Windows.Forms.TextBox goodsIdTextbox;
        private System.Windows.Forms.TextBox ordNumTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsId;
        private System.Windows.Forms.DataGridViewComboBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn operators;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantities;
    }
}