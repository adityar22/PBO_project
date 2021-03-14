using System;
namespace portal
{
    public struct krsData
    {
       public string krsNama;
       public string krsNim;
       public int[] matChoose;
       public int totalSKS;
       public int totalMat;

       public void transfer()
       {         
           
       }
         
       public void tampil()
       {
           krsData datkrs = new krsData();
           datkrs.transfer();
        
       }
    }
}