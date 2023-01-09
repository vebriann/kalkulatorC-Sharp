using System;
using System.Diagnostics.SymbolStore;

// Anggota Kelompok
// 1. M. Tegar Wahyu H. ( 22 )
// 2. Vebrian Nikola S. ( 30 )


class Kalkultor_UAS_22_30
{
    static void Main()
    {
        double angka1_22_30, angka2_22_30;
        string operator_22_30, pilihan_22_30;
        double hasil_22_30;
        string input;
        bool? kalkulator_22_30 = false;
        bool? Cobadoang = false;
        
        
        Console.Clear();
        Console.WriteLine("Membuat Kalkulator Sederhana");
        Console.WriteLine("");
        do
        {

            Console.Write("Masukkan Angka Pertama = ");
            angka1_22_30 = double.Parse(Console.ReadLine());

            Console.Write("Masukkan Operator = ");
            operator_22_30 = Console.ReadLine();

            Console.Write("Masukkan Angka Kedua = ");
            angka2_22_30 = double.Parse(Console.ReadLine());


            if (operator_22_30 == "+")
            {
                hasil_22_30 = angka1_22_30 + angka2_22_30;
                Console.WriteLine($"Hasil dari {angka1_22_30} {operator_22_30} {angka2_22_30} = {hasil_22_30}");
            }
            else if (operator_22_30 == "-")
            {
                hasil_22_30 = angka1_22_30 - angka2_22_30;
                Console.WriteLine($"Hasil dari {angka1_22_30} {operator_22_30} {angka2_22_30} = {hasil_22_30}");
            }
            else if (operator_22_30 == "*")
            {
                hasil_22_30 = angka1_22_30 * angka2_22_30;
                Console.WriteLine($"Hasil dari {angka1_22_30} {operator_22_30} {angka2_22_30} = {hasil_22_30}");
            }
            else if (operator_22_30 == "/")
            {
                hasil_22_30 = angka1_22_30 / angka2_22_30;
                Console.WriteLine($"Hasil dari {angka1_22_30} {operator_22_30} {angka2_22_30} = {hasil_22_30}");
            }
            else if (operator_22_30 == "%")
            {
                hasil_22_30 = angka1_22_30 % angka2_22_30;
                Console.WriteLine($"Hasil dari {angka1_22_30} {operator_22_30} {angka2_22_30} = {hasil_22_30}");
            }
            else if (operator_22_30 == "^")
            {
                hasil_22_30 = Math.Pow(angka1_22_30, angka2_22_30);
                Console.WriteLine($"Hasil dari {angka1_22_30} {operator_22_30} {angka2_22_30} = {hasil_22_30}");
            }
            else
            {
                Console.WriteLine($"Tidak Ada Operator {operator_22_30}");
            }
            
            Console.WriteLine();
            Console.Write("Apakah anda akan menghitung kembali ? jika yes (Y,y), jika no (N,n) = ");
            pilihan_22_30 = Console.ReadLine().ToLower();
            Console.WriteLine("");
            if (pilihan_22_30 == "y")
            {
                kalkulator_22_30 = true;
            }
            else if (pilihan_22_30 == "n")
            {
                Console.WriteLine("Anda sudah keluar program");
                kalkulator_22_30 = false;

            }
            else
            {
                do
                {
                    Cobadoang = false;
                    Console.WriteLine("Maaf Tidak Ada Pilihan! ");
                    Console.WriteLine("Mau Coba Lagi? y/n: ");
                    input = Console.ReadLine();
                    if (input == "y")
                    {
                        kalkulator_22_30 = true;
                        Console.Clear();
                    }
                    else if (input == "n")
                    {
                        Console.WriteLine("Anda sudah keluar program");
                        kalkulator_22_30  = false;
                    }
                    else
                    {
                        Cobadoang = true;
                    }
                }
                while (Cobadoang == true);
            }
        }
        while (kalkulator_22_30 == true);
            
            
        

         
    }
}