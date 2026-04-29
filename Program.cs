
Start: // Pilihan Untuk Kembali ke Menu
Console.Clear();
Console.WriteLine("Pilih untuk menghitung ");
Console.WriteLine("1. Pembagian Biasa");
Console.WriteLine("2. Pembagian Sisa Bagi");
Console.WriteLine("3. Perkalian ");
Console.WriteLine("4. Penjumlahan ");
Console.WriteLine("5. Pengurangan ");

Console.WriteLine("Pilih Salah Satu Untuk Menghitung : ");
int Pilihan = Convert.ToInt32(Console.ReadLine());


switch (Pilihan)
{
    case 1:
        Console.WriteLine("Masukkan Angka Pertama : ");
        int angka1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Masukkan Angka Kedua : ");
        int angka2 = Convert.ToInt32(Console.ReadLine());
        int hasilPembagian = angka1 / angka2;
        Console.WriteLine("Hasil Pembagian Biasa : " + hasilPembagian);
        break;

    case 2:
        Console.WriteLine("Masukkan Angka Pertama : ");
        int angka3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Masukkan Angka Kedua : ");
        int angka4 = Convert.ToInt32(Console.ReadLine());
        int hasilSisaBagi = angka3 % angka4; 
        int hasilpembagian2 = angka3 / angka4;
        Console.WriteLine(" Dan Hasil Pembagian Biasa : " + hasilpembagian2 + " Hasil Pembagian Sisa Bagi : " + hasilSisaBagi);
        break;

    case 3:
        Console.WriteLine("Masukkan Angka Pertama : ");
        int angka5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Masukkan Angka Kedua : ");
        int angka6 = Convert.ToInt32(Console.ReadLine());
        int hasilPerkalian = angka5 * angka6;
        Console.WriteLine("Hasil Perkalian : " + hasilPerkalian);
        break;

    case 4:
        Console.WriteLine("Masukkan Angka Pertama : ");
        int angka7 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Masukkan Angka Kedua : ");
        int angka8 = Convert.ToInt32(Console.ReadLine());
        int hasilPenjumlahan = angka7 + angka8;
        Console.WriteLine("Hasil Penjumlahan : " + hasilPenjumlahan);
        break;

    case 5:
        Console.WriteLine("Masukkan Angka Pertama : ");
        int angka9 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Masukkan Angka Kedua : ");
        int angka10 = Convert.ToInt32(Console.ReadLine());
        int hasilPengurangan = angka9 - angka10;
        Console.WriteLine("Hasil Pengurangan : " + hasilPengurangan);
        break;

    default:
        Console.WriteLine("Pilihan tidak valid.");
        break;
}
{
    Console.WriteLine("Apakah Anda Ingin Menghitung Lagi ? (Y/N) : ");
    string? pilihanLagi = Console.ReadLine();
    if (pilihanLagi != null && pilihanLagi.Equals("Y", StringComparison.OrdinalIgnoreCase))
    {
        Console.Clear();
        // Panggil kembali menu utama atau fungsi yang sesuai untuk memulai ulang proses
        goto Start;
    }
    else
    {
        Console.WriteLine("Terima kasih telah menggunakan program ini!");
        // Keluar dari program atau lakukan tindakan lain sesuai kebutuhan
    }
}