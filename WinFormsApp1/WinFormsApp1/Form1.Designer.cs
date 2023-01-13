namespace WinFormsApp1
{
    partial class inventory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.IMG_Charge = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IMG_Decharge = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IMG_Inventory = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IMG_Product = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IMG_Poeple = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IMG_PrintExcel = new System.Windows.Forms.PictureBox();
            this.cmbx_PR_Group = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl17 = new System.Windows.Forms.Label();
            this.lbl19 = new System.Windows.Forms.Label();
            this.txbx_PR_Model = new System.Windows.Forms.TextBox();
            this.lbl20 = new System.Windows.Forms.Label();
            this.txbx_PR_Name = new System.Windows.Forms.TextBox();
            this.btn_Find_Poeple = new System.Windows.Forms.Button();
            this.lbl24 = new System.Windows.Forms.Label();
            this.txbx_PR_ID = new System.Windows.Forms.TextBox();
            this.cmbx_Poeple = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbx_SearchType = new System.Windows.Forms.ComboBox();
            this.txbx_LName = new System.Windows.Forms.TextBox();
            this.lbl_LName = new System.Windows.Forms.Label();
            this.txbx_FName = new System.Windows.Forms.TextBox();
            this.lbl_FName = new System.Windows.Forms.Label();
            this.txbx_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_Find_Product = new System.Windows.Forms.Button();
            this.tlstrip_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Charge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Decharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Poeple)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_PrintExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(1011, 797);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Excel چاپ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1109, 27);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // IMG_Charge
            // 
            this.IMG_Charge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IMG_Charge.Image = global::WinFormsApp1.Properties.Resources.icons8_worldwide_delivery_100;
            this.IMG_Charge.Location = new System.Drawing.Point(991, 430);
            this.IMG_Charge.Name = "IMG_Charge";
            this.IMG_Charge.Size = new System.Drawing.Size(100, 100);
            this.IMG_Charge.TabIndex = 28;
            this.IMG_Charge.TabStop = false;
            this.IMG_Charge.Click += new System.EventHandler(this.IMG_Charge_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(1011, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "ورود کالا";
            // 
            // IMG_Decharge
            // 
            this.IMG_Decharge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IMG_Decharge.Image = global::WinFormsApp1.Properties.Resources.icons8_truck_100;
            this.IMG_Decharge.Location = new System.Drawing.Point(991, 559);
            this.IMG_Decharge.Name = "IMG_Decharge";
            this.IMG_Decharge.Size = new System.Drawing.Size(100, 100);
            this.IMG_Decharge.TabIndex = 26;
            this.IMG_Decharge.TabStop = false;
            this.IMG_Decharge.Click += new System.EventHandler(this.IMG_Decharge_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(1015, 662);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "خروج کالا";
            // 
            // IMG_Inventory
            // 
            this.IMG_Inventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IMG_Inventory.Image = global::WinFormsApp1.Properties.Resources.icons8_inventory_100;
            this.IMG_Inventory.Location = new System.Drawing.Point(991, 304);
            this.IMG_Inventory.Name = "IMG_Inventory";
            this.IMG_Inventory.Size = new System.Drawing.Size(100, 100);
            this.IMG_Inventory.TabIndex = 24;
            this.IMG_Inventory.TabStop = false;
            this.IMG_Inventory.Click += new System.EventHandler(this.IMG_Inventory_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(1030, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "انبار";
            // 
            // IMG_Product
            // 
            this.IMG_Product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IMG_Product.Image = global::WinFormsApp1.Properties.Resources.icons8_used_product_100;
            this.IMG_Product.Location = new System.Drawing.Point(991, 178);
            this.IMG_Product.Name = "IMG_Product";
            this.IMG_Product.Size = new System.Drawing.Size(100, 100);
            this.IMG_Product.TabIndex = 22;
            this.IMG_Product.TabStop = false;
            this.IMG_Product.Click += new System.EventHandler(this.IMG_Product_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(1019, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "کالاها";
            // 
            // IMG_Poeple
            // 
            this.IMG_Poeple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IMG_Poeple.Image = global::WinFormsApp1.Properties.Resources.icons8_people_100;
            this.IMG_Poeple.Location = new System.Drawing.Point(991, 46);
            this.IMG_Poeple.Name = "IMG_Poeple";
            this.IMG_Poeple.Size = new System.Drawing.Size(100, 100);
            this.IMG_Poeple.TabIndex = 20;
            this.IMG_Poeple.TabStop = false;
            this.IMG_Poeple.Click += new System.EventHandler(this.IMG_Poeple_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(1015, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "اشخاص";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(58, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(911, 39);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "اطلاعات کالا ها";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(58, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(911, 39);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "اطلاعات افراد ";
            // 
            // IMG_PrintExcel
            // 
            this.IMG_PrintExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IMG_PrintExcel.Image = global::WinFormsApp1.Properties.Resources.icons8_microsoft_excel_2019_100;
            this.IMG_PrintExcel.Location = new System.Drawing.Point(991, 694);
            this.IMG_PrintExcel.Name = "IMG_PrintExcel";
            this.IMG_PrintExcel.Size = new System.Drawing.Size(100, 100);
            this.IMG_PrintExcel.TabIndex = 40;
            this.IMG_PrintExcel.TabStop = false;
            this.IMG_PrintExcel.Click += new System.EventHandler(this.IMG_PrintExcel_Click_1);
            // 
            // cmbx_PR_Group
            // 
            this.cmbx_PR_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_PR_Group.FormattingEnabled = true;
            this.cmbx_PR_Group.Items.AddRange(new object[] {
            "digital",
            "clothes",
            "personal items",
            "hobby",
            "industrial tools and equipment"});
            this.cmbx_PR_Group.Location = new System.Drawing.Point(597, 283);
            this.cmbx_PR_Group.Name = "cmbx_PR_Group";
            this.cmbx_PR_Group.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbx_PR_Group.Size = new System.Drawing.Size(289, 28);
            this.cmbx_PR_Group.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(911, 463);
            this.dataGridView1.TabIndex = 5;
            // 
            // lbl17
            // 
            this.lbl17.AutoSize = true;
            this.lbl17.Location = new System.Drawing.Point(645, 253);
            this.lbl17.Name = "lbl17";
            this.lbl17.Size = new System.Drawing.Size(52, 20);
            this.lbl17.TabIndex = 10;
            this.lbl17.Text = "نام کالا";
            // 
            // lbl19
            // 
            this.lbl19.AutoSize = true;
            this.lbl19.Location = new System.Drawing.Point(901, 286);
            this.lbl19.Name = "lbl19";
            this.lbl19.Size = new System.Drawing.Size(68, 20);
            this.lbl19.TabIndex = 11;
            this.lbl19.Text = "دسته کالا";
            // 
            // txbx_PR_Model
            // 
            this.txbx_PR_Model.Location = new System.Drawing.Point(72, 246);
            this.txbx_PR_Model.Name = "txbx_PR_Model";
            this.txbx_PR_Model.Size = new System.Drawing.Size(211, 27);
            this.txbx_PR_Model.TabIndex = 12;
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Location = new System.Drawing.Point(289, 249);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(145, 20);
            this.lbl20.TabIndex = 13;
            this.lbl20.Text = "شماره سریال مدل کالا";
            // 
            // txbx_PR_Name
            // 
            this.txbx_PR_Name.Location = new System.Drawing.Point(450, 246);
            this.txbx_PR_Name.Name = "txbx_PR_Name";
            this.txbx_PR_Name.Size = new System.Drawing.Size(189, 27);
            this.txbx_PR_Name.TabIndex = 22;
            // 
            // btn_Find_Poeple
            // 
            this.btn_Find_Poeple.BackColor = System.Drawing.Color.Gray;
            this.btn_Find_Poeple.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Find_Poeple.Location = new System.Drawing.Point(72, 140);
            this.btn_Find_Poeple.Name = "btn_Find_Poeple";
            this.btn_Find_Poeple.Size = new System.Drawing.Size(211, 38);
            this.btn_Find_Poeple.TabIndex = 39;
            this.btn_Find_Poeple.Text = "جستجوی افراد";
            this.btn_Find_Poeple.UseVisualStyleBackColor = false;
            this.btn_Find_Poeple.Click += new System.EventHandler(this.btn_Find_People_Click);
            // 
            // lbl24
            // 
            this.lbl24.AutoSize = true;
            this.lbl24.Location = new System.Drawing.Point(892, 250);
            this.lbl24.Name = "lbl24";
            this.lbl24.Size = new System.Drawing.Size(77, 20);
            this.lbl24.TabIndex = 41;
            this.lbl24.Text = "شناسه کالا";
            // 
            // txbx_PR_ID
            // 
            this.txbx_PR_ID.Location = new System.Drawing.Point(703, 246);
            this.txbx_PR_ID.Name = "txbx_PR_ID";
            this.txbx_PR_ID.Size = new System.Drawing.Size(183, 27);
            this.txbx_PR_ID.TabIndex = 42;
            // 
            // cmbx_Poeple
            // 
            this.cmbx_Poeple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Poeple.FormattingEnabled = true;
            this.cmbx_Poeple.Items.AddRange(new object[] {
            "تحویل گیرنده",
            "تحویل دهنده"});
            this.cmbx_Poeple.Location = new System.Drawing.Point(621, 98);
            this.cmbx_Poeple.Name = "cmbx_Poeple";
            this.cmbx_Poeple.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbx_Poeple.Size = new System.Drawing.Size(198, 28);
            this.cmbx_Poeple.TabIndex = 69;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(892, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 20);
            this.label16.TabIndex = 70;
            this.label16.Text = "نوع شخص";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(833, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 20);
            this.label14.TabIndex = 72;
            this.label14.Text = "نوع جستجوی شخص";
            // 
            // cmbx_SearchType
            // 
            this.cmbx_SearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_SearchType.FormattingEnabled = true;
            this.cmbx_SearchType.Items.AddRange(new object[] {
            "با شناسه",
            "با نام و نام خانوادگی",
            "با شناسه و نام و نام خانوادگی"});
            this.cmbx_SearchType.Location = new System.Drawing.Point(621, 132);
            this.cmbx_SearchType.Name = "cmbx_SearchType";
            this.cmbx_SearchType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbx_SearchType.Size = new System.Drawing.Size(198, 28);
            this.cmbx_SearchType.TabIndex = 71;
            // 
            // txbx_LName
            // 
            this.txbx_LName.Location = new System.Drawing.Point(384, 134);
            this.txbx_LName.Name = "txbx_LName";
            this.txbx_LName.Size = new System.Drawing.Size(121, 27);
            this.txbx_LName.TabIndex = 74;
            // 
            // lbl_LName
            // 
            this.lbl_LName.AutoSize = true;
            this.lbl_LName.Location = new System.Drawing.Point(512, 138);
            this.lbl_LName.Name = "lbl_LName";
            this.lbl_LName.Size = new System.Drawing.Size(90, 20);
            this.lbl_LName.TabIndex = 73;
            this.lbl_LName.Text = "نام خانوادگی";
            // 
            // txbx_FName
            // 
            this.txbx_FName.Location = new System.Drawing.Point(384, 101);
            this.txbx_FName.Name = "txbx_FName";
            this.txbx_FName.Size = new System.Drawing.Size(121, 27);
            this.txbx_FName.TabIndex = 76;
            // 
            // lbl_FName
            // 
            this.lbl_FName.AutoSize = true;
            this.lbl_FName.Location = new System.Drawing.Point(512, 105);
            this.lbl_FName.Name = "lbl_FName";
            this.lbl_FName.Size = new System.Drawing.Size(27, 20);
            this.lbl_FName.TabIndex = 75;
            this.lbl_FName.Text = "نام";
            // 
            // txbx_ID
            // 
            this.txbx_ID.Location = new System.Drawing.Point(72, 98);
            this.txbx_ID.Name = "txbx_ID";
            this.txbx_ID.Size = new System.Drawing.Size(177, 27);
            this.txbx_ID.TabIndex = 68;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(255, 101);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(98, 20);
            this.lbl_ID.TabIndex = 67;
            this.lbl_ID.Text = "شناسه شخص";
            // 
            // btn_Find_Product
            // 
            this.btn_Find_Product.BackColor = System.Drawing.Color.Gray;
            this.btn_Find_Product.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Find_Product.Location = new System.Drawing.Point(72, 281);
            this.btn_Find_Product.Name = "btn_Find_Product";
            this.btn_Find_Product.Size = new System.Drawing.Size(211, 41);
            this.btn_Find_Product.TabIndex = 77;
            this.btn_Find_Product.Text = "جستجوی کالاها";
            this.btn_Find_Product.UseVisualStyleBackColor = false;
            this.btn_Find_Product.Click += new System.EventHandler(this.btn_Find_Product_Click);
            // 
            // tlstrip_Exit
            // 
            this.tlstrip_Exit.Name = "tlstrip_Exit";
            this.tlstrip_Exit.Size = new System.Drawing.Size(224, 26);
            this.tlstrip_Exit.Text = "خروج از برنامه";
            this.tlstrip_Exit.Click += new System.EventHandler(this.tlstrip_Exit_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrip_Exit});
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(99, 24);
            this.toolStripLabel1.Text = "مدیریت انبار";
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 825);
            this.Controls.Add(this.btn_Find_Product);
            this.Controls.Add(this.txbx_FName);
            this.Controls.Add(this.lbl_FName);
            this.Controls.Add(this.txbx_LName);
            this.Controls.Add(this.lbl_LName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbx_SearchType);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbx_Poeple);
            this.Controls.Add(this.txbx_PR_ID);
            this.Controls.Add(this.txbx_ID);
            this.Controls.Add(this.lbl24);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_Find_Poeple);
            this.Controls.Add(this.txbx_PR_Name);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.txbx_PR_Model);
            this.Controls.Add(this.lbl19);
            this.Controls.Add(this.lbl17);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbx_PR_Group);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.IMG_PrintExcel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.IMG_Charge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IMG_Decharge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IMG_Inventory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IMG_Product);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IMG_Poeple);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انبارداری";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Charge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Decharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Poeple)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_PrintExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label7;
        private ToolStrip toolStrip1;
        private PictureBox IMG_Charge;
        private Label label4;
        private PictureBox IMG_Decharge;
        private Label label5;
        private PictureBox IMG_Inventory;
        private Label label3;
        private PictureBox IMG_Product;
        private Label label2;
        private PictureBox IMG_Poeple;
        private Label label1;
        private GroupBox groupBox2;
        private Label label8;
        private GroupBox groupBox1;
        private Label label6;
        private PictureBox IMG_PrintExcel;
        private ComboBox cmbx_PR_Group;
        private DataGridView dataGridView1;
        private Label lbl17;
        private Label lbl19;
        private TextBox txbx_PR_Model;
        private Label lbl20;
        private TextBox txbx_PR_Name;
        private Button btn_Find_Poeple;
        private Label lbl24;
        private TextBox txbx_PR_ID;
        private ComboBox cmbx_Poeple;
        private Label label16;
        private Label label14;
        private ComboBox cmbx_SearchType;
        private TextBox txbx_LName;
        private Label lbl_LName;
        private TextBox txbx_FName;
        private Label lbl_FName;
        private TextBox txbx_ID;
        private Label lbl_ID;
        private Button btn_Find_Product;
        private ToolStripDropDownButton toolStripLabel1;
        private ToolStripMenuItem tlstrip_Exit;
    }
}