using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {        
        List<Musteri> musteriList =new List<Musteri>();
        public void MusteriEkle(Musteri musteriExp)
        {
            musteriList.Add(musteriExp);
            Console.WriteLine(musteriExp.Ad+" eklendi.");
        }        
        public void MusterileriListele()
        {
            foreach (Musteri x in musteriList)
            {
                Console.WriteLine("Müşteri id = "+x.Id+", adi = "+x.Ad+", yaşı = "+x.Yas+".");
            }
        }
        public void MusteriSil(Musteri musteriExp)
        {
            musteriList.Remove(musteriExp);
            Console.WriteLine(musteriExp.Ad + " silindi.");
        }
    }
}
