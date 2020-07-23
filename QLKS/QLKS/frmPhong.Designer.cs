namespace QLKS
{
    partial class frmPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tenPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loaiPhong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ghiChuPhong = new System.Windows.Forms.TextBox();
            this.flpPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.donGia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maPhong = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvChiTietPhong = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo phòng";
            // 
            // tenPhong
            // 
            this.tenPhong.Location = new System.Drawing.Point(118, 115);
            this.tenPhong.Name = "tenPhong";
            this.tenPhong.Size = new System.Drawing.Size(181, 22);
            this.tenPhong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại phòng";
            // 
            // loaiPhong
            // 
            this.loaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loaiPhong.FormattingEnabled = true;
            this.loaiPhong.Location = new System.Drawing.Point(118, 156);
            this.loaiPhong.Name = "loaiPhong";
            this.loaiPhong.Size = new System.Drawing.Size(181, 24);
            this.loaiPhong.TabIndex = 4;
            this.loaiPhong.SelectedIndexChanged += new System.EventHandler(this.loaiPhong_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ghi chú";
            // 
            // ghiChuPhong
            // 
            this.ghiChuPhong.Location = new System.Drawing.Point(324, 114);
            this.ghiChuPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ghiChuPhong.Multiline = true;
            this.ghiChuPhong.Name = "ghiChuPhong";
            this.ghiChuPhong.Size = new System.Drawing.Size(241, 62);
            this.ghiChuPhong.TabIndex = 10;
            // 
            // flpPhong
            // 
            this.flpPhong.AutoScroll = true;
            this.flpPhong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpPhong.Location = new System.Drawing.Point(0, 245);
            this.flpPhong.Name = "flpPhong";
            this.flpPhong.Size = new System.Drawing.Size(980, 280);
            this.flpPhong.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Đơn giá:";
            // 
            // donGia
            // 
            this.donGia.AutoSize = true;
            this.donGia.Location = new System.Drawing.Point(256, 204);
            this.donGia.Name = "donGia";
            this.donGia.Size = new System.Drawing.Size(0, 17);
            this.donGia.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã phòng:";
            // 
            // maPhong
            // 
            this.maPhong.AutoSize = true;
            this.maPhong.Location = new System.Drawing.Point(115, 204);
            this.maPhong.Name = "maPhong";
            this.maPhong.Size = new System.Drawing.Size(0, 17);
            this.maPhong.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(407, 200);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 28);
            this.button3.TabIndex = 17;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 200);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 28);
            this.button2.TabIndex = 18;
            this.button2.Text = "Xoá";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Thông tin phòng";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(0, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(980, 2);
            this.label7.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(3, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(980, 2);
            this.label9.TabIndex = 22;
            // 
            // dgvChiTietPhong
            // 
            this.dgvChiTietPhong.AllowUserToAddRows = false;
            this.dgvChiTietPhong.AllowUserToDeleteRows = false;
            this.dgvChiTietPhong.AllowUserToResizeColumns = false;
            this.dgvChiTietPhong.AllowUserToResizeRows = false;
            this.dgvChiTietPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvChiTietPhong.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvChiTietPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiTietPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhong.Location = new System.Drawing.Point(0, 567);
            this.dgvChiTietPhong.Name = "dgvChiTietPhong";
            this.dgvChiTietPhong.RowHeadersWidth = 49;
            this.dgvChiTietPhong.RowTemplate.Height = 24;
            this.dgvChiTietPhong.Size = new System.Drawing.Size(980, 130);
            this.dgvChiTietPhong.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 544);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Chi tiết phòng";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(115, 544);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(0, 17);
            this.lblTenPhong.TabIndex = 25;
            // 
            // frmPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblTenPhong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvChiTietPhong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maPhong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.donGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flpPhong);
            this.Controls.Add(this.ghiChuPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loaiPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tenPhong);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPhong";
            this.Size = new System.Drawing.Size(980, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox loaiPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ghiChuPhong;
        private System.Windows.Forms.FlowLayoutPanel flpPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label donGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label maPhong;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvChiTietPhong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTenPhong;
    }
}
