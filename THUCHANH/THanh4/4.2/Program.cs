using System.Collections.Generic;
using System;
using System.Text;
/*Xây dựng lớp HinhVe (hình vẽ) làm lớp cơ sở cho các loại hình vẽ cụ thể.
Trong lớp HinhVe cài đặt phương thức ảo DienTich() trả về diện tích của hình.
- Xây dựng các lớp hình chữ nhật, hình tròn kế thừa lớp HinhVe, còn lớp hình vuông kế thừa lớp hình chữ nhật.
- Viết chương trình cho phép nhập vào một trong các hình kể trên. Tính và in ra diện tích của hình đó.*/
namespace Quanlyhinh
{

    abstract class HinhVe
    {
        public string Name
        {
            get { return this.GetType().ToString(); }
        }
        // Hàm trừu tượng nhập
        public abstract void Nhap();

        // Hàm trừu tượng tính diện tích
        public abstract double DienTich();
    }
    // Kết thúc lớp HinhVe
    //*********************************************************************************************************************//
    // Xây dựng các lớp hình chữ nhật, hình tròn kế thừa lớp HinhVe
    class HinhTron : HinhVe
    {
        protected double _r;
        private const double pi = 3.1416;
        public HinhTron(double r = 0)
        {
            _r = r;
        }
        public override double DienTich()
        {
            return _r * _r * pi;
        }

        // Hàm nhập số liệu hình tròn
        public override void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            do
            {
                try
                {
                    Console.Write("Nhập bán kính = ");
                    _r = double.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sai định dạng, phải là số!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
            } while (_r < 0);
        }
    }
    // Kết thúc lớp HinhTron
    //*********************************************************************************************************************//
    // Lớp hình chữ nhật kế thừa lớp hình vẽ
    class HinhChuNhat : HinhVe
    {
        protected double _chieuDai;
        protected double _chieuRong;
        public HinhChuNhat(double chieudai = 0, double chieurong = 0)
        {
            _chieuDai = chieudai;
            _chieuRong = chieurong;
        }
        public override double DienTich()
        {
            return _chieuDai * _chieuRong;
        }

        //Hàm nhập số liệu hình chữ nhật
        public override void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            do
            {
                try
                {
                    Console.Write("Nhập cạnh dài:  ");
                    _chieuDai = double.Parse(Console.ReadLine());
                    Console.Write("Nhập chiều rộng:  ");
                    _chieuRong = double.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sai định dạng, phải là số!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
            } while (_chieuDai < 0 && _chieuRong < 0);
        }
    }
    // Kết thúc lớp HinhChuNhat
    //*********************************************************************************************************************//
    // Lớp hình vuông kế thừa lớp hình chữ nhật
    class HinhVuong : HinhChuNhat
    {
        public HinhVuong(double canh = 0) : base(canh, canh) { }
        //Hàm nhập số liệu hình vuông
        public override void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            do
            {
                try
                {
                    Console.Write("Nhập độ dài cạnh: ");
                    _chieuDai = _chieuRong = double.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sai định dạng, phải là số!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
            } while (_chieuDai < 0 && _chieuRong < 0);
        }
    }
    class HinhTamGiac : HinhVe
    {
        protected double _duongcao;
        protected double _canhday;
        private const double so = 0.5;

