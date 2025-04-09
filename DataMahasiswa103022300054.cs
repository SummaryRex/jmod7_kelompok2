using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace jmod7_kelompok2
{
    class DataMahasiswa103022300054
    {
        public class Biodata
        {
            [JsonPropertyName("firstName")]

            public string first { get; set; }

            [JsonPropertyName("lastName")]
            public string last { get; set; }

            [JsonPropertyName("gender")]
            public string JenisK { get; set; }

            [JsonPropertyName("age")]

            public string usia { get; set; }

            [JsonPropertyName("alamat")]

            public Alamat alamat
            {
                get; set;
            }

            public class Alamat
            {
                [JsonPropertyName("streetAddress")]
                public string sAddress { get; set; }

                [JsonPropertyName("city")]
                public string kota { get; set; }

                [JsonPropertyName("state")]
                public string provinsi { get; set; }
            }

            public class Courses
            {
                public string code { get; set; }
                public string Name { get; set; }
            }

            public class ListCourse
            {
                public List<Courses> Course { get; set; }
            }

            public void ReadJSON()
            {
                string path = "jurnal7_1_103022300054.json";
                string jsonString = File.ReadAllText(path);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                Biodata bio = JsonSerializer.Deserialize<Biodata>(jsonString, options);
                ListCourse data = JsonSerializer.Deserialize<ListCourse>(jsonString, options);

                Console.WriteLine($"Nama Mahasiswa {bio.first} {bio.last} gender {bio.JenisK} usia {bio.usia}");
                Console.WriteLine($"Alamat {bio.alamat.sAddress} {bio.alamat.kota} {bio.alamat.provinsi}");
            }

        }
    }
}
