using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    internal class Baitap
    {
        public void Bai1()
        {
            Console.Write("Nhập họ và tên:");
            string hoTen = Console.ReadLine();
            Console.Write("Nhập điểm:");
            double diem = double.Parse(Console.ReadLine());
            Console.WriteLine("Họ tên:"+hoTen);
            Console.WriteLine("Điểm:"+diem);
            Console.Write("Xếp hạng: ");
            if (diem >= 8)
            {
                Console.WriteLine("Giỏi");
            }
            else if (diem >= 6.5)
            {
                Console.Write("Khá");
            }
            else if (diem >=5)
            {
                Console.Write("Trung bình");
            }
            else if(diem < 5)
            {
                Console.Write("Kém");
            }
        }

        public void Bai2()
        {
            Console.Write("Nhập thứ: ");
            int thu = int.Parse(Console.ReadLine());
            switch (thu)
            {
                case 2:
                    Console.WriteLine("Thứ Hai");
                    break;

                case 3:
                    Console.WriteLine("Thứ Ba");
                    break;

                case 4:
                    Console.WriteLine("Thứ Tư");
                    break;

                case 5:
                    Console.WriteLine("Thứ Năm");
                    break;

                case 6:
                    Console.WriteLine("Thứ Sáu");
                    break;

                case 7:
                    Console.WriteLine("Thứ Bảy");
                    break;

                case 8:
                    Console.WriteLine("Chủ Nhật");
                    break;

                default:
                    Console.WriteLine("Không hợp lệ");
                    break;
            }
        }

        public void Bai3() 
        {
            for(int i=1; i<=10; i++)
            {
                int tich = 5 * i;
                Console.WriteLine($"5 x {i} = {tich}");
            }
        }

        public void Bai4()
        {
            string matKhau;
            do
            {
                Console.Write("Nhập mật khẩu: ");
                matKhau = Console.ReadLine();
                if(matKhau != "123456")
                {
                    Console.WriteLine("Sai mật khẩu, nhập lại!");
                }
            }
            while (matKhau != "123456");
            Console.WriteLine("Đăng nhập thành công");
        }

        public void Bai5()
        {
            string[] fruits = { "Apple", "Banana", "Orange", "Mango" };
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
