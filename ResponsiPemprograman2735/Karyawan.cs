using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemprograman2735
{
    class Karyawan
    {
        public int No { get; set; }
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public int NaikGaji { get; set; }

        public Karyawan(int no, int nik, string nama, int gajibulanan)
        {
            this.No = no;
            this.Nik = nik;
            this.Nama = nama;

            if (gajibulanan < 0)
            {
                GajiBulanan = 0;
                NaikGaji = Convert.ToInt32((GajiBulanan * 0.1 + GajiBulanan));
            }
            else
            {
                this.GajiBulanan = gajibulanan;
                NaikGaji = Convert.ToInt32((GajiBulanan * 0.1 + GajiBulanan));
            }
        }
    }
}
