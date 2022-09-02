
namespace TinhTienTaxi
{
    partial class Form1
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
            this.txtQuangDuong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo4Cho = new System.Windows.Forms.RadioButton();
            this.rdo7Cho = new System.Windows.Forms.RadioButton();
            this.chkGiamGia = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bảngGiáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quãng đường đi (km):";
            // 
            // txtQuangDuong
            // 
            this.txtQuangDuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuangDuong.Location = new System.Drawing.Point(244, 29);
            this.txtQuangDuong.Name = "txtQuangDuong";
            this.txtQuangDuong.Size = new System.Drawing.Size(142, 26);
            this.txtQuangDuong.TabIndex = 1;
            this.txtQuangDuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuangDuong.TextChanged += new System.EventHandler(this.txtQuangDuong_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo4Cho);
            this.groupBox1.Controls.Add(this.rdo7Cho);
            this.groupBox1.Location = new System.Drawing.Point(39, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 62);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại xe";
            // 
            // rdo4Cho
            // 
            this.rdo4Cho.AutoSize = true;
            this.rdo4Cho.Location = new System.Drawing.Point(134, 25);
            this.rdo4Cho.Name = "rdo4Cho";
            this.rdo4Cho.Size = new System.Drawing.Size(66, 24);
            this.rdo4Cho.TabIndex = 4;
            this.rdo4Cho.Text = "4 chỗ";
            this.rdo4Cho.UseVisualStyleBackColor = true;
            this.rdo4Cho.CheckedChanged += new System.EventHandler(this.rdo4Cho_CheckedChanged);
            // 
            // rdo7Cho
            // 
            this.rdo7Cho.AutoSize = true;
            this.rdo7Cho.Checked = true;
            this.rdo7Cho.Location = new System.Drawing.Point(23, 25);
            this.rdo7Cho.Name = "rdo7Cho";
            this.rdo7Cho.Size = new System.Drawing.Size(66, 24);
            this.rdo7Cho.TabIndex = 3;
            this.rdo7Cho.TabStop = true;
            this.rdo7Cho.Text = "7 chỗ";
            this.rdo7Cho.UseVisualStyleBackColor = true;
            this.rdo7Cho.CheckedChanged += new System.EventHandler(this.rdo7Cho_CheckedChanged);
            // 
            // chkGiamGia
            // 
            this.chkGiamGia.AutoSize = true;
            this.chkGiamGia.Location = new System.Drawing.Point(295, 89);
            this.chkGiamGia.Name = "chkGiamGia";
            this.chkGiamGia.Size = new System.Drawing.Size(91, 24);
            this.chkGiamGia.TabIndex = 3;
            this.chkGiamGia.Text = "Giảm giá";
            this.chkGiamGia.UseVisualStyleBackColor = true;
            this.chkGiamGia.CheckedChanged += new System.EventHandler(this.chkGiamGia_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bảngGiáToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bảngGiáToolStripMenuItem
            // 
            this.bảngGiáToolStripMenuItem.Name = "bảngGiáToolStripMenuItem";
            this.bảngGiáToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.bảngGiáToolStripMenuItem.Text = "Bảng giá";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(284, 184);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblThanhTien.Location = new System.Drawing.Point(35, 184);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(243, 40);
            this.lblThanhTien.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số tiền thanh toán:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 235);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkGiamGia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtQuangDuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Tính tiền taxi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuangDuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo4Cho;
        private System.Windows.Forms.RadioButton rdo7Cho;
        private System.Windows.Forms.CheckBox chkGiamGia;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bảngGiáToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label label2;
    }
}

