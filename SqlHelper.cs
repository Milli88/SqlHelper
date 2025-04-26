using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Linq.Expressions;


public class SqlHelper
{
    private string sqlconnectionstring;
	private string sqlscriptpath;
	

	public void Helper(string connectionstring, string scriptpath)
	{
		//Pass in connection string for mysql database, and path to your sql script to run
		sqlconnectionstring = connectionstring;
		sqlscriptpath = scriptpath;

		//Read sql script
		string sql = File.ReadAllText(sqlscriptpath);

		//Create connection to database
		var connection = new MySqlConnection(connectionstring);

		//Create Mysql commands from script
		var sqlcommandsfromscript = new MySqlCommand(sql, connection);


		//Open connection and execute sql script
		try { 
			connection.Open();
            Console.WriteLine(sqlcommandsfromscript.ExecuteNonQueryAsync());
            connection.Close();
			Console.WriteLine("Script Executed successfully");
			Console.WriteLine("Press Enter to exit........");
            Console.ReadLine();
			
        } catch (MySqlException e) { 
			Console.WriteLine(e.Message);
		}
		
    }
}
