//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Configuration;

//namespace ConsoleApp1
//{
//    public class Class6

//    {

//        static void Main(string[] args)

//        {
//            try
//            {

//                DataTable Persons = new DataTable("Persons");

//                DataColumn PersonID = new DataColumn("PersonID");

//                PersonID.Caption = "PersonID";

//                PersonID.DataType = System.Type.GetType("System.Int32");

//                PersonID.AllowDBNull = false;

//                PersonID.AutoIncrement = true;

//                PersonID.AutoIncrementSeed = 1;

//                PersonID.AutoIncrementStep = 1;

//                Persons.Columns.Add(PersonID);


//                DataColumn FirstName = new DataColumn("FirstName");

//                FirstName.Caption = "FirstName";

//                FirstName.DataType = typeof(string);
                
//                FirstName.AllowDBNull = false;
                
//                FirstName.MaxLength = 50;
                
//                Persons.Columns.Add(FirstName);

//                FirstName.DefaultValue = "Anonymous";


//                DataColumn LastName = new DataColumn("LastName");
                
//                LastName.DataType = typeof(string);
                
//                LastName.AllowDBNull = false;
                
//                LastName.MaxLength = 50;
                
//                LastName.Caption = "LastName";
                
//                Persons.Columns.Add(LastName);


//                DataColumn Address = new DataColumn("Address");

//                Address.DataType = typeof(string);

//                Address.AllowDBNull = false;

//                Address.Caption = "Address";

//                Address.MaxLength= 50;

//                Persons.Columns.Add(Address);


//                DataColumn City = new DataColumn("City");

//                City.DataType = typeof(string);

//                City.AllowDBNull = false;

//                City.MaxLength = 50;

//                City.Caption = "City";

//                Persons.Columns.Add(City);



//                DataRow row1 = Persons.NewRow();

                
//                row1["PersonID"] = 1;
                
//                row1["FirstName"] = "mohammed";
                
//                row1["LastName"] = "Fazal";
                
//                row1["Address"] = "Vaishali nagar";
                
//                row1["City"] = "jaipur";
                
//                Persons.Rows.Add(row1);


//                Persons.Rows.Add(2, "niyat", "Mishra","malaviya nagar", "jaipur");

//                Persons.Rows.Add(3, "saqlain", "syed", "nirman nagar", "jaipur");

//                Persons.PrimaryKey = new DataColumn[];


//                foreach (DataRow row in Persons.Rows)
                
//                {
                
//                    Console.WriteLine(row["PersonID"] + " " + row["FirstName"] + " " + row["LastName"]);
               
//                }



//            }

//            catch (Exception ex)
            
//            {
            
//                Console.WriteLine(ex.Message);

//            }
//        }
//    }
//}
