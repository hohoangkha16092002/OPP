using System.Collections.Generic;
using System;
/*Vận dụng phương pháp lập trình hướng đối tượng giải quyết bài toán xử lý các đối tượng hình tròn. Với các yêu cầu sau:
1. Xây dựng các lớp (5đ)
Khai báo hằng số PI = 3.1416. (0.25đ)
a) Lớp Point mô tả điểm trong mặt phẳng.
- Thuộc tính: X, Y (tọa độ của điểm trong mặt phẳng, kiểu số thực). Cài đặt X, Y dạng thuộc tính tự động (auto-implemented properties). (0.5đ)
- Phương thức thiết lập có tham số để khởi tạo đối tượng điểm kèm theo tọa độ. (0.5đ)
*/
namespace BaiThi
{
    class Point
    {
        private const double _pi = 3.1416;
        public double X { get; set; }
        public double Y { get; set; }
        public double PI { get { return _pi; } }

        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }
        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
        }
        public void Move(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
    //**************************************************************************************************************************//
    /*b) Lớp Circle mô tả các hình tròn trong mặt phẳng
    - Các trường:
    + Point _center, với Point là lớp điểm đã xây dựng ở câu a. (0.25đ)
    + double _radius: bán kính hình tròn. (0.5đ)
    - Các thuộc tính:
    + Point Center, cho phép đọc trường _center. (0.5đ)
    + double Radius, cho phép đọc trường _radius. (0.5đ)
    - Các phương thức:
    + Phương thức thiết lập có tham số khởi tạo đối tượng hình tròn. Cần cài đặt cơ chế xử lý ngoại lệ phù hợp khi r < 0. (1đ)
    + Phương thức trả về diện tích hình tròn (1đ).

    2. Chương trình chính (5đ)
    - Nhập mảng n hình tròn (3 ≤ n ≤100). (1đ)
    - In mảng hình tròn vừa nhập kèm theo diện tích. (1đ)
    - Tìm hình tròn có diện tích lớn nhất. (1đ)
    - Sắp xếp mảng hình tròn theo thứ tự giảm dần của diện tích và in ra danh sách đã sắp xếp. (1đ)
    - Tìm và in ra các cặp hình tròn giao thoa nhau (tức là hình này chồng lấn lên hình kia). (1đ)*/
    class Circle
    {
        private Point _center = new Point(0, 0);
        private double _radius = 1;
        private List<Circle> _circleL = new List<Circle>();
        private int _n;



        public Circle() { }
        public Circle(double x, double y, double r)
        {
            _radius = r;
            _center = new Point(x, y);
        }
        // get set
        public Point CENTER { get { return _center; } set { _center = value; } }
        public double Y { get { return _radius; } set { _radius = value; } }

        public double Area()
        {
            return _radius * _radius * 3.1416;
        }


        public void Nhap()
        {
            do
            {
                Console.Write("Nhap so hinh tron muon them(3 ≤ n ≤100) =  ");
                _n = int.Parse(Console.ReadLine());
            } while (_n < 3 || _n > 100);

            for (int i = 0; i < _n; i++)
            {
                Console.Write("Nhap hoanh do:  ");
                _center.X = double.Parse(Console.ReadLine());
                Console.Write("Nhap tung do:  ");
                _center.Y = double.Parse(Console.ReadLine());
                try
                {
                    Console.Write("Nhap ban kinh:  ");
                    _radius = double.Parse(Console.ReadLine());
                    if (_radius <= 0)
                        throw new ArgumentException();
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Ban kinh phai lon hon 0");
                    Console.Write("Nhap ban kinh:  ");
                    _radius = double.Parse(Console.ReadLine());
                }
                Circle c = new Circle(_center.X, _center.Y, _radius);
                _circleL.Add(c);
            }
        }

        public void Xuat()
        {
            int num = 1;
            foreach (Circle c in _circleL)
            {
                Console.WriteLine("toa do hinh tron {4}: ({0},{1}) ban kinh = {2} - dien tich = {3}", c._center.X, c._center.Y, c._radius, c.Area(), num);
                num++;
            }
        }

        // Tìm hình tròn có diện tích lớn nhất. (1đ)
        public void DTLonNhat()
        {
            Circle max = _circleL[0];
            foreach (Circle c in _circleL)
            {
                if (max.Area() < c.Area()) max = c;
            }
            Console.WriteLine("Hinh tron co dien tich lon nhat la: ({0},{1}) ban kinh = {2}", max._center.X, max._center.Y, max._radius);
        }

        //Sắp xếp mảng hình tròn theo thứ tự giảm dần của diện tích và in ra danh sách đã sắp xếp. (1đ)
        public void SXGiamDan_DT()
        {
            Console.WriteLine("Dien tich sap xep theo thu tu giam dan");
            _circleL.Sort(
                (p1, p2) =>
                {
                    // 0 p1==p2
                    // 1 p1 > p2
                    // -1 p1 < p2
                    if (p1.Area() == p2.Area()) return 0;
                    if (p1.Area() < p2.Area()) return 1;
                    else return -1;
                }
            );
            Xuat();
        }

        //Tính tổng 2 bán kính nếu tổng 2 bán kính lớn hơn khoảng cách giữa 2 điểm thì 2 htron` giao thoa 
        public double KhoangCach(Circle c)
        {
            double dx = c.CENTER.X - _center.X;
            double dy = c.CENTER.Y - _center.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public void GiaoThoa() {
            Circle gt1 = _circleL[0];
            Circle gt2 = _circleL[1];
            for (int i = 0; i < _n - 1; i++)
            {
                for (int j = i + 1; j < _n; j++)
                {
                    if (_circleL[i].KhoangCach(_circleL[j]) < gt1._radius+gt2._radius)
                    {
                        gt1 = _circleL[i];
                        gt2 = _circleL[j];
                    }
                }
                Console.WriteLine("({0},{1}),({2},{3})", gt1._center.X,gt1._center.Y,gt2._center.X,gt1._center.Y);
            }
            
        }
        //---------------------------------------------------------------------------------------------------------------------------//
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.Nhap();
            Console.WriteLine("******************************************************************************************");
            c.Xuat();
            Console.WriteLine("******************************************************************************************");
            c.DTLonNhat();
            Console.WriteLine("******************************************************************************************");
            c.SXGiamDan_DT();
            Console.WriteLine("******************************************************************************************");
            c.GiaoThoa();
        }
    }

}

