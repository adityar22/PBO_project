using System;

namespace portal
{
    public struct matData
    {
        public string[] matNama;
        public int[] matSks;
        public string[] matHari;
        public int[] matSmstr;
        public int[] matChoice;

        public void transfer()
        {
            matList MatList = new matList();
            MatList.input();
            int i;
            for(i = 0; i < MatList.total; i++)
            {
                matNama[i] = MatList.namaMat[i];
            }

            for(i=0; i < MatList.total; i++)
            {
                matSks[i] = MatList.sksMat[i];
            }

            for(i=0; i < MatList.total; i++)
            {
                matHari[i] = MatList.hariMat[i];
            }

            for(i=0; i < MatList.total; i++)
            {
                matSmstr[i] = MatList.smstrMat[i];
            }
        }

        
        public void tampil()
        {
            matList matlist = new matList();
            
            for(int i = 0; i < matlist.total; i++)
            {
                Console.WriteLine("{0}, {1} SKS",matNama[i], matSks[i]);
            }
        }
       
        public void pilih() 
        {
            int choice, i;
            choice = 0;
            i = 0;
            while (choice != -1)
            {
                Console.WriteLine("Masukkan kode matkul yang di pilih (-1 untuk berhenti) ");
                matChoice[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
        }
    }
}