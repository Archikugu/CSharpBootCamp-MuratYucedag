using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD -> Create, Read, Update, Delete
            Console.WriteLine("**** Menu Order Processing Panel ****");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");

            #region Category Addition Process
            //Console.WriteLine("Enter the name of the category you want to add: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4K38GM2;Initial Catalog=CSharpBootcampDb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Insert into TblCategories(CategoryName) values = (@categoryName)", connection);
            //command.Parameters.AddWithValue("@categoryName", categoryName);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Category successfully added.");
            #endregion

            #region Product Addition Process

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.WriteLine("Product Name: ");
            //productName = Console.ReadLine();
            //Console.WriteLine("Product Price: ");
            //productPrice = decimal.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4K38GM2;Initial Catalog=CSharpBootcampDb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProducts (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Product successfully added.");

            #endregion

            #region Product Listing Process

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4K38GM2;Initial Catalog=CSharpBootcampDb;Integrated Security=True");

            //connection.Open();

            //SqlCommand command = new SqlCommand("SELECT * FROM TblProducts", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);

            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Product Deletion Process

            //Console.WriteLine("Enter the ID of the product to be deleted:");
            //int productId = int.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4K38GM2;Initial Catalog=CSharpBootcampDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProducts Where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Product successfully deleted.");

            #endregion

            #region Product Update Process 

            Console.WriteLine("Enter the ID of the product to be updated:");
            int productId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the new product name:");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter the new product price:");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4K38GM2;Initial Catalog=CSharpBootcampDb;Integrated Security=True");
            connection.Open();

            SqlCommand command = new SqlCommand("Update TblProducts Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Product successfully updated.");
            #endregion
        }
    }
}
