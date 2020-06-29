using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TugasLab9.ClassInduk;

namespace TugasLab9.ClassAnak
{
    public class KaryawanDaily : Karyawan
    {
        public double UpahPerJam;
        public double JumlahJamKerja;
        public override double Gaji()
        {
            return JumlahJamKerja * UpahPerJam;
        }
    }
}
