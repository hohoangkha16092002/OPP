/*
Bài kiểm tra giữa kỳ.
Họ và tên: Hồ Hoàng Kha
MSSV: 62130808
*/

using System;
using System.Collections.Generic;
using System.Text;
// Viết code của bạn ở đây
namespace Qly_Xe
{
    class DongCo
    {
        private int _namSX;
        
        public int namSX{
            get{return _namSX;}
        }
        public DongCo(){
        } 
        public DongCo(int nam)
        { nam = _namSX;}
        
    }
    class Xe
    {
        private DongCo _dongCo = new DongCo(0);
        private String _bienSo;
        private List<Xe> xeList = new List<Xe>();
        private int n;
        public String BIENSO{
            get{return _bienSo;}
        }
        public Xe(){
        }
        public Xe(int nam, String bienso)
        {
            _bienSo = bienso;
            _dongCo = new DongCo(nam);
        }
        public int NamSx()
        {
            return _dongCo.namSX;
        }
        public void Nhap(){
            Console.Write("Nhập năm sản xuất: ");
            _dongCo.namSX = int.Parse(Console.Readline());
            Console.Write("Nhập biến số: ");
            _bienSo = Console.ReadLine();
        }
        public void Xuat(){
            Console.Write("Năm sản xuất: {0} || - Biển số: {1}",_namSX, _bienSo);
        }
        public void Nhapmang()
        {
            do{
                Console.Write("Nhập số lượng xe hơi: ");
                n = int.Parse(Console.ReadLine());
            }while(_n<0);
            for(int i = 0; i < n; i++)
            {
                Xe xehoi = new Xe();
                xe.Nhap();
                xeList.Add(xe);
            }
        }
        public void Xuatmang()
        {
            foreach (Xe c in _xeList)
            { c.Xuat();}
        }
        public void Namcunhat()
        {
            double cu = xeList[0].namSX;
            int num = 1;
            foreach (Xe xehois in _xeList)
            {
                if (cu < xehois.namSX)
                {
                    cu = xehois.namSX;
                    num++;
                }
            }
            Console.WriteLine("Xe có năm sản xuất cũ nhất là xe thứ {0} với năm sản xuất là {1}",num,xehois.namSX);
        }
        public void Sorttangdan()
        {
            Console.WriteLine("Mảng sau khi đã sắp xếp tăng dần theo năm");
            xeList.Sort(
                (x1,x2)->
                {
                    if(x1.NamSx > x2.NamSx) return 1;
                    slse if(x1.NamSx)
                }
                )
        }
    }
}