
namespace HinhTron
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
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.btnTinhChuVi = new System.Windows.Forms.Button();
            this.btnTinhDienTich = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập bán kính hình tròn:";
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanKinh.Location = new System.Drawing.Point(209, 22);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(238, 26);
            this.txtBanKinh.TabIndex = 1;
            this.txtBanKinh.Text = "0";
            this.txtBanKinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBanKinh.TextChanged += new System.EventHandler(this.txtBanKinh_TextChanged);
            // 
            // btnTinhChuVi
            // 
            this.btnTinhChuVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhChuVi.Location = new System.Drawing.Point(15, 72);
            this.btnTinhChuVi.Name = "btnTinhChuVi";
            this.btnTinhChuVi.Size = new System.Drawing.Size(108, 46);
            this.btnTinhChuVi.TabIndex = 2;
            this.btnTinhChuVi.Text = "Tính chu vi";
            this.btnTinhChuVi.UseVisualStyleBackColor = true;
            this.btnTinhChuVi.Click += new System.EventHandler(this.btnTinhChuVi_Click);
            // 
            // btnTinhDienTich
            // 
            this.btnTinhDienTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhDienTich.Location = new System.Drawing.Point(168, 72);
            this.btnTinhDienTich.Name = "btnTinhDienTich";
            this.btnTinhDienTich.Size = new System.Drawing.Size(117, 46);
            this.btnTinhDienTich.TabIndex = 3;
            this.btnTinhDienTich.Text = "Tính diện tích";
            this.btnTinhDienTich.UseVisualStyleBackColor = true;
            this.btnTinhDienTich.Click += new System.EventHandler(this.btnTinhDienTich_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(339, 72);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 46);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(15, 147);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(433, 103);
            this.lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 259);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTinhDienTich);
            this.Controls.Add(this.btnTinhChuVi);
            this.Controls.Add(this.txtBanKinh);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Hình tròn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.Button btnTinhChuVi;
        private System.Windows.Forms.Button btnTinhDienTich;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblResult;
    }
}

