using System;
using System.Collections.Generic;
using System.Text;
/*Xây dựng lớp XeCon kế thừa lớp Xe và có thêm thuộc tính: số chỗ ngồi, loại xe (sedal/SUV/bán tải).
Yêu cầu:
a) Cài đặt các lớp với các phương thức sau:
- Phương thức thiết lập có tham số và không có tham số.
- Phương thức Nhap() để nhập thông tin xe.
- Phương thức Xuat() để in thông tin xe.
*/
//*************************************************************************************************************************//
/*b) Nhập danh sách n xe con (0 - In ra danh sách xe và thông số kèm theo.
- Tìm xe có giá thấp nhất, cao nhất.
- Nhập 2 chữ số đầu biển số (ví dụ 79), in ra tất cả xe thuộc tỉnh có biển số đó.
- Sắp xếp danh sách xe theo thứ tự tăng dần của năm sản xuất, in ra danh sách sau sắp xếp.*/
namespace Qly_Xe
{
    class Xe
    {
        private String _bienSo;
        private int _namSX;
        private double _gia;

        public Xe()
        {
        }

        public Xe(String bienso, int namsx, double gia)
        {
            _bienSo = bienso;
            _namSX = namsx;
            _gia = gia;
        }

        public String BIENSO
        {
            get { return _bienSo; }
            set { _bienSo = value; }
        }

        public int NAMSX
        {
            get { return _namSX; }
            set { _namSX = value; }
        }

        public double GIA
        {
            get { return _gia; }
            set { _gia = value; }
        }
        //-------------------------------------------------------------------------------------------------------------//
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhập biển số xe (79A-12345):  ");
            _bienSo = Console.ReadLine();
            try
            {
                Console.Write("Nhập năm sản xuất:  ");
                _namSX = int.Parse(Console.ReadLine());
                Console.Write("Nhập giá:  ");
                _gia = double.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Sai định dạng, phải là số!");
            }
        }

        public void Xuat()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Biển số: {0}  | Năm sản xuất: {1}  | Giá: {2}", _bienSo, _namSX, _gia);
        }
    }
    // end of class xe
    //**********************************************************************************************************************//
    class XeCon : Xe
    {
        private int _soChoNgoi;
        private String _loaiXe;
        public XeCon() { }
        public XeCon(String bienso, int namsx, double gia, int sochongoi, String loaixe) : base(bienso, namsx, gia)
        {
            sochongoi = _soChoNgoi;
            loaixe = _loaiXe;
        }
        public String LOAIXE
        {

            get { return _loaiXe; }
            set { _loaiXe = value; }
        }
        public int SOCHONGOI
        {
            get { return _soChoNgoi; }
            set { _soChoNgoi = value; }
        }
        //-------------------------------------------------------------------------------------------------------------//
        public new void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            base.Nhap();
            try
            {
                Console.Write("Nhập số chổ ngồi:  ");
                _soChoNgoi = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Sai định dạng, phải là số!");
            }
            Console.Write("Nhập loại xe (Sedal/SUV/Bán tải):  ");
            _loaiXe = Console.ReadLine();
        }
        public new void Xuat()
        {
            Console.OutputEncoding = Encoding.Unicode;
            base.Xuat();
            Console.Write("  |Số chổ ngồi: {0}  |Loại xe: {1}\n", _soChoNgoi, _loaiXe);
        }
        public int CompareTo(XeCon xecons) // OverRight phương thức CompareTo của Interface IComparable
        {
            return this.LOAIXE.CompareTo(xecons.LOAIXE); //Phương thức CompareTo này có sẵn với các kiểu cơ bản như Integer, String.
        }
    }
    class QuanLyXeCon
    {
        private List<XeCon> xeconL = new List<XeCon>();
        private int _soLuong;
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.Unicode;
            int a = 1;
            do
            {
                Console.Write("Nhập số lượng xe =  ");
                _soLuong = int.Parse(Console.ReadLine());
            } while (_soLuong < 0);

            for (int i = 0; i < _soLuong; i++)
            {
                Console.WriteLine("\t\tXe thứ {0}", a);
                XeCon xecon = new XeCon();
                xecon.Nhap();
                xeconL.Add(xecon);
                a++;
            }
        }
        public void Xuat()
        {
            foreach (XeCon xecons in xeconL)
            {
                xecons.Xuat();
            }
        }
        public void GiaCaoNhat()
        {
            Console.OutputEncoding = Encoding.Unicode;
            double max = xeconL[0].GIA;
            foreach (XeCon xecons in xeconL)
            {
                if (max < xecons.GIA)
                {
                    max = xecons.GIA;
                }
            }
            Console.WriteLine("Gái xe cao nhất =  " + max);
        }
        public void GiaThapNhat()
        {
            Console.OutputEncoding = Encoding.Unicode;
            double min = xeconL[0].GIA;
            foreach (XeCon xecons in xeconL)
            {
                if (min > xecons.GIA)
                {
                    min = xecons.GIA;
                }
            }
            Console.WriteLine("Giá xe thấp nhất =  " + min);
        }
        public void TimXeBang_BS()
        {
            Console.OutputEncoding = Encoding.Unicode;
            String bienso;
            Console.Write("Nhập 2 chữ số đầu tiên trong biển số: ");
            bienso = Console.ReadLine();

            // tim bien so co 2 chu so dau trung voi so nguoi dung nhap vao!
            foreach (XeCon xecons in xeconL)
            {
                // neu 2 chu so dau tien cua bien so trong List trung voi cua nguoi dung -> xuat
                if (bienso.Equals(xecons.BIENSO.Substring(0, 2)))
                {
                    Console.WriteLine("Thông tin xe cần tìm dựa vào biển số:");
                    xecons.Xuat();
                }
            }
        }
        public void SXTangDan_theoNam()
        {
            xeconL.Sort(
                (p1, p2) =>
                {
                    if (p1.NAMSX == p2.NAMSX) return 0;
                    if (p1.NAMSX > p2.NAMSX) return 1;
                    else return -1;
                }
            );
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Danh sách xe sau khi sắp xếp tăng dần theo năm sản xuất:");
            Xuat();
        }
    }
    class Run
    {
        static void Main()
        {
            QuanLyXeCon qlxc = new QuanLyXeCon();
            qlxc.Nhap();
            Console.WriteLine("====================================================================");
            qlxc.Xuat();
            Console.WriteLine("====================================================================");
            qlxc.GiaCaoNhat();
            Console.WriteLine("====================================================================");
            qlxc.GiaThapNhat();
            Console.WriteLine("====================================================================");
            qlxc.TimXeBang_BS();
            Console.WriteLine("====================================================================");
            qlxc.SXTangDan_theoNam();
            Console.WriteLine("====================================================================");
        }
    }
}