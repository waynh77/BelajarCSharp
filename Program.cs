Console.WriteLine("Hello, World!");
// This is a simple C# console application that prints "Hello, World!" to the console and waits for the user to press Enter before closing.
/*
Ini komentar
lebih dari satu baris
*/
string NamaPanjang = "Hidayat";
string nama = $"Andi {NamaPanjang}";

int umur = 20;

//double tinggi = 170.5;

//bool aktif = true;

//Console.WriteLine("Nama: " + nama);
//Console.WriteLine("Umur: " + umur);
//Console.WriteLine("Tinggi: " + tinggi);
//Console.WriteLine("Aktif: " + aktif);

//Console.WriteLine($"Nama: {nama}");
//Console.WriteLine($"Umur: {umur}");
//Console.WriteLine($"Tinggi: {tinggi}");
//Console.WriteLine($"Aktif: {aktif}");

//Console.WriteLine();
Console.WriteLine("===== BIODATA INPUT =====");
Console.Write("Nama: ");
nama = Console.ReadLine();

//bool validUmur = false;
//do
//{
//    try
//    {
//        //validasi umur harus angka dan tidak boleh negatif
//        Console.Write("Umur: ");
//        umur =
//            Convert.ToInt32(
//                Console.ReadLine()
//            );
//        if (umur < 0)
//        {
//            Console.WriteLine(
//                "Umur tidak boleh negatif"
//            );
//        }
//        else
//        {
//            validUmur = true;
//        }
//    }
//    catch
//    {
//        Console.WriteLine(
//            "Input harus angka"
//        );
//    }
//} while (umur < 0 || validUmur == false);

while (true)
{
    try
    {
        Console.Write("Umur: ");

        umur =
            Convert.ToInt32(
                Console.ReadLine()
            );

        if (umur < 0)
        {
            Console.WriteLine(
                "Umur tidak valid"
            );

            continue;
        }

        break;
    }
    catch
    {
        Console.WriteLine(
            "Input harus angka"
        );
    }
}

Console.WriteLine(
    $"Umur anda {umur}"
);

Console.Write("Kota: ");
string kota = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("===== BIODATA OUTPUT =====");

Console.WriteLine($"Nama : {nama}");
Console.WriteLine($"Umur : {umur}");
Console.WriteLine($"Kota : {kota}");

//Console.WriteLine();
//Console.WriteLine("------------------------------------");
//Console.Write("Nama barang: ");
//string namaBarang =
//    Console.ReadLine();

//Console.Write("Harga: ");
//int harga =
//    Convert.ToInt32(
//        Console.ReadLine()
//    );

//Console.Write("Jumlah: ");
//int jumlah =
//    Convert.ToInt32(
//        Console.ReadLine()
//    );

//int total = harga * jumlah;

//Console.WriteLine();
//Console.WriteLine("===== STRUK =====");

//Console.WriteLine(
//    $"Barang : {namaBarang}"
//);

//Console.WriteLine(
//    $"Harga : {harga}"
//);

//Console.WriteLine(
//    $"Jumlah : {jumlah}"
//);

//Console.WriteLine(
//    $"Total : {total}"
//);


//Console.WriteLine("1. Login");
//Console.WriteLine("2. Register");

//Console.Write("Pilih menu: ");

//string pilih =
//    Console.ReadLine();

//switch (pilih)
//{
//    case "1":
//        Console.WriteLine("Menu Login");
//        break;

//    case "2":
//        Console.WriteLine("Menu Register");
//        break;

//    default:
//        Console.WriteLine(
//            "Menu tidak tersedia"
//        );
//        break;
//}
Console.ReadLine();
