using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_kelompok_6
{
	public class DataMahasiswa_1302204034
	{
		public string nama { get; set; }
		public string nim { get; set; }
		public string fakultas { get; set; }

        public void ReadJSON()
		{
			string fileName = "tp6_1_1302204034.json";

            string jsonString = File.ReadAllText(fileName);
			DataMahasiswa_1302204034 jsonData = JsonSerializer.Deserialize<DataMahasiswa_1302204034>(jsonString);

			this.nama = jsonData.nama;
			this.nim = jsonData.nim;
			this.fakultas = jsonData.fakultas;

			Console.WriteLine($"Nama {this.nama} dengan nim {this.nim} dari fakultas {this.fakultas}");
		}
	}
}
