namespace GiaiPTB2
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
            this.lblNhap_b = new System.Windows.Forms.Label();
            this.lblNhap_c = new System.Windows.Forms.Label();
            this.txtNhap_a = new System.Windows.Forms.TextBox();
            this.txtNhap_b = new System.Windows.Forms.TextBox();
            this.txtNhap_c = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnNhaplai = new System.Windows.Forms.Button();
            this.gbxNhap = new System.Windows.Forms.GroupBox();
            this.gbxKetqua = new System.Windows.Forms.GroupBox();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbxNhap.SuspendLayout();
            this.gbxKetqua.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNhap_a
            // 
            this.lblNhap_a.AutoSize = true;
            this.lblNhap_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNhap_a.Location = new System.Drawing.Point(31, 28);
            this.lblNhap_a.Name = "lblNhap_a";
            this.lblNhap_a.Size = new System.Drawing.Size(57, 17);
            this.lblNhap_a.TabIndex = 0;
            this.lblNhap_a.Text = "Hệ số a";
            // 
            // lblNhap_b
            // 
            this.lblNhap_b.AutoSize = true;
            this.lblNhap_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNhap_b.Location = new System.Drawing.Point(30, 65);
            this.lblNhap_b.Name = "lblNhap_b";
            this.lblNhap_b.Size = new System.Drawing.Size(57, 17);
            this.lblNhap_b.TabIndex = 1;
            this.lblNhap_b.Text = "Hệ số b";
            this.lblNhap_b.Click += new System.EventHandler(this.lblNhap_b_Click);
            // 
            // lblNhap_c
            // 
            this.lblNhap_c.AutoSize = true;
            this.lblNhap_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNhap_c.Location = new System.Drawing.Point(31, 102);
            this.lblNhap_c.Name = "lblNhap_c";
            this.lblNhap_c.Size = new System.Drawing.Size(56, 17);
            this.lblNhap_c.TabIndex = 2;
            this.lblNhap_c.Text = "Hệ số c";
            this.lblNhap_c.Click += new System.EventHandler(this.lblNhap_c_Click);
            // 
            // txtNhap_a
            // 
            this.txtNhap_a.Location = new System.Drawing.Point(94, 28);
            this.txtNhap_a.Name = "txtNhap_a";
            this.txtNhap_a.Size = new System.Drawing.Size(100, 20);
            this.txtNhap_a.TabIndex = 1;
            this.txtNhap_a.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNhap_b
            // 
            this.txtNhap_b.Location = new System.Drawing.Point(94, 65);
            this.txtNhap_b.Name = "txtNhap_b";
            this.txtNhap_b.Size = new System.Drawing.Size(100, 20);
            this.txtNhap_b.TabIndex = 2;
            this.txtNhap_b.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNhap_c
            // 
            this.txtNhap_c.Location = new System.Drawing.Point(94, 102);
            this.txtNhap_c.Name = "txtNhap_c";
            this.txtNhap_c.Size = new System.Drawing.Size(100, 20);
            this.txtNhap_c.TabIndex = 3;
            this.txtNhap_c.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnGiai
            // 
            this.btnGiai.Location = new System.Drawing.Point(12, 173);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(75, 23);
            this.btnGiai.TabIndex = 4;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNhaplai
            // 
            this.btnNhaplai.Location = new System.Drawing.Point(93, 173);
            this.btnNhaplai.Name = "btnNhaplai";
            this.btnNhaplai.Size = new System.Drawing.Size(75, 23);
            this.btnNhaplai.TabIndex = 5;
            this.btnNhaplai.Text = "Nhập lại";
            this.btnNhaplai.UseVisualStyleBackColor = true;
            this.btnNhaplai.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbxNhap
            // 
            this.gbxNhap.Controls.Add(this.txtNhap_b);
            this.gbxNhap.Controls.Add(this.lblNhap_a);
            this.gbxNhap.Controls.Add(this.lblNhap_b);
            this.gbxNhap.Controls.Add(this.txtNhap_c);
            this.gbxNhap.Controls.Add(this.lblNhap_c);
            this.gbxNhap.Controls.Add(this.txtNhap_a);
            this.gbxNhap.Location = new System.Drawing.Point(12, 12);
            this.gbxNhap.Name = "gbxNhap";
            this.gbxNhap.Size = new System.Drawing.Size(238, 155);
            this.gbxNhap.TabIndex = 6;
            this.gbxNhap.TabStop = false;
            this.gbxNhap.Text = "Nhập hệ số";
            // 
            // gbxKetqua
            // 
            this.gbxKetqua.Controls.Add(this.lblKetqua);
            this.gbxKetqua.Location = new System.Drawing.Point(12, 212);
            this.gbxKetqua.Name = "gbxKetqua";
            this.gbxKetqua.Size = new System.Drawing.Size(238, 74);
            this.gbxKetqua.TabIndex = 7;
            this.gbxKetqua.TabStop = false;
            this.gbxKetqua.Text = "Kết quả";
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Location = new System.Drawing.Point(7, 20);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(141, 13);
            this.lblKetqua.TabIndex = 0;
            this.lblKetqua.Text = "Ấn nút Giải để nhận kết quả";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(174, 173);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 312);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.gbxKetqua);
            this.Controls.Add(this.gbxNhap);
            this.Controls.Add(this.btnNhaplai);
            this.Controls.Add(this.btnGiai);
            this.Name = "Form1";
            this.Text = "Giải phương trình bậc 2";
            this.gbxNhap.ResumeLayout(false);
            this.gbxNhap.PerformLayout();
            this.gbxKetqua.ResumeLayout(false);
            this.gbxKetqua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNhap_a;
        private System.Windows.Forms.Label lblNhap_b;
        private System.Windows.Forms.Label lblNhap_c;
        private System.Windows.Forms.TextBox txtNhap_a;
        private System.Windows.Forms.TextBox txtNhap_b;
        private System.Windows.Forms.TextBox txtNhap_c;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnNhaplai;
        private System.Windows.Forms.GroupBox gbxNhap;
        private System.Windows.Forms.GroupBox gbxKetqua;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.Button btnThoat;
    }
}

