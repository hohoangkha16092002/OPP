using System;
using System.Collections.Generic;
using System.Text;
namespace Qly_Mayin
{
    class Printer
    {
        private String _nhasanxuat;
        private double _gia;
        public Printer()
        {
        }
        public Printer(String nhasanxuat, double gia)
        {
            _nhasanxuat = nhasanxuat;
            _gia = gia;
        }
        public String NHASANXUAT
        {
            get { return _nhasanxuat; }
            set { _nhasanxuat = value; }
        }
        public double GIA
        {
            get { return _gia; }
            set { _gia = value; }
        }
        //====================================//
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.Unicode;
            int loi = 0;
            System.Console.WriteLine("Nhập nhà sản xuất(Brother, Panasonic, Canon, Epson, HP,...): ");
            _nhasanxuat = Console.ReadLine();
            do
            {
                loi = 0;
                try
                {
                    Console.Write("Nhập giá: ");
                    _gia = double.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*Sai định dạng, phải là số!*");
                    Console.ForegroundColor = ConsoleColor.White;
                    loi = 1;
                }

                if (_gia < 0 && loi == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("*Giá bé nhất có thể là 0*");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (_gia < 0 || loi == 1);
        }

        public void KC(String khoangcach)
        {
            for (int i = 0; i < 10 - khoangcach.Length; i++)
            {
                Console.Write(" ");
            }
        }
        public void Xuat()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nhà sản xuất: {0} ", _nhasanxuat); KC(_nhasanxuat);
            Console.Write("|| Giá thành: {0} ", _gia); KC(_gia.ToString());
        }
    }
    ////////////////////////////////////////////////////////////////////////
    class LaserPrinter : Printer
    {
        private String _dpi;
        public LaserPrinter()
        {
        }
        public LaserPrinter(String dpi)
        {
            _dpi = dpi;
        }
        public String DPI
        {
            get { return _dpi; }
            set { _dpi = value; }
        }
        public new void Nhap()
        {
            Console.OutputEncoding = Encoding.Unicode;
            base.Nhap();
            System.Console.WriteLine("Nhập độ phân giải(1200x1200, 1200x600, 2400x600,...): ");
            _dpi = Console.ReadLine();
        }
        public new void Xuat()
        {
            Console.OutputEncoding = Encoding.Unicode;
            base.Xuat();
            Console.Write("|| Độ phân giải: {0}\n", _dpi);
        }
    }
    ////////////////////////////////////////////////////////////////////////
    class Quanlymayin
    {
        private List<LaserPrinter> mayinL = new List<LaserPrinter>();
        private int _soLuong;
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.Unicode;
            int loi = 0;
            do
            {
                loi = 0;
                try
                {
                    Console.Write("Nhập số lượng máy in =  ");
                    _soLuong = int.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*Sai định dạng, phải là số!*");
                    Console.ForegroundColor = ConsoleColor.White;
                    loi = 1;
                }

                if (_soLuong < 0 && loi == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Số lượng máy in thấp nhất là 1");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("========================================================================================");
                }

                else if (_soLuong == 0 && loi == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("*Không có dữ liệu được nhập vào*");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("***ĐÓNG CHƯƠNG TRÌNH***");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Environment.Exit(0);
                }
            } while (_soLuong < 0 || loi == 1);

            for (int i = 0; i < _soLuong; i++)
            {
                System.Console.WriteLine("----------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t\tMáy in thứ {0}", i + 1);
                Console.ForegroundColor = ConsoleColor.White;
                LaserPrinter mayin = new LaserPrinter();
                mayin.Nhap();
                mayinL.Add(mayin);
            }
        }
        public void Xuat()
        {
            int stt = 1;
            foreach (LaserPrinter mayin in mayinL)
            {
                Console.Write("{0}. ", stt);
                mayin.Xuat();
                stt++;
            }
        }
        public void GiaCaoNhat()
        {
            Console.OutputEncoding = Encoding.Unicode;
            double max = mayinL[0].GIA;
            foreach (LaserPrinter mayin in mayinL)
            {
                if (max < mayin.GIA)
                {
                    max = mayin.GIA;
                }
            }
            Console.WriteLine("Giá máy in cao nhất =  " + max);
        }
        public void GiaThapNhat()
        {
            Console.OutputEncoding = Encoding.Unicode;
            double min = mayinL[0].GIA;
            foreach (LaserPrinter mayin in mayinL)
            {
                if (min > mayin.GIA)
                {
                    min = mayin.GIA;
                }
            }
            Console.WriteLine("Giá máy in thấp nhất =  " + min);
        }
        public void TimMayIn_NSX()
        {
            Console.OutputEncoding = Encoding.Unicode;
            String nsx;
            int loi = 0, stt = 1;
            do
            {
                Console.Write("Nhập tên nhà sản xuất muốn lọc: ");
                nsx = Console.ReadLine();
                Console.WriteLine("Thông tin máy in tìm dựa vào tên nhà sản xuất:");
                // Tìm máy in theo tên nhà sản xuất mà người dùng nhập vào
                foreach (LaserPrinter mayin in mayinL)
                {
                    // Nếu tên nhà sản xuất mà người dùng nhập vào trung với tên nhà sản xuất trong List -> Xuất
                    if (nsx.Equals(mayin.NHASANXUAT.Substring(0, mayin.NHASANXUAT.Length)))
                    {
                        Console.Write("{0}. ", stt);
                        loi++; stt++;
                        mayin.Xuat();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Red;
                if (loi == 0) Console.WriteLine("*Bạn đã nhập sai tên nhà sản xuất hoặc không có dữ liệu về nhà sản xuất đó*");
                Console.ForegroundColor = ConsoleColor.White;
            } while (loi == 0);

        }
        public void SXTangDan_Gia()
        {
            mayinL.Sort(
                (p1, p2) =>
                {
                    if (p1.GIA == p2.GIA) return 0;
                    if (p1.GIA > p2.GIA) return 1;
                    else return -1;
                }
            );
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Danh sách máy in sau khi sắp xếp tăng dần theo giá:");
            Xuat();
        }
    }
    class Run
    {
        static void Main()
        {
            Quanlymayin qlmi = new Quanlymayin();
            qlmi.Nhap();
            Console.WriteLine("========================================================================================");
            qlmi.Xuat();
            Console.WriteLine("========================================================================================");
            Console.ForegroundColor = ConsoleColor.Green;
            qlmi.GiaCaoNhat();
            qlmi.GiaThapNhat();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("========================================================================================");
            qlmi.TimMayIn_NSX();
            Console.WriteLine("========================================================================================");
            qlmi.SXTangDan_Gia();
            Console.WriteLine("========================================================================================");
            Console.ResetColor();
        }
    }
}