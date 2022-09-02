using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GiaiPTB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNhap_a.Text != "" && txtNhap_b.Text != "" && txtNhap_c.Text != "") //Các ô phải có dữ liệu mới thực hiện
            {
                int a, b, c, delta;
                float x1, x2, sqrt_delta;
                a = Convert.ToInt32(txtNhap_a.Text);
                b = Convert.ToInt32(txtNhap_b.Text);
                c = Convert.ToInt32(txtNhap_c.Text);
                delta = b * b - 4 * a * c;

                if (delta < 0) lblKetqua.Text = "Vô nghiệm";
                else
                    if (delta == 0)
                    {
                        x1 = -b / (2 * a);
                        lblKetqua.Text = "Phương trình có nghiệm kép: x=" + Convert.ToString(x1);
                    }
                    else
                    {
                        sqrt_delta = (float)Math.Sqrt(delta);
                        x1 = (-b + sqrt_delta) / (2 * a);
                        x2 = (-b - sqrt_delta) / (2 * a);
                        lblKetqua.Text = "Phương trình có 2 nghiệm phân biệt:\n      x1 = " + Convert.ToString(x1) + "\n      x2 = " + Convert.ToString(x2);
                    }
            }
            else MessageBox.Show("Chú ý: Nhập đủ các chỉ số!", "Lỗi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNhap_a.Text = txtNhap_b.Text = txtNhap_c.Text = "";
            lblKetqua.Text = "Ấn nút giải để nhận kết quả";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblKetqua.Text = "Ấn nút giải để nhận kết quả";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lblKetqua.Text = "Ấn nút giải để nhận kết quả";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            lblKetqua.Text = "Ấn nút giải để nhận kết quả";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNhap_c_Click(object sender, EventArgs e)
        {

        }

        private void lblNhap_b_Click(object sender, EventArgs e)
        {

        }
    }
}
