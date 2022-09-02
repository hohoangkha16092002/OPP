/*
Lớp mảng đối tượng phân số.
*/
using System;

class DSPhanSo
{
    private PhanSo[] _dsPS;
    private int _size;

    public void Nhap()
    {
        Console.Write("So luong phan so: ");
        _size = int.Parse(Console.ReadLine());
        _dsPS = new PhanSo[_size];
        for(int i=0; i < _size; i++)
        {
            Console.WriteLine("Nhap phan so thu " + (i+1));
            _dsPS[i] = new PhanSo();
            _dsPS[i].Nhap();
        }        
    }

    public void Xuat()
    {
        for(int i=0; i < _size; i++)
            _dsPS[i].Xuat();
    }

    public void SapXep()
    {
        // Sort ascending
        for(int i=0; i < _size-1; i++)
            for(int j=i+1; j < _size; j++)
                if(_dsPS[i].GiaTri > _dsPS[j].GiaTri)
                {
                    PhanSo tmp = new PhanSo(_dsPS[i]);
                    _dsPS[i] = _dsPS[j];
                    _dsPS[j] = tmp;
                }
    }
    static void Max(int[] a, int n)
        {
        int maxValue = a[0];
        for (int i = 1; i < n; i++)
        {
            if (a[i] > maxValue) {
				maxValue = a[i];
			}
        }
        Console.WriteLine("\nPhan tu lon nhat la: {0} ", maxValue);
    }    
}

/*
Định nghĩa lớp phân số.////////////////////////////////////////////////
*/

class PhanSo
{
    private int _tuSo, _mauSo;

    public int TuSo{
        get => _tuSo;
        set => _tuSo = value;
    }

    public int MauSo{
        get => _mauSo;
    }

    // Constructor
    public PhanSo(int t=0, int m=1)
    {
        if(m == 0) 
            throw new ArgumentException("Mau so phai khac 0.", nameof(m));
        _tuSo = t;
        _mauSo = m;
    }

    // Copy constructor
    public PhanSo(PhanSo p)
    {
        _tuSo = p._tuSo;
        _mauSo = p._mauSo;
    }

    public void Nhap()
    {
        Console.Write("Tu so = ");
        _tuSo = int.Parse(Console.ReadLine());
        do{
            Console.Write("Mau so = ");
            _mauSo = int.Parse(Console.ReadLine());
        }while(_mauSo == 0);
    }

    public void Xuat()
    {
        Console.WriteLine("{0}/{1}", _tuSo, _mauSo);
    }

    public override string ToString()
    {
        return $"{_tuSo}/{_mauSo}";
    }

    /*
    Phân số được gọi là tối giản khi ước số chung lớn nhất (ucln) của tử số và mẫu số là 1.
    */
    public void ToiGian()
    {
        // Tìm ucln của tử số và mẫu số
        int ucln=1;
        for(int i=Math.Min(Math.Abs(_tuSo), Math.Abs(_mauSo)); i > 1; i--)
            if(_tuSo % i == 0 && _mauSo % i == 0)
            {
                ucln = i;
                break;
            }
        // Chia cả tử số và mẫu số cho ucln -> phân số tối giản
        _tuSo /= ucln;
        _mauSo /= ucln;
    }

    // Tính giá trị phân số
    public double GiaTri{
        get => Convert.ToDouble(_tuSo) / _mauSo;
    }

} ///////////////////////////////////////////////////////////////////////////

/*
Chương trình xử lý lớp phân số
Program.cs: Chương trình chính
PhanSo.cs: Cài đặt lớp phân số
DSPhanSo.cs: Cài đặt lớp mảng phân số
*/

class Program
{
    static void Main(string[] args)
    {
        /*
        // Create an object
        PhanSo p = new PhanSo(-8,4);
        Console.WriteLine("Phan so ban dau:");
        p.Xuat();   // Gọi hàm Xuat()
        // Toi gian phan so
        p.ToiGian();    // Gọi hàm tối giản
        Console.WriteLine("Phan so toi gian: ");
        Console.WriteLine(p);   // Hàm ToString() trả về chuỗi biểu diễn phân số
                                // vì thế có thể in ra như một chuỗi
        */

        // Create an array of Fractions
        DSPhanSo dsPS = new DSPhanSo();
        dsPS.Nhap();
        dsPS.Xuat();
        // Sort the array ascending
        dsPS.SapXep();
        // Display the sorted array
        Console.WriteLine("Mang sap xep tang dan: ");
        dsPS.Xuat();
    }
}
