namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Mehmet";
            musteri1.Yas = 21;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Yusuf";
            musteri2.Yas = 19;

            MusteriManager m = new MusteriManager();
            m.MusteriEkle(musteri1);
            m.MusteriEkle(musteri2);

            Console.WriteLine("------------------");

            m.MusterileriListele();
            
            Console.WriteLine("------------------");

            m.MusteriSil(musteri1);
            m.MusteriSil(musteri2);
        }
    }
}