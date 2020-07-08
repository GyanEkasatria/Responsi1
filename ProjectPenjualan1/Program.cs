using ProjectPenjualan;
using System;
using System.Collections.Generic;

namespace Praktikum
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Penjualan> listPenjualan = new List<Penjualan>();
            void tampil()
            {
                int Number = 1;
                foreach (Penjualan penjualan in listPenjualan)
                {
                    Console.WriteLine(" {0}. NOTA: {1}, TANGGAL: {2}, CUSTOMER: {3}, JENIS: {4}, TOTAL {5}", Number, penjualan.nota, penjualan.tgl, penjualan.customer, penjualan.jenis, penjualan.Total());
                    Number++;
                }
            }
            void Ncreate(string nota, string tgl, string customer, string jenis, double Total)
            {
                listPenjualan.Add(new DPenjualan { Nota = nota, Tanggal = tgl, Jenis = jenis, TNota = Total });
            }
            void delete_K()
            {
                int n = 1;
                int pjl = 0;
                foreach (Penjualan penjualan in listPenjualan)
                {
                    Console.WriteLine("{0}. Nik: {1}", n, penjualan.nota);
                    n++;
                    pjl += 1;
                }
                Console.WriteLine();
                Console.Write("Pilih Data Yang Ingin Dihapus [1-");
                Console.Write(pjl);
                Console.Write("] : ");
                int index_nota = int.Parse(Console.ReadLine());
                index_nota = index_nota - 1;

                listPenjualan.RemoveAt(index_nota);
                Console.WriteLine();
                Console.WriteLine("Data Berhasil Dihapus ");
                Console.WriteLine();
                Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
            }

            bool keluar = false;
            while (keluar == false)
            {
                Console.Clear();
                Console.WriteLine("\tPilih Menu : \n");
                Console.WriteLine("\t1. Tambah Data");
                Console.WriteLine("\t2. Hapus Data");
                Console.WriteLine("\t3. Tampilkan Data");
                Console.WriteLine("\t4. Exit");
                Console.WriteLine();
                Console.Write("Pilihan [1..4] = ");
                int pilih = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();

                if (pilih < 1 || pilih > 4)
                {
                    Console.WriteLine("Pilihan tidak tersedia");
                }

                else if (pilih == 1)
                {
                    Console.Write("\tNota = ");
                    string nota = Console.ReadLine();
                    Console.Write("\tTanggal = ");
                    string tgl = Console.ReadLine();
                    Console.Write("\tCustomer = ");
                    string customer = Console.ReadLine();
                    Console.Write("\tTotal = ");
                    double TNota = int.Parse(Console.ReadLine());
                    string Jenis = "";

                    Ncreate(nota, tgl, customer, Jenis, TNota);
                }

                else if (pilih == 2)
                {
                    delete_K();
                }
                else if (pilih == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Data:");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine();
                    tampil();
                    Console.WriteLine("\nTekan Enter Untuk Kembali");
                }
                else if (pilih == 4)
                {
                    keluar = true;
                }
                Console.ReadLine();
            }
        }

        private static void Ncreate(string nota1, string tgl, string customer, double nota2, string jenis)
        {
            throw new NotImplementedException();
        }
    }
}