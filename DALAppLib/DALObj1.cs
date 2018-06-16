using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALAppLib
{
    public class DALObj1
    {
        public DataSet BindGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnStringNW"].ConnectionString;
            string query = "SELECT TOP 10 ContactName, City, Country FROM Customers;";
            query += "SELECT TOP 10 (FirstName + ' ' + LastName) EmployeeName, City, Country FROM Employees";

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            return (ds);


                        }
                    }
                }
            }

        }
    }
}