        public HinhTamGiac() { }
        public HinhTamGiac(double duongcao, double canhday)
        {
            if (duongcao < 0 || canhday < 0)
                throw new ArgumentOutOfRangeException("Out of range.");
            duongcao = _duongcao;
            canhday = _canhday;

        }
        public override double DienTich()
        {
            return so * _duongcao * _canhday;
        }
        //Hàm nhập số liệu hình tam giác
        public override void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            do
            {
                try
                {
                    Console.Write("Nhập đường cao:  ");
                    _duongcao = double.Parse(Console.ReadLine());
                    Console.Write("Nhập cạnh đáy:  ");
                    _canhday = double.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sai định dạng, phải là số!");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
            } while (_duongcao < 0 && _canhday < 0);
        }
    }
    // Kết thúc lớp HinhVuong
    //*********************************************************************************************************************//
    // Lớp Quản lý hình vẽ tạo mảng cho từng hình và 
    class QLHV
    {
        List<HinhTron> htList = new List<HinhTron>();
        List<HinhChuNhat> hcnList = new List<HinhChuNhat>();
        List<HinhVuong> hvList = new List<HinhVuong>();
        List<HinhTamGiac> htgcList = new List<HinhTamGiac>();
        public void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int loai;
            int a = 0, b = 0, c = 0, d = 0;
            do
            {
                try
                {
                    Console.WriteLine("Nhập loại hình muốn tính diện tích:\n1.Hình tròn ⊙\n2.Hình chữ nhật ▭\n3.Hình vuông ❒\n4.Hình Tam giác\n0.Dừng!");
                    loai = int.Parse(Console.ReadLine());
                    if (loai == 0) break;
                }
                catch (System.Exception) //Khi người dùng nhập định dạng khác số
                {
                    Console.Write("=================================================================================\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*Hãy nhập số tương ứng với các tác vụ có thể thực hiện được ở trên!*");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Nhập loại hình muốn tính diện tích:\n1.Hình tròn ⊙\n2.Hình chữ nhật ▭\n3.Hình vuông □\n4.Hình Tam giác\n0.Dừng!");
                    loai = int.Parse(Console.ReadLine());
                    if (loai == 0) break;
                }
                switch (loai)
                {
                    case 1:
                        Console.Write("Nhập số liệu cho hình tròn thứ {0}\n", a + 1); a++;
                        HinhTron ht = new HinhTron();
                        ht.Nhap();
                        htList.Add(ht);
                        double httest = ht.DienTich();
                        if (httest < 0)
                        {
                            htList.Remove(ht);
                        }
                        Console.Write("=================================================================================\n");
                        break;

                    case 2:
                        Console.Write("Nhập số liệu cho hình chữ nhật thứ {0}\n", b + 1); b++;
                        HinhChuNhat hcn = new HinhChuNhat();
                        hcn.Nhap();
                        hcnList.Add(hcn);
                        double hcntest = hcn.DienTich();
                        if (hcntest < 0)
                        {
                            hcnList.Remove(hcn);
                        }
                        Console.Write("=================================================================================\n");
                        break;

                    case 3:
                        Console.Write("Nhập số liệu cho hình vuông thứ {0}\n", c + 1); c++;
                        HinhVuong hv = new HinhVuong();
                        hv.Nhap();
                        hvList.Add(hv);
                        double hvtest = hv.DienTich();
                        if (hvtest < 0)
                        {
                            hvList.Remove(hv);
                        }
                        Console.Write("=================================================================================\n");
                        break;

                    case 4:
                        Console.Write("Nhập số liệu cho hình tam giác thứ {0}\n", d + 1); d++;
                        HinhTamGiac htgc = new HinhTamGiac();
                        htgc.Nhap();
                        htgcList.Add(htgc);
                        double htgctest = htgc.DienTich();
                        if (htgctest < 0)
                        {
                            htgcList.Remove(htgc);
                        }
                        Console.Write("=================================================================================\n");
                        break;

                    default: //Khi người dùng chọn các số khác các số đã cho
                        Console.Write("=================================================================================\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("*Hãy chọn 1 trong 4 hình!*");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            } while (true);
        }

        public void Xuat()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int a = 0, b = 0, c = 0, d = 0;
            foreach (HinhTron ht in htList)
            {
                Console.WriteLine("Diện tích hình tròn thứ {0} là: {1:F2}", a + 1, ht.DienTich());
                a++;
            }
            foreach (HinhChuNhat hcn in hcnList)
            {
                Console.WriteLine("Diện tích hình chữ nhật thứ {0} là: {1}", b + 1, hcn.DienTich());
                b++;
            }
            foreach (HinhVuong hv in hvList)
            {
                Console.WriteLine("Diện tích hình vuông thứ {0} là: {1}", c + 1, hv.DienTich());
                c++;
            }
            foreach (HinhTamGiac htgc in htgcList)
            {
                Console.WriteLine("Diện tích hình tam giác thứ {0} là: {1}", d + 1, htgc.DienTich());
                d++;
            }
            Console.ForegroundColor = ConsoleColor.White;
            if (a == 0 && b == 0 && c == 0 && d == 0) //Check xem có hình nào được nhập vào không
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Không có hình nào được nhập vào");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static void Main()
        {
            QLHV qlyh = new QLHV();
            qlyh.Nhap();
            qlyh.Xuat();
            Console.ReadKey();
        }
    }
}
