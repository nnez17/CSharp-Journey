using System.Data.SqlTypes;

namespace Looping;

public class Perulangan
{
    //Praktik 5.1 Perulangan for -Perulangan untuk menampilkan angka 1 sampai 10
    public static void Praktik1()
    {
        Console.WriteLine("Perulangan untuk menampilkan angka 1-10");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Angka ke-" + i);
        }

        Console.WriteLine("\nPerulangan selesai.");
    }

    //Praktik 5.2 Menghitung Jumlah Angka (Penjumlahan)
    public static void Praktik2()
    {
        int total = 0;

        Console.WriteLine("Menghitung Jumlah Angka dari 1 sampai 5");

        for (int i = 1; i <= 5; i++)
        {
            total += i;

            Console.WriteLine("Menambahkan " + i + ", total sementara = " + total);
        }

        Console.WriteLine("\nHasil akhir penjumlahan adalah = " + total);
    }

    //Praktik 5.3 Perulangan while
    //Meminta Input Pengguna Hingga Kondisi Terpenuhi
    //Ini adalah contoh yang sangat umum di dunia nyata. Program akan terus meminta
    //input dari pengguna sampai pengguna mengetikkan kata "keluar". Jumlah iterasi di
    //sini sepenuhnya bergantung pada pengguna.
    public static void Praktik3()
    {
        string inputuser = "";

        Console.WriteLine("Program akan terus berjalan hingga Anda mengetik 'keluar'.");

        while (inputuser.ToLower() != "keluar")
        {
            Console.Write("\nKetik sesuatu (atau 'keluar' untuk berhenti): ");
            inputuser = Console.ReadLine() ?? "";

            Console.WriteLine("\nAnda mengetik: " + inputuser);
        }

        Console.WriteLine("\nProgram selesai. Terima kasih!");
    }

    //Praktik 5.4 Menghitung mundur dari 5 sampai 1 dan mencetak setiap angka, lalu mencetak pesan di akhir.
    public static void Praktik4()
    {
        int hitungan = 5;

        Console.WriteLine("Memulai hitungan mundur");

        while (hitungan > 0)
        {
            Console.WriteLine($"Hitungan: {hitungan}");

            hitungan = hitungan - 1;
        }
        Console.WriteLine("Selesai! Hitungan mundur telah berakhir.");
    }

    //Praktik 5.5 Perulangan do while - Menampilkan angka dari 1 sampai dengan 20
    public static void Praktik5()
    {
        int angka = 1;

        Console.WriteLine("Menampilkan angka dari 1 sampai dengan 20");

        do
        {
            Console.WriteLine($"Angka ke-{angka}");
            angka++;
        } while (angka <= 20);

        Console.WriteLine("Selesai.");
    }

    //Praktik 5.6 Aplikasi ini akan meminta pengguna memasukkan angka genap. Perulangan akan terus berjalan jika inputnya ganjil.
    public static void Praktik6()
    {
        int angka;

        do
        {
            Console.Write("Masukkan angka genap: ");
            if (!int.TryParse(Console.ReadLine(), out angka))
            {
                Console.WriteLine("Input tidak valid. Masukkan angka genap.");
                angka = 1;
                continue;
            }
            if (angka % 2 != 0)
            {
                Console.WriteLine($"Angka {angka} adalah ganjil. Coba lagi.");
            }
        } while (angka % 2 != 0);
        Console.WriteLine($"Selamat! Anda memasukkan angka genap: {angka}.");
    }

    //Praktik 5.7 Menu Pilihan Sederhana
    //Aplikasi ini menampilkan menu pilihan dan meminta input hingga pengguna memilih
    //opsi "Keluar" (nomor 3).
    public static void Praktik7()
    {
        int pilihan;

        do
        {
            Console.WriteLine("\n=== Menu Aplikasi ===");
            Console.WriteLine("1. Lihat Data");
            Console.WriteLine("2. Tambah Data");
            Console.WriteLine("3. Keluar");
            Console.Write("Masukkan pilihan Anda (1-3): ");

            if (!int.TryParse(Console.ReadLine(), out pilihan))
            {
                Console.WriteLine("Pilihan tidak valid. Harap masukkan angka 1, 2, atau 3.");
                pilihan = 0;
                continue;
            }

            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("Anda memilih: Lihat Data.");
                    break;
                case 2:
                    Console.WriteLine("Anda memilih: Tambah Data.");
                    break;
                case 3:
                    Console.WriteLine("Program akan berhenti...");
                    break;
                default:
                    Console.WriteLine("Pilihan di luar jangkauan. Harap masukkan 1, 2, atau 3.");
                    break;
            }

        } while (pilihan != 3);
        Console.WriteLine("Terima kasih telah menggunakan aplikasi.");
    }

    //Praktik 5.8 Program akan meminta nama pengguna dan kemudian bertanya apakah akan mengulang.
    public static void Praktik8()
    {
        string ulangPilihan;

        do
        {
            Console.WriteLine("--------------------");
            Console.Write("Masukkan nama Anda: ");
            string nama = Console.ReadLine() ?? "";
            Console.WriteLine($"Halo, {nama}! Proses telah selesai.");

            Console.WriteLine
            ("\nApakah Anda ingin mengulang program? (y/n)");
            ulangPilihan = Console.ReadLine() ?? "";
        } while (ulangPilihan.ToLower() == "y");
        {
            Console.WriteLine("Terima kasih telah menggunakan program ini.");
        }
    }

    //Latihan 5.1 - Buat program menggunakan for untuk menampilkan perkalian 5 (tabel 5).
    //Output yang diharapkan:
    //5 x 1 = 5
    //5 x 2 = 10
    //...
    //5 x 10 = 50
    public static void Latihan1()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"5 x {i} = {5 * i}");
        }
    }

    //Latihan 5.2 - Buat program menggunakan while untuk menampilkan jumlah total dari bilangan 1 sampai 5.
    //Output yang diharapkan:
    //Total = 15
    public static void Latihan2()
    {
        int total = 0;
        int i = 1;

        while (i <= 5)
        {
            total += i;
            i++;
        }

        Console.WriteLine($"Total = {total}");
    }
}