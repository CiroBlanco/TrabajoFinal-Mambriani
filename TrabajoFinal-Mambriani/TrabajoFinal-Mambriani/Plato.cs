using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal_Mambriani
{
    public class Plato
    {
        private int Id_Plato;
        private string Nombre;
        private string Descripcion;
        private float Precio;

        public int id_plato { get { return Id_Plato; } private set { } }
        public string nombre { get { return Nombre; } set { Nombre = value; } }
        public string descripcion { get { return Descripcion; } set { Descripcion = value; } }
        public float precio { get { return Precio; } set { Precio = value; } }
        public void Insertar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "INSERT INTO Platos (Nombre, Descripcion, Precio) VALUES (@Nombre,@Descripcion,@Precio)";
            parametros.Add(new SqliteParameter("@Nombre", Nombre));
            parametros.Add(new SqliteParameter("@Descripcion", Descripcion));
            parametros.Add(new SqliteParameter("@Precio", Precio));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public void Actualizar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "UPDATE Platos SET Nombre=@Nombre, Descripcion=@Descripcion, Precio=@Precio WHERE Id_Plato = @Id_Plato";
            parametros.Add(new SqliteParameter("@Nombre", Nombre));
            parametros.Add(new SqliteParameter("@Descripcion", Descripcion));
            parametros.Add(new SqliteParameter("@Precio", Precio));
            parametros.Add(new SqliteParameter("@Id_Plato", Id_Plato));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public void Eliminar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "DELETE FROM Platos WHERE Id_Plato = @Id_Plato";
            parametros.Add(new SqliteParameter("@Id_Plato", Id_Plato));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public static List<Plato> TraerTodos()
        {
            List<Plato> listaDePlatos = new List<Plato>();
            string consulta = "SELECT * FROM Platos";
            DataTable tabla = GestorConexion.Instancia.ConsultarBD(consulta, null);
            foreach (DataRow fila in tabla.Rows)
            {
                Plato nuevoPlato = new Plato();
                nuevoPlato.Id_Plato = int.Parse(fila["Id_Plato"].ToString());
                nuevoPlato.Nombre = fila["Nombre"].ToString();
                nuevoPlato.Descripcion = fila["Descripcion"].ToString();
                nuevoPlato.Precio = float.Parse(fila["Precio"].ToString());
                listaDePlatos.Add(nuevoPlato);
            }
            return listaDePlatos;
        }
        public static Plato TraerUno(int idABuscar)
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "SELECT * FROM Platos WHERE Id_Plato = @Id_Plato";

            parametros.Add(new SqliteParameter("@Id_Plato", idABuscar));

            DataTable tabla = GestorConexion.Instancia.ConsultarBD(consulta, parametros);
            if (tabla == null || tabla.Rows.Count <= 0)
                return null;
            DataRow fila = tabla.Rows[0];

            Plato nuevoPlato = new Plato();

            nuevoPlato.Id_Plato = int.Parse(fila["Id_Plato"].ToString());
            nuevoPlato.Nombre = (fila["Nombre"].ToString());
            nuevoPlato.Descripcion = (fila["Descripcion"].ToString());
            nuevoPlato.Precio = float.Parse(fila["Precio"].ToString());

            return nuevoPlato;
        }
    }
}
