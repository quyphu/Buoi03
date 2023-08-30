using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_Buoi_3
{
    class SinhVien
    {
        private int masinhvien;

        public int Masinhvien
        {
            get { return masinhvien; }
            set
            {
                if (value > 0)
                    masinhvien = value;
                else Console.WriteLine("Mã Sinh Phải Lớn Hơn 0");
            }
        }
        private string hoten;

        public string Hoten
        {
            get { return hoten; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    hoten = value;
                else
                    Console.WriteLine("Họ tên không được rỗng.");
            }
        }
        private double diemLT;

        public double DiemLT
        {
            get { return diemLT; }
            set
            {
                if (value >= 0.0 && value <= 10.0)
                    diemLT = value;
                else
                    Console.WriteLine("Điểm LT phải thuộc khoảng từ 0.0 đến 10.0");
            }
        }
        private double diemTH;

        public double DiemTH
        {
            get { return diemTH; }
            set
            {
                if (value >= 0.0 && value <= 10.0)
                    diemTH = value;
                else
                    Console.WriteLine("Điểm TH phải thuộc khoảng từ 0.0 đến 10.0");
            }
        }


        public SinhVien(int masinhvien, string hoten, double diemLT, double diemTH )
        {
            this.masinhvien = masinhvien;
            this.hoten = hoten;
            this.diemLT = diemLT;
            this.diemTH = diemTH;
        }

        public SinhVien()
        {
            masinhvien = 2033210170;
            hoten = "Nguyen Ngoc Phu Quy";
            diemTH = 10;
            diemLT = 10;
        }

        public double TinhDiemTB()
        {
            return (diemLT + diemTH) / 2;
        }

        public void NhapTuPhimSinhVien()
        {
            Console.WriteLine("Nhap Ma So SV:\n");
            masinhvien = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Ho Ten:\n");
            hoten = Console.ReadLine();
            Console.WriteLine ("Nhap Diem TH\n");
            diemTH = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Diem LH\n");
            diemLT = double.Parse(Console.ReadLine());
        }


        public void XuatMH()
        {
            Console.WriteLine("Ma SV: {0} \t Ten SV: {1} \t Diem LT: {2} \t Diem TH: {3} \t Diem TB: {4} \n", masinhvien, hoten, diemLT, diemTH, TinhDiemTB());
        }
    }
    }
}
