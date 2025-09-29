using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrabajoFinal_Mambriani
{
    public class GestorConexion
    {
        private GestorConexion()
        {
            conexion = new SqliteConnection("Data source= Restaurante.bd");
        }
        private static GestorConexion _instancia;

        public static GestorConexion Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new GestorConexion();
                return _instancia;
            }

            private set { }
        }

        private SqliteConnection conexion;
        private SqliteCommand comando;
        private SqliteDataReader lector;
        public void ModificarBD(string consulta, List<SqliteParameter> parametros)
        {
            try
            {
                conexion.Open();
                comando = new SqliteCommand(consulta, conexion);
                if (parametros != null)
                {
                    foreach (SqliteParameter param in parametros)
                    {
                        comando.Parameters.Add(param);
                    }
                }
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conexion.Close();
        }

        public DataTable ConsultarBD(string consulta, List<SqliteParameter> parametros)
        {
            DataTable tabla = null;
            try
            {
                conexion.Open();
                comando = new SqliteCommand(consulta, conexion);
                if (parametros != null)
                {
                    foreach (SqliteParameter param in parametros)
                    {
                        comando.Parameters.Add(param);
                    }
                }
                lector = comando.ExecuteReader();
                tabla = new DataTable();
                tabla.Load(lector);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conexion.Close();

            return tabla;
        }
    }
}
