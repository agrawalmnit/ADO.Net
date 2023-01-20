//using System;

//using System.Collections.Generic;

//using System.Linq;

//using System.Text;

//using System.Threading.Tasks;

//using System.Data;

//using System.Data.SqlClient;

//namespace ConsoleApp1

//{
//    class Class3

//    {
//        static void Main(string[] args)

//        {

//            Class3.Connection();

//            Console.ReadLine();
//        }
//        static void Connection()

//        {
//            string cs = "Data Source=ABJIMA-ISHANSI; Initial Catalog=ado_db;Integrated Security=true;";

//            SqlConnection con = null;

//            try

//            {
//                using (con = new SqlConnection(cs))

//                {
//                    Console.WriteLine("Person ID:");

//                    string PersonId = Console.ReadLine();

//                    Console.WriteLine("First Name :");

//                    string FirstName = Console.ReadLine();

//                    Console.WriteLine("Last Name : ");

//                    string LastName = Console.ReadLine();

//                    Console.WriteLine("City :");

//                    string City = Console.ReadLine();

//                    Console.WriteLine("Address :");

//                    string Address = Console.ReadLine();

//                    string query = "update dbo.Persons set PersonID = @PersonID,FirstName = @FirstName,LastName = @LastName,City =  @City,Address = @Address";


//                    SqlCommand cmd = new SqlCommand(query, con);


//                    cmd.Parameters.AddWithValue("@PersonID", PersonId);

//                    cmd.Parameters.AddWithValue("@FirstName", FirstName);

//                    cmd.Parameters.AddWithValue("@LastName", LastName);

//                    cmd.Parameters.AddWithValue("@City", City);

//                    cmd.Parameters.AddWithValue("@Address", Address);

//                    con.Open();

//                    int a = cmd.ExecuteNonQuery();

//                    if (a > 0)
//                    {
//                        Console.WriteLine("data has been updated successfully");
//                    }

//                    else
//                    {
//                        Console.WriteLine("Data updation failed..");
//                    }

//                    SqlDataReader dr = cmd.ExecuteReader();

//                    while (dr.Read())

//                    {

//                        Console.WriteLine("PersonId =" + dr["PersonId"] +

//                            "FirstName = " + dr["FirstName"] +

//                            "LastName = " + dr["LastName"] +

//                            "City =" + dr["City"]);

//                    }

//                }

//            }




//            catch (SqlException ex)

//            {

//                Console.WriteLine(ex.Message);

//            }

//            finally

//            {

//                con.Close();

//            }

//        }

//    }

//}