using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Data;

namespace TrabajoFinal_Mambriani
{
    public class Bebida
    {
        private int Id_Bebida;
        private string Nombre;
        private string Descripcion;
        private bool Alcoholica;
        private float Precio;

        public int id_bebida { get { return Id_Bebida; } private set { } }
        public string nombre { get { return Nombre; } set { Nombre = value; } }
        public string descripcion { get { return Descripcion; } set { Descripcion = value; } }
        public bool alcoholica { get { return Alcoholica; } set { Alcoholica = value; } }
        public float precio { get { return Precio; } set { Precio = value; } }
        public void Insertar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "INSERT INTO Bebidas (Nombre, Descripcion, Alcoholica, Precio) VALUES (@Nombre,@Descripcion,@Alcoholica,@Precio)";
            parametros.Add(new SqliteParameter("@Nombre", Nombre));
            parametros.Add(new SqliteParameter("@Descripcion", Descripcion));
            parametros.Add(new SqliteParameter("@Alcoholica", Alcoholica));
            parametros.Add(new SqliteParameter("@Precio", Precio));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public void Actualizar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "UPDATE Bebidas SET Nombre=@Nombre,Descripcion=@Descripcion,Alcoholica=@Alcoholica, Precio=@Precio WHERE Id_Bebida = @Id_Bebida";
            parametros.Add(new SqliteParameter("@Nombre", Nombre));
            parametros.Add(new SqliteParameter("@Descripcion", Descripcion));
            parametros.Add(new SqliteParameter("@Alcoholica", Alcoholica));
            parametros.Add(new SqliteParameter("@Precio", Precio));
            parametros.Add(new SqliteParameter("@Id_Bebida", Id_Bebida));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public void Eliminar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "DELETE FROM Bebidas WHERE Id_Bebida = @Id_Bebida";
            parametros.Add(new SqliteParameter("@Id_Bebida", Id_Bebida));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public static List<Bebida> TraerTodos()
        {
            List<Bebida> listaDeBebidas = new List<Bebida>();
            string consulta = "SELECT * FROM Bebidas";
            DataTable tabla = GestorConexion.Instancia.ConsultarBD(consulta, null);
            foreach (DataRow fila in tabla.Rows)
            {
                Bebida nuevaBebida = new Bebida();
                nuevaBebida.Id_Bebida = int.Parse(fila["Id_Bebida"].ToString());
                nuevaBebida.Nombre = fila["Nombre"].ToString();
                nuevaBebida.Descripcion = fila["Descripcion"].ToString();
                nuevaBebida.Alcoholica = Convert.ToBoolean(fila["Alcoholica"]);
                nuevaBebida.Precio = float.Parse(fila["Precio"].ToString());
                listaDeBebidas.Add(nuevaBebida);
            }
            return listaDeBebidas;
        }
        public static Bebida TraerUno(int idABuscar)
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "SELECT * FROM Bebidas WHERE Id_Bebida = @Id_Bebida";

            parametros.Add(new SqliteParameter("@Id_Bebida", idABuscar));

            DataTable tabla = GestorConexion.Instancia.ConsultarBD(consulta, parametros);
            if (tabla == null || tabla.Rows.Count <= 0)
                return null;
            DataRow fila = tabla.Rows[0];

            Bebida nuevaBebida = new Bebida();

            nuevaBebida.Id_Bebida = int.Parse(fila["Id_Bebida"].ToString());
            nuevaBebida.Nombre = fila["Nombre"].ToString();
            nuevaBebida.Descripcion = fila["Descripcion"].ToString();
            nuevaBebida.Alcoholica = Convert.ToBoolean(fila["Alcoholica"]);
            nuevaBebida.Precio = float.Parse(fila["Precio"].ToString());

            return nuevaBebida;
        }
    }
}
