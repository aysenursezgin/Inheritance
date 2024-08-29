public class Ogrenci : BaseKisi
{
    public string OgrenciNumarasi { get; set; }

    public void OgrenciYazdir()
    {
        Console.WriteLine($"Öğrenci Numarası: {OgrenciNumarasi}, Ad: {Ad}, Soyad: {Soyad}");
    }
}