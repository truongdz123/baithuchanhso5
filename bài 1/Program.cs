using System;
using System.Transactions;

namespace bai_1
{
    class TD
    {
        protected double truoc, nay;
        protected string hoten, diach;
        protected double diendung;
        public TD()
        {
            truoc = nay = 0;
            hoten = diach = "";
        }
        public TD(double truoc, double nay, string hoten, string diachi)
        {
            this.truoc = truoc;
            this.nay = nay;
            this.hoten = hoten;
            this.diach = diachi;
        }
        public void nhap()
        {
            Console.WriteLine("nhap so dien thang truoc"); truoc = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap so dien thang nay"); nay = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap ho ten chu ho"); hoten = Console.ReadLine();
            Console.WriteLine("nhap dia chi"); diach = Console.ReadLine();
        }
        public double Diendung
        {
            get
            {
                return diendung;
            }
            //set { return diendung = value; 
        }
        public double tinhdd()
        {
            return this.nay - this.truoc;
        }
        public double tinhtien()
        {
            return tinhdd() * 500;
        }
        public void hien()
        {
            Console.WriteLine("thong tin");
            Console.WriteLine("ho ten\t\tdiachi\t\tsodiendung\t\ttienphaitra");
            Console.WriteLine(hoten + "\t\t" + diach + "\t\t" + tinhdd() + "\t\t\t" + tinhtien());
        }
        class NEWTD : TD
        {
            private double dinhmuc;
            public NEWTD()
            {
                dinhmuc = 0;
            }
            public NEWTD(int dinhmuc) : base()
            {
                this.dinhmuc = dinhmuc;
            }
            public new void nhap()
            {
                base.nhap();
                Console.WriteLine("nhap dinh muc"); dinhmuc = double.Parse(Console.ReadLine());
            }
            public new double tinhtien()
            {
                if (dinhmuc > base.tinhdd())
                    return base.tinhdd() * 600;
                else
                    return base.tinhdd() * 500;
            }
            public new void hien()
            {
                base.hien();
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            NEWTD t = new NEWTD();
            Console.ForegroundColor = ConsoleColor.Red;
            t.nhap(); t.tinhtien(); t.hien();
            Console.ReadKey();
        }
    }
}