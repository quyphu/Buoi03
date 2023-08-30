using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Buoi_3
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            sv.NhapTuPhimSinhVien();
            sv.XuatMH();
            Console.ReadKey();
        }
    }
}
