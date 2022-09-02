using System.Collections.Generic;
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
using System;
class NhanVien
{
    public String ten;
    public DateTime ngaySinh;
    public double luong;
    public String TEN { get; }
    public DateTime NGAYSINH { get; }
    public double LUONG { get; }

    public NhanVien() { }
    public NhanVien(String ten, DateTime ngaysinh, double luong)
    {
        this.ten = ten;
        this.ngaySinh = ngaysinh;
        this.luong = luong;
    }

    public virtual double GetLuong()
    {
        return luong;
    }
    public virtual void Nhap()
    {
        Console.Write("Nhap ten: ");
        ten = Console.ReadLine();
        Console.Write("Nhap ngay sinh: ");
        ngaySinh = DateTime.Parse(Console.ReadLine());
    }

    public virtual void Xuat()
    {
        Console.Write("Ho ten: {0} - Ngay sinh: {1:dd/MM/yyyy} - Luong: {2} ", ten, ngaySinh, GetLuong());
    }
}
class NVVP : NhanVien
{

    public int SONGAYLAM { get; set; }

    public NVVP() { }
    public NVVP(String ten, DateTime ngaysinh, double luong, int songaylam) : base(ten, ngaysinh, luong)
    {
        SONGAYLAM = songaylam;
    }

    public override double GetLuong()
    {
        return SONGAYLAM * 100000;
    }
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap so ngay lam: ");
        SONGAYLAM = int.Parse(Console.ReadLine());
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("- So ngay lam: {0} ", SONGAYLAM);
    }
}
class NVSX : NhanVien
{
    public double LUONGCB { get; set; }
    public int SOSP { get; set; }

    public NVSX() { }
    public NVSX(String ten, DateTime ngaysinh, double luong, double luongcb, int sosp) : base(ten, ngaysinh, luong)
    {
        LUONGCB = luongcb;
        SOSP = sosp;
    }

    public override double GetLuong()
    {
        return LUONGCB + SOSP * 5000;
    }
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap luong can ban: ");
        LUONGCB = double.Parse(Console.ReadLine());
        Console.Write("Nhap so san pham: ");
        SOSP = int.Parse(Console.ReadLine());
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("- Luong can ban: {0} - So san pham: {1} ", LUONGCB, SOSP);
    }
}
class QLNV
{
    List<NhanVien> nvList = new List<NhanVien>();
    int n;
    int loai;
    int num = 1;
    public void Nhap()
    {
        Console.Write("Nhap so nhan vien muon them: ");
        n = int.Parse(Console.ReadLine());
        while (num <= n)
        {
            Console.WriteLine("\tNhan vien thu {0}", num);
            Console.Write("1.Nhan vien san xuat|| 2. Nhan vien van phong: ");
            loai = int.Parse(Console.ReadLine());
            switch (loai)
            {
                case 1:
                    NVSX sx = new NVSX();
                    sx.Nhap();
                    nvList.Add(sx);
                    num++;
                    break;
                case 2:
                    NVVP vp = new NVVP();
                    vp.Nhap();
                    nvList.Add(vp);
                    num++;
                    break;
                default:
                    Console.WriteLine("1.Nhan vien san xuat|| 2. Nhan vien van phong");
                    break;
            }
        }
    }

    public void Xuat()
    {
        foreach (NhanVien nv in nvList)
        {
            nv.Xuat();
        }
    }

    public void SXGiam_Luong()
    {
        Console.WriteLine("***Danh sach sau khi sap xep giam dan***");
        nvList.Sort((x, y) => y.GetLuong().CompareTo(x.GetLuong()));
        Xuat();
    }
}
class Program
{
    static void Main()
    {
        QLNV ql = new QLNV();
        ql.Nhap();
        ql.Xuat();
        ql.SXGiam_Luong();
    }
}