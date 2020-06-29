using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TugasLab9.ClassInduk;

namespace TugasLab9.ClassAnak
{
    public class Sales : Karyawan
    {
        public double JumlahPenjualan;
        public double Komisi;
        public override double Gaji()
        {
            return JumlahPenjualan * Komisi;
        }
    }
}
