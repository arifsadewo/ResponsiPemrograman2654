using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2654
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan(19112599, "Istu", 2000000);
            Karyawan karyawan2 = new Karyawan(191125600, "Arif", 3000000);


            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.DataKaryawan();
            karyawan2.DataKaryawan();

            Console.WriteLine("\n\n Asikkk naik gaji!!!");

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.UpGaji();
            karyawan2.UpGaji();

            Console.ReadKey();
        }
    }
}
