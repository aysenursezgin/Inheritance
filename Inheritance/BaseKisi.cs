using System;

public class BaseKisi
{
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public void Yazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
    }
}