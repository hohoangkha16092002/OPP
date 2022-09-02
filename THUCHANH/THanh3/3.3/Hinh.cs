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
        public HinhVe() { }

        public abstract double DienTich();
    }
    // Kết thúc lớp HinhVe
    //*********************************************************************************************************************//
    // Xây dựng các lớp hình chữ nhật, hình tròn kế thừa lớp HinhVe
    class HinhTron : HinhVe
    {
        private double _x;
        private double _y;
        private double _r;
        private const double pi = 3.1416;

        public HinhTron() {}
        public HinhTron(double x, double y, double r)
        {
            x = _x;
            y = _y;
            r = _r;
        }

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public double R
        {
            get { return _r; }
            set { _r = value; }
        }


        public override double DienTich()
        {
            return _r * _r * pi;
        }

        // Hàm nhập số liệu hình tròn
        public void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            try
            {
            Console.Write("Nhập x: ");
            _x = double.Parse(Console.ReadLine());
            Console.Write("Nhập y: ");
            _y = double.Parse(Console.ReadLine());
            Console.Write("Nhập bán kính: ");
            _r = double.Parse(Console.ReadLine());                 
            }
            catch (System.Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sai định dạng, phải là số!");
                Console.ForegroundColor = ConsoleColor.White;
                return;                     
            }
        }
    }
    // Kết thúc lớp HinhTron
    //*********************************************************************************************************************//
    // Lớp hình chữ nhật kế thừa lớp hình vẽ
    class HinhChuNhat : HinhVe
    {
        private double _chieuDai;
        private double _chieuRong;

        public HinhChuNhat() { }
        public HinhChuNhat(double chieudai, double chieurong)
        {
            chieudai = _chieuDai;
            chieurong = _chieuRong;
        }

        public double CHIEUDAI
        {
            get { return _chieuDai; }
            set { _chieuDai = value; }
        }
        public double CHIEURONG
        {
            get { return _chieuRong; }
            set { _chieuRong = value; }
        }


        public override double DienTich()
        {
            return _chieuDai * _chieuRong;
        }

        //Hàm nhập số liệu hình chữ nhật
        public void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
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
        }
    }
    // Kết thúc lớp HinhChuNhat
    //*********************************************************************************************************************//
    // Lớp hình vuông kế thừa lớp hình chữ nhật
    class HinhVuong : HinhChuNhat
    {
        private double _canh;

        public HinhVuong() { }
        public HinhVuong(double canh)
        {
            canh = _canh;
        }

        public double CANH
        {
            get { return _canh; }
            set { _canh = value; }
        }


        public new double DienTich()
        {
            return _canh * _canh;
        }

        //Hàm nhập số liệu hình vuông
        public new void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            try
            {
                Console.Write("Nhập độ dài cạnh: ");
                _canh = double.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sai định dạng, phải là số!");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
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
        public void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int loai;
            int a = 1, b = 1, c = 1;
            do
            {
                try
                {
                    Console.WriteLine("Nhập loại hình muốn tính diện tích:\n1.Hình tròn ⊙\n2.Hình chữ nhật ▭\n3.Hình vuông ❒\n0.Dừng!");
                    loai = int.Parse(Console.ReadLine());
                    if (loai == 0) break;
                }
                catch (System.Exception) //Khi người dùng nhập định dạng khác số
                {
                    Console.Write("=================================================================================\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*Hãy nhập số tương ứng với các tác vụ có thể thực hiện được ở trên!*");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Nhập loại hình muốn tính diện tích:\n1.Hình tròn ⊙\n2.Hình chữ nhật ▭\n3.Hình vuông □\n0.Dừng!");
                    loai = int.Parse(Console.ReadLine());
                    if (loai == 0) break;
                }
                switch (loai)
                {
                    case 1:
                    Console.Write("Nhập số liệu cho hình tròn thứ {0}\n",a); a++;
                    HinhTron ht = new HinhTron();
                    ht.Nhap();
                    htList.Add(ht);
                    double httest = ht.DienTich();
                    if (httest == 0)
                    {
                        htList.Remove(ht);
                    }
                    Console.Write("=================================================================================\n");
                    break;

                    case 2:
                    Console.Write("Nhập số liệu cho hình chữ nhật thứ {0}\n",b); b++;
                    HinhChuNhat hcn = new HinhChuNhat();
                    hcn.Nhap();
                    hcnList.Add(hcn);
                    double hcntest = hcn.DienTich();
                    if (hcntest == 0)
                    {
                        hcnList.Remove(hcn);
                    }
                    Console.Write("=================================================================================\n");
                    break;

                    case 3:
                    Console.Write("Nhập số liệu cho hình vuông thứ {0}\n",c); c++;
                    HinhVuong hv = new HinhVuong();
                    hv.Nhap();
                    hvList.Add(hv);
                    double hvtest = hv.DienTich();
                    if (hvtest == 0)
                    {
                        hvList.Remove(hv);
                    }
                    Console.Write("=================================================================================\n");
                    break;

                    default: //Khi người dùng chọn các số khác các số đã cho
                    Console.Write("=================================================================================\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*Hãy chọn 1 trong 3 hình!*");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            } while (true);
        }

        public void Xuat() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int a = 0, b = 0, c = 0;    
            foreach (HinhTron ht in htList)
            {
                Console.WriteLine("Diện tích hình tròn thứ {0} là: {1:F2}",a+1,ht.DienTich());
                a++;
            }
            foreach (HinhChuNhat hcn in hcnList)
            {
                Console.WriteLine("Diện tích hình chữ nhật thứ {0} là: {1}",b+1,hcn.DienTich());
                b++;
            }
            foreach (HinhVuong hv in hvList)
            {
                Console.WriteLine("Diện tích hình vuông thứ {0} là: {1}",c+1,hv.DienTich());
                c++;  
            }
            Console.ForegroundColor = ConsoleColor.White;
            if (a==0 && b==0 && c==0) //Check xem có hình nào được nhập vào không
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Không có hình nào được nhập vào");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static void Main() {
            QLHV qlyh = new QLHV();
            qlyh.Nhap();
            qlyh.Xuat();
            Console.ReadKey();  
        }
    }
}
