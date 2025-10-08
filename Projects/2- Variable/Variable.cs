namespace Variable;

public class Variabel
{
    //Praktik2.1- Variabel bilangan bulat dan teks
    public static void Praktik1()
    {
        int umur = 16;
        string nama = "Budi";

        Console.WriteLine("Nama: " + nama);
        Console.WriteLine("Umur: " + umur);
    }

    //Praktik2.2- Variabel desimal dan karakter
    public static void Praktik2()
    {
        double tinggi = 170.5;
        char jenisKelamin = 'L';

        Console.WriteLine("Tinggi badan: " + tinggi + "cm");
        Console.WriteLine("Jenis Kelamin: " + jenisKelamin);
    }

    //Praktik2.3- Variabel logika (boolean)
    public static void Praktik3()
    {
        bool isPelajar = true;
        string sekolah = "SMK Negeri 1 Kandeman";

        Console.WriteLine("Apakah masih pelajar? " + isPelajar);
        Console.WriteLine("Sekolah: " + sekolah);
    }

    //Praktik2.4- Variabel dengan tipe data yang bervariasi
    public static void Praktik4()
    {
        int age = 17;
        double nilai = 85.5;
        char grade = 'A';
        string name = "Budi";
        bool isLulus = true;

        Console.WriteLine("Nama Siswa  : " + name);
        Console.WriteLine("Umur        : " + age);
        Console.WriteLine("Nilai       : " + nilai);
        Console.WriteLine("Grade       : " + grade);
        Console.WriteLine("Status Lulus: " + isLulus);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}