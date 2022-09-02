using System;
using System.Collections.Generic;
using System.Text;
/*I. Cài đặt các lớp đối tượng (6đ)
1. Thiết kế giao diện IXe mô tả thông tin phương tiện cơ giới, gồm có các thuộc tính: Biển số, hãng
sản xuất, năm sản xuất; các phương thức: nhập, xuất thông tin xe, phương thức tính năm hết hạn sử
dụng.
2. Lớp XeCon cài đặt giao diện IXe và có thêm thành phần dữ liệu: số chỗ ngồi. Trong đó phương
thức tính năm hết hạn sử dụng theo công thức
Năm hết hạn = Năm sản xuất + 30
3. Lớp XeTai cài đặt giao diện IXE và có thêm thành phần dữ liệu: tải trọng. Trong đó phương thức
tính năm hết hạn sử dụng theo công thức
Năm hết hạn = Năm sản xuất + 20
II. Chương trình chính (4đ)
- Nhập thông tin n xe vào một danh sách duy nhất, khi nhập cho phép người dùng chọn xe con hay xe
tải, chương trình sẽ tạo đối tượng phù hợp. (1đ)
- In danh sách xe vừa nhập và thông tin chi tiết từng xe. (0.5đ)
- Thống kê số lượng mỗi loại xe (xe con, xe tải) trong danh sách. (1đ)
- Sắp xếp danh sách xe theo loại, trong mỗi loại có năm sản xuất tăng dần. (1đ)
- Lưu danh sách xe đã sắp xếp vào file văn bản, thông tin mỗi xe trên một dòng, các thành phần dữ liệu
cách nhau bởi ký tự “\t”. (0.5đ)
*/
public interface IXe
{
    String _bienso { get; set; }
    String _hangsanxuat { get; set; }
    double _namsanxuat { get; set; }
    public virtual void Nhap()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.Write("Nhập biển số xe:  ");
        _bienso = Console.ReadLine();
        Console.Write("Nhập năm sản xuất:  ");
        _namsanxuat = int.Parse(Console.ReadLine());
        Console.Write("Nhập hảng sản xuất:  ");
        _hangsanxuat = String.Parse(Console.ReadLine());
    }
    public virtual void Xuat()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.Write("Biển số: {0}  | Năm sản xuất: {1}  | Hảng SX: {2}", _bienso, _namsanxuat, _hangsanxuat);
    }
    public virtual void TinhNamHetHan()
    { }
}

class XeCon : IXe
{
    public int _sochongoi;
    public XeCon() { }
    public XeCon(String bienso, String hangsanxuat, double namsanxuat, int sochongoi) : base(_bienso, _hangsanxuat, _namsanxuat)
    {
        sochongoi = _sochongoi;
    }
    public int SOCHONGOI
    {
        get { return _sochongoi; }
        set { _sochongoi = value; }
    }
    //-------------------------------------------------------------------------------------------------------------//
    public new void Nhap()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        base.Nhap();
        try
        {
            Console.Write("Nhập số chổ ngồi:  ");
            _sochongoi = int.Parse(Console.ReadLine());
        }
        catch (System.Exception)
        {
            Console.WriteLine("Sai định dạng, phải là số!");
        }
    }
    public new void Xuat()
    {
        Console.OutputEncoding = Encoding.Unicode;
        base.Xuat();
        Console.Write("  |Số chổ ngồi: {0} \n", _sochongoi);
    }
    public new int TinhNamHetHan()
    {
        int namhethan;
        namhethan = _namsanxuat + 30;
        return namhethan;
    }
}
class XeTai : IXe
{
    public int _taitrong;
    public XeTai() { }
    public XeTai(String bienso, String hangsanxuat, double namsanxuat, int taitrong) : base(_bienso, _hangsanxuat, _namsanxuat)
    {
        taitrong = _taitrong;
    }
    public int TAITRONG
    {
        get { return _taitrong; }
        set { _taitrong = value; }
    }
    //-------------------------------------------------------------------------------------------------------------//
    public new void Nhap()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        base.Nhap();
        try
        {
            Console.Write("Nhập số tải trọng:  ");
            _taitrong = int.Parse(Console.ReadLine());
        }
        catch (System.Exception)
        {
            Console.WriteLine("Sai định dạng, phải là số!");
        }
    }
    public new void Xuat()
    {
        Console.OutputEncoding = Encoding.Unicode;
        base.Xuat();
        Console.Write("  |Số tải trọng: {0} \n", _taitrong);
    }
    public new int TinhNamHetHan()
    {
        int namhethan;
        namhethan = _namsanxuat + 20;
        return namhethan;
    }
}

class QuanLyXe
{
    private List<XeCon> xeconL = new List<XeCon>();
    private List<XeTai> xetaiL = new List<XeTai>();
    private List<IXe> xeL = new List<IXe>();

    private int _soLuong;
    public void Nhap()
    {
        Console.OutputEncoding = Encoding.Unicode;
        int loai;
        int num = 1;
        do
        {
            Console.WriteLine("\t\t\tXe thứ {0}", num);
            try
            {
                Console.WriteLine("Nhập loại xe(1.Xe con ||2.Xe tải||0.Dừng nhập):");
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
                    XeCon xc = new XeCon();
                    xc.Nhap();
                    xeconL.Add(xc);
                    num++;
                    break;
                case 2:
                    XeTai xt = new XeTai();
                    xt.Nhap();
                    xetaiL.Add(xt);
                    num++;
                    break;
            }
        } while (true);
    }
    public void Xuat()
    {
        foreach (IXe xe in IXe)
        {
            xe.Xuat();
        }
    }

    public void SXTangDan_theoNam()
    {
        xeconL.Sort(
            (p1, p2) =>
            {
                if (p1.NAMSX == p2.NAMSX) return 0;
                if (p1.NAMSX > p2.NAMSX) return 1;
                else return -1;
            }
        );
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("Danh sách xe con sau khi sắp xếp tăng dần theo năm sản xuất:");
        xc.Xuat();

        xetaiL.Sort(
            (p1, p2) =>
            {
                if (p1.NAMSX == p2.NAMSX) return 0;
                if (p1.NAMSX > p2.NAMSX) return 1;
                else return -1;
            }
        );
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("Danh sách xe tải sau khi sắp xếp tăng dần theo năm sản xuất:");
        xt.Xuat();
    }
}
class Run
{
    static void Main()
    {
        QuanLyXe qlx = new QuanLyXe();
        qlx.Nhap();
        
        Console.WriteLine("====================================================================");
        qlx.Xuat();
        Console.WriteLine("====================================================================");
        qlx.SXTangDan_theoNam();
        Console.WriteLine("====================================================================");
    }
}
























