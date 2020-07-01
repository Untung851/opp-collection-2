using System;
using System.Collections.Generic;
using System.Text;
using TugasUntung;

namespace tugas
{
    public class Sales : Karyawan
    {
        public double JumlahPenjualan;
        public double Komisi;
        public override double Gaji()
        {
            return this.JumlahPenjualan * this.Komisi;
        }
    }
}