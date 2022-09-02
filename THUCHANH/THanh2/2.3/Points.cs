/*
Lớp Points mô tả các điểm trong mặt phẳng.
*/

using System;
class Points
{
    // Fields
    private Point[] _pointArray;
    private int _nPoints;

    public Point[] PointArray
    {
        get => _pointArray;
    }

    public int nPoints
    {
        get => _nPoints;
    }

    //Constructor: khởi tạo mảng các điểm
    public Points(int nPoints)
    {
        _nPoints = nPoints;
        _pointArray = new Point[nPoints];
    }

    // Hàm nhập: Nhập các điểm từ bàn phím
    public void Nhap()
    {
        for(int i=0; i < _nPoints; i++)
        {
            Console.WriteLine("Nhap diem thu {0}", i+1);
            _pointArray[i] = new Point();
            _pointArray[i].Nhap();
        }       
    }

    // Xuất danh sách các điểm
    public void Xuat()
    {
        for(int i=0; i < _nPoints; i++)
            _pointArray[i].Xuat();
    }

    // Hàm trả về điểm xa gốc tọa độ nhất
    public Point DiemXaNhat()
    {
        // So sánh khoảng cách mỗi điểm đến gốc tọa độ, 
        // điểm nào khoảng cách lớn nhất <-> xa nhất
        Point p = new Point(_pointArray[0]);
        for(int i=1; i < _nPoints; i++)
        {
            double distance = Math.Sqrt(Math.Pow(PointArray[i].X, 2) + Math.Pow(PointArray[i].Y, 2));
            if(Math.Sqrt(Math.Pow(p.X, 2) + Math.Pow(p.Y, 2)) < distance)
                p = _pointArray[i];
        }
        return p;
    }

}