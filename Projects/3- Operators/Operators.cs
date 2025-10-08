namespace Operators;

public class Operator
{
    //Praktik3.1- Operator Penjumlahan
    public static void Praktik1()
    {
        Console.WriteLine("Masukkan angka pertama : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Masukkan angka kedua : ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hasil penjumlahan : " + (a + b));

        Console.WriteLine("Masukkan angka ketiga : ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Masukkan angka keempat : ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Hasil penjumlahan (double): " + (c + d));
    }

    //Praktik3.2- Operator Pengurangan
    public static void Praktik2()
    {
        Console.WriteLine("Masukkan angka pertama : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Masukkan angka kedua : ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hasil pengurangan : " + (a - b));

        Console.WriteLine("Masukkan angka ketiga : ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Masukkan angka keempat : ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Hasil pengurangan (double): " + (c - d));
    }

    //Praktik3.3- Operator Perkalian
    public static void Praktik3()
    {
        Console.WriteLine("Masukkan angka pertama : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Masukkan angka kedua : ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hasil perkalian : " + (a * b));

        Console.WriteLine("Masukkan angka ketiga : ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Masukkan angka keempat : ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Hasil perkalian (double): " + (c * d));
    }

    //Praktik3.4- Operator Pembagian
    public static void Praktik4()
    {
        Console.WriteLine("Masukkan angka pertama : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Masukkan angka kedua : ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hasil pembagian : " + (a / b));

        Console.WriteLine("Masukkan angka ketiga : ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Masukkan angka keempat : ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Hasil pembagian (double): " + (c / d));
    }

    //Praktik3.5- Operator Sisabagi
    public static void Praktik5()
    {
        Console.WriteLine("Masukkan angka pertama : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Masukkan angka kedua : ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sisa bagi : " + (a % b));

        Console.WriteLine("Masukkan angka ketiga : ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Masukkan angka keempat : ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Sisa bagi : " + (c % d));
    }

    //Praktik3.6- Operator matematika penjumlahan beruntun
    public static void Praktik6()
    {
        Console.WriteLine("Masukkan angka : ");
        int x = Convert.ToInt32(Console.ReadLine());
        x++;
        Console.WriteLine("Setelah x++ : " + x);

        Console.WriteLine("Masukkan angka lain: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nilai awal : " + y);
        Console.WriteLine("Setelah ++y : " + (++y));
    }

    //Praktik3.7- Operator matematika pengurangan beruntun
    public static void Praktik7()
    {
        Console.WriteLine("Masukkan angka: ");
        int x = Convert.ToInt32(Console.ReadLine());
        x--;
        Console.WriteLine("Setelah x--: " + x);

        Console.WriteLine("Masukkan angka lain: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nilai awal: " + y);
        Console.WriteLine("Nilai --y: " + (--y));
    }

    //Praktik3.8- Operator Perbandingan
    public static void Praktik8()
    {
        Console.WriteLine("=== Program Operator Perbandingan ===");

        Console.Write("Masukkan angka pertama: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan angka kedua: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{a} > {b}   : " + (a > b));
        Console.WriteLine($"{a} < {b}   : " + (a < b));
        Console.WriteLine($"{a} >= {b}  : " + (a >= b));
        Console.WriteLine($"{a} <= {b}  : " + (a <= b));
        Console.WriteLine($"{a} == {b}  : " + (a == b));
        Console.WriteLine($"{a} != {b}  : " + (a != b));
    }

    //Praktik3.9- Operator Logika
    public static void Praktik9()
    {
        Console.WriteLine("=== Program Operator Logika ===");

        Console.Write("Masukkan angka pertama: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan angka kedua: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nHasil Logika:");

        //AND
        Console.WriteLine($"({a} > 5 && {b} <10) = " + (a > 5 && b < 10));

        //OR
        Console.WriteLine($"({a} > 5 || {b} <10) = " + (a > 5 || b < 10));

        //NOT
        Console.WriteLine($"!{a} > {b} = " + (!(a > b)));
    }

    //Praktik3.10- Operator Penugasan
    public static void Praktik10()
    {
        Console.WriteLine("=== Program Operasi Penugasan ===");
        Console.WriteLine("Masukkan nilai awal x : ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nHasil Operasi penugasan");
        Console.WriteLine("Nilai awal x = " + x);

        x += 5;
        Console.WriteLine("x += 5 → " + x);

        x -= 2;
        Console.WriteLine("x -= 2 → " + x);

        x *= 3;
        Console.WriteLine("x *= 3 → " + x);

        x /= 4;
        Console.WriteLine("x /= 4 → " + x);

        x %= 3;
        Console.WriteLine("x %= 3 → " + x);
    }

