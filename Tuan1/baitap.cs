namespace Tuan1
{
    public class baitap
    {
        public void Bai1()
        {
            Console.Write("Nhập số thứ nhất: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập số thứ hai: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Tổng = " + (a + b));
            Console.WriteLine("Hiệu = " + (a - b));
            Console.WriteLine("Tích = " + (a * b));
            Console.WriteLine("Thương = " + (a / b));
        }
        public void Bai2()
        {
            Console.Write("Nhập độ C: ");
            double c = double.Parse(Console.ReadLine());
            double f = c * 9 / 5 + 32;
            Console.WriteLine("Độ F = " + f);
        }
        public void Bai3()
        {
            Console.Write("Nhập cân nặng (kg): ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều cao (m): ");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);

            Console.WriteLine("BMI = " + bmi);
        }
    }
}
