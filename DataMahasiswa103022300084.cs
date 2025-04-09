using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json; 
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace jmod7_kelompok2
{
    class DataMahasiswa103022300084
    {
        public class Nama
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }

            public Address address { get; set; }
        }

        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }
        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class ListCourse
        {
            public List<Course> Courses { get; set; }
        }

        public static void ReadJSON()
        {
            string filePath = "jurnal7_1_103022300084.json";
            string jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            try
            {
                string jsonContent = File.ReadAllText(filePath);
                Nama mhs = JsonSerializer.Deserialize<Nama>(jsonString, options);
                Console.WriteLine("Nama " + mhs.firstName + " " + mhs.lastName + " jenis kelamin " + mhs.gender + " dan umur " + mhs.age + " tahun ");
                Console.WriteLine("Alamat " + mhs.address.streetAddress + " kota " + mhs.address.city + " provinsi " + mhs.address.state);
                ListCourse data = JsonSerializer.Deserialize<ListCourse>(jsonString, options);

                Console.WriteLine("Daftar mata kuliah yang diambil:");
                int i = 1;
                foreach (var course in data.Courses)
                {
                    Console.WriteLine($"MK {i} {course.code} - {course.name}");
                    i++;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi kesalahan saat membaca file JSON: " + e.Message);
            }
        }
    }
}
