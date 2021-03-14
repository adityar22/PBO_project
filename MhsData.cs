using System;

namespace portal
{
    public struct MhsData
    {
            public string mhsNama;
            public string mhsNIM;
            public double mhsSKS;
            public double mhsSmstr;
            public string mhsJrsn;

            public void input()
            {
                MhsData mhsData = new MhsData();
                matData mat = new matData();

                Console.WriteLine("Masukkan nama mahasiswa...");
                mhsData.mhsNama = Console.ReadLine();

                Console.WriteLine("Masukkan NIM mahasiswa...");
                mhsData.mhsNIM = Console.ReadLine();

                Console.WriteLine("Masukkan jurusan mahasiswa...");
                mhsData.mhsJrsn = Console.ReadLine();

                Console.WriteLine("Masukkan semester mahasiswa...");
                mhsData.mhsSmstr = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Masukkan jumlah SKS mahasiswa...");
                mhsData.mhsSKS = Convert.ToDouble(Console.ReadLine());

                mat.tampil();
            } 
    }
}