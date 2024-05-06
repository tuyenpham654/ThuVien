namespace QuanLyThuVien
{
    partial class PhieuMuonForm
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
            panel1 = new Panel();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            btnTimKiem = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            txtMaPM = new TextBox();
            dtNgayTra = new DateTimePicker();
            dtNgayMuon = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtMaTV = new TextBox();
            panel3 = new Panel();
            btnNew = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox5);
            panel1.Location = new Point(7, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(969, 92);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkViolet;
            label2.Location = new Point(402, 23);
            label2.Name = "label2";
            label2.Size = new Size(285, 54);
            label2.TabIndex = 3;
            label2.Text = "PHIẾU MƯỢN";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.khungvien;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(685, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(280, 76);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox3.BackgroundImage = Properties.Resources.khungvien1;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(15, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(280, 76);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.note;
            pictureBox5.BackgroundImageLayout = ImageLayout.None;
            pictureBox5.Location = new Point(299, -3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(98, 95);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(7, 103);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(965, 508);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(btnTimKiem);
            tabPage1.Controls.Add(txtSearch);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(957, 480);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Danh Sách";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(910, 375);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackgroundImage = Properties.Resources.tim;
            btnTimKiem.BackgroundImageLayout = ImageLayout.Zoom;
            btnTimKiem.Location = new Point(745, 23);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(52, 43);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(245, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Mã phiếu";
            txtSearch.Size = new Size(481, 43);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(104, 34);
            label1.Name = "label1";
            label1.Size = new Size(121, 29);
            label1.TabIndex = 0;
            label1.Text = "Tìm Kiếm";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(pictureBox6);
            tabPage2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(957, 480);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cập Nhật";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtMaPM);
            panel4.Controls.Add(dtNgayTra);
            panel4.Controls.Add(dtNgayMuon);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtMaTV);
            panel4.Location = new Point(85, 51);
            panel4.Name = "panel4";
            panel4.Size = new Size(731, 341);
            panel4.TabIndex = 4;
            // 
            // txtMaPM
            // 
            txtMaPM.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaPM.Location = new Point(241, 30);
            txtMaPM.Name = "txtMaPM";
            txtMaPM.Size = new Size(429, 39);
            txtMaPM.TabIndex = 4;
            // 
            // dtNgayTra
            // 
            dtNgayTra.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtNgayTra.Format = DateTimePickerFormat.Short;
            dtNgayTra.Location = new Point(241, 266);
            dtNgayTra.Margin = new Padding(3, 2, 3, 2);
            dtNgayTra.Name = "dtNgayTra";
            dtNgayTra.Size = new Size(429, 38);
            dtNgayTra.TabIndex = 15;
            // 
            // dtNgayMuon
            // 
            dtNgayMuon.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtNgayMuon.Format = DateTimePickerFormat.Short;
            dtNgayMuon.Location = new Point(241, 195);
            dtNgayMuon.Margin = new Padding(3, 2, 3, 2);
            dtNgayMuon.Name = "dtNgayMuon";
            dtNgayMuon.Size = new Size(429, 38);
            dtNgayMuon.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkViolet;
            label9.Location = new Point(3, 272);
            label9.Name = "label9";
            label9.Size = new Size(134, 32);
            label9.TabIndex = 13;
            label9.Text = "Ngày trả:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkViolet;
            label8.Location = new Point(3, 192);
            label8.Name = "label8";
            label8.Size = new Size(181, 32);
            label8.TabIndex = 12;
            label8.Text = "Ngày mượn:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkViolet;
            label7.Location = new Point(3, 113);
            label7.Name = "label7";
            label7.Size = new Size(206, 32);
            label7.TabIndex = 11;
            label7.Text = "Mã thành viên:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkViolet;
            label6.Location = new Point(3, 37);
            label6.Name = "label6";
            label6.Size = new Size(232, 32);
            label6.TabIndex = 10;
            label6.Text = "Mã phiếu mượn:";
            // 
            // txtMaTV
            // 
            txtMaTV.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMaTV.Location = new Point(241, 106);
            txtMaTV.Name = "txtMaTV";
            txtMaTV.Size = new Size(429, 39);
            txtMaTV.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnNew);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnInsert);
            panel3.Location = new Point(836, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(107, 361);
            panel3.TabIndex = 3;
            // 
            // btnNew
            // 
            btnNew.BackgroundImageLayout = ImageLayout.Center;
            btnNew.Image = Properties.Resources._new;
            btnNew.Location = new Point(15, 278);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(84, 80);
            btnNew.TabIndex = 3;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImageLayout = ImageLayout.Center;
            btnDelete.Image = Properties.Resources.xoa;
            btnDelete.Location = new Point(15, 106);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 80);
            btnDelete.TabIndex = 2;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackgroundImageLayout = ImageLayout.Center;
            btnUpdate.Image = Properties.Resources.update;
            btnUpdate.Location = new Point(15, 192);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(84, 80);
            btnUpdate.TabIndex = 1;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackgroundImageLayout = ImageLayout.Center;
            btnInsert.Image = Properties.Resources.them1;
            btnInsert.Location = new Point(15, 20);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(84, 80);
            btnInsert.TabIndex = 0;
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.dv2;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(45, 444);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(221, 26);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.dv1;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(3, 238);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 247);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.sach2;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(739, 361);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(254, 172);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // PhieuMuonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 623);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            MaximumSize = new Size(1000, 662);
            MinimumSize = new Size(1000, 662);
            Name = "PhieuMuonForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SachForm";
            Load += PhieuMuonForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnTimKiem;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Button btnNew;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Label label2;
        private TextBox txtMaTV;
        private TextBox txtMaPM;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox6;
        private DateTimePicker dtNgayMuon;
        private DateTimePicker dtNgayTra;
    }
}