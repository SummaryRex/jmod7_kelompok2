// See https://aka.ms/new-console-template for more information
using jmod7_kelompok2;
class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa103022300084.ReadJSON();
        Console.WriteLine();

        var member = new TeamMembers103022300084();
        member.ReadJSON();
    }
}
