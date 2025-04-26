



using System.Diagnostics;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Beginning program. Running Sql Script to build database tables for your data pull");
        SqlHelper helper = new SqlHelper();
        helper.Helper("Server=localhost;Database=_db;User ID=root;Password=password;", "C:\\Users\\developer1\\Desktop\\Dynamic\\dot-net\\sqlhelper\\SqlHelper\\dump.sql");
        
    }
}
