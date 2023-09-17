using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppTest
{
    public class DBConnection
    {

        public static string ConnectionString
        {
            get
            {
                return "Data Source=31.9.185.56; Initial Catalog=CarsDealer;  Integrated Security=true;";
            }
        }
    }
}