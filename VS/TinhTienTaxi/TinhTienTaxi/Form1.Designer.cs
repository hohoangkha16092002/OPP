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
            this.gBxBangGia = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInTien = new System.Windows.Forms.Label();
            this.lblTien = new System.Windows.Forms.Label();
            this.chkGiamGia = new System.Windows.Forms.CheckBox();
            this.gBxLoaiXe = new System.Windows.Forms.GroupBox();
            this.rBn4Cho = new System.Windows.Forms.RadioButton();
            this.rBn7Cho = new System.Windows.Forms.RadioButton();
            this.tBxQuangDuong = new System.Windows.Forms.TextBox();
            this.lblQuangDuong = new System.Windows.Forms.Label();
            this.gBxBangGia.SuspendLayout();
            this.gBxLoaiXe.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBxBangGia
            // 
            this.gBxBangGia.Controls.Add(this.btnClose);
            this.gBxBangGia.Controls.Add(this.lblInTien);
            this.gBxBangGia.Controls.Add(this.lblTien);
            this.gBxBangGia.Controls.Add(this.chkGiamGia);
            this.gBxBangGia.Controls.Add(this.gBxLoaiXe);
            this.gBxBangGia.Controls.Add(this.tBxQuangDuong);
            this.gBxBangGia.Controls.Add(this.lblQuangDuong);
            this.gBxBangGia.Cursor = System.Windows.Forms.Cursors.Default;
            this.gBxBangGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBxBangGia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxBangGia.Location = new System.Drawing.Point(0, 0);
            this.gBxBangGia.Name = "gBxBangGia";
            this.gBxBangGia.Size = new System.Drawing.Size(418, 326);
            this.gBxBangGia.TabIndex = 0;
            this.gBxBangGia.TabStop = false;
            this.gBxBangGia.Text = "Bảng giá";
            this.gBxBangGia.Enter += new System.EventHandler(this.gBxBangGia_Enter);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(316, 257);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInTien
            // 
            this.lblInTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInTien.AutoEllipsis = true;
            this.lblInTien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblInTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInTien.Location = new System.Drawing.Point(23, 257);
            this.lblInTien.Name = "lblInTien";
            this.lblInTien.Size = new System.Drawing.Size(281, 33);
            this.lblInTien.TabIndex = 5;
            this.lblInTien.Text = "                    ";
            // 
            // lblTien
            // 
            this.lblTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTien.AutoSize = true;
            this.lblTien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTien.Location = new System.Drawing.Point(23, 234);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(165, 23);
            this.lblTien.TabIndex = 4;
            this.lblTien.Text = "Số tiền thanh toán:";
            // 
            // chkGiamGia
            // 
            this.chkGiamGia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkGiamGia.AutoSize = true;
            this.chkGiamGia.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGiamGia.Location = new System.Drawing.Point(272, 148);
            this.chkGiamGia.Name = "chkGiamGia";
            this.chkGiamGia.Size = new System.Drawing.Size(105, 27);
            this.chkGiamGia.TabIndex = 3;
            this.chkGiamGia.Text = "Giảm giá";
            this.chkGiamGia.UseVisualStyleBackColor = true;
            this.chkGiamGia.CheckedChanged += new System.EventHandler(this.cBxGiamGia_CheckedChanged);
            // 
            // gBxLoaiXe
            // 
            this.gBxLoaiXe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBxLoaiXe.Controls.Add(this.rBn4Cho);
            this.gBxLoaiXe.Controls.Add(this.rBn7Cho);
            this.gBxLoaiXe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxLoaiXe.Location = new System.Drawing.Point(27, 117);
            this.gBxLoaiXe.Name = "gBxLoaiXe";
            this.gBxLoaiXe.Size = new System.Drawing.Size(219, 91);
            this.gBxLoaiXe.TabIndex = 2;
            this.gBxLoaiXe.TabStop = false;
            this.gBxLoaiXe.Text = "Loại xe";
            // 
            // rBn4Cho
            // 
            this.rBn4Cho.AutoSize = true;
            this.rBn4Cho.Dock = System.Windows.Forms.DockStyle.Right;
            this.rBn4Cho.Location = new System.Drawing.Point(137, 28);
            this.rBn4Cho.Name = "rBn4Cho";
            this.rBn4Cho.Size = new System.Drawing.Size(79, 60);
            this.rBn4Cho.TabIndex = 1;
            this.rBn4Cho.TabStop = true;
            this.rBn4Cho.Text = "4 Chổ";
            this.rBn4Cho.UseVisualStyleBackColor = true;
            this.rBn4Cho.CheckedChanged += new System.EventHandler(this.rBn4Cho_CheckedChanged);
            // 
            // rBn7Cho
            // 
            this.rBn7Cho.AutoSize = true;
            this.rBn7Cho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rBn7Cho.Location = new System.Drawing.Point(3, 28);
            this.rBn7Cho.Name = "rBn7Cho";
            this.rBn7Cho.Size = new System.Drawing.Size(213, 60);
            this.rBn7Cho.TabIndex = 0;
            this.rBn7Cho.TabStop = true;
            this.rBn7Cho.Text = "7 Chổ";
            this.rBn7Cho.UseVisualStyleBackColor = true;
            this.rBn7Cho.CheckedChanged += new System.EventHandler(this.rBn7Cho_CheckedChanged);
            // 
            // tBxQuangDuong
            // 
            this.tBxQuangDuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBxQuangDuong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxQuangDuong.Location = new System.Drawing.Point(253, 48);
            this.tBxQuangDuong.Name = "tBxQuangDuong";
            this.tBxQuangDuong.Size = new System.Drawing.Size(120, 32);
            this.tBxQuangDuong.TabIndex = 1;
            this.tBxQuangDuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBxQuangDuong.TextChanged += new System.EventHandler(this.tBxQuangDuong_TextChanged);
            // 
            // lblQuangDuong
            // 
            this.lblQuangDuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuangDuong.AutoSize = true;
            this.lblQuangDuong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuangDuong.Location = new System.Drawing.Point(51, 51);
            this.lblQuangDuong.Name = "lblQuangDuong";
            this.lblQuangDuong.Size = new System.Drawing.Size(196, 23);
            this.lblQuangDuong.TabIndex = 0;
            this.lblQuangDuong.Text = "Quảng đường đi (km):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 326);
            this.Controls.Add(this.gBxBangGia);
            this.Name = "Form1";
            this.Text = "Tính tiền Taxi";
            this.gBxBangGia.ResumeLayout(false);
            this.gBxBangGia.PerformLayout();
            this.gBxLoaiXe.ResumeLayout(false);
            this.gBxLoaiXe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBxBangGia;
        private System.Windows.Forms.Label lblInTien;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.CheckBox chkGiamGia;
        private System.Windows.Forms.GroupBox gBxLoaiXe;
        private System.Windows.Forms.RadioButton rBn4Cho;
        private System.Windows.Forms.RadioButton rBn7Cho;
        private System.Windows.Forms.Label lblQuangDuong;
        private System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.TextBox tBxQuangDuong;
    }
}

