using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Wfrm_RastreoVehiculos.logica
{
    public class cls_DBConnection
    {
        private readonly string connectionString = "Server=localhost;Database=vehiculos;Uid=root;Pwd=tu_contraseña;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }

}
