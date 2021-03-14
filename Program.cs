using System;

namespace portal
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Selamat datang di Program Pengisian KRS");
           
           MhsData mhsData = new MhsData();
           mhsData.input();

           matData mat = new matData();
           mat.transfer();
           mat.tampil();
           mat.pilih();

           krsData krs = new krsData();
           krs.tampil();
        }
    }
}

