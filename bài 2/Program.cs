using System;
using System.Globalization;

namespace bai_2
{
    class TG
    {
        protected double a, b, c;
        public TG()
        {
            a = b = c = 0;
        }
        public TG(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void nhap()
        {
            Console.WriteLine("nhap thong tin canh");
            do
            {
                Console.WriteLine("canh a"); a = double.Parse(Console.ReadLine());
                Console.WriteLine("canh b"); b = double.Parse(Console.ReadLine());
                Console.WriteLine("canh c"); c = double.Parse(Console.ReadLine());
            } while (a + b < c && a + c < b && b + c < a);
        }
        public void hien()
        {
            Console.WriteLine("thong tin");
            Console.WriteLine("canh a:{0};canh b:{1};canhc:{2}", a, b, c);
        }
        public double tinhS()
        {
            double ncv = (a + b + c) / 2;
            return Math.Sqrt(ncv * (ncv - a) * (ncv - b) * (ncv - c));
        }
    }
    class TuG : TG
    {
        private double h;
        public TuG() : base()
        {
            h = 0;
        }
        public TuG(double a, double b, double c, double h) : base(a, b, c)
        {
            this.h = h;
        }
        public new void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap them chieu cao"); h = double.Parse(Console.ReadLine());
        }
        public new void hien()
        {
            base.hien();
            Console.WriteLine("chieu cao:{0}", h);
            Console.WriteLine("dien tich la" + base.tinhS());
            Console.WriteLine("the tich la" + TinhV());
        }
        public double TinhV()
        {
            return base.tinhS() * h;
        }
    }
    class test
    {
        static void Main(string[] args)
        {
            TuG t = new TuG();
            t.nhap(); t.hien();
            Console.ReadKey();
        }
    }
}