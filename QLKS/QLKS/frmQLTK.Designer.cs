﻿namespace QLKS
{
    partial class frmQLTK
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
            this.cbNameList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAD = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbDiachi = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người dùng";
            // 
            // cbNameList
            // 
            this.cbNameList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNameList.FormattingEnabled = true;
            this.cbNameList.Location = new System.Drawing.Point(165, 41);
            this.cbNameList.Name = "cbNameList";
            this.cbNameList.Size = new System.Drawing.Size(195, 30);
            this.cbNameList.TabIndex = 1;
            this.cbNameList.SelectedIndexChanged += new System.EventHandler(this.cbNameList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // tbTK
            // 
            this.tbTK.Location = new System.Drawing.Point(155, 121);
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(100, 22);
            this.tbTK.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quyền quản lí";
            // 
            // cbAD
            // 
            this.cbAD.FormattingEnabled = true;
            this.cbAD.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.cbAD.Location = new System.Drawing.Point(155, 309);
            this.cbAD.Name = "cbAD";
            this.cbAD.Size = new System.Drawing.Size(121, 24);
            this.cbAD.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(155, 177);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 22);
            this.tbEmail.TabIndex = 9;
            // 
            // tbDiachi
            // 
            this.tbDiachi.Location = new System.Drawing.Point(155, 227);
            this.tbDiachi.Name = "tbDiachi";
            this.tbDiachi.Size = new System.Drawing.Size(100, 22);
            this.tbDiachi.TabIndex = 10;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(155, 266);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(100, 22);
            this.tbSDT.TabIndex = 11;
            // 
            // frmQLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbDiachi);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.cbAD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNameList);
            this.Controls.Add(this.label1);
            this.Name = "frmQLTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLTK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNameList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAD;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbDiachi;
        private System.Windows.Forms.TextBox tbSDT;
    }
}