    //Tugas3.1- Buat program C# operator matematika : penjumlahan, pengurangan, perkalian, pembagian tiga buah bilangan.
    public static void Tugas1()
    {
        double a, b, c;
        string op1, op2;
        double hasil = 0;

        Console.WriteLine("     ╰☆૮꒰ ˶• ༝ •˶꒱ა ╮♡〰");
        Console.WriteLine("──── ୨ Operator Matematika ୧ ─────\n");

        Console.Write("Masukkan Angka Pertama = ");
        a = inputValue();

        Console.Write("Masukkan Operator (+, -, *, /, %) = ");
        op1 = Console.ReadLine() ?? "";

        Console.Write("Masukkan Angka Kedua = ");
        b = inputValue();

        Console.Write("Masukkan Operator (+, -, *, /, %) = ");
        op2 = Console.ReadLine() ?? "";

        Console.Write("Masukkan Angka Ketiga = ");
        c = inputValue();

        double temp = Hitung(a, b, op1);

        hasil = Hitung(temp, c, op2);

        Console.WriteLine("\nHasil = " + hasil);
    }

    static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Input salah! Masukkan angka: ");
        }
        return result;
    }

    static double Hitung(double x, double y, string op)
    {
        return op switch
        {
            "+" => x + y,
            "-" => x - y,
            "*" => x * y,
            "/" => y != 0 ? x / y : double.NaN,
            "%" => y != 0 ? x % y : double.NaN,
            _ => double.NaN
        };
    }

    //Tugas3.2- Buat program untuk memasukkan nilai siswa.
    public static void Tugas2()
    {
        Console.WriteLine("──── ୨ Tugas 3.2  Nilai Siswa ୧ ────\n");

        Console.Write("Siapa nama kamu? ");
        string name = Console.ReadLine() ?? string.Empty;
        Console.Write("Kamu kelas apa? ");
        string grade = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("\nMasukkan nilai kamu:");
        Console.Write("Matematika → ");
        double math = InputScore();
        Console.Write("Bahasa Indonesia → ");
        double indo = InputScore();
        Console.Write("Bahasa Inggris → ");
        double eng = InputScore();

        double total = math + indo + eng;
        double average = total / 3;

        Console.WriteLine(
            $"""
            
            ⌯⌲ Hasil nilai kamu:
            Nama Siswa              : {name}
            Kelas                   : {grade}
            ---
            Nilai Matematika        : {math}
            Nilai Bahasa Indonesia  : {indo}
            Nilai Bahasa Inggris    : {eng}
            Nilai rata-rata         : {average}
            Nilai total             : {total} / 300 ({total / 300 * 100}%)
            """);
    }
    private static double InputScore()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

    //Latihan1- 1. Buatlah program untuk mengubah / konversi suhu dari Celcius ke fahrenheit dan reamur.
    public static void Latihan1()
    {
        Console.WriteLine("╰┈➤  Latihan 1 - Konversi Suhu");
        Console.Write("Masukkan suhu dalam Celcius: ");
        double cel = double.Parse(Console.ReadLine() ?? "0");

        double fah = (cel * 9 / 5) + 32;
        double rem = cel * 4 / 5;
        double kel = cel + 273.15;

        Console.WriteLine(
            $"""

            ⁕ Hasil Konversi
            Celcius    : {cel} °C
            Fahrenheit : {fah} °F
            Reamur     : {rem} °Re
            Kelvin     : {kel} K
            """
        );
    }

    //Latihan2- Buatlah program untuk mengkonversi nilai tukar Rupiah ke mata uang :
    //Dolar Amerika (USD)
    //Poundsterling Inggris (GBP)
    //Yen Jepang (JPY)
    //Riyal Saudi (SAR)
    public static void Latihan2()
    {
        Console.WriteLine("╰┈➤  Latihan 2 - Konversi Mata Uang");

        Console.Write("Masukkan jumlah uang dalam rupiah (IDR): ");
        double idr = double.Parse(Console.ReadLine() ?? "0");

        double usd = idr / 16_635;
        double gbp = idr / 22_345.81;
        double jpy = idr / 111.93;
        double sar = idr / 4_435.44;

        Console.WriteLine(
            $"""
            ⁕ Hasil Konversi
            Rupiah (IDR) : Rp{idr:0.00}
            Dollar (USD) : ${usd:0.00}
            Pound (GBP)  : £{gbp:0.00}
            Yen (JPY)    : ¥{jpy:0.00}
            Riyal (SAR)  : ر.س {sar:0.00}
            """
        );
    }
}