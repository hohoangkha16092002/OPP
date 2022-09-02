using System;
using System.Collections.Generic;


class Stack
{
    protected static readonly int Max=1000;  // Số phần tử tối đa của ngăn xếp
    protected int _top;               // chỉ số của phần tử trên cùng
    protected int[] _stack = new int[Max];            // mảng chứa các phần tử

    // Hàm thiết lập
    public Stack()
    {
        _top = -1;      // Khởi tạo ngăn xếp rỗng
    }

    // phương thức thêm 1 phần tử vào ngăn xếp
    public bool Push(int data)
    {
        if(_top >= Max)
        {
            Console.WriteLine("Ngan xep day! Khong chua them duoc!");
            return false;
        }
        else
        {
            _top ++;
            _stack[_top] = data;
            return true;
        }
    }

    // Lấy phần tử trên cùng ra khỏi ngăn xếp & trả về cho lời gọi hàm
    public int Pop()
    {
        if (_top < 0)
        {
            System.Console.WriteLine("Ngan xep trong");
            return -1;
        }
        if(_top >= 0)    
            {
                int data = _stack[_top];
                _top--;
                return data;
            }
        else return -1;
    }
    public virtual void Print()
    {}
}
//////////////////////////////////////////////////////////////////////////
class PrimeStack: Stack
{
    
    public PrimeStack():base(){}

    /*
    In ra dãy các thừa số nguyên tố của số tự nhiên (> 1) lưu trong ngăn xếp.
    */
    public override void Print()
    {
        int i;
        // In theo thứ tự ngược lại
        for(i=_top ;i > 0 ; i--)
            Console.Write("{0}*", _stack[i]);
        Console.WriteLine("{0}", _stack[i]);
    }
}
////////////////////////////////////////////////////////////////
class HexaStack:Stack
{
    public HexaStack():base(){}

    /*
    In biểu diễn của các số tự nhiên trong ngăn xếp trong hệ 16.
    Ví dụ, với data[]={7, 16, 43, 298} in ra {'7', '10', '2B', '12A'}
    */
    public override void Print()
    {
        string HexaDigits = "0123456789ABCDEF";
        for(int i=_top; i >= 0; i--)
            Console.Write(HexaDigits[_stack[i]]);       
    }
}
class Program
{
    // Hàm PhanTichThua số nhận vào số tự nhiên n 
    // và trả về ngăn xếp chứa các thừa số nguyên tố của n
    public static PrimeStack PhanTichThuaSo(int n)
    {
        PrimeStack stack = new PrimeStack();
        for(int i=2; i <= n; i++)
        {
            while(n % i ==0)
            {
                stack.Push(i);        
                n /= i;
            }
        }
        return stack;
    }

    // Hàm Dec2Hex số nhận vào số tự nhiên n 
    // và trả về ngăn xếp chứa các dư số của n chia cho 16
    public static HexaStack Dec2Hex(int n)
    {
        HexaStack stack = new HexaStack();
        while(n > 0)
        {
            int soDu = n % 16;
            stack.Push(soDu);
            n /= 16;
        }
        return stack;
    }

    static void Main(string[] args)
    {
        int n = 0, loi = 0;
        // Input
        do{
            loi = 0;
            try
            {
                Console.Write("Nhap n = ");
                n = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sai dinh dang, phai la so!");
                Console.ForegroundColor = ConsoleColor.White;
                loi = 1;
            }
        } while( n < 2 || loi == 1);
        Console.WriteLine("=========================================================");
        // Phan tich n ra thua so nguyen to
        PrimeStack stack1 = PhanTichThuaSo(n);
        Console.Write("So {0} bieu dien trong he nhi phan la: {0} = ", n);
        stack1.Print();

        // Doi n sang he 16
        HexaStack stack2 = Dec2Hex(n);
        Console.Write("So {0} bieu dien trong he 16 la: ", n);
        stack2.Print();
        Console.ReadKey();
    }
}