using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class TeamMembers103022300125
{
    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public class MemberList
    {
        public List<Member> members { get; set; }
    }

    public static void readJSON()
    {
        string jsonPath = "jurnal7_2_103022300125.json"; // pastiin file JSON ini ada di folder project
        string jsonContent = File.ReadAllText(jsonPath);

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        MemberList team = JsonSerializer.Deserialize<MemberList>(jsonContent, options);

        Console.WriteLine("Team member list:");
        foreach (var m in team.members)
        {
            Console.WriteLine($"{m.nim} {m.firstName} {m.lastName} ({m.age} {m.gender})");
        }
    }
}