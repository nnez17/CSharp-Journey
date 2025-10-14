namespace Array;

public class Array
{
    //Praktik6.1 Praktik Array - Membuat dan menampilkan data array dengan tipe data string
    public static void Praktik1()
    {
        string[] siswa = new string[5];
        siswa[0] = "Budi";
        siswa[1] = "Andi";
        siswa[2] = "Citra";
        siswa[3] = "Dewi";
        siswa[4] = "Eka";

        Console.WriteLine("Daftar Nama Siswa: ");
        Console.WriteLine("Siswa ke-1: " + siswa[0] + "\nSiswa ke-2: " + siswa[1] + "\nSiswa ke-3: " + siswa[2] + "\nSiswa ke-4: " + siswa[3] + "\nSiswa ke-5: " + siswa[4]);

    }

    //Praktik6.2 Membuat dan menampilkan data array dengan tipe data integer
    public static void Praktik2()
    {
        int[] angka = new int[5];
        Console.Write("Masukkan nilai ke-1: "); angka[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan nilai ke-2: "); angka[1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan nilai ke-3: "); angka[2] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan nilai ke-4: "); angka[3] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan nilai ke-5: "); angka[4] = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nData yang Anda masukkan: ");
        Console.WriteLine("Nilai ke-1: " + angka[0] + "\nNilai ke-2: " + angka[1] + "\nNilai ke-3: " + angka[2] + "\nNilai ke-4: " + angka[3] + "\nNilai ke-5: " + angka[4]);
    }

    //Praktik6.3 Membuat dan menampilkan data array dengan tipe data integer dan string
    public static void Praktik3()
    {
        int[] nilai = new int[3];
        string[] nama = new string[3];

        Console.Write("Masukkan nama siswa ke-1: "); nama[0] = Console.ReadLine() ?? string.Empty;
        Console.Write("Masukkan nilai siswa ke-1: "); nilai[0] = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Masukkan nama siswa ke-2: "); nama[1] = Console.ReadLine() ?? string.Empty;
        Console.Write("Masukkan nilai siswa ke-2: "); nilai[1] = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Masukkan nama siswa ke-3: "); nama[2] = Console.ReadLine() ?? string.Empty;
        Console.Write("Masukkan nilai siswa ke-3: "); nilai[2] = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("\n=== Data Siswa ===");
        Console.WriteLine("Nama: " + nama[0] + " | Nilai: " + nilai[0] + "\nNama: " + nama[1] + " | Nilai: " + nilai[1] + "\nNama: " + nama[2] + " | Nilai: " + nilai[2]);
    }

    //Tugas6.1 Buatlah sebuah array untuk menampilkan tiga buah elemen yang berisi :
    //nama siswa, jenis kelamin dan kelas.
    //Nama siswa → bertipe string
    //Jenis kelamin (L/P) → bertipe char
    //Kelas → bertipe string
    public static void Tugas1()
    {
        string[] nama = new string[3];
        char[] jk = new char[3];
        string[] kelas = new string[3];

        Console.Write("Masukkan nama siswa ke-1: "); nama[0] = Console.ReadLine() ?? string.Empty;
        Console.Write("Masukkan jenis kelamin (L/P): "); jk[0] = char.Parse(Console.ReadLine() ?? "0");
        Console.Write("Masukkan kelas: "); kelas[0] = Console.ReadLine() ?? string.Empty;

        Console.Write("Masukkan nama siswa ke-2: "); nama[1] = Console.ReadLine() ?? string.Empty;
        Console.Write("Masukkan jenis kelamin (L/P): "); jk[1] = char.Parse(Console.ReadLine() ?? "0");
        Console.Write("Masukkan kelas: "); kelas[1] = Console.ReadLine() ?? string.Empty;

        Console.Write("Masukkan nama siswa ke-3: "); nama[2] = Console.ReadLine() ?? string.Empty;
        Console.Write("Masukkan jenis kelamin (L/P): "); jk[2] = char.Parse(Console.ReadLine() ?? "0");
        Console.Write("Masukkan kelas: "); kelas[2] = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("\n=== Data Siswa ===");
        Console.WriteLine($"Nama: {nama[0]} | Jenis Kelamin: {jk[0]} | Kelas: {kelas[0]}");
        Console.WriteLine($"Nama: {nama[1]} | Jenis Kelamin: {jk[1]} | Kelas: {kelas[1]}");
        Console.WriteLine($"Nama: {nama[2]} | Jenis Kelamin: {jk[2]} | Kelas: {kelas[2]}");

    }
}