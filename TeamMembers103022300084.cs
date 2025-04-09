using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jmod7_kelompok2
{
    class TeamMembers103022300084
    {
        public class Member
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }

            public int age { get; set; }

            public string nim { get; set; }

        }

        public class ListCourse
        {
            public List<Member> Members { get; set; }
        }

        public void ReadJSON()
        {
            string path = "jurnal7_2_103022300084.json";
            string jsonString = File.ReadAllText(path);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            ListCourse data = JsonSerializer.Deserialize<ListCourse>(jsonString, options);

            Console.WriteLine("Daftar member:");
            int i = 1;
            foreach (var course in data.Members)
            {
                Console.WriteLine($"Member {i} {course.firstName} - {course.lastName} - {course.gender} - {course.age} - {course.nim}");
                i++;
            }
        }
    }
}
