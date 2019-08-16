using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCAM
{
    public static class DAO
    {
        public static string ConnectionString()
        {
            return "server=DESKTOP-20E1M0S\\SQLEXPRESS; database=ScamProject;Integrated Security = SSPI";
        }
    }
}