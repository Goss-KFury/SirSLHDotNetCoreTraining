using KZHDotNetCore.ConsoleApp;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

//SqlConnection

//Ctrl + . =>suggestion
// F10 =>
// F11 =>
// F9 => breakpoint

//SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
//stringBuilder.DataSource = "DESKTOP-VDN16K4";  //server name
//stringBuilder.InitialCatalog = "DotNetTrainingBatch4"; // database name
//stringBuilder.UserID = "sa";
//stringBuilder.Password = "sasa@123";
//SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
//// SqlConnection connection = new SqlConnection({Data Source=DESKTOP-VDN16K4;Initial Catalog=DotNetTrainingBatch4;User ID=sa;Password=sasa@123});

//connection.Open();
//Console.WriteLine("Connection Open.");

//string query = "select * from Tbl_Blog";
//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//sqlDataAdapter.Fill(dt);

//connection.Close();
//Console.WriteLine("Connection close.");

//// dataset => datatable
//// datatable => datarow
//// datarow => datacolum

//foreach (DataRow dr in dt.Rows)
//{
//    //Console.WriteLine("Blog Id => " + dr["BlogId"]);
//    Console.WriteLine("Blog Title => " + dr["BlogTitle"]);
//    Console.WriteLine("Blog Author => " + dr["BlogAuthor"]);
//    Console.WriteLine("Blog Content => " + dr["BlogContent"]);
//    Console.WriteLine("------------------");
//}

// Ado.Net Read
// CRUD

AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetRead.Read();
//adoDotNetExample.Create("title", "author", "content");
//adoDotNetExample.Update(1005, "test title", "test author", "test content");
//adoDotNetExample.Delete(1005);
adoDotNetExample.Edit(1005);
adoDotNetExample.Edit(1);

Console.ReadLine();