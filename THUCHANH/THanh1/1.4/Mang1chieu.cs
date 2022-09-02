/*Viết chương trình C# thực hiện các công việc sau (mỗi chức năng xây dựng thành một hàm):
a) Nhập một mảng n số nguyên từ bàn phím.
b) In các phần tử của mảng lên màn hình.
c) Trả về phần tử lớn nhất của mảng.
d) Trả về kiểu boolean kiểm tra mảng đã được sắp xếp tăng dần chưa.
e) Sắp xếp mảng theo thứ tự tăng dần.
f) Tách mảng thành 2 mảng con: một mảng chứa các phần tử chẵn, mảng còn lại chứa các phần tử lẻ.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mang1chieu
{
    class Program
    {
//////////////////////////////////////////////////////////////////////////////////////
        static void nhap(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
//////////////////////////////////////////////////////////////////////////////////////
        static void xuat(int[] a, int n)
        {
            Console.Write("Hien thi mang: ");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
        }
//////////////////////////////////////////////////////////////////////////////////////
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
//////////////////////////////////////////////////////////////////////////////////////
        
    public static System.Boolean Ktralon(int[] a, int n)
        {
            int dem = 0;
            for (int i = 0; i < n-1; i++)
            {
                if (a[i + 1] >= a[i]) dem++;
            }
            if (dem == n - 1) return true;
            else return false;
        }
//////////////////////////////////////////////////////////////////////////////////////         
        static void Sortup(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++) {
				for (int j = i + 1; j < n; j++) {
					if (a[i] > a[j]) {
						// Nếu a[i] > a[j] thì hoán đổi giá trị của a[i] và a[j]
						int temp = a[i];
						a[i] = a[j];
						a[j] = temp;
					}
				}
			}
            Console.Write("\nHien thi mang sau khi sap xep tang dan: ");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
        }
//////////////////////////////////////////////////////////////////////////////////////
        static void split_arr(int[] a, int n, int[] b, int[] c)
        {
            int i;
            int m = 0; int k = 0;
            for(i = 0; i < n; i++){
                if(a[i]%2 != 0) // odd number
                {
                    b[(m)++] = a[i];
                }
                else //even number
                {
                    c[(k)++] = a[i];
                }
            }
            Console.Write("\nHien thi mang le sau khi tach: ");
            for (int h = 0; h < m; h++)
                Console.Write(b[h] + " ");
            Console.Write("\nHien thi mang chan sau khi tach: ");
            for (int j = 0; j < k; j++)
                Console.Write(c[j] + " ");
        }
//////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            Console.Write("Nhap so ptu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[100];
            int[] b = new int[100];
            int[] c = new int[100];
            nhap(a, n);
            xuat(a, n);
            Max(a, n);
            if(Ktralon(a, n) == true) Console.Write("Mang tang dan");
            else Console.Write("Mang khong tang dan");
            Sortup(a, n);
            split_arr(a, n, b, c);
            Console.ReadKey();
        }
    }
}