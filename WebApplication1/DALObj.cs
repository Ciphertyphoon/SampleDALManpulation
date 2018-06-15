using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class DALObj
    {
        public DataSet BindGrid()
        {
            string constr = "Data Source = SARIMANOK\\HYDRASERVER; Initial Catalog = Northwind; Persist Security Info = True; User ID = SA; Password = system123";
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