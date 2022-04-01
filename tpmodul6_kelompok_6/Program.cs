using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_kelompok_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_1302204034 mhs1 = new DataMahasiswa_1302204034();
            mhs1.ReadJSON();

            KuliahMahasiswa_1302204034 mhs2 = new KuliahMahasiswa_1302204034();
            mhs2.ReadJson();
        }
    }
}
