using bai_4;
using System;
using System.Threading;

namespace bai_4
{
    class PTBH
    {
        protected int a, b, c;
        public PTBH()
        {
            a = b = c = 0;
        }
        public PTBH(int a, int b, int c)
        {
            this.a = a; this.b = b; this.c = c;
        }
        public void nhap()
        {
            Console.WriteLine("nhap he so a"); a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap he so b"); b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap he so c"); c = int.Parse(Console.ReadLine());
        }
        public void hien()
        {
            Console.WriteLine("pt {0}x^2+{1}x+{2}=0", a, b, c);
        }
        public double delta()
        {
            return (b * b) - 4 * a * c;
        }
        public void giaipt()
        {


            if (a == 0)
            {
                Console.WriteLine("phuong trinh ko phai bac 2");
            }
            if (delta() == 0)
            {
                Console.WriteLine("phuong trinh co nghiem kep" + -b / 2 * a);

            }
            else if (delta() < 0)
            {
                Console.WriteLine("pt vo nghiem");
            }
            else
            {

                double x1 = (-b + Math.Sqrt(delta())) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta())) / (2 * a);
                Console.WriteLine("2 nhiem{0},{1}", x1, x2);
            }
        }
    }
    class PTTP : PTBH
    {
        public new void giaipt()
        {
            double d = delta();

            if (d < 0) Console.WriteLine("Phuong trinh vo nghiem");
            else if (d == 0)
            {
                double y = -b / (2 * a);
                if (y < 0) Console.WriteLine("Phuong trinh vo nghiem");
                else Console.WriteLine("Phuong trinh co hai nghiem phan biet\nx1={0}\nx2={1}", -Math.Sqrt(y), Math.Sqrt(y));
            }
            else
            {
                double y1 = (-b - Math.Sqrt(d)) / (2 * a);
                double y2 = (-b + Math.Sqrt(d)) / (2 * a);
                if (y1 > 0 && y2 > 0)
                {
                    double x1 = -Math.Sqrt(y1);
                    double x2 = Math.Sqrt(y1);
                    double x3 = -Math.Sqrt(y2);
                    double x4 = Math.Sqrt(y2);
                    Console.WriteLine("Phuong trinh co bon nghiem phan biet");
                    Console.WriteLine("x1={0}\nx2={1}\nx3={2}\nx4={3}", x1, x2, x3, x4);
                }
                else if (y1 > 0 && y2 < 0)
                {
                    double x1 = -Math.Sqrt(y1);
                    double x2 = Math.Sqrt(y1);
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet");
                    Console.WriteLine("x1={0}\nx2={1}", x1, x2);
                }
                else if (y1 < 0 && y2 > 0)
                {
                    double x1 = -Math.Sqrt(y2);
                    double x2 = Math.Sqrt(y2);
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet");
                    Console.WriteLine("x1={0}\nx2={1}", x1, x2);
                }
                else Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
    }


    class test
    {
        static void Main(string[] args)
        {
            PTTP a = new PTTP();
            a.nhap(); a.giaipt();
            Console.ReadLine();
        }
    }
}