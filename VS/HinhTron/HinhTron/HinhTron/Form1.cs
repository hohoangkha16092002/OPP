using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HinhTron
{
    public partial class Form1 : Form
    {
        public static double Pi = 3.1416;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinhChuVi_Click(object sender, EventArgs e)
        {
            // Đọc giá trị bán kính từ TextBox:
            double r = 0;
            bool result = double.TryParse(txtBanKinh.Text, out r);
            // Tính chu vi & gửi giá trị cho Label kết quả:
            if (!result)
            {
                lblResult.Text = "Không phải giá trị số";
            }    
            else
            if(r < 0)
            {
                lblResult.Text = "Không thỏa mãn là bán kính hình tròn";
            }    
            else
            {
                double ChuVi = 2 * r * Pi;
                lblResult.Text = "Chu vi = " + ChuVi.ToString();                
            }
        }

        private void txtBanKinh_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhDienTich_Click(object sender, EventArgs e)
        {
            // Đọc giá trị bán kính từ TextBox:
            double r = 0;
            bool result = double.TryParse(txtBanKinh.Text, out r);
            // Tính diện tích & gửi giá trị cho Label kết quả:
            if (!result)
            {
                lblResult.Text = "Không phải giá trị số";
            }
            else
            if (r < 0)
            {
                lblResult.Text = "Không thỏa mãn là bán kính hình tròn";
            }
            else
            {
                double DienTich = r * r * Pi;
                lblResult.Text = "Diện tích = " + DienTich.ToString();
            }
        }
    }
}
