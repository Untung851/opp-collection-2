using System;
using System.Collections.Generic;
using System.Text;
using TugasUntung;

namespace tugas
{
    public class KaryawanHarian : Karyawan
    {
        public double UpahPerJam;
        public double JumlahJamKerja;
        public override double Gaji()
        {
            return this.UpahPerJam * this.JumlahJamKerja;
        }
    }
}