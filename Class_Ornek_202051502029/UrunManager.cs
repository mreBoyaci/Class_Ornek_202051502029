using System;
namespace Class_Ornek_202051502029
{
    class UrunManager
    {
        public void Add(Urun urun)
        {
            Console.WriteLine("Eklendi : " + urun.Adi);
        }
        public void Delete(Urun urun)
        {
            Console.WriteLine("Silindi : " + urun.Adi);
        }
        public void Update(Urun urun)
        {
            Console.WriteLine("Güncellendi : " + urun.Adi);
        }
    }
}














