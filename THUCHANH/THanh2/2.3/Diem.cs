using System;

class Program
{
    const double MaxValue = 1.7976931348623157E+308;
    static void Main(string[] args)
    {
        // Tạo mảng 5 điểm
        int nPoints = 5;
        Points ps = new Points(nPoints);
        ps.Nhap();
        Console.WriteLine("Danh sach cac diem: ");
        ps.Xuat();
        // Tìm điểm xa gốc tọa độ nhất
        Point farestPoint = ps.DiemXaNhat();
        Console.WriteLine("Diem xa goc toa do nhat la: " + farestPoint.ToString());

        // Tìm cặp điểm gần nhau nhất
        double minDistance = MaxValue;
        Point p1 = new Point();
        Point p2 = new Point();
        for(int i=0; i < nPoints-1; i++)
            for(int j=i+1; j < nPoints; j++)
                // Tính khoảng cách giữa 2 điểm ps[i] và ps[j]
                // Euclidean distance
                {
                    double distance = Math.Sqrt(Math.Pow(ps.PointArray[i].X - ps.PointArray[j].X, 2) + 
                    Math.Pow(ps.PointArray[i].Y - ps.PointArray[j].Y,2));
                    if(minDistance > distance)
                    {
                        minDistance = distance;
                        p1 = new Point(ps.PointArray[i].X, ps.PointArray[i].Y);
                        p2 = new Point(ps.PointArray[j].X, ps.PointArray[j].Y);
                    }
                }
        // p1, p2 là cặp điểm gần nhau nhất
        Console.WriteLine("Cap diem gan nhau nhat: " + p1.ToString() + " va " + p2.ToString());
    }
}