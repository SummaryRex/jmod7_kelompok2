// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using jmod7_kelompok2;
// Define the missing class to resolve CS0246
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of DataMahasiswa103022300142
        DataMahasiswa103022300142 dataMahasiswa = new DataMahasiswa103022300142();

        // Call the ReadJSON method
        dataMahasiswa.ReadJSON();
    }
    
}

