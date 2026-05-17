Console.WriteLine("Hello, World!");
// This is a simple C# console application that prints "Hello, World!" to the console and waits for the user to press Enter before closing.
/*
Ini komentar
lebih dari satu baris
*/
string NamaPanjang = "Hidayat";
string nama = $"Andi {NamaPanjang}";

int umur = 20;

double tinggi = 170.5;

bool aktif = true;

Console.WriteLine("Nama: " + nama);
Console.WriteLine("Umur: " + umur);
Console.WriteLine("Tinggi: " + tinggi);
Console.WriteLine("Aktif: " + aktif);

Console.WriteLine($"Nama: {nama}");
Console.WriteLine($"Umur: {umur}");
Console.WriteLine($"Tinggi: {tinggi}");
Console.WriteLine($"Aktif: {aktif}");

Console.WriteLine();
Console.WriteLine("===== BIODATA INPUT =====");
Console.Write("Nama: ");
nama = Console.ReadLine();
bool validUmur = false;
do
{
    try
    {
        //validasi umur harus angka dan tidak boleh negatif
        Console.Write("Umur: ");
        umur =
            Convert.ToInt32(
                Console.ReadLine()
            );
        if (umur < 0)
        {
            Console.WriteLine(
                "Umur tidak boleh negatif"
            );
        }
        else
        {
            validUmur = true;
        }
    }
    catch
    {
        Console.WriteLine(
            "Input harus angka"
        );
    }
} while (umur < 0 || validUmur == false);

Console.Write("Kota: ");
string kota = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("===== BIODATA OUTPUT =====");

Console.WriteLine($"Nama : {nama}");
Console.WriteLine($"Umur : {umur}");
Console.WriteLine($"Kota : {kota}");

Console.ReadLine();
