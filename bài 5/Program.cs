using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Unicode;

namespace bai_2
{
    class Person
    {
        protected string name, national;
        protected int age;
        public Person()
        {
            name = national = "";
            age = 0;
        }
        public Person(string name, string national, int age)
        {
            this.name = name;
            this.national = national;
            this.age = age;
        }
        public void nhap()
        {
            Console.WriteLine("nhap ten"); name = Console.ReadLine();
            Console.WriteLine("nhap qt"); national = Console.ReadLine();
            Console.WriteLine("nhap  tuoi"); age = int.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("ten\t" + name);
            Console.WriteLine("qtich\t" + national);
            Console.WriteLine("tuoi\t" + age);
        }
        class player : Person
        {
            protected string team, position;
            protected int number;
            public player() : base()
            {
                team = "";
                position = "";
                number = 0;
            }
            public player(string name, string national, int age, string team, string position, int number) : base(name, national, age)
            {
                this.team = team;
                this.position = position;
                this.number = number;
            }
            public new void nhap()
            {
                Console.WriteLine("nhap ten"); name = Console.ReadLine();
                Console.WriteLine("nhap qtich"); national = Console.ReadLine();
                Console.WriteLine("nhap tuoi"); age = int.Parse(Console.ReadLine());
                Console.WriteLine("ten team"); team = Console.ReadLine();
                Console.WriteLine("ten vi tri"); position = Console.ReadLine();
                Console.WriteLine("so ao"); number = int.Parse(Console.ReadLine());
            }
            public new void display()

            {

                Console.WriteLine("ten\t" + name);
                Console.WriteLine("qtich\t" + national);
                Console.WriteLine("tuoi\t" + age);
                Console.WriteLine("team\t" + team);
                Console.WriteLine("vitri\t" + position);
                Console.WriteLine("so ao\t" + number);
            }
        }
        class coach : Person
        {
            private int year;
            public coach() : base()
            {
                year = 0;
            }
            public coach(string name, int age, string national, int year) : base(name, national, age)
            {
                this.year = year;
            }
            public new void nhap()
            {
                base.nhap();
                Console.WriteLine("nhap nam "); year = int.Parse(Console.ReadLine());
            }
            public new void display()
            {
                Console.WriteLine("thong tin hlv");
                base.display();
                Console.WriteLine("nam lam hlv" + year);
            }
        }

        class Team
        {
            private player[] ds;
            private coach[] c;
            private int n, sc;

            public void nhap()
            {
                Console.WriteLine("nhap so cau thu"); int n = int.Parse(Console.ReadLine());
                Console.WriteLine("nhap so hlv"); int sc = int.Parse(Console.ReadLine());
                ds = new player[n];
                c = new coach[sc];
                Console.WriteLine("nhap thong tin ct");
                for (int i = 0; i < n; i++)
                {
                    ds[i] = new player(); ds[i].nhap(); Console.Clear();
                }
                Console.WriteLine("nhap tt hlv");
                for (int i = 0; i < sc; i++)
                {
                    c[i] = new coach(); c[i].nhap(); Console.Clear();
                    c[i].display();
                }
                for (int i = 0; i < n; i++)
                {
                    ds[i].display();
                }

            }
            public void display()
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("thong tin cau thu");
                    ds[i].display();
                    c[i].display();
                }

            }

        }
        class test
        {
            static void Main(string[] args)
            {
                Team a = new Team();
                a.nhap(); a.display();
                Console.ReadLine();
            }
        }
    }
}