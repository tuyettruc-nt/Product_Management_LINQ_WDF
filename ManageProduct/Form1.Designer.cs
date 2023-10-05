namespace ManageProduct
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtOrigin = new TextBox();
            txtPrice = new TextBox();
            txtAmount = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            btnRemoveDate = new Button();
            btnRemoveAll = new Button();
            btnCheckDate = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            btnFindAmount = new Button();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnFindDate = new Button();
            textBox4 = new TextBox();
            btnRemoveOrigin = new Button();
            textBox3 = new TextBox();
            btnFindOrigin = new Button();
            label7 = new Label();
            txtPriceTo = new TextBox();
            txtPriceFrom = new TextBox();
            btnFilterPrice = new Button();
            btnDate = new Button();
            btnPriceMax = new Button();
            groupBox5 = new GroupBox();
            listView2 = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 255);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtOrigin);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(466, 306);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(358, 261);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 39);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(237, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 39);
            btnSave.TabIndex = 12;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(130, 213);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(329, 30);
            dateTimePicker1.TabIndex = 11;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new Point(130, 176);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(329, 30);
            txtOrigin.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(130, 140);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(329, 30);
            txtPrice.TabIndex = 9;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(130, 104);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(329, 30);
            txtAmount.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(329, 30);
            txtName.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(130, 35);
            txtID.Name = "txtID";
            txtID.Size = new Size(329, 30);
            txtID.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 219);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 5;
            label6.Text = "Hạn Dùng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 183);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 4;
            label5.Text = "Xuất Xứ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 147);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 3;
            label4.Text = "Đơn Giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 111);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 2;
            label3.Text = "Số Lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 71);
            label2.Name = "label2";
            label2.Size = new Size(36, 23);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 42);
            label1.Name = "label1";
            label1.Size = new Size(35, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 255, 192);
            groupBox2.Controls.Add(listView1);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(467, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(733, 306);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(6, 29);
            listView1.Name = "listView1";
            listView1.Size = new Size(721, 270);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Số Lượng";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Đơn Giá";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Xuất Xứ";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Hạn Dùng";
            columnHeader6.Width = 150;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 192, 128);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(btnRemoveDate);
            groupBox3.Controls.Add(btnRemoveAll);
            groupBox3.Controls.Add(btnCheckDate);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(btnFindAmount);
            groupBox3.Controls.Add(dateTimePicker3);
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(btnFindDate);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(btnRemoveOrigin);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(btnFindOrigin);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtPriceTo);
            groupBox3.Controls.Add(txtPriceFrom);
            groupBox3.Controls.Add(btnFilterPrice);
            groupBox3.Controls.Add(btnDate);
            groupBox3.Controls.Add(btnPriceMax);
            groupBox3.Location = new Point(2, 307);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(466, 291);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(465, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 125);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // btnRemoveDate
            // 
            btnRemoveDate.BackColor = SystemColors.GradientInactiveCaption;
            btnRemoveDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemoveDate.Location = new Point(232, 253);
            btnRemoveDate.Name = "btnRemoveDate";
            btnRemoveDate.Size = new Size(228, 29);
            btnRemoveDate.TabIndex = 18;
            btnRemoveDate.Text = "Xóa SP Hết Hạn";
            btnRemoveDate.UseVisualStyleBackColor = false;
            btnRemoveDate.Click += button9_Click;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.BackColor = Color.Yellow;
            btnRemoveAll.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemoveAll.Location = new Point(6, 253);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(228, 29);
            btnRemoveAll.TabIndex = 17;
            btnRemoveAll.Text = "Xóa Toàn Bộ SP";
            btnRemoveAll.UseVisualStyleBackColor = false;
            btnRemoveAll.Click += button8_Click;
            // 
            // btnCheckDate
            // 
            btnCheckDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckDate.Location = new Point(6, 218);
            btnCheckDate.Name = "btnCheckDate";
            btnCheckDate.Size = new Size(452, 29);
            btnCheckDate.TabIndex = 16;
            btnCheckDate.Text = "Kiểm Tra Có Sản Phẩm Hết Hạn";
            btnCheckDate.UseVisualStyleBackColor = true;
            btnCheckDate.Click += button7_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(347, 183);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(111, 27);
            textBox6.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(219, 183);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(122, 27);
            textBox5.TabIndex = 14;
            // 
            // btnFindAmount
            // 
            btnFindAmount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnFindAmount.Location = new Point(6, 183);
            btnFindAmount.Name = "btnFindAmount";
            btnFindAmount.Size = new Size(207, 29);
            btnFindAmount.TabIndex = 13;
            btnFindAmount.Text = "Tìm Số Lượng Sản Phẩm";
            btnFindAmount.UseVisualStyleBackColor = true;
            btnFindAmount.Click += button6_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(318, 150);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(140, 27);
            dateTimePicker3.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(175, 150);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(140, 27);
            dateTimePicker2.TabIndex = 11;
            // 
            // btnFindDate
            // 
            btnFindDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnFindDate.Location = new Point(6, 148);
            btnFindDate.Name = "btnFindDate";
            btnFindDate.Size = new Size(163, 29);
            btnFindDate.TabIndex = 10;
            btnFindDate.Text = "Tìm SP Theo Ngày";
            btnFindDate.UseVisualStyleBackColor = true;
            btnFindDate.Click += button5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(159, 113);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 27);
            textBox4.TabIndex = 9;
            // 
            // btnRemoveOrigin
            // 
            btnRemoveOrigin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemoveOrigin.Location = new Point(6, 113);
            btnRemoveOrigin.Name = "btnRemoveOrigin";
            btnRemoveOrigin.Size = new Size(147, 29);
            btnRemoveOrigin.TabIndex = 8;
            btnRemoveOrigin.Text = "Xóa Xuất Xứ";
            btnRemoveOrigin.UseVisualStyleBackColor = true;
            btnRemoveOrigin.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(159, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 27);
            textBox3.TabIndex = 7;
            // 
            // btnFindOrigin
            // 
            btnFindOrigin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnFindOrigin.Location = new Point(6, 78);
            btnFindOrigin.Name = "btnFindOrigin";
            btnFindOrigin.Size = new Size(147, 29);
            btnFindOrigin.TabIndex = 6;
            btnFindOrigin.Text = "Tìm Xuất Xứ SP";
            btnFindOrigin.UseVisualStyleBackColor = true;
            btnFindOrigin.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(276, 48);
            label7.Name = "label7";
            label7.Size = new Size(39, 23);
            label7.TabIndex = 5;
            label7.Text = "đến";
            // 
            // txtPriceTo
            // 
            txtPriceTo.Location = new Point(318, 44);
            txtPriceTo.Name = "txtPriceTo";
            txtPriceTo.Size = new Size(141, 27);
            txtPriceTo.TabIndex = 4;
            // 
            // txtPriceFrom
            // 
            txtPriceFrom.Location = new Point(132, 44);
            txtPriceFrom.Name = "txtPriceFrom";
            txtPriceFrom.Size = new Size(138, 27);
            txtPriceFrom.TabIndex = 3;
            // 
            // btnFilterPrice
            // 
            btnFilterPrice.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilterPrice.Location = new Point(6, 43);
            btnFilterPrice.Name = "btnFilterPrice";
            btnFilterPrice.Size = new Size(120, 29);
            btnFilterPrice.TabIndex = 2;
            btnFilterPrice.Text = "Lọc Giá SP";
            btnFilterPrice.UseVisualStyleBackColor = true;
            btnFilterPrice.Click += button2_Click;
            // 
            // btnDate
            // 
            btnDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDate.Location = new Point(132, 7);
            btnDate.Name = "btnDate";
            btnDate.Size = new Size(328, 29);
            btnDate.TabIndex = 1;
            btnDate.Text = "Tìm Những SP Hết Hạn";
            btnDate.UseVisualStyleBackColor = true;
            btnDate.Click += button1_Click;
            // 
            // btnPriceMax
            // 
            btnPriceMax.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnPriceMax.Location = new Point(6, 7);
            btnPriceMax.Name = "btnPriceMax";
            btnPriceMax.Size = new Size(120, 29);
            btnPriceMax.TabIndex = 0;
            btnPriceMax.Text = "SP Giá MAX";
            btnPriceMax.UseVisualStyleBackColor = true;
            btnPriceMax.Click += btnPriceMax_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.Info;
            groupBox5.Controls.Add(listView2);
            groupBox5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(466, 307);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(734, 291);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh Sách Sản Phẩm Tìm Kiếm";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(7, 26);
            listView2.Name = "listView2";
            listView2.Size = new Size(721, 259);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Mã";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Tên";
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Số Lượng";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Đơn Giá";
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Xuất Xứ";
            columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Hạn Dùng";
            columnHeader12.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 658);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDelete;
        private Button btnSave;
        private DateTimePicker dateTimePicker1;
        private TextBox txtOrigin;
        private TextBox txtPrice;
        private TextBox txtAmount;
        private TextBox txtName;
        private TextBox txtID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnRemoveDate;
        private Button btnRemoveAll;
        private Button btnCheckDate;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button btnFindAmount;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private Button btnFindDate;
        private TextBox textBox4;
        private Button btnRemoveOrigin;
        private TextBox textBox3;
        private Button btnFindOrigin;
        private Label label7;
        private TextBox txtPriceTo;
        private TextBox txtPriceFrom;
        private Button btnFilterPrice;
        private Button btnDate;
        private Button btnPriceMax;
        private GroupBox groupBox5;
        private ListView listView2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
    }
}