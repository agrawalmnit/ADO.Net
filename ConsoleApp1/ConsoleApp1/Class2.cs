//using System;

//using System.Collections.Generic;

//using System.Linq;

//using System.Text;

//using System.Threading.Tasks;

//using System.Data;

//using System.Data.SqlClient;

//namespace ConsoleApp1

//{
//    class Class2

//    {
//        static void Main(string[] args)

//        {

//            Class2.Connection();

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



//                    string query = "GetPersons";


//                    SqlCommand cmd = new SqlCommand();

//                    cmd.CommandText = query;

//                    cmd.Connection = con;

//                    cmd.CommandType = CommandType.StoredProcedure;


//                    con.Open();

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