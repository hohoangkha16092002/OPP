using System.Text;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using System.Data;

/*Một Công ty có hai loại nhân viên: Nhân viên văn phòng và Nhân viên sản xuất. Mỗi nhân viên cần quản lý các thông tin sau: Họ tên, ngày sinh, lương.
Công ty cần tính lương cho nhân viên như sau:
- Đối với nhân viên sản xuất: Lương = lương căn bản + số sản phẩm * 5.000
- Đối với nhân viên văn phòng: Lương = số ngày làm việc * 100.000
Yêu cầu:
- Cài đặt các lớp Nhân viên, Nhân viên văn phòng, Nhân viên sản xuất; trong đó các lớp Nhân viên văn phòng, Nhân viên sản xuất kế thừa lớp Nhân viên.
- Chương trình chính:
+ Nhập danh sách n nhân viên, mỗi nhân viên thuộc 1 trong 2 loại: Nhân viên văn phòng hoặc Nhân viên sản xuất.
+ In ra danh sách nhân viên kèm thông tin chi tiết.
+ Sắp xếp danh sách nhân viên theo thứ tự giảm dần của lương và in ra màn hình.*/
namespace CongTy
{
    class NhanVien
    {
        private String _hoTen;
        private String _ngaySinh;
        private double _luong;
        public NhanVien()
        {
        }
        public NhanVien(String hoten, String ngaysinh, double luong)
        {
            hoten = _hoTen;
            ngaysinh = _ngaySinh;
            luong = _luong;
        }
        public String HOTEN
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        public String NGAYSINH
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }
        public double LUONG
        {
            get { return _luong; }
            set { _luong = value; }
        }
        public double getLuong()
        {
            return _luong;
        }
        public string String()
        {
            return $"Họ tên: {_hoTen}  ||Ngày sinh: {_ngaySinh}  ||Lương:  {_luong}\n";
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        public void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Họ tên: ");
            _hoTen = Console.ReadLine();
            Console.Write("Ngày sinh: ");
            _ngaySinh = Console.ReadLine();
        }
        public void KC(String khoangcach)
        {
            for (int i = 0; i < 20 - khoangcach.Length; i++)
            {
                Console.Write(" ");
            }
        }
        public void Xuat()
        {
            //Console.Write("Họ tên: {0} || Ngày sinh: {1} || Lương: {2}",_hoTen, _ngaySinh, _luong);
            Console.Write("Họ tên: {0} ", _hoTen); KC(_hoTen);
            Console.Write("|| Ngày sinh: {0} ", _ngaySinh); KC(_ngaySinh.ToString());
            Console.Write("|| Lương: {0} ", _luong); KC(_luong.ToString());
            Console.Write(Environment.NewLine);
        }
    }
    // end of class NhanVien
    //****************************************************************************************************************************//
    class NhanVienSX : NhanVien
    {
        private const double _luongCanBan = 1500000;
        private int _soSP;
        public NhanVienSX()
        {
        }
        public NhanVienSX(String hoten, String ngaysinh, double luong, double luongcb, int sosanpham) : base(hoten, ngaysinh, luong)
        {
            luongcb = _luongCanBan;
            sosanpham = _soSP;
        }
        public double LUONGCANBAN
        {
            get { return _luongCanBan; }
        }
        public int SOSP
        {
            get { return _soSP; }
            set { _soSP = value; }
        }
        public new double getLuong()
        {
            return base.getLuong() + _luongCanBan + _soSP * 5.000;
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        public new void Nhap()
        {
            Console.OutputEncoding = Encoding.Unicode;
            base.Nhap();
            Console.Write("Số sản phẩm:  ");
            _soSP = int.Parse(Console.ReadLine());
        }
    }
    // end of class NhanVienSX    
    class NhanVienVP : NhanVien
    {
        private int _soNgayLam;
        public NhanVienVP()
        {
        }
        public NhanVienVP(String hoten, String ngaysinh, double luong, int songaylam) : base(hoten, ngaysinh, luong)
        {
            songaylam = _soNgayLam;
        }
        public int SONGAYLAM
        {
            get { return _soNgayLam; }
            set { _soNgayLam = value; }
        }
        public new double getLuong()
        {
            return base.getLuong() + _soNgayLam * 100.000;
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        public new void Nhap()
        {
            Console.OutputEncoding = Encoding.Unicode;
            base.Nhap();
            Console.Write("Số ngày làm:  ");
            _soNgayLam = int.Parse(Console.ReadLine());
        }
    }
    //end of class NhanVienVP
    //*************************************************************************************************************************************//
    class QuanLyNhanVien
    {
        private List<NhanVienSX> _nvsxL = new List<NhanVienSX>();
        private List<NhanVienVP> _nvvpL = new List<NhanVienVP>();
        private List<NhanVien> _nvL = new List<NhanVien>();
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.Unicode;
            int loai;
            int num = 1;
            do
            {
                Console.WriteLine("\t\t\tNhân viên thứ {0}", num);
                try
                {
                    Console.WriteLine("Nhập chức vụ(1.Nhân viên sản xuất||2.Nhân viên văn phòng||0.Dừng nhập):");
                    loai = int.Parse(Console.ReadLine());
                    if (loai == 0) break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Sai định dạng, phải là số!");
                    return;
                }

                int i = loai;
                switch (i)
                {
                    case 1:
                        NhanVienSX nvsx = new NhanVienSX();
                        nvsx.Nhap();
                        NhanVien nv = new NhanVien();
                        nv.HOTEN = nvsx.HOTEN;
                        nv.NGAYSINH = nvsx.NGAYSINH;
                        nv.LUONG = nvsx.getLuong();
                        _nvL.Add(nv);
                        num++;
                        break;
                    case 2:
                        NhanVienVP nvvp = new NhanVienVP();
                        nvvp.Nhap();
                        NhanVien nv2 = new NhanVien();
                        nv2.HOTEN = nvvp.HOTEN;
                        nv2.NGAYSINH = nvvp.NGAYSINH;
                        nv2.LUONG = nvvp.getLuong();
                        _nvL.Add(nv2);
                        num++;
                        break;
                }
            } while (true);
        }
        public void Xuat()
        {
            foreach (NhanVien nv in _nvL)
            {
                nv.Xuat();
                File.AppendAllText("text.txt", nv.String());
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
            string sapxep = "=================================================================================" + "\nLương sau khi sắp xếp theo thứ tự giảm dần:\n";
            File.AppendAllText("text.txt", sapxep);
            Xuat();
        }
        /*public void testAppendAllText()
        {
            var filename = "test.txt";
            var path = Path.GetFullPath("test.txt");
            if (File.Exists(path))
            {
                // File đã tồn tại - nối thêm nội dung
                File.AppendAllText(path, this.Xuat);
            }
            else
            {
                // tạo mới vì chưa tồn tại file
                File.WriteAllText(path, this.Xuat);
            }
        }*/

    }
    //*************************************************************************************************************************************//
    class Run
    {
        static void Main()
        {
            QuanLyNhanVien ql = new QuanLyNhanVien();
            ql.Nhap();
            Console.WriteLine("=================================================================================");
            ql.Xuat();
            Console.WriteLine("=================================================================================");
            ql.SortLuong();
        }
    }
}