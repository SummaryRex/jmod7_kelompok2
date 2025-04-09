using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class DataMahasiswa103022300125
{
	public class Address
	{
		public string streetAddress { get; set; }
		public string city { get; set; }
		public string state { get; set; }

	}
	public class Course
	{
		public string code { get; set; }
		public string name { get; set;}
	}

	public class Mahasiswa
	{
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string gender { get; set; }
		public int age { get; set; }
		public Address address { get; set; }
		public List<Course> courses { get; set; }
	} 
	public static void readJSON()
	{
		string jsonFilePath = "jurnal7_1_103022300125.json";
		string jsonContent = File.ReadAllText(jsonFilePath);

		var options = new JsonSerializerOptions
		{
			PropertyNameCaseInsensitive = true
		};

		Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonContent);

		Console.WriteLine("===== DATA MAHASISWA =====");
        Console.WriteLine($"Nama	: {data.firstName} {data.lastName}");
        Console.WriteLine($"Gender	: {data.gender}");
        Console.WriteLine($"Age	: {data.age}");

        Console.WriteLine("=== Alamat");
        Console.WriteLine($"Jalan	: {data.address.streetAddress}");
        Console.WriteLine($"Kota	: {data.address.city}");
        Console.WriteLine($"State	: {data.address.state}");

        Console.WriteLine("=== Mata Kuliah");
		foreach (var course in data.courses)
		{
            Console.WriteLine($" - [{course.code}] {course.name}");
        }
    }

}

