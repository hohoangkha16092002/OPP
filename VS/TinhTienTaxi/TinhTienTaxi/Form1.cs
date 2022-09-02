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
        public static int _7gia0toi1 = 17000;
        public static int _7gia2toi5 = 15000;
        public static int _7gia6toi100 = 12000;
        public static int _7giatu101 = 11000;

        public static int _4gia0toi1 = 15000;
        public static int _4gia2toi5 = 13500;
        public static int _4gia6toi100 = 11000;
        public static int _4giatu101 = 10000;
        public Form1()
        {
            InitializeComponent();
        }
        private void TinhTien()
        {
            bool inputOK;
            double qd;
            double thanhtien = 0;

            inputOK = double.TryParse(tBxQuangDuong.Text, out qd);

            if(inputOK)
            {
                if (rBn7Cho.Checked == true) /// 7 CHO
                {
                    if (qd <= 1)
                        thanhtien = _7gia0toi1;
                    else if (qd <= 5)
                        thanhtien = _7gia0toi1 + (qd - 1) * _7gia2toi5;
                    else if (qd <= 100)
                        thanhtien = _7gia0toi1 + (qd - 1) * _7gia2toi5 + (qd - 5) * _7gia6toi100;
                    else
                        thanhtien = _7gia0toi1 + (qd - 1) * _7gia2toi5 + (qd - 5) * _7gia6toi100 + (qd - 100) * _7giatu101;
                }

                if (rBn4Cho.Checked == true) /// 4 CHO
                {
                    if (qd <= 1)
                        thanhtien = _4gia0toi1;
                    else if (qd <= 5)
                        thanhtien = _4gia0toi1 + (qd - 1) * _4gia2toi5;
                    else if (qd <= 100)
                        thanhtien = _4gia0toi1 + (qd - 1) * _4gia2toi5 + (qd - 5) * _4gia6toi100;
                    else
                        thanhtien = _4gia0toi1 + (qd - 1) * _4gia2toi5 + (qd - 5) * _4gia6toi100 + (qd - 100) * _4giatu101;
                }
                if (chkGiamGia.Checked) thanhtien *= 0.95;
                lblInTien.ForeColor = Color.Green;
                lblInTien.Text = thanhtien.ToString();
                lblInTien.ForeColor = Color.Black;
            }
        }
        private void gBxBangGia_Enter(object sender, EventArgs e)
        {
           
        }

        private void tBxQuangDuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double quangDuong = double.Parse(tBxQuangDuong.Text);
                if (quangDuong < 0)
                {
                    lblInTien.Text = "Quãng đường phải > 0";
                }
                
                else
                {
                    lblInTien.ForeColor = Color.Black;
                    TinhTien();
                }
            }
            catch
            {
                if (tBxQuangDuong.Text == "")
                {
                    lblInTien.ForeColor = Color.Red;
                    lblInTien.Text = "Hãy nhập quảng đường";
                    
                }    
                    
                else
                {
                    lblInTien.ForeColor = Color.Red;
                    lblInTien.Text = "Error!";
                }    
            }
        }

        private void cBxGiamGia_CheckedChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void rBn7Cho_CheckedChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void rBn4Cho_CheckedChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
