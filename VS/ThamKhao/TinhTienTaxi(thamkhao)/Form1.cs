using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienTaxi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TinhTien()
        {
            double distance = double.Parse(txtQuangDuong.Text);
            double soTien = 0;
            if(rdo7Cho.Checked) // 7 cho
            {
                if (distance <= 1)
                    soTien = 17000;
                else if (distance <= 5)
                    soTien = 17000 + (distance - 1) * 15000;
                else if (distance <= 100)
                    soTien = 17000 + 4 * 15000 + (distance - 5) * 12000;
                else
                    soTien = 17000 + 4 * 15000 + 95 * 12000 + (distance-100)*11000;
            }

            if(rdo4Cho.Checked) // 4 cho
            {
                if (distance <= 1)
                    soTien = 15000;
                else if (distance <= 5)
                    soTien = 15000 + (distance - 1) * 13500;
                else if (distance <= 100)
                    soTien = 15000 + 4 * 13500 + (distance - 5) * 11000;
                else
                    soTien = 15000 + 4 * 13500 + 95 * 11000 + (distance - 100) * 10000;
            }

            if (chkGiamGia.Checked) soTien *= 0.95;

            lblThanhTien.Text = soTien.ToString();
        }
        private void txtQuangDuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double quangDuong = double.Parse(txtQuangDuong.Text);
                if(quangDuong <= 0)
                {
                    lblThanhTien.Text = "Quãng đường phải > 0";
                }
                else
                {
                    lblThanhTien.ForeColor = Color.Black;
                    TinhTien();
                } 
            }
            catch
            {
                lblThanhTien.ForeColor = Color.Red;
                lblThanhTien.Text = "Error!";
            }
        }

        private void chkGiamGia_CheckedChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void rdo7Cho_CheckedChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void rdo4Cho_CheckedChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
