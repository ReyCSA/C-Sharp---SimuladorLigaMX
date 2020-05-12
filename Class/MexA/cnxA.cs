using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador.Class.MexA
{
    class cnxA
    {
        static string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=root; database=liga2;";

        public cnxA()
        {
            
        }

        public void LimpiarBD(string tmp, string tabla)
        {
            string query =  "drop table if exists " + tmp + " ;" +
                            "create table " + tmp + " like " + tabla + ";" +
                            "insert into " + tmp + " select *from " + tabla + ";";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            #region Conexion
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar cualquier error
                MessageBox.Show(ex.Message);
            }
            #endregion
        }
    }
}
