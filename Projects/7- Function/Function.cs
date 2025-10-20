using System.Reflection.Metadata.Ecma335;

namespace Function;

public class Function
{
    //Praktik7.1 - Fungsi tanpa parameter dan tanpa nilai kembali
    public static void Praktik1()
    {
        static void sapa()
        {
            Console.WriteLine("Halo, selamat datang di pembelajaran C#!");
            Console.WriteLine("Mari belajar tentang fungsi!");
        }

        sapa();
    }

    //Praktik7.2 - Fungsi dengan parameter
    public static void Praktik2()
    {
        static void sapaNama(string nama)
        {
            Console.WriteLine("Halo, " + nama + "!");
            Console.WriteLine("Semangat belajar C# hari ini!");
        }
        Console.WriteLine("Masukkan nama Anda: ");
        string nama = Console.ReadLine() ?? string.Empty;

        sapaNama(nama);
    }

    //Praktik7.3 - Fungsi dengan nilai kembali
    public static void Praktik3(string[] args)
    {
        static int plus(int a, int b)
        {
            return a + b;
        }

        Console.Write("Masukkan angka pertama: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan angka kedua: ");
        int y = Convert.ToInt32(Console.ReadLine());

        int hasil = plus(x, y);
        Console.WriteLine("Hasil penjumlahan: " + hasil);
    }

    //Contoh7.1 - penggunaan fungsi membuat program sederhana
    //Menghitung Luas Persegi Panjang Menggunakan Fungsi
    //Deskripsi:
    //Buatlah program untuk menghitung luas persegi panjang dengan menggunakan
    //fungsi.
    //Program harus meminta input panjang dan lebar, lalu memanggil fungsi
    //HitungLuas untuk menghitung dan menampilkan hasilnya.
    public static void Contoh1()
    {
        static double HitungLuas(double panjang, double lebar)
        {
            double luas = panjang * lebar;
            return panjang * lebar;
        }

        {
            Console.WriteLine("Masukkan panjang persegi panjang: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan lebar persegi panjang: ");
            double l = Convert.ToDouble(Console.ReadLine());

            double luas = HitungLuas(p, l);
            Console.WriteLine("Luas persegi panjang adalah: " + luas);
        }
    }

    //Contoh7.2 - penggunaan fungsi membuat program sederhana Kalkulator
    public static void Contoh2()
    {
        string hitungLagi;

        static double Tambah(double a, double b)
        {
            return a + b;
        }

        static double Kurang(double a, double b)
        {
            return a - b;
        }

        static double Kali(double a, double b)
        {
            return a * b;
        }

        static double Bagi(double a, double b)
        {
            return a / b;
        }
        do
        {
            Console.Clear();
            Console.WriteLine("--- KALKULATOR SEDERHANA ---");


            TampilkanMenu();

            Console.Write("Masukkan pilihan operasi (1-4): ");
            string pilihan = Console.ReadLine() ?? string.Empty;
            double a, b, hasil = 0;

            if (AmbilInputAngka(out a, out b))
            {
                switch (pilihan)
                {
                    case "1":
                        hasil = Tambah(a, b);
                        Console.WriteLine($"\nHasil {a} + {b} = {hasil}");
                        break;
                    case "2":
                        hasil = Kurang(a, b);
                        Console.WriteLine($"\nHasil {a} - {b} = {hasil}");
                        break;
                    case "3":
                        hasil = Kali(a, b);
                        Console.WriteLine($"\nHasil {a} * {b} = {hasil}");
                        break;
                    case "4":
                        if (b == 0)
                        {
                            Console.WriteLine("\nError: Tidak dapat melakukan pembagian dengan nol.");
                        }
                        else
                        {
                            hasil = Bagi(a, b);
                            Console.WriteLine($"\nHasil {a} / {b} = {hasil}");
                        }
                        break;
                    default:
                        Console.WriteLine("\nPilihan yang Anda masukkan tidak valid.");
                        break;
                }
            }

            Console.Write("\nApakah Anda ingin menghitung lagi? (y/n): ");
            hitungLagi = Console.ReadLine() ?? string.Empty;
        }
        while (hitungLagi.ToLower() == "y");
        static void TampilkanMenu()
        {
            Console.WriteLine("Pilih operasi matematika:");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
        }
        static bool AmbilInputAngka(out double a, out double b)
        {
            Console.Write("Masukkan angka pertama: ");
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Input untuk angka pertama tidak valid.");
                b = 0;
                return false;
            }
            Console.Write("Masukkan angka kedua: ");
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Input untuk angka kedua tidak valid.");
                return false;
            }
            return true;
        }
    }

    //Tugas7.1 - Buat fungsi bernama Kali yang menerima tiga bilangan dan menampilkan hasil perkalian!
    public static void Tugas1()
    {
        static void Kali(int a, int b, int c)
        {
            int hasil = a * b * c;
            Console.WriteLine("Hasil perkalian: " + hasil);
        }
        Kali(7, 3, 4);
    }

    //Tugas7.2 - Buat fungsi RataRata yang menerima tiga nilai dan mengembalikan hasil rata-ratanya!
    public static void Tugas2()
    {
        static void RataRata(int a, int b, int c)
        {
            int hasil = (a + b + c) / 3;
            Console.WriteLine("Hasil rata-rata: " + hasil);
        }
        RataRata(14, 6, 4);
    }

    //Tugas7.3 - Buat fungsi KonversiSuhu untuk mengubah suhu dari Celcius ke Fahrenheit dengan
    //rumus:
    //F = (C × 9/5) + 32.
    //Tampilkan hasil konversi pada program utama!
    public static void Tugas3()
    {
        static void KonversiSuhu(double celcius)
        {
            double fahrenheit = (celcius * 9 / 5) + 32;
            Console.WriteLine("Hasil konversi suhu: " + fahrenheit + " °F");
        }
        KonversiSuhu(25);
    }
}