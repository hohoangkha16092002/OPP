/*1. Cài đặt lớp Stack mô tả các thao tác xử lý trên ngăn xếp với dữ liệu là số nguyên.
Các thuộc tính:
- top: chỉ số của phần tử trên cùng.
- Max: số phần tử đối đa.
- stack: mảng chứa các phần tử.
Các phương thức:
- Thiết lập: khởi tạo ngăn xếp rỗng (gán chỉ số top = -1).
- Push(int data): thêm phần tử.
- Pop(): lấy ra phần tử trên cùng.
- Peek(): in ra phần tử trên cùng.
- IsEmpty(): kiểm tra Stack có rỗng hay không.
- Print(): In ra danh sách phần tử trong Stack.

2. Chương trình chính
a. Sử dụng lớp Stack để phân tích một số nguyên thành thừa số nguyên tố, sau đó in ra các thừa số theo thứ tự ngược lại.
Ví dụ:
Input: 12
Output: = 3 * 2 * 2
b. Sử dụng lớp Stack để đổi một số nguyên sang hệ nhị phân, thập lục phân.*/

using System;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        // Sử dụng stack vào bài toán phân tích số tự nhiên ra thừa số nguyên tố.
        int n, n0;

        // Khởi tạo ngăn xếp
        Stack stack1 = new Stack();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("*Sai định dạng, phải là số!*");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Nhập số tự nhiên n: ");
        n = int.Parse(Console.ReadLine());
        n0 = n;


        // phân tích n ra thừa số nguyên tố
        for (int i = 2; i <= n; i++)
        {
            // Chừng nào n còn chia hết cho i -> đẩy i vào ngăn xếp, giảm n = n/i
            while (n % i == 0)
            {
                stack1.Push(i);
                n /= i;
            }
        }

        // In ra các phần tử trong ngăn xếp:
        Console.WriteLine("Số {0} phân tích ra thừa số nguyên tố:", n0);
        Console.ForegroundColor = ConsoleColor.Green;
        stack1.Print();
        Console.ForegroundColor = ConsoleColor.White;
        ////////////////////////////////////////////////////////////////////////////////////////////
        // Đổi số n sang hệ 16
        n = n0; // gán lại giá trị ban đầu của n
        // Tạo 1 ngăn xếp mới (rỗng)
        Stack stack2 = new Stack();

        while (n > 0)
        {
            // Lấy ra số dư của phép chia n/16
            int soDu = n % 16;
            // Đẩy số dư vào stack
            stack2.Push(soDu);
            // Giảm n
            n = n / 16;
        }

        // In ra ngăn xếp (chứa các số dư theo thứ tự ngược lại)
        Console.WriteLine("\nSố {0} đổi sang hệ 16 là:", n0);
        Console.ForegroundColor = ConsoleColor.Green;
        stack2.PrintHex();
        Console.ForegroundColor = ConsoleColor.White;
        ////////////////////////////////////////////////////////////////////////////////////////////
        // Đổi số n sang hệ nhị phân
        n = n0;
        Stack stack3 = new Stack();
        while (n > 0)
        {
            int soDu = n % 2;
            stack3.Push(soDu);
            n = n / 2;
        }
        Console.WriteLine("\nSố {0} đổi sang hệ nhị phân là:", n0);
        Console.ForegroundColor = ConsoleColor.Green;
        stack3.PrintBinary();
        Console.ForegroundColor = ConsoleColor.White;

        Console.ReadKey();
    }
}