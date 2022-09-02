using System.Text;
using System.Collections.Generic;
using System;
using System.Linq;
using fstream;
using System.IO;
public interface GiaoDich
{ //properties
    private const double Min = 50;
    //Methods
    void TinhPhiDichVu();
}
//*************************************************************************************************************************************//
namespace TheGhiNo
{
    class The
    {
        private double _sothe;
        private String _hoten;
        public The()
        {
        }
        public The(double sothe, String hoten)
        {
            sothe = _sothe;
            hoten = _hoten;
        }

        public double SOTHE
        {
            get { return _sothe; }
            set { _sothe = value; }
        }
        public String HOTEN
        {
            get { return _hoten; }
            set { _hoten = value; }
        }
        public void Xuat()
        {
            Console.Write("Họ tên: {0}  ||Số thẻ: {1}\n", _hoten, _sothe);
        }
    }
    //*************************************************************************************************************************************//
    class TheGhiNoNoiDia : The, GiaoDich
    {
        private double _sodu;
        public double SODU
        {
            get { return _sodu; }
            set { _sodu = value; }
        }
        public TheGhiNoNoiDia(double sodu)
        {
            sodu = _sodu;
        }
        public void ThanhToanMuaHang(int m)
        {
            if (m < _sodu)
            {
                _sodu = _sodu - m;
            }
            else
                System.Console.WriteLine("Thanh toán thất bại");
        }
        public void KiemTraSoDu()
        {
            WriteLine("Số thẻ: {0}\nNgày hiện tại trong hệ thống: {1}\nSố dư: {2}", _sothe, DateTime.Now.Day, _sodu);
        }
        public override double TinhPhiDichVu()
        {
            if (_sodu <= Min)
            {
                return 5000;
            }
            else return 12000;
        }
    }
    class Nhap
    {
        private List<TheGhiNoNoiDia> _tgnnd = new List<TheGhiNoNoiDia>();
        public void Nhap()
        {
            string[] a = File.ReadAllLines("data.txt");
            for (int i = 0; i < a.Length; i + 3)
            {
                if (a[i] == null)
                    TheGhiNoNoiDia tgnnd = new TheGhiNoNoiDia();
                for (int j = i; j < i + 3; j++)
                {
                    tgnnd.SOTHE = a[j];
                    Console.Write(i + ". ");
                    Console.WriteLine(a[i]);
                }
            }

            Console.ReadKey();
        }


        public void Xuat()
        {
            foreach (NhanVien nv in _nvL)
            {
                nv.Xuat();
            }
        }


        public void SortLuong()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Lương sắp xếp theo thứ tự giảm dần:");
            _nvL.Sort(
                (p1, p2) =>
                {
                    if (p1.LUONG == p2.LUONG) return 0;
                    if (p1.LUONG < p2.LUONG) return 1;
                    else return -1;
                }
            );
            Xuat();
        }
    }

    //*************************************************************************************************************************************//
    class Run
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            QuanLyNhanVien ql = new QuanLyNhanVien();
            ql.Nhap();
            Console.WriteLine("====================================================================");
            ql.Xuat();
            Console.WriteLine("====================================================================");
            ql.SortLuong();
        }
    }
}