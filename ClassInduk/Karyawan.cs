﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLab9.ClassInduk
{
    public abstract class Karyawan
    {
        public string NIK;
        public string Nama;
        public string Jenis;
        public abstract double Gaji();
    }
}
