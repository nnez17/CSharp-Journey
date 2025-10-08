namespace Branching;

public class Percabangan
{
    //Praktik4.1– Percabangan dalam C# Percabangan IF - Mengecek Angka Positif
    public static void Praktik1()
    {
        Console.Write("Masukkan angka: ");
        int angka = int.Parse(Console.ReadLine() ?? "0");

        if (angka > 0)
        {
            Console.WriteLine("Angka positif.");
        }
    }

    //Praktik4.2– Percabangan dalam C# Percabangan IF, Mengecek Usia Minimal
    public static void Praktik2()
    {
        Console.Write("Masukkan umur anda: ");
        int umur = int.Parse(Console.ReadLine() ?? "0");

        if (umur >= 18)
        {
            Console.WriteLine("Anda sudah cukup umur untuk membuat KTP.");
        }
    }

    //Praktik4.3– Percabangan dalam C# Percabangan IF, Mengecek Nilai Ujian
    public static void Praktik3()
    {
        Console.Write("Masukkan nilai ujian: ");
        int nilai = int.Parse(Console.ReadLine() ?? "0");

        if (nilai >= 75)
        {
            Console.WriteLine("Selamat, Anda lulus!");
        }
    }

    //Praktik4.4- Percabangan IF-ELSE, Mengecek Bilangan Positif atau Negatif
    public static void Praktik4()
    {
        Console.Write("Masukkan angka: ");
        int angka = int.Parse(Console.ReadLine() ?? "0");

        if (angka >= 0)
        {
            Console.WriteLine("Angka positif");
        }
        else
        {
            Console.WriteLine("Angka negatif");
        }
    }

    //Praktik4.5- Percabangan IF-ELSE, Mengecek Usia Dewasa atau Anak-anak
    public static void Praktik5()
    {
        Console.Write("Masukkan umur Anda: ");
        int umur = int.Parse(Console.ReadLine() ?? "0");

        if (umur >= 17)
        {
            Console.WriteLine("Anda sudah dewasa.");
        }
        else
        {
            Console.WriteLine("Anda masih anak-anak.");
        }
    }

    //Praktik4.6- Percabangan IF-ELSE, Mengecek Kelulusan Berdasarkan Nilai
    public static void Praktik6()
    {
        Console.Write("Masukkan nilai ujian: ");
        int nilai = int.Parse(Console.ReadLine() ?? "0");

        if (nilai >= 75)
        {
            Console.WriteLine("Selamat, Anda lulus!");
        }
        else
        {
            Console.WriteLine("Maaf, Anda tidak lulus.");
        }
    }

    //Praktik4.7- Percabangan IF-ELSE-IF, Menentukan Kategori Nilai 
    public static void Praktik7()
    {
        Console.Write("Masukkan nilai: ");
        int nilai = int.Parse(Console.ReadLine() ?? "0");

        if (nilai >= 90)
        {
            Console.WriteLine("Nilai Anda A");
        }
        else if (nilai >= 75)
        {
            Console.WriteLine("Nilai Anda B");
        }
        else if (nilai >= 60)
        {
            Console.WriteLine("Nilai Anda C");
        }
        else
        {
            Console.WriteLine("Nilai Anda D");
        }
    }

    //Praktik4.8- Percabangan IF-ELSE-IF, Menentukan Jenis Bilangan
    public static void Praktik8()
    {
        Console.Write("Masukkan angka: ");
        int angka = int.Parse(Console.ReadLine() ?? "0");

        if (angka > 0)
        {
            Console.WriteLine("Angka Positif");
        }
        else if (angka < 0)
        {
            Console.WriteLine("Angka Negatif");
        }
        else
        {
            Console.WriteLine("Angka Nol");
        }
    }

    //Praktik4.9- Percabangan IF-ELSE-IF, Menentukan Biaya Tiket Berdasarkan Umur
    public static void Praktik9()
    {
        Console.Write("Masukkan umur: ");
        int umur = int.Parse(Console.ReadLine() ?? "0");

        if (umur < 5)
        {
            Console.WriteLine("Tiket Gratis");
        }
        else if (umur <= 12)
        {
            Console.WriteLine("Harga Tiket Rp. 20.000");
        }
        else if (umur <= 60)
        {
            Console.WriteLine("Harga Tiket Rp. 50.000");
        }
        else
        {
            Console.WriteLine("Harga Tiket Rp. 30.000 (Diskon Lansia)");
        }
    }

    //Praktik4.10- Percabangan switch case, Menentukan Nama Hari
    public static void Praktik10()
    {
        Console.Write("Masukkan angka (1-7): ");
        int hari = int.Parse(Console.ReadLine() ?? "0");

        switch (hari)
        {
            case 1:
                Console.WriteLine("Senin"); break;
            case 2:
                Console.WriteLine("Selasa"); break;
            case 3:
                Console.WriteLine("Rabu"); break;
            case 4:
                Console.WriteLine("Kamis"); break;
            case 5:
                Console.WriteLine("Jumat"); break;
            case 6:
                Console.WriteLine("Sabtu"); break;
            case 7:
                Console.WriteLine("Minggu"); break;
            default:
                Console.WriteLine("Hari tidak valid"); break;
        }
    }

    //Praktik4.11- Percabangan switch case, Menentukan Nama Bulan
    public static void Praktik11()
    {
        Console.Write("Masukkan angka bulan (1-12): ");
        int bulan = int.Parse(Console.ReadLine() ?? "0");

        switch (bulan)
        {
            case 1: Console.WriteLine("Januari"); break;
            case 2: Console.WriteLine("Februari"); break;
            case 3: Console.WriteLine("Maret"); break;
            case 4: Console.WriteLine("April"); break;
            case 5: Console.WriteLine("Mei"); break;
            case 6: Console.WriteLine("Juni"); break;
            case 7: Console.WriteLine("Juli"); break;
            case 8: Console.WriteLine("Agustus"); break;
            case 9: Console.WriteLine("September"); break;
            case 10: Console.WriteLine("Oktober"); break;
            case 11: Console.WriteLine("November"); break;
            case 12: Console.WriteLine("Desember"); break;
            default: Console.WriteLine("Input tidak valid"); break;
        }
    }

    //Praktik4.12- Percabangan switch case, Menu Sederhana (Kasir)
    public static void Praktik12()
    {
        Console.WriteLine("=== Menu Makanan ===\n");
        Console.WriteLine("1. Nasi Goreng");
        Console.WriteLine("2. Mie Ayam");
        Console.WriteLine("3. Soto Ayam");
        Console.Write("\nPilih Menu (1-3): ");
        int menu = int.Parse(Console.ReadLine() ?? "0");

        switch (menu)
        {
            case 1: Console.WriteLine("Anda memilih Nasi Goreng. Harga: Rp 15.000"); break;
            case 2: Console.WriteLine("Anda memilih Mie Ayam. Harga: Rp 12.000"); break;
            case 3: Console.WriteLine("Anda memilih Soto Ayam. Harga: Rp 10.000"); break;
            default: Console.WriteLine("Menu tidak tersedia"); break;
        }
    }

    //Contoh4.1- Program untuk mengetahui karakter yang diinputkan, apakah huruf Besar, huruf
    //kecil, spasi, digit, atau yang lainnya ! Input : Masukkan Karakter : A Output: Karakter
    //yang diinputkan adalah huruf besar.
    public static void Contoh1()
    {
        Console.Write("Masukkan Karakter : ");
        char karakter = Console.ReadKey().KeyChar; // Membaca 1 karakter
        Console.WriteLine(); // Pindah baris

        if (char.IsUpper(karakter))
        {
            Console.WriteLine("Karakter yang diinputkan adalah huruf besar.");
        }
        else if (char.IsLower(karakter))
        {
            Console.WriteLine("Karakter yang diinputkan adalah huruf kecil.");
        }
        else if (char.IsWhiteSpace(karakter))
        {
            Console.WriteLine("Karakter yang diinputkan adalah spasi.");
        }
        else if (char.IsDigit(karakter))
        {
            Console.WriteLine("Karakter yang diinputkan adalah digit (angka).");
        }
        else
        {
            Console.WriteLine("Karakter yang diinputkan adalah karakter lainnya (simbol).");
        }
    }

