using System;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace jmod7_kelompok2
{
	class DataMahasiswa103022300142()
	{
        public class Nama
        {
            public string namadepan { get; set; }
            public string namabelakang { get; set; }
            public string gender { get; set; }
            public int age { get; set; }

        }
    public class address
    {
        public string jalan { get; set; }
        public string kota { get; set; }
        public string provinsi { get; set; }
    }
    public class course
    {
        public string kode { get; set; }
        public string nama { get; set; }
        
    }

    public class ListCourse
    {
        public List<course> courses { get; set; }
    }


    public static void ReadJSON()
    {
            
            Console.WriteLine("DEBUG: Mulai baca DataMahasiswa...");
            string path = "jurnal7_1_103022300142.json";


            string json = File.ReadAllText(path);
            var data = new JsonSerializerOptions

            {
                PropertyNameCaseInsensitive = true,
            };

            try
            {
                string json = File.ReadAllText(path);
                Nama nama = JsonSerializer.Deserialize<Nama>(json, data);
                Console.WriteLine("Nama: " nama.namadepan + " " + nama.namabelakang + ", jenis kelamin " + nama.gender+", umur "+nama.age+" tahun");
                Console.WriteLine("alamat: "+nama.address.jalan + ", " + nama.address.kota + ", " + nama.address.provinsi);

                ListCourse listCourse = JsonSerializer.Deserialize<ListCourse>(json, data);

                Console.WriteLine("Daftar Mata Kuliah:");

                foreach (var course in listCourse.courses)
                {
                    Console.WriteLine($"Kode: {i} {course.kode} - {course.nama}");
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

            
    }
}
}
