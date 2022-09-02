namespace GiaiPTbac2
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
            this.lblNhap_a = new System.Windows.Forms.Label();
            this.txtNhap_a = new System.Windows.Forms.TextBox();
            this.txtNhap_b = new System.Windows.Forms.TextBox();
            this.lblNhap_b = new System.Windows.Forms.Label();
            this.txtNhap_c = new System.Windows.Forms.TextBox();
            this.lblNhap_c = new System.Windows.Forms.Label();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNhap_a
            // 
            this.lblNhap_a.AutoSize = true;
            this.lblNhap_a.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhap_a.Location = new System.Drawing.Point(55, 43);
            this.lblNhap_a.Name = "lblNhap_a";
            this.lblNhap_a.Size = new System.Drawing.Size(114, 20);
            this.lblNhap_a.TabIndex = 0;
            this.lblNhap_a.Text = "Nhập hệ số a:";
            // 
            // txtNhap_a
            // 
            this.txtNhap_a.Location = new System.Drawing.Point(187, 43);
            this.txtNhap_a.Name = "txtNhap_a";
            this.txtNhap_a.Size = new System.Drawing.Size(137, 20);
            this.txtNhap_a.TabIndex = 1;
            // 
            // txtNhap_b
            // 
            this.txtNhap_b.Location = new System.Drawing.Point(187, 89);
            this.txtNhap_b.Name = "txtNhap_b";
            this.txtNhap_b.Size = new System.Drawing.Size(137, 20);
            this.txtNhap_b.TabIndex = 3;
            // 
            // lblNhap_b
            // 
            this.lblNhap_b.AutoSize = true;
            this.lblNhap_b.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhap_b.Location = new System.Drawing.Point(55, 89);
            this.lblNhap_b.Name = "lblNhap_b";
            this.lblNhap_b.Size = new System.Drawing.Size(115, 20);
            this.lblNhap_b.TabIndex = 2;
            this.lblNhap_b.Text = "Nhập hệ số b:";
            this.lblNhap_b.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNhap_c
            // 
            this.txtNhap_c.Location = new System.Drawing.Point(187, 133);
            this.txtNhap_c.Name = "txtNhap_c";
            this.txtNhap_c.Size = new System.Drawing.Size(137, 20);
            this.txtNhap_c.TabIndex = 5;
            // 
            // lblNhap_c
            // 
            this.lblNhap_c.AutoSize = true;
            this.lblNhap_c.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhap_c.Location = new System.Drawing.Point(55, 133);
            this.lblNhap_c.Name = "lblNhap_c";
            this.lblNhap_c.Size = new System.Drawing.Size(113, 20);
            this.lblNhap_c.TabIndex = 4;
            this.lblNhap_c.Text = "Nhập hệ số c:";
            // 
            // btnGiai
            // 
            this.btnGiai.Location = new System.Drawing.Point(384, 43);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(124, 47);
            this.btnGiai.TabIndex = 6;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(384, 104);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 49);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txtNhap_c);
            this.Controls.Add(this.lblNhap_c);
            this.Controls.Add(this.txtNhap_b);
            this.Controls.Add(this.lblNhap_b);
            this.Controls.Add(this.txtNhap_a);
            this.Controls.Add(this.lblNhap_a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhap_a;
        private System.Windows.Forms.TextBox txtNhap_a;
        private System.Windows.Forms.TextBox txtNhap_b;
        private System.Windows.Forms.Label lblNhap_b;
        private System.Windows.Forms.TextBox txtNhap_c;
        private System.Windows.Forms.Label lblNhap_c;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
    }
}

