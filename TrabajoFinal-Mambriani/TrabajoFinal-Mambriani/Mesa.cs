using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal_Mambriani
{
   public class Mesa
    {
        private int Id_Mesa;
        private int Cantidad_Personas;
        private bool Libre;
        private int Id_Sector;

        public int id_mesa { get { return Id_Mesa; } private set { } }
        public int cantidad_personas { get { return Cantidad_Personas; } set { Cantidad_Personas = value; } }
        public bool libre { get { return Libre; } set { Libre = value; } }
        public int id_sector { get { return Id_Sector; } set { } }
        public void Insertar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "INSERT INTO Mesas (Cantidad_Personas, Libre, Id_Sector) VALUES (@Cantidad_Personas,@Libre,@Id_Sector)";

            parametros.Add(new SqliteParameter("@Cantidad_Personas", Cantidad_Personas));
            parametros.Add(new SqliteParameter("@Libre", Libre));
            parametros.Add(new SqliteParameter("@Id_Sector", Id_Sector));

            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }

        public void Actualizar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "UPDATE Mesas SET Cantidad_Personas=@Cantidad_Personas,Libre=@Libre, Id_Sector=@Id_Sector WHERE Id_Mesa = @Id_Mesa";

            parametros.Add(new SqliteParameter("@Cantidad_Personas", Cantidad_Personas));
            parametros.Add(new SqliteParameter("@Libre", Libre));
            parametros.Add(new SqliteParameter("@Id_Sector", Id_Sector));
            parametros.Add(new SqliteParameter("@Id_Mesa", Id_Mesa));
            ;

            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }

        public void Eliminar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "DELETE FROM Mesas WHERE Id_Mesa = @Id_Mesa";

            parametros.Add(new SqliteParameter("@Id_Mesa", Id_Mesa));

            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public static List<Mesa> TraerTodos()
        {
            List<Mesa> listaDeMesas = new List<Mesa>();

            string consulta = "SELECT * FROM Mesas";

            DataTable tabla = GestorConexion.Instancia.ConsultarBD(consulta, null);

            foreach (DataRow fila in tabla.Rows)
            {
                Mesa nuevaMesa = new Mesa();

                nuevaMesa.Id_Mesa = int.Parse(fila["Id_Mesa"].ToString());
                nuevaMesa.Cantidad_Personas= int.Parse(fila["Cantidad_Personas"].ToString());
                nuevaMesa.Libre = bool.Parse(fila["Libre"].ToString());
                nuevaMesa.Id_Sector = int.Parse(fila["Id_Sector"].ToString());
                listaDeMesas.Add(nuevaMesa);
            }

            return listaDeMesas;
        }

        public static Mesa TraerUno(int idABuscar)
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "SELECT * FROM Mesas WHERE Id_Mesa = @Id_Mesa";

            parametros.Add(new SqliteParameter("@Id_Mesa", idABuscar));

            DataTable tabla = GestorConexion.Instancia.ConsultarBD(consulta, parametros);
            if (tabla == null || tabla.Rows.Count <= 0)
                return null;
            DataRow fila = tabla.Rows[0];

            Mesa nuevaMesa = new Mesa();

            nuevaMesa.Id_Mesa = int.Parse(fila["Id_Mesa"].ToString());
            nuevaMesa.Cantidad_Personas = int.Parse(fila["Cantidad_Personas"].ToString());
            nuevaMesa.Libre = bool.Parse(fila["Libre"].ToString());
            nuevaMesa.Id_Sector = int.Parse(fila["Id_Sector"].ToString());

            return nuevaMesa;
        }
    }
}
