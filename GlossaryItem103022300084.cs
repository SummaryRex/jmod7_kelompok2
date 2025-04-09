using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace jmod7_kelompok2
{
    public class GlossaryItem103022300084
    {
        public class GlossaryRoot
        {
            public Glossary glossary { get; set; }
        }

        public class Glossary
        {
            public string title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }

        public class GlossDiv
        {
            public string title { get; set; }
            public GlossList GlossList { get; set; }
        }

        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
        }

        public class GlossEntry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public GlossDef GlossDef { get; set; }
            public string GlossSee { get; set; }
        }

        public class GlossDef
        {
            public string para { get; set; }
            public List<string> GlossSeeAlso { get; set; }
        }

        public static void ReadJSON()
        {
            string filePath = "jurnal7_3_103022300084.json";
            try
            {
                string jsonString = File.ReadAllText(filePath);
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                GlossaryRoot data = JsonSerializer.Deserialize<GlossaryRoot>(jsonString, options);
                var entry = data.glossary.GlossDiv.GlossList.GlossEntry;

                Console.WriteLine("=== GlossEntry ===");
                Console.WriteLine($"ID: {entry.ID}");
                Console.WriteLine($"SortAs: {entry.SortAs}");
                Console.WriteLine($"GlossTerm: {entry.GlossTerm}");
                Console.WriteLine($"Acronym: {entry.Acronym}");
                Console.WriteLine($"Abbrev: {entry.Abbrev}");
                Console.WriteLine($"GlossDef.para: {entry.GlossDef.para}");
                Console.WriteLine("GlossSeeAlso: " + string.Join(", ", entry.GlossDef.GlossSeeAlso));
                Console.WriteLine($"GlossSee: {entry.GlossSee}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan saat membaca JSON: " + ex.Message);
            }
        }
    }
}