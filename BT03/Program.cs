using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT03
{
    class PhanSo
    {
        private int tuso;
        private int mauso;
        public PhanSo()
        {
            tuso = 0;
            mauso = 1;
        }
        public PhanSo(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        public void setTuso(int tuso)
        {
            this.tuso = tuso;
        }
        public int getTuso()
        {
            return tuso;
        }
        public void setMauso(int mauso)
        {
            this.mauso = mauso;
        }
        public int getMauso()
        {
            return mauso;
        }
        public void toiGian()
        {
            // Buoc 1: tim ucln va nn cua tuso va mauso
            // Buoc 2: toi gian tuso= tuso/ucln, mauso=mauso/ucln
            int uscln = TimUSCLN(tuso, mauso);
            tuso = tuso / uscln;
            mauso = mauso / uscln;
        }
        private int TimUSCLN(int a, int b)
        {
            int x = Math.Abs(a);
            int y = Math.Abs(b);
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            return x;
        }
        public PhanSo cong(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.mauso + ps.tuso * mauso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public PhanSo tru(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.mauso - ps.tuso * mauso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public PhanSo nhan(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.tuso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public PhanSo chia(PhanSo ps)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * ps.mauso;
            kq.mauso = mauso * ps.tuso;
            return kq;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //cau a
            PhanSo p1 = new PhanSo();
            Console.WriteLine("Nhap thong tin phan so thu nhat:");
            Console.Write("\t -Nhap tu so:");
            int tuso = int.Parse(Console.ReadLine());
            Console.Write("\t -Nhap mau so:");
            int mauso = int.Parse(Console.ReadLine());

            p1.setTuso(tuso);
            p1.setMauso(mauso);

            Console.WriteLine("Nhap thong tin phan so thu 2");
            Console.Write("\t -Nhap tu so:");
            tuso = int.Parse(Console.ReadLine());
            Console.Write("\t -Nhap mau so:");
            mauso = int.Parse(Console.ReadLine());

            PhanSo p2 = new PhanSo(tuso, mauso);

            p2.toiGian();

            PhanSo tong = p1.cong(p2);
            Console.WriteLine("Tong 2 phan so PS1:{0}/{1} va PS2:{2}/{3} = {4}/{5}",
                p1.getTuso(), p1.getMauso(), p2.getTuso(), p2.getMauso(), tong.getTuso(), tong.getMauso());
            PhanSo hieu = p1.tru(p2);
            Console.WriteLine("Tru 2 phan so PS1:{0}/{1} va PS2:{2}/{3} = {4}/{5}",
                p1.getTuso(), p1.getMauso(), p2.getTuso(), p2.getMauso(), tong.getTuso(), tong.getMauso());
            PhanSo tich = p1.nhan(p2);
            Console.WriteLine("Nhan 2 phan so PS1:{0}/{1} va PS2:{2}/{3} = {4}/{5}",
                p1.getTuso(), p1.getMauso(), p2.getTuso(), p2.getMauso(), tong.getTuso(), tong.getMauso());
            PhanSo Thuong = p1.chia(p2);
            Console.WriteLine("thuong 2 phan so PS1:{0}/{1} va PS2:{2}/{3} = {4}/{5}",
                p1.getTuso(), p1.getMauso(), p2.getTuso(), p2.getMauso(), tong.getTuso(), tong.getMauso());

            //cau b
            Console.WriteLine("Tinh toan day phan so:");
            Console.Write("\t -Nhap vao so nguyen duong:");
            int n = int.Parse(Console.ReadLine());

            PhanSo s = new PhanSo(0, 1);
            for (int i = 1; i <= n; i++)
            {
                s = s.cong(new PhanSo(1, i));
            }
            Console.WriteLine("Ket qua day phan so: 1 + 1/2 + 1/3 + .. 1/n = {0}/{1}", s.getTuso(), s.getMauso());
            Console.ReadLine();
        }
    }
}
