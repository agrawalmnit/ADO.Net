using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class5
    {
        static void Main(string[] args)
        {
            Class5.Connection();
            Console.ReadLine();
        }
        static void Connection()
        {
            Console.WriteLine("Enter ID of any person");

            int PersonID = Convert.ToInt32(Console.ReadLine());

            string cs = "Data Source=ABJIMA-ISHANSI; Initial Catalog=ado_db;Integrated Security=true;";

            SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter sda  = new SqlDataAdapter();

            sda.SelectCommand = new SqlCommand("SetPerson", con);

            sda.SelectCommand.CommandType = CommandType.StoredProcedure;

            sda.SelectCommand.Parameters.AddWithValue("@PersonID", PersonID);

            DataSet ds = new DataSet();

            sda.Fill(ds);

            foreach(DataRow row in ds.Tables[0].Rows)
            {

                Console.WriteLine("{0} {1} {2} {3} {4}", row[0], row[1], row[2], row[3], row[4]);

            }

            Console.WriteLine("--------------------------------");

            DataTable dt = new DataTable();

            sda.Fill(dt);

            foreach(DataRow row in dt.Rows)
            {
                Console.WriteLine("{0} {1} {2}", row[0], row[1], row[2]);


            }

            Console.ReadLine();

        }
    }
}