    //Contoh4.2- Program untuk mempermudah pembayaran di suatu bioskop 
    public static void Contoh2()
    {
        Console.WriteLine("=== PROGRAM PEMBAYARAN BIOSKOP ===");
        Console.WriteLine("Pilih Jenis Film:");
        Console.WriteLine("1. Horor");
        Console.WriteLine("2. Romantic");
        Console.Write("Masukkan pilihan (1/2): ");
        int jenis = int.Parse(Console.ReadLine() ?? "0");
        int harga = 0;
        string judul = "";

        // Pilihan untuk film Horor
        if (jenis == 1)
        {
            Console.WriteLine("\n--- Daftar Film Horor ---");
            Console.WriteLine("1. Kang Solah from Kang Mak x Nenek Gayung   Rp 30000");
            Console.WriteLine("2. Death Whisperer 3                         Rp 35000");
            Console.WriteLine("3. Rest Area                                 Rp 40000");
            Console.Write("Pilih nomor film: ");
            int pilih = int.Parse(Console.ReadLine() ?? "0");

            if (pilih == 1)
            {
                judul = "Kang Solah from Kang Mak x Nenek Gayung";
                harga = 30000;
            }
            else if (pilih == 2)
            {
                judul = "Death Whisperer 3";
                harga = 35000;
            }
            else if (pilih == 3)
            {
                judul = "Rest Area";
                harga = 40000;
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid!");
                return;
            }
        }
        // Pilihan untuk film Romantic
        else if (jenis == 2)
        {
            Console.WriteLine("\n--- Daftar Film Romantic ---");
            Console.WriteLine("1. The Architecture of Love      Rp 35000");
            Console.WriteLine("2. Sampai Nanti, Hanna!          Rp 30000");
            Console.WriteLine("3. Love for Sale                 Rp 40000");
            Console.Write("Pilih nomor film: ");
            int pilih = int.Parse(Console.ReadLine() ?? "0");

            if (pilih == 1)
            {
                judul = "The Architecture of Love";
                harga = 35000;
            }
            else if (pilih == 2)
            {
                judul = "Sampai Nanti, Hanna!";
                harga = 30000;
            }
            else if (pilih == 3)
            {
                judul = "Love for Sale";
                harga = 40000;
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid!");
                return;
            }
        }
        else
        {
            Console.WriteLine("Pilihan jenis film tidak valid!");
            return;
        }

        // Menampilkan hasil
        Console.WriteLine("\n================================");
        Console.WriteLine("Judul Film\t: " + judul);
        Console.WriteLine("Harga Tiket\t: Rp " + harga);
        Console.WriteLine("================================");
        Console.WriteLine("Terima kasih telah membeli tiket!");
    }

    //Tugas4.1 – If. Buat program untuk menentukan apakah sebuah angka lebih besar dari 100 atau tidak
    public static void Tugas1()
    {
        Console.Write("Masukkan Angka: ");
        int angka = int.Parse(Console.ReadLine() ?? "0");

        if (angka > 100)
        {
            Console.WriteLine("Angka lebih besar dari 100");
        }
    }

    //Tugas4.2 – If-Else. Buat program yang meminta input umur. Jika umur ≥ 60, tampilkan “Lansia”,
    // selain itu, tampilkan “Bukan Lansia”.
    public static void Tugas2()
    {
        Console.Write("Masukkan umur: ");
        int umur = int.Parse(Console.ReadLine() ?? "0");

        if (umur >= 60)
        {
            Console.WriteLine("Lansia");
        }
        else
        {
            Console.WriteLine("Bukan Lansia");
        }
    }

    //Tugas4.3 – Switch CaseBuat program yang meminta input angka 1–5 dan menampilkan nama warna:
    //1 = Merah, 2 = Biru, 3 = Hijau, 4 = Kuning, 5 = Hitam.
    public static void Tugas3()
    {
        Console.Write("Masukan angka (1-5): ");
        int warna = int.Parse(Console.ReadLine() ?? "0");

        switch (warna)
        {
            case 1: Console.WriteLine("Warna Merah"); break;
            case 2: Console.WriteLine("Warna Biru"); break;
            case 3: Console.WriteLine("Warna Hijau"); break;
            case 4: Console.WriteLine("Warna Kuning"); break;
            case 5: Console.WriteLine("Warna Hitam"); break;
            default: Console.WriteLine("Angka tidak valid"); break;
        }
    }

    //Tugas4.4 – Switch CaseBuat program dengan input jam (0–23).
    // Jika jam 6–11 → “Selamat Pagi”
    // Jika jam 12–15 → “Selamat Siang”
    // Jika jam 16–18 → “Selamat Sore”
    // Jika jam 19–23 atau 0–5 → “Selamat Malam
    public static void Tugas4()
    {
        Console.Write("Masukkan Jam (0-23): ");
        int jam = int.Parse(Console.ReadLine() ?? "0");

        if (jam >= 6 && jam <= 11)
        {
            Console.WriteLine("Selamat Pagi!");
        }
        else if (jam >= 12 && jam <= 15)
        {
            Console.WriteLine("Selamat Siang!");
        }
        else if (jam >= 16 && jam <= 18)
        {
            Console.WriteLine("Selamat Sore!");
        }
        else if (jam >= 19 && jam <= 23)
        {
            Console.WriteLine("Selamat Malam!");
        }
        else if (jam >= 0 && jam <= 5)
        {
            Console.WriteLine("Selamat Malam!");
        }
    }

