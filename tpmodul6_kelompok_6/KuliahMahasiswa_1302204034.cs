using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_kelompok_6
{
	public class KuliahMahasiswa_1302204034
	{
		public string kode_mk { get; set; }
		public string nama_mk { get; set; }

		public void ReadJson()
		{
			string fileName = "tp6_2_1302204034.json";

			string jsonString = System.IO.File.ReadAllText(fileName);
			KuliahMahasiswa_1302204034[] jsonData = JsonSerializer.Deserialize<KuliahMahasiswa_1302204034[]>(jsonString);

			int i = 1;
			Console.WriteLine("Daftar mata kuliah yang diambil");
			foreach (KuliahMahasiswa_1302204034 K in jsonData)
			{
				Console.WriteLine($"MK {i} {K.kode_mk} - {K.nama_mk}"); i++;
			}

		}
	}
}
