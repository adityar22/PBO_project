using System;

namespace portal
{
    public struct matList
    {
        public string[] namaMat;
        public int[] sksMat;
        public string[] hariMat;
        public int[] smstrMat;
        public int total;

        public void input()
        {
            total = 2;
            lstMat();
            lstSks();
            lstHari();
            lstSmstr();
        }

        public void lstMat(){
            namaMat[0] = "Matematika Elektro";
            namaMat[1] = "Matematika Teknik";
            namaMat[2] = "Matematika Disktrit";
        }

        public void lstSks(){
            sksMat[0] = 3;
            sksMat[1] = 3;
            sksMat[2] = 3;
        }

        public void lstHari(){
            hariMat[0] = "Senin";
            hariMat[1] = "Selasa";
            hariMat[2] = "Rabu";
        }
        
        public void lstSmstr(){
            sksMat[0] = 1;
            sksMat[1] = 2;
            sksMat[2] = 3;
        }

        
    }
}