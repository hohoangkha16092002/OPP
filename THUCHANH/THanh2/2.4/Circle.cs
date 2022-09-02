/*1. Cài đặt lớp Circle mô tả các hình tròn, với các thuộc tính, phương thức sau
- Thuộc tính:
+ r: bán kính
+ c: tâm hình tròn, với c là đối tượng của lớp Point đã cài đặt ở Bài 2.3
- Phương thức:
+ Hàm thiết lập khởi tạo hình tròn.
+ Hàm Area() tính diện tích hình tròn.
+ Hàm Move(double dx, double xy) di chuyển hình tròn với khoảng cách tương ứng dx, dy.

2. Chương trình chính
- Khởi tạo một vài đối tượng hình tròn và sử dụng các phương thức đã cài đặt để kiểm tra kết quả.*/

using System;

namespace Circle
{
    //Khai báo lớp hình tròn
    public static class Constants
    {
        public const double PI = 3.1416;
    } // End of Circle class
    class Circle
    {
        private double _r;
        private double _t;

        public double R
        {
            get { return _r; }
            set { value = _r; }
        }
        public double T
        {
            get { return _t; }
            set { value = _t; }
        }
        public Circle(double r, double t)
        {
            _r = r;
            _t = t;
        }
        public Circle(Circle c)
        {
            _t = c._t;
            _r = c._r;

        }

        ~Circle()
        {
            Console.WriteLine("Destroyed.");
        }

        public double Area()
        {
            return _r * _r * Constants.PI;
        }

        public void Nhap()
        {
            Console.Write("Nhap diem x = ");
            _r = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem y = ");
            _t = double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Hinh tron co toa do la: {0},{1} ", _t, _r);
        }
        public void Move(double dx, double dy)
        {
            _t += dx;
            _r += dy;
        }

    }

    // Main program 
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(0, 0);
            c.Nhap();
            c.Xuat();

            Console.WriteLine("Dien tich hinh tron = {0}", c.Area());
            c.Move(2, 1);
            Console.WriteLine("Vi tri moi cua hinh tron");
            c.Xuat();


        }
    } // End of class Program
}