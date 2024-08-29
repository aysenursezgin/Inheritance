class Program
{
    static void Main()
    {
        // Öğrenci nesnesi oluşturuluyor ve değerler atanıyor
        Ogrenci ogrenci = new Ogrenci
        {
            Ad = "Aysenur",
            Soyad = "Sezgin",
            OgrenciNumarasi = "123456"
        };

        // Öğrenci bilgileri yazdırılıyor
        ogrenci.OgrenciYazdir();

        // Öğretmen nesnesi oluşturuluyor ve değerler atanıyor
        Ogretmen ogretmen = new Ogretmen
        {
            Ad = "Alperen",
            Soyad = "Sezgin",
            MaasBilgisi = 7500.00m
        };

        // Öğretmen bilgileri yazdırılıyor
        ogretmen.OgretmenYazdir();
    }
}