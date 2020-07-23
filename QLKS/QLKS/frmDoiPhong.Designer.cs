namespace QLKS
{
    partial class frmDoiPhong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLpCu = new System.Windows.Forms.ComboBox();
            this.cbPCu = new System.Windows.Forms.ComboBox();
            this.cbLpMoi = new System.Windows.Forms.ComboBox();
            this.cbPMoi = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại phòng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPCu);
            this.groupBox1.Controls.Add(this.cbLpCu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng hiện tại";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPMoi);
            this.groupBox2.Controls.Add(this.cbLpMoi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 127);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phòng mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phòng:";
            // 
            // cbLpCu
            // 
            this.cbLpCu.FormattingEnabled = true;
            this.cbLpCu.Location = new System.Drawing.Point(264, 32);
            this.cbLpCu.Name = "cbLpCu";
            this.cbLpCu.Size = new System.Drawing.Size(121, 24);
            this.cbLpCu.TabIndex = 3;
            this.cbLpCu.SelectedIndexChanged += new System.EventHandler(this.cbLpCu_SelectedIndexChanged);
            // 
            // cbPCu
            // 
            this.cbPCu.FormattingEnabled = true;
            this.cbPCu.Location = new System.Drawing.Point(264, 74);
            this.cbPCu.Name = "cbPCu";
            this.cbPCu.Size = new System.Drawing.Size(121, 24);
            this.cbPCu.TabIndex = 4;
            this.cbPCu.SelectedIndexChanged += new System.EventHandler(this.cbPCu_SelectedIndexChanged);
            // 
            // cbLpMoi
            // 
            this.cbLpMoi.FormattingEnabled = true;
            this.cbLpMoi.Location = new System.Drawing.Point(264, 27);
            this.cbLpMoi.Name = "cbLpMoi";
            this.cbLpMoi.Size = new System.Drawing.Size(121, 24);
            this.cbLpMoi.TabIndex = 2;
            this.cbLpMoi.SelectedIndexChanged += new System.EventHandler(this.cbLpMoi_SelectedIndexChanged);
            // 
            // cbPMoi
            // 
            this.cbPMoi.FormattingEnabled = true;
            this.cbPMoi.Location = new System.Drawing.Point(264, 76);
            this.cbPMoi.Name = "cbPMoi";
            this.cbPMoi.Size = new System.Drawing.Size(121, 24);
            this.cbPMoi.TabIndex = 3;
            this.cbPMoi.SelectedIndexChanged += new System.EventHandler(this.cbPMoi_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDoiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmDoiPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoiPhong";
            this.Load += new System.EventHandler(this.frmDoiPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPCu;
        private System.Windows.Forms.ComboBox cbLpCu;
        private System.Windows.Forms.ComboBox cbPMoi;
        private System.Windows.Forms.ComboBox cbLpMoi;
        private System.Windows.Forms.Button button1;
    }
}