using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class9
    {
        static void Main(string[] args)
        {

            Class9.Connection();
            Console.ReadLine();
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> EmployeesList = new List<Employee>();

            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("ProcedurePersons", con);

            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Employees emp = new Employees();

                emp.PersonID = Convert.ToInt32(dr.GetValue(0).ToString());

                emp.FirstName = dr.GetValue(1).ToString();

                emp.LastName = dr.GetValue(2).ToString();

                emp.Address = dr.GetValue(3).ToString();

                emp.City = dr.GetValue(4).ToString();

                emp.Email = dr.GetValue(5).ToString();

                EmployeesList.Add(emp);
            }

            con.Close();
        }


    }
}