    //Percabangan1- Buatlah program untuk mencari luas dan volume menggunakan percabangan switch case untuk menghitung:
    //Luas Permukaan Kubus, Volume Kubus, Luas Permukaan Balok, Volume Balok.
    public static void Operator_Percabangan1()
    {
        Console.WriteLine("=== Program Luas dan Volume ===");
        Console.WriteLine("1. Luas Permukaan Kubus");
        Console.WriteLine("2. Volume Kubus");
        Console.WriteLine("3. Luas Permukaan Balok");
        Console.WriteLine("4. Volume Balok");

        Console.Write("\nMasukkan pilihan: ");
        int pilihan = int.Parse(Console.ReadLine() ?? "0");

        switch (pilihan)
        {
            case 1:
                {
                    Console.WriteLine("Luas Permukaan Kubus");
                    Console.WriteLine("Masukkan panjang sisi kubus: ");
                    double sisi = double.Parse(Console.ReadLine() ?? "0");
                    double luas = 6 * sisi * sisi;
                    Console.WriteLine("Luas permukaan kubus adalah: " + luas);
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Volume Kubus");
                    Console.WriteLine("Masukkan panjang sisi kubus: ");
                    double sisi = double.Parse(Console.ReadLine() ?? "0");
                    double volume = sisi * sisi * sisi;
                    Console.WriteLine("Volume kubus adalah: " + volume);
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Luas Permukaan Balok");
                    Console.WriteLine("Masukkan panjang balok: ");
                    double panjang = double.Parse(Console.ReadLine() ?? "0");
                    Console.WriteLine("Masukkan lebar balok: ");
                    double lebar = double.Parse(Console.ReadLine() ?? "0");
                    Console.WriteLine("Masukkan tinggi balok: ");
                    double tinggi = double.Parse(Console.ReadLine() ?? "0");
                    double luas = 2 * (panjang * lebar + panjang * tinggi + lebar * tinggi);
                    Console.WriteLine("Luas permukaan balok adalah: " + luas);
                    break;
                }

            case 4:
                {
                    Console.WriteLine("Volume Balok");
                    Console.WriteLine("Masukkan panjang balok: ");
                    double panjang = double.Parse(Console.ReadLine() ?? "0");
                    Console.WriteLine("Masukkan lebar balok: ");
                    double lebar = double.Parse(Console.ReadLine() ?? "0");
                    Console.WriteLine("Masukkan tinggi balok: ");
                    double tinggi = double.Parse(Console.ReadLine() ?? "0");
                    double volume = panjang * lebar * tinggi;
                    Console.WriteLine("Volume balok adalah: " + volume);
                    break;
                }

            default: Console.WriteLine("Pilihan tidak valid"); break;
        }
    }

    ////Percabangan2- Buatlah program C# untuk menghitung Indeks Massa Tubuh (IMT/BMI) menggunakan
    //percabangan (if–else) agar bisa menentukan kategori berat badan seperti kurus, normal,
    //gemuk, atau obesitas.
    public static void Operator_Percabangan2()
    {
        Console.WriteLine("====== Program Menghitung Indeks Massa Tubuh (IMT/BMI) ======\n");
        Console.Write("Masukkan Berat Badan (kg) : ");
        double beratBadan = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Masukkan Tinggi Badan (m) : ");
        double tinggiBadan = double.Parse(Console.ReadLine() ?? "0");
        double imt = beratBadan / (tinggiBadan * tinggiBadan);
        string kategori = "";
        if (imt < 18.5)
        {
            kategori = "Kurus";
        }
        else if (imt >= 18.5 && imt <= 24.9)
        {
            kategori = "Normal";
        }
        else if (imt >= 25 && imt <= 29.9)
        {
            kategori = "Gemuk";
        }
        else
        {
            kategori = "Obesitas";
        }
        Console.WriteLine("Indeks Massa Tubuh (IMT/BMI) Anda adalah " + imt + " dan Anda termasuk dalam kategori " + kategori);
    }
}