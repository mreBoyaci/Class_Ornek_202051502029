namespace Class_Ornek_202051502029
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Çamaşır deterjanı";
            urun1.StokAdedi = "342";
            urun1.Fiyat = "29.99 TL";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Armut";
            urun2.StokAdedi = "288 KG";
            urun2.Fiyat = "6.99 TL";

            Urun urun3 = new Urun();
            urun3.Id = 3;
            urun3.Adi = "İphone 11";
            urun3.StokAdedi = "12";
            urun3.Fiyat = "15.000 TL";

            UrunManager urunManager = new UrunManager();
            urunManager.Add(urun1);
            urunManager.Delete(urun2);
            urunManager.Update(urun3);
        }
    }
}














