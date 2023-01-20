using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class8
    {
        static void Main(string[] args)
        {
            Class8.Connection();

            Console.ReadLine();

        }

        static void Connection()
        {
            string cs = "Data Source = ABJIMA-ISHANSI;Integrated Security = true; Initial Catalog = ado_db ";

            SqlConnection con = null;



            try
            {
                using (con = new SqlConnection(cs))
                {

                    string query = "select * from dbo.Persons";

                    con.Open();

                    SqlDataAdapter sda = new SqlDataAdapter(query, con);

                    DataTable DatatablePersons = new DataTable(); ;

                    sda.Fill(DatatablePersons);

                    

                    DataSet ds = new DataSet();

                    sda.Fill(ds);

                    ds.Tables.Add(DatatablePersons);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        Console.WriteLine(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4] + " ");



                    }



                }
            }



            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

    }
}
