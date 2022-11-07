using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ADODOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-K029TNO\\SQLEXPRESS;Database=EmployeeDB;Trusted_Connection=true");
            SqlCommand cmd;
            int i;
            conn.Open();
            cmd=new SqlCommand("insert into ")

        }
    }
}
