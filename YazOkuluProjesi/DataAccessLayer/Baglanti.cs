using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti  
    {
        
        public static SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-GLTFK1B;Initial Catalog=Dbo_YazOkulu;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}