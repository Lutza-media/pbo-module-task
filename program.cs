using System;
using System.Collections.Generic;

class Kendaraan
{
    public string Nama { get; set; }
    public int Kecepatan { get; set; }

    public Kendaraan(string nama, int kecepatan)
    {
        Nama = nama;
        Kecepatan = kecepatan;
    }

    public virtual void Bergerak()
    {
        Console.WriteLine($"{Nama} sedang bergerak.");
    }

    public virtual void InfoKendaraan()
    {
        Console.WriteLine($"Nama: {Nama}, Kecepatan: {Kecepatan}");
    }
}

class Darat : Kendaraan
{
    public int JumlahRoda { get; set; }

    public Darat(string nama, int kecepatan, int jumlahRoda)
        : base(nama, kecepatan)
    {
        JumlahRoda = jumlahRoda;
    }

    public void HitungRoda()
    {
        Console.WriteLine($"{Nama} memiliki {JumlahRoda} roda.");
    }

    public override void InfoKendaraan()
    {
        Console.WriteLine($"Nama: {Nama}, Kecepatan: {Kecepatan}, Jumlah Roda: {JumlahRoda}");
    }
}

class Air : Kendaraan
{
    public string JenisAir { get; set; }

    public Air(string nama, int kecepatan, string jenisAir)
        : base(nama, kecepatan)
    {
        JenisAir = jenisAir;
    }

    public void CekKondisiAir()
    {
        Console.WriteLine($"{Nama} berjalan di air {JenisAir}");
    }

    public override void InfoKendaraan()
    {
        Console.WriteLine($"Nama: {Nama}, Kecepatan: {Kecepatan}, Jenis Air: {JenisAir}");
    }
}

class Mobil : Darat
{
    public Mobil(string nama, int kecepatan, int jumlahRoda)
        : base(nama, kecepatan, jumlahRoda) { }

    public void Klakson()
    {
        Console.WriteLine($"{Nama}: Tin! Tin!");
    }

    public override void Bergerak()
    {
        Console.WriteLine($"{Nama} melaju di jalan raya.");
    }
}

class Motor : Darat
{
    public Motor(string nama, int kecepatan, int jumlahRoda)
        : base(nama, kecepatan, jumlahRoda) { }

    public void GasPol()
    {
        Console.WriteLine($"{Nama}: Ngeeeeng!");
    }

    public override void Bergerak()
    {
        Console.WriteLine($"{Nama} melaju dengan cepat di jalan.");
    }
}

class Kapal : Air
{
    public Kapal(string nama, int kecepatan, string jenisAir)
        : base(nama, kecepatan, jenisAir) { }

    public void Berlayar()
    {
        Console.WriteLine($"{Nama} sedang berlayar.");
    }

    public override void Bergerak()
    {
        Console.WriteLine($"{Nama} berlayar di lautan.");
    }
}

class Perahu : Air
{
    public Perahu(string nama, int kecepatan, string jenisAir)
        : base(nama, kecepatan, jenisAir) { }

    public void Dayung()
    {
        Console.WriteLine($"{Nama} sedang didayung.");
    }

    public override void Bergerak()
    {
        Console.WriteLine($"{Nama} bergerak di air dengan dayung.");
    }
}

class Garasi
{
    private List<Kendaraan> daftarKendaraan = new List<Kendaraan>();

    public void TambahKendaraan(Kendaraan kendaraan)
    {
        daftarKendaraan.Add(kendaraan);
    }

    public void DaftarKendaraan()
    {
        Console.WriteLine("\n=== Daftar Kendaraan ===");
        foreach (var k in daftarKendaraan)
        {
            k.InfoKendaraan();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Garasi garasi = new Garasi();

        Mobil mobil = new Mobil("Mobil Avanza", 120, 4);
        Motor motor = new Motor("Motor Ninja", 150, 2);
        Kapal kapal = new Kapal("Kapal Laut", 80, "laut");
        Perahu perahu = new Perahu("Perahu Kayu", 20, "sungai");

        garasi.TambahKendaraan(mobil);
        garasi.TambahKendaraan(motor);
        garasi.TambahKendaraan(kapal);
        garasi.TambahKendaraan(perahu);

        garasi.DaftarKendaraan();

        Console.WriteLine("\n=== Demonstrasi Method ===");

        mobil.Bergerak();
        kapal.Bergerak();

        mobil.Klakson();

        mobil.InfoKendaraan();

        perahu.Dayung();

        Kendaraan k = new Motor("Motor Supra", 100, 2);
        k.Bergerak();

        motor.GasPol();
        kapal.Berlayar();

        Console.ReadLine();
    }
}
