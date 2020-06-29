using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TugasLab9.ClassInduk;

namespace TugasLab9.ClassAnak
{
    public class KaryawanReg : Karyawan
    {
        public double GajiBulanan;
        public override double Gaji()
        {
            return GajiBulanan;
        }
    }
}