using System;
using System.Collections.Generic;

namespace ManajemenLaundry
{
    class Program
    {
        static void Main(string[] args)
        {
  
            List<string> macampaket = new List<string>();
            macampaket.Add("A");
            macampaket.Add("B");
            macampaket.Add("C");
            
            List<double> paketharga = new List<double>();
            paketharga.Add(30000);
            paketharga.Add(25000);
            paketharga.Add(20000);

        

            Console.Clear();
            Console.WriteLine("\t\t\t============================\t\t\t");
            Console.WriteLine("\t\t\tSistem Manajemen QQ Loundry\t\t\t");
            Console.WriteLine("\t\t\tJalan Mandala Utara No 89\t\t\t");
            Console.WriteLine("\t\t\t============================\t\t\t");
            Console.WriteLine(" ");
            Console.WriteLine("1. Pembayaran Laundry ");
            Console.WriteLine("2. Input Data Laundry");
            Console.WriteLine("3. Keluar");
            Console.WriteLine(" ");
            Console.WriteLine("Pilih Menu :");

            int pilih = Convert.ToInt32(Console.ReadLine());

            switch (pilih)
            {
                case 1:
                    string name, paket;
                    int noHp, tanggal;
                    double beratbarang;

                    print();
 
                    Console.Write("Masukan Nama                               :  ");
                    name = Console.ReadLine();

                    try
                    {
                        Console.Write("Masukan No Hp                           :  ");
                        noHp = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Input masukan salah ! (int)");
                    
                    }

                    
                    Console.Write("Masukan tanggal masuk                 :  ");
                    tanggal = int.Parse(Console.ReadLine());
                   
                    Console.Write("Masukan Berat Loundry (Kg)            :  ");
                    beratbarang = double.Parse(Console.ReadLine());
                
                    
                    for (int i = 0; i < macampaket.Count; i++)
                    {
                        Console.WriteLine(macampaket[i] + paketharga[i]);
                    }

                    Console.Write("Masukan Paket (A/B/C)                      :  ");
                    paket = (Console.ReadLine());

                    switch (paket)
                    {
                        case "a":
                            Console.WriteLine("Total bayar adalah : " + bayarlast(beratbarang, paketharga[0]));
                            Console.WriteLine("Enter Untuk Kembali Ke Menu Utama");
                            break; 

                        case "b":
                            Console.WriteLine("Total bayar adalah : " + bayarlast(beratbarang, paketharga[1]));
                            Console.WriteLine("Enter Untuk Kembali Ke Menu Utama");
                            break;

                        case "c":
                            Console.WriteLine("Total bayar adalah : " + bayarlast(beratbarang, paketharga[2]));
                            Console.WriteLine("Enter Untuk Kembali Ke Menu Utama");
                            break; ;
                        default:
                            break; ;
                    }
                    break;
                   

                case 2:

                    string namec2, paketc2;
                    int noHpc2, tanggalc2;

                    Console.Clear();

                    Console.WriteLine("\t\t\t============================\t\t\t");
                    Console.WriteLine("\t\t\tSistem Manajemen QQ Loundry\t\t\t");
                    Console.WriteLine("\t\t\tJalan Mandala Utara No 89\t\t\t");
                    Console.WriteLine("\t\t\tSistem Input Pelanggan\t\t\t");
                    Console.WriteLine("\t\t\t============================\t\t\t");
                    Console.WriteLine(" ");
                    Console.Write("Masukan Nama                               :  ");
                    namec2 = Console.ReadLine();

                    Console.Write("Masukan No hp                              :  ");
                    noHpc2 = int.Parse(Console.ReadLine());

                    Console.Write("Masukan tanggal pesanan                    :  ");
                    tanggalc2 = int.Parse(Console.ReadLine());

                    Console.Write("Masukan Data Paket (A/B/C)                 :  ");
                    paketc2 = Console.ReadLine();
                    paketc2.ToLower();

                    if (paketc2  == "A" || paketc2 == "a")
                    {
                        Console.WriteLine("6 jam selesai - Rp. 30.000");
                    }
                    else if (paketc2 == "B" || paketc2 == "b")
                    {
                        Console.WriteLine("1 hari selesai - Rp. 25.000");
                    }
                    else if (paketc2 == "C" || paketc2 == "c")
                    {
                        Console.WriteLine("3 hari selesai - Rp. 20.000");
                    }


                    Console.WriteLine("\t\t\t========Data Input Laundry=========\t\t\t");
                    Console.WriteLine("\t\t\t===================================\t\t\t");
                    Console.WriteLine("\t\t\tNama                       :\t\t\t" + namec2);
                    Console.WriteLine("\t\t\tNo Hp                      :\t\t\t" + noHpc2);
                    Console.WriteLine("\t\t\tTanggal                    :\t\t\t" + tanggalc2);
                    Console.WriteLine("\t\t\tPaket                      :\t\t\t" + paketc2);
                    Console.WriteLine(" ");
                    Console.Read();

                   
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }

        }

            static double bayarlast(double beratbarang, double paketharga)
            {
            double bayarloundry = beratbarang * paketharga;
            return bayarloundry;
            }

            static void print()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t============================\t\t\t");
            Console.WriteLine("\t\t\tSistem Manajemen QQ Loundry\t\t\t");
            Console.WriteLine("\t\t\tJalan Mandala Utara No 89\t\t\t");
            Console.WriteLine("\t\t\tMasukan Data Laundry\t\t\t");
            Console.WriteLine("\t\t\t============================\t\t\t");
        }
            

    }

}
