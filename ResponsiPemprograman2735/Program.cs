using System;

namespace ResponsiPemprograman2735
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t");
            Karyawan karyawan1 = new Karyawan(1 , 1901, "Dinda", 3000000);
            Karyawan karyawan2 = new Karyawan(2 , 1905, "Naima", 2000000);

            Console.WriteLine("\t");
            Console.WriteLine(" No  Nik/Nama\t\t  Gaji Bulanan\t ");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(" {0}  {1} {2} \t\t  {3}\t ", karyawan1.No, karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine(" {0}  {1} {2} \t\t  {3}\t ", karyawan2.No, karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.WriteLine("\n\nAsiiiiiik kenaikan gaji 10%!!\n");

            Console.WriteLine("\t");
            Console.WriteLine(" No  Nik/Nama\t\t  Gaji Bulanan\t ");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(" {0}  {1} {2} \t\t  {3}\t ", karyawan1.No, karyawan1.Nik, karyawan1.Nama, karyawan1.NaikGaji);
            Console.WriteLine(" {0}  {1} {2} \t\t  {3}\t ", karyawan2.No, karyawan2.Nik, karyawan2.Nama, karyawan2.NaikGaji);


            Console.ReadKey();
        }
    }

}