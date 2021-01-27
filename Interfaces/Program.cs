using System;

namespace Interfaces
{
    class Program
    {
        //interfaceler newlenemez
        static void Main(string[] args)
        {
            IKisiManager musteriManager = new MusteriManager();
            //musteriManager.Ekle();
            //musteriManager.Güncelle();

            IKisiManager personelManager = new PersonelManager();
            //personelManager.Ekle();
            //personelManager.Güncelle();

            IKisiManager stajyerManager = new StajyerManager();
            //stajyerManager.Ekle();
            //stajyerManager.Güncelle()

            ProjeManager projeManager = new ProjeManager();

            projeManager.Ekle(stajyerManager);

            projeManager.Güncelle(stajyerManager);
        }
    }

    interface IKisiManager
    {
        //uniplemented operation = içi doldurulmamış 
        void Ekle();
        void Güncelle();
    }
    class MusteriManager:IKisiManager
    {
        //iplemented operation = içi doldurulmuş 
        public void Ekle()
        {
            //musteri ekleme kodları
            Console.WriteLine("Musteri Eklendi");
        }

        public void Güncelle()
        {
            Console.WriteLine("Musteriler Güncellendi");
        }
    }

    class PersonelManager : IKisiManager
    {
        public void Ekle()
        {
            //Musteri2 ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void Güncelle()
        {
            Console.WriteLine("Personeller güncellendi");
        }
    }
    class StajyerManager : IKisiManager
    {
        public void Ekle()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Güncelle()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }

    class ProjeManager
    {
        public void Ekle(IKisiManager kisiManager)
        {
            kisiManager.Ekle();
        }
        public void Güncelle(IKisiManager kisiManager)
        {
            kisiManager.Güncelle();
        }
    }
}
