using System.Collections.Generic;
/*Xây dựng lớp Printer mô tả máy in.
Các thuộc tính:
- Nhà sản xuất (vd: Canon)
- Giá bán.
Các phương thức:
+ Khởi tạo
+ Nhập
+ Xuất
Xây dựng lớp LaserPrinter mô tả máy in laser.
Các thuộc tính:
- Độ phân giải (dpi, vd: 1200x1200)
Các phương thức:
+ Khởi tạo
+ Nhập
+ Xuất
Chương trình chính:
- Nhập danh sách n máy in laser.
- In ra danh sách và thông số kèm theo.
- Tìm máy in có giá thấp nhất, cao nhất.
- Lọc danh sách máy in theo tên hãng sản xuất.
- Sắp xếp danh sách xe theo thứ tự tăng dần của giá bán, in ra danh sách sau sắp xếp.*/
using System;
class Printer
{
    public String NSX { get; set; }
    public double GIA { get; set; }

    public Printer() { }
    public Printer(String nsx, double gia)
    {
        NSX = nsx;
        GIA = gia;
    }

    public virtual void Nhap()
    {
        Console.Write("Nhap ten nha san xuat: ");
        NSX = Console.ReadLine();
        Console.Write("Nhap gia: ");
        GIA = double.Parse(Console.ReadLine());
    }

    public virtual void Xuat()
    {
        Console.Write("Nha san xuat: {0} - gia: {1} ", NSX, GIA);
    }

    public virtual String toS ()
    {
        return String.Format("Nha san xuat: {0} - gia: {1} ",NSX,GIA);
    }
}
class LazerPrinter : Printer
{
    public String dophangiai;
    public String DPG { get => dophangiai; }
    public LazerPrinter() { }
    public LazerPrinter(String nsx, double gia, String dpg) : base(nsx, gia)
    {
        dophangiai = dpg;
    }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap do phan giai: ");
        dophangiai = Console.ReadLine();
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("- do phan giai: {0}", DPG);
    }

    public override string toS()
    {
        base.toS();
        return String.Format("- do phan giai: {0}",DPG);
    }

}
class QLPR
{
    List<Printer> prList = new List<Printer>();
    int n;
    int num = 1;
    public void Nhap()
    {
        Console.Write("Nhap so may in muon them:  ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\tMay in thu {0}", num);
            LazerPrinter lz = new LazerPrinter();
            lz.Nhap();
            prList.Add(lz);
            num++;
        }
    }

    public void Xuat()
    {
        foreach (Printer p in prList)
        {
            p.Xuat();
        }
    }

    public void LocMayIn()
    {
        String nsx;
        Console.Write("Nhap nha san xuat muon tim: ");
        nsx = Console.ReadLine();
        Console.WriteLine("Da tim thay may in co hang {0}: ",nsx);
        foreach (Printer p in prList)
        {
            if (nsx.Equals(p.NSX)) p.Xuat();
        }
    }

    public void GiaLonNhat()
    {
        Printer max = prList[0];
        foreach (Printer p in prList)
        {
            if (max.GIA < p.GIA) max = p;
        }
        Console.WriteLine("May in co gia lon nhat la: {0}", max.toS());
    }

    public void GiaNhoNhat()
    {
        Printer min = prList[0];
        foreach (Printer p in prList)
        {
            if (min.GIA > p.GIA) min = p;
        }
        Console.WriteLine("May in co gia nho nhat la: {0}", min.toS());
    }

}
class Program
{
    static void Main()
    {
        QLPR pr = new QLPR();
        pr.Nhap();
        pr.Xuat();
        pr.GiaLonNhat();
        pr.GiaNhoNhat();
        pr.LocMayIn();
    }
}