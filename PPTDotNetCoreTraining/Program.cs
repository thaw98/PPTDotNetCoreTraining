// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;
using DotNetTrainingBatch5.ConsoleApp;

Console.WriteLine("Hello, World!");
Console.ReadKey();

//md = markdown

//string connectionString =
//    "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DotNetTrainingBatch5;User ID=sa;Password=root;";
//Console.WriteLine("Connection string: " + connectionString);
//SqlConnection connection = new SqlConnection(connectionString);

//Console.WriteLine("Connection opening...");
//connection.Open();
//Console.WriteLine("Connection opened.");

//string query = @"SELECT [BlogId]
//      ,[BlogTitle]
//      ,[BlogAuthor]
//      ,[BlogContent]
//      ,[DeleteFlag]
//  FROM [dbo].[Tbl_Blog] where DeleteFlag = 0";
//SqlCommand cmd = new SqlCommand(query, connection);
////SqlDataAdapter adapter = new SqlDataAdapter(cmd);
////DataTable dt = new DataTable();
////adapter.Fill(dt);
//SqlDataReader reader = cmd.ExecuteReader();
//while (reader.Read())
//{
//    Console.WriteLine(reader["BlogId"]);
//    Console.WriteLine(reader["BlogTitle"]);
//    Console.WriteLine(reader["BlogAuthor"]);
//    Console.WriteLine(reader["BlogContent"]);
//    //Console.WriteLine(dr["DeleteFlag"]);
//}

//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine(dr["BlogId"]);
//    Console.WriteLine(dr["BlogTitle"]);
//    Console.WriteLine(dr["BlogAuthor"]);
//    Console.WriteLine(dr["BlogContent"]);
//    //Console.WriteLine(dr["DeleteFlag"]);
//}

//Console.WriteLine("Connection closing...");
//connection.Close();
//Console.WriteLine("Connection closed.");

// DataSet
// DataTable
// DataRow
// DataColumn

//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine(dr["BlogId"]);
//    Console.WriteLine(dr["BlogTitle"]);
//    Console.WriteLine(dr["BlogAuthor"]);
//    Console.WriteLine(dr["BlogContent"]);
//    //Console.WriteLine(dr["DeleteFlag"]);
//}

AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Create();
//adoDotNetExample.Edit();
adoDotNetExample.Update();

Console.ReadKey();
