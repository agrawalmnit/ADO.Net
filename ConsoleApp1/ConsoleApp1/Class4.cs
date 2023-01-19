//using System;

//using System.Collections.Generic;

//using System.Linq;

//using System.Text;

//using System.Threading.Tasks;

//using System.Data;

//using System.Data.SqlClient;

//namespace ConsoleApp1

//{
//    class Class4

//    {
//        static void Main(string[] args)

//        {

//            Class4.Connection();

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



//                    string query = "delete from dbo.Persons where PersonID = @PersonID";




//                    SqlCommand cmd = new SqlCommand(query, con);


//                    cmd.Parameters.AddWithValue("@PersonID", PersonId);



//                    con.Open();

//                    int a = cmd.ExecuteNonQuery();

//                    if (a > 0)
//                    {
//                        Console.WriteLine("data has been deleted successfully");
//                    }

//                    else
//                    {
//                        Console.WriteLine("Data deletion failed..");
//                        }

//                        SqlDataReader dr = cmd.ExecuteReader();

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