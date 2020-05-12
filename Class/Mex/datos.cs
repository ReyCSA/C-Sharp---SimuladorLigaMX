using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador.Class.Mex
{
    class datos
    {
        static string cadena = "datasource=127.0.0.1; port=3306; username=root; password=root; database=liga1;";
        public MySqlConnection cn;
        private MySqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public MySqlDataAdapter da;
        public MySqlCommand comando;

        private void conectar()
        {
            cn = new MySqlConnection(cadena);
        }

        public datos()
        {
            conectar();
        }

        public void consultar(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new MySqlDataAdapter(sql, cn);
            cmb = new MySqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        public void consultar2(string tabla)
        {
            string sql = "select * from " + tabla;
            ds.Tables.Clear();
            da = new MySqlDataAdapter(sql, cn);
            cmb = new MySqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        public void general(string tabla)
        {
            string sql = "select * from " + tabla + " order by PTS desc, PJ desc, DG desc, GF desc;";
            ds.Tables.Clear();
            da = new MySqlDataAdapter(sql, cn);
            cmb = new MySqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        public bool eliminar(string tabla, string condicion)
        {
            cn.Open();
            string sql = "delete from " + tabla + " where " + condicion;
            comando = new MySqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
                return true;
            else 
                return false;
        }

        public bool actTJ(string tabla, string campos, string condicion)
        {
            cn.Open();
            string sql = "update " + tabla + " set " + campos + "=1 where Torneo='" + condicion + "';";
            comando = new MySqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
                return true;
            else
                return false;
        }

        public bool aPen(string tabla, string campos, string condicion)
        {
            cn.Open();
            string sql = "update " + tabla + " set "+ campos + "='P' where Club='" + condicion + "';";
            comando = new MySqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
                return true;
            else
                return false;
        }

        public bool aPar(string tabla, string campos, string condicion)
        {
            cn.Open();
            string sql = "update " + tabla + " set " + campos + "='1' where Club='" + condicion + "';";
            comando = new MySqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
                return true;
            else
                return false;
        }

        public bool aEdPar(string tabla, string campos, int valor, string condicion)
        {
            cn.Open();
            string sql = "update " + tabla + " set " + campos + "='" + valor + "' where Club='" + condicion + "';";
            comando = new MySqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
                return true;
            else
                return false;
        }

        public bool aGF(string tabla, string campos, int gol, string condicion)
        {
            cn.Open();
            string sql = "update " + tabla + " set " + campos + "=" + gol + " where Club='" + condicion + "';";
            comando = new MySqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
                return true;
            else
                return false;
        }

        public bool aGC(string tabla, string campos, int gol, string condicion)
        {
            cn.Open();
            string sql = "update " + tabla + " set " + campos + "=" + gol + " where Club='" + condicion + "';";
            comando = new MySqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
                return true;
            else
                return false;
        }        

        public bool insertar(string sql)
        {
            cn.Open();
            comando = new MySqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
                return true;
            else
                return false;

        }
    }
}
