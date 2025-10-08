namespace HelloWorld;

public class HelloWorld
{
    //Praktik 1.1 – menuliskan kode pertama kali di editor visual studio.
    public static void Praktik1()
    {
        Console.WriteLine("Hallo Dunia");
        Console.WriteLine("Nama Saya Noval Akbar");
        Console.WriteLine("Saya belajar bahasa pemrograman C#");
    }

    //Praktik1.2- Fungsi Output pada C# menggunakan fungsi WriteLine()
    public static void Praktik2()
    {
        Console.WriteLine("Selamat Datang di Pemrograman C#");
        Console.WriteLine("Ini adalah tutorial belajar C# dari dasar");
        Console.WriteLine("Terima kasih sudah menggunakan program ini");
    }

    //Praktik1.3- Perbedaan WriteLine() dengan Write()
    public static void Praktik3()
    {
        Console.WriteLine("=== BIODATA SAYA ===");
        Console.Write("Nama: ");
        Console.Write("Noval");
        Console.WriteLine();
        Console.WriteLine("Alamat: Limpung");
        Console.WriteLine("-----------");

        Console.WriteLine("=== BIODATA SAYA ===");
        Console.Write("Nama: ");
        Console.Write("Noval");
        //Console.WriteLine();
        Console.WriteLine("Alamat: Limpung");

        Console.WriteLine(
            """
            Penjelasan: Perbedaan utama fungsi WriteLine dan Write adalah
                        bahwa WriteLine akan menambahkan baris baru setelah
                        menulis teks, sedangkan Write tidak
            """);
    }

    //Praktik1.4- Fungsi Input pada C#
    public static void Praktik4()
    {
        Console.WriteLine("=== PROGRAM INPUT NAMA ===");
        Console.Write("Tuliskan nama kamu: ");
        string nama = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Hi, {0} selamat datang!", nama);
    }

    //Praktik1.5- penggunaan input dan output C#
    public static void Praktik5()
    {
        Console.WriteLine("=== INPUT BIODATA SISWA ===");
        Console.Write("NAMA SISWA    : ");
        string nama = Console.ReadLine() ?? string.Empty;
        Console.Write("KELAS         : ");
        string kelas = Console.ReadLine() ?? string.Empty;
        Console.Write("JENIS KELAMIN : ");
        string jk = Console.ReadLine() ?? string.Empty;
        Console.Write("JURUSAN       : ");
        string jur = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("=======================");
        Console.WriteLine("=== BIODATA SISWA ===");
        Console.WriteLine($"Nama Siswa    : {nama}");
        Console.WriteLine($"Kelas         : {kelas}");
        Console.WriteLine($"Jenis Kelamin : {jk}");
        Console.WriteLine($"Jurusan       : {jur}");
        Console.WriteLine("=======================");
    }

    //Tugas1.1- Buatlah kode program untuk menampilkan biodata kalian masing-masing
    public static void Tugas1()
    {
        Console.WriteLine("✦·┈๑⋅⋯ INPUT BIODATA SISWA ⋯⋅๑┈·✦");
        Console.Write("Nama Lengkap           : ");
        string nama = Console.ReadLine() ?? string.Empty;
        Console.Write("Nama Panggilan         : ");
        string nick = Console.ReadLine() ?? string.Empty;
        Console.Write("Jenis Kelamin (L/P)    : ");
        string jk = Console.ReadLine() ?? string.Empty;
        Console.Write("Agama                  : ");
        string ag = Console.ReadLine() ?? string.Empty;
        Console.Write("Umur                   : ");
        string ur = Console.ReadLine() ?? string.Empty;
        Console.Write("Kelas                  : ");
        string kl = Console.ReadLine() ?? string.Empty;
        Console.Write("Jurusan                : ");
        string jur = Console.ReadLine() ?? string.Empty;
        Console.Write("Alamat                 : ");
        string al = Console.ReadLine() ?? string.Empty;
        Console.Write("Hobi                   : ");
        string hb = Console.ReadLine() ?? string.Empty;
        Console.Write("Cita-Cita              : ");
        string ct = Console.ReadLine() ?? string.Empty;

        if (jk.ToLower() == "l") jk = "Laki-laki";
        else if (jk.ToLower() == "p") jk = "Perempuan";

        Console.WriteLine("       ૮₍´˶• . • ⑅ ₎ა");
        Console.WriteLine("✦·┈๑⋅⋯ BIODATA SISWA ⋯⋅๑┈·✦");
        Console.WriteLine($"Nama Siswa    : {nama}");
        Console.WriteLine($"Nama Panggilan: {nick}");
        Console.WriteLine($"Jenis Kelamin : {jk}");
        Console.WriteLine($"Agama         : {ag}");
        Console.WriteLine($"Umur          : {ur}");
        Console.WriteLine($"Kelas         : {kl}");
        Console.WriteLine($"Jurusan       : {jur}");
        Console.WriteLine($"Alamat        : {al}");
        Console.WriteLine($"Hobi          : {hb}");
        Console.WriteLine($"Cita-Cita     : {ct}");
        Console.WriteLine("✦·┈๑⋅⋯⋯⋅⋅⋯⋯⋅⋅⋯⋯⋅⋅⋯⋯⋅⋅⋅⋯๑┈·✦");
        Console.WriteLine("       ૮₍´˶• . • ⑅ ₎ა");

    }

}