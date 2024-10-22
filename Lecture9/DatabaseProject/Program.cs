using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ADO.NET

            Console.WriteLine("***** C# Database-Driven Product-Category Information System *****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-----------------------------");
            string tableNumber;
            Console.WriteLine("1-Categories");
            Console.WriteLine("2-Products");
            Console.WriteLine("3-Orders");
            Console.WriteLine("4-Exit");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-----------------------------");

            // Corrected connection string
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4K38GM2;Initial Catalog=CSharpBootcampDb;Integrated Security=True");

            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TblCategories", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

        }
    }
}
