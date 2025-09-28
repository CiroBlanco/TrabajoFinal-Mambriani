using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Data;

namespace TrabajoFinal_Mambriani
{
    public class Sector
    {
        private int Id_Sector;
        private string Nombre;

        public int id_sector { get { return Id_Sector; } private set { } }
        public string nombre { get { return Nombre; } set { Nombre = value; } }

        public void Insertar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "INSERT INTO Sectores (Nombre) VALUES (@Nombre)";
            parametros.Add(new SqliteParameter("@Nombre", Nombre));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public void Update()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "UPDATE Sectores SET Nombre=@Nombre WHERE Id_Sector = @Id_Sector";
            parametros.Add(new SqliteParameter("@Nombre", Nombre));
            parametros.Add(new SqliteParameter("@Id_Sector", Id_Sector));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public void Eliminar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "DELETE FROM Sectores WHERE Id_Sector = @Id_Sector";
            parametros.Add(new SqliteParameter("@Id_Sector", Id_Sector));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public static List<Sector> TraerTodos()
        {
            List<Sector> listaDeSectores = new List<Sector>();
            string consulta = "SELECT * FROM Sectores";
            DataTable tabla = GestorConexion.Instancia.ConsultarBD(consulta, null);
            foreach (DataRow fila in tabla.Rows)
            {
                Sector nuevoSector = new Sector();
                nuevoSector.Id_Sector = int.Parse(fila["Id_Sector"].ToString());
                nuevoSector.Nombre = fila["Nombre"].ToString();
                listaDeSectores.Add(nuevoSector);
            }
            return listaDeSectores;
        }
        public static Sector TraerUno(int idABuscar)
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "SELECT * FROM Sectores WHERE Id_Sector = @Id_Sector";

            parametros.Add(new SqliteParameter("@Id_Sector", idABuscar));

            DataTable tabla = GestorConexion.Instancia.ConsultarBD(consulta, parametros);
            if (tabla == null || tabla.Rows.Count <= 0)
                return null;
            DataRow fila = tabla.Rows[0];

            Sector nuevoSector = new Sector();

            nuevoSector.Id_Sector = int.Parse(fila["Id_Mesa"].ToString());
            nuevoSector.Nombre = (fila["Cantidad_Personas"].ToString());

            return nuevoSector;
        }
    }
}
