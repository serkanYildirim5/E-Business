namespace E_Business.DAL.Migrations
{
    using E_Business.Entity.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<E_Business.DAL.E_BusinessContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(E_Business.DAL.E_BusinessContext context)
        {
            //List<Kategori> kt = new List<Kategori>() {
            //    new Kategori(){KategoriAdi="Araba"},
            //    new Kategori(){KategoriAdi="Giyim"},
            //    new Kategori(){KategoriAdi="Elektronik"},
            //    new Kategori(){KategoriAdi="Beyaz Eşya"},
            //};
            //context.Kategoriler.AddRange(kt);
            //context.SaveChanges();

            //List<AltKategori> alt = new List<AltKategori>() {
            //    new AltKategori(){KategoriAd="Spor Araba",BagliOlduguKategoriId=1},
            //    new AltKategori(){KategoriAd="Pickup",BagliOlduguKategoriId=1},
            //    new AltKategori(){KategoriAd="Dış Giyim",BagliOlduguKategoriId=2},
            //    new AltKategori(){KategoriAd="Alt Giyim",BagliOlduguKategoriId=2},
            //    new AltKategori(){KategoriAd="Televizyon",BagliOlduguKategoriId=3},
            //    new AltKategori(){KategoriAd="Bilgisayar",BagliOlduguKategoriId=3},
            //    new AltKategori(){KategoriAd="Telefon",BagliOlduguKategoriId=3},
            //    new AltKategori(){KategoriAd="Bulaşık Makinesi",BagliOlduguKategoriId=4},
            //    new AltKategori(){KategoriAd="Çamaşır Makinesi",BagliOlduguKategoriId=4},

            //};
            //context.AltKategoriler.AddRange(alt);
            //context.SaveChanges();

            List<Urun> urunler = new List<Urun>() {
                new Urun(){UrunAdi="Panamera 4 E-Hybrid",UrunAciklama="YENİKÖY MOTORS 2019 PORSCHE PANAMERA 4 E-HYBRID-SPORT CHRONO-0",UrunFiyati=2.450000,UrunFotografı="Assets/img/product/porsche.jpg", BagliOlduguKategoriId=1,UrunAdeti=10},
                new Urun(){UrunAdi=" 760i xDrive Long M Sport",UrunAciklama="ağaçlı'DAN 2017 BMW M7.60Lİ XDRIVE BAYİ HATASIZ ORJ.MAT",UrunFiyati=2.125000,UrunFotografı="Assets/img/product/bmw.jpg",BagliOlduguKategoriId=1,UrunAdeti=10},
                new Urun(){UrunAdi="Rezvani",UrunAciklama="HD MOTORLU ARAÇLAR- 2019 MODEL REZVANİ TANK 6400CC 500HP!",UrunFiyati=7.890000,UrunFotografı="Assets/img/product/pickup1.jpg",BagliOlduguKategoriId=2,UrunAdeti=10},
                new Urun(){UrunAdi="Rezvani",UrunAciklama="HD MOTORLU ARAÇLAR- 2019 MODEL REZVANİ TANK 6400CC 500HP!",UrunFiyati=7.890000,UrunFotografı="Assets/img/product/pickup1.jpg",BagliOlduguKategoriId=2,UrunAdeti=10},
                new Urun(){UrunAdi="Rezvani",UrunAciklama="HD MOTORLU ARAÇLAR- 2019 MODEL REZVANİ TANK 6400CC 500HP!",UrunFiyati=7.890000,UrunFotografı="Assets/img/product/pickup1.jpg",BagliOlduguKategoriId=2,UrunAdeti=10},
                new Urun(){UrunAdi="Rezvani",UrunAciklama="HD MOTORLU ARAÇLAR- 2019 MODEL REZVANİ TANK 6400CC 500HP!",UrunFiyati=7.890000,UrunFotografı="Assets/img/product/pickup1.jpg",BagliOlduguKategoriId=2,UrunAdeti=10},
                new Urun(){UrunAdi="Rezvani",UrunAciklama="HD MOTORLU ARAÇLAR- 2019 MODEL REZVANİ TANK 6400CC 500HP!",UrunFiyati=7.890000,UrunFotografı="Assets/img/product/pickup1.jpg",BagliOlduguKategoriId=2,UrunAdeti=10},
                new Urun(){UrunAdi="Yakası Suni Kürk Detaylı Mont",UrunAciklama="Klasik Yaka, Cep Detaylı, Fermuar Detaylı Mont",UrunFiyati=194.99,UrunFotografı="Assets/img/product/mont.jpg",BagliOlduguKategoriId=3,UrunAdeti=10},
                new Urun(){UrunAdi="Yakası Suni Kürk Detaylı Mont",UrunAciklama="Klasik Yaka, Cep Detaylı, Fermuar Detaylı Mont",UrunFiyati=194.99,UrunFotografı="Assets/img/product/mont.jpg",BagliOlduguKategoriId=3,UrunAdeti=10},
                new Urun(){UrunAdi="Yakası Suni Kürk Detaylı Mont",UrunAciklama="Klasik Yaka, Cep Detaylı, Fermuar Detaylı Mont",UrunFiyati=194.99,UrunFotografı="Assets/img/product/mont.jpg",BagliOlduguKategoriId=3,UrunAdeti=10},
                new Urun(){UrunAdi="Yakası Suni Kürk Detaylı Mont",UrunAciklama="Klasik Yaka, Cep Detaylı, Fermuar Detaylı Mont",UrunFiyati=194.99,UrunFotografı="Assets/img/product/mont.jpg",BagliOlduguKategoriId=3,UrunAdeti=10},
                new Urun(){UrunAdi="Yakası Suni Kürk Detaylı Mont",UrunAciklama="Klasik Yaka, Cep Detaylı, Fermuar Detaylı Mont",UrunFiyati=194.99,UrunFotografı="Assets/img/product/mont.jpg",BagliOlduguKategoriId=3,UrunAdeti=10},
                new Urun(){UrunAdi="Yakası Suni Kürk Detaylı Mont",UrunAciklama="Klasik Yaka, Cep Detaylı, Fermuar Detaylı Mont",UrunFiyati=194.99,UrunFotografı="Assets/img/product/mont.jpg",BagliOlduguKategoriId=3,UrunAdeti=10},
                new Urun(){UrunAdi="50UM7600PLB",UrunAciklama="LG 50UM7600 50' 127 CM 4K UHD webOS SMART TV,DAHİLİ UYDU ALICI",UrunFiyati=3.799,UrunFotografı="Assets/img/product/tv.jpg",BagliOlduguKategoriId=5,UrunAdeti=10},
                new Urun(){UrunAdi="50UM7600PLB",UrunAciklama="LG 50UM7600 50' 127 CM 4K UHD webOS SMART TV,DAHİLİ UYDU ALICI",UrunFiyati=3.799,UrunFotografı="Assets/img/product/tv.jpg",BagliOlduguKategoriId=5,UrunAdeti=10},
                new Urun(){UrunAdi="50UM7600PLB",UrunAciklama="LG 50UM7600 50' 127 CM 4K UHD webOS SMART TV,DAHİLİ UYDU ALICI",UrunFiyati=3.799,UrunFotografı="Assets/img/product/tv.jpg",BagliOlduguKategoriId=5,UrunAdeti=10},
                new Urun(){UrunAdi="50UM7600PLB",UrunAciklama="LG 50UM7600 50' 127 CM 4K UHD webOS SMART TV,DAHİLİ UYDU ALICI",UrunFiyati=3.799,UrunFotografı="Assets/img/product/tv.jpg",BagliOlduguKategoriId=5,UrunAdeti=10},
                new Urun(){UrunAdi="50UM7600PLB",UrunAciklama="LG 50UM7600 50' 127 CM 4K UHD webOS SMART TV,DAHİLİ UYDU ALICI",UrunFiyati=3.799,UrunFotografı="Assets/img/product/tv.jpg",BagliOlduguKategoriId=5,UrunAdeti=10},
                new Urun(){UrunAdi="50UM7600PLB",UrunAciklama="LG 50UM7600 50' 127 CM 4K UHD webOS SMART TV,DAHİLİ UYDU ALICI",UrunFiyati=3.799,UrunFotografı="Assets/img/product/tv.jpg",BagliOlduguKategoriId=5,UrunAdeti=10},
            };
            context.Urunler.AddRange(urunler);
            context.SaveChanges();

            //List<Yorum> yorumlar = new List<Yorum>() {
            //    new Yorum(){FullName="Serkan Yıldırım",Email="yildirim@gmail.com",Number="12345678910",BagliOlduguUrunId=1}
            //};
            //context.Yorumlar.AddRange(yorumlar);
            //context.SaveChanges();


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
