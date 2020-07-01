using System;
using System.Collections.Generic;
using System.Text;
using TugasUntung;

namespace tugas
{
    public class KaryawanTetap : Karyawan
    {

        public double GajiBulanan;
        public override double Gaji()
        {
            return this.GajiBulanan;
        }
    }
}