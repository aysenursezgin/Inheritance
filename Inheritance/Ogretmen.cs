public class Ogretmen : BaseKisi
{
    public decimal MaasBilgisi { get; set; }

    public void OgretmenYazdir()
    {
        Console.WriteLine($"Maaş Bilgisi: {MaasBilgisi}, Ad: {Ad}, Soyad: {Soyad}");
    }
}