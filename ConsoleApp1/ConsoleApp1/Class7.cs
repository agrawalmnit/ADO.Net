//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    public class Class7
//    {
//        static void Main(string[] args)
//        {
//            Class7.Connection();

//            Console.ReadLine();
//        }

//        static void Connection()

//        {

//            string cs = "Data Source = ABJIMA-ISHANSI; Initial Catalog = ado_db;Integrated Security = true;";

//            SqlConnection con = null;


//            try

//            {

//                using (con = new SqlConnection(cs))

//                {


//                    string query = "SELECT * FROM dbo.Persons";

//                    SqlDataAdapter sda = new SqlDataAdapter(query, con);

//                    con.Open();

//                    DataTable Persons = new DataTable();

//                    sda.Fill(Persons);

//                    Console.WriteLine("Original table");

//                    foreach (DataRow row in Persons.Rows)
//                    {
//                        Console.WriteLine(row["PersonID"] + " " + row["FirstName"] + " " + row["LastName"] + " " + row["Address"] + " " + row["City"] + " ");
//                    }

//                    DataTable CopyPersons = Persons.Copy();

//                    Console.WriteLine("CopyPersons table");


//                    foreach (DataRow row in CopyPersons.Rows)
//                    {
//                        Console.WriteLine(row["PersonID"] + " " + row["FirstName"] + " " + row["LastName"] + " " + row["Address"] + " " + row["City"] + " ");
//                    }

//                    DataTable ClonePersons = Persons.Clone(); ;

//                    Console.WriteLine("ClonePersons table");

//                    if (ClonePersons.Rows.Count > 0)
//                    {

//                        foreach (DataRow row in ClonePersons.Rows)
//                        {
//                            Console.WriteLine(row["PersonID"] + " " + row["FirstName"] + " " + row["LastName"] + " " + row["Address"] + " " + row["City"] + " ");
//                        }
//                    }

//                    else
//                    {
//                        /*Console.WriteLine("Row not found");*/

//                        ClonePersons.Rows.Add(1, "nirman", "jangid", "nirman nagar", "jaipur");

//                        ClonePersons.Rows.Add(2, "jaman", "gujjar", "vigyan nagar", "kota");

//                        ClonePersons.Rows.Add(3, "sandhya", "rani", "jln maarg", "jaipur");

//                        ClonePersons.Rows.Add(4, "swati", "suman", "jantar mantar", "noida");
//                    }

//                    foreach (DataRow row in ClonePersons.Rows)
//                    {
//                        Console.WriteLine(row["PersonID"] + " " + row["FirstName"] + " " + row["LastName"] + " " + row["Address"] + " " + row["City"] + " ");

//                    }


//                }
//            }



//            catch (Exception ex)
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
