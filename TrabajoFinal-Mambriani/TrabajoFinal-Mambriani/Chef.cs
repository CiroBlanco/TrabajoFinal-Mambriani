using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrabajoFinal_Mambriani
{
    public class Chef
    {
        private int Id_Chef;
        private string Nombre_Completo;
        private int Dni;
        private int Telefono;
        private DateTime Fecha_Nacimiento;
        private DateTime Horario_Inicio;
        private DateTime Horario_Fin;
        private int Id_Sector;

        public int id_chef { get { return Id_Chef; } private set { } }
        public string nombre_completo { get { return Nombre_Completo; } set { Nombre_Completo = value; } }
        public int dni { get { return Dni; } set { Dni = value; } }
        public int telefono { get { return Telefono; } set { Telefono = value; } }
        public DateTime fecha_nacimiento { get { return Fecha_Nacimiento; } set { Fecha_Nacimiento = value; } }
        public DateTime horario_inicio { get { return Horario_Inicio; } set { Horario_Inicio = value; } }
        public DateTime horario_fin { get { return Horario_Fin; } set { Horario_Fin = value; } }
        public int id_sector { get { return Id_Sector; }  set { } }

        public void Insertar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "INSERT INTO Chef (Nombre_Completo, Dni, Telefono, Fecha_Nacimiento, Horario_Inicio, Horario_Fin, Id_Sector) VALUES (@Nombre_Completo, @Dni, @Telefono, @Fecha_Nacimiento, @Horario_Inicio,@Horario_Fin, @Id_Sector)";
            parametros.Add(new SqliteParameter("@Nombre_Completo", Nombre_Completo));
            parametros.Add(new SqliteParameter("@Dni", Dni));
            parametros.Add(new SqliteParameter("@Telefono",Telefono ));
            parametros.Add(new SqliteParameter("@Fecha_Nacimiento", Fecha_Nacimiento));
            parametros.Add(new SqliteParameter("@Horario_Inicio", Horario_Inicio));
            parametros.Add(new SqliteParameter("@Horario_Fin", Horario_Fin));
            parametros.Add(new SqliteParameter("@Id_Sector", Id_Sector));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public void Actualizar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "UPDATE Chef SET Nombre_Completo=@Nombre_Completo,Dni=@Dni,Telefono=@Telefono, Fecha_Nacimiento=@Fecha_Nacimiento, Horario_Inicio= @Horario_Inicio, Horario_Fin= @Horario_Fin, Id_Sector= @Id_Sector WHERE Id_Chef = @Id_Chef";
            parametros.Add(new SqliteParameter("@Nombre_Completo", Nombre_Completo));
            parametros.Add(new SqliteParameter("@Dni", Dni));
            parametros.Add(new SqliteParameter("@Telefono", Telefono));
            parametros.Add(new SqliteParameter("@Fecha_Nacimiento", Fecha_Nacimiento));
            parametros.Add(new SqliteParameter("@Horario_Inicio", Horario_Inicio));
            parametros.Add(new SqliteParameter("@Horario_Fin", Horario_Fin));
            parametros.Add(new SqliteParameter("@Id_Sector", Id_Sector));
            parametros.Add(new SqliteParameter("@Id_Chef", Id_Chef));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public void Eliminar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "DELETE FROM Chefs WHERE Id_Chef = @Id_Chef";
            parametros.Add(new SqliteParameter("@Id_Chef", Id_Chef));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public static List<Chef> TraerTodos()
        {
            List<Chef> listaDeChefs = new List<Chef>();
            string consulta = "SELECT * FROM Chef";
            DataTable tabla = GestorConexion.Instancia.ConsultarBD(consulta, null);
            foreach (DataRow fila in tabla.Rows)
            {
                Chef nuevoChef = new Chef();
                nuevoChef.Id_Chef = int.Parse(fila["Id_Chef"].ToString());
                nuevoChef.Nombre_Completo = fila["Nombre_Completo"].ToString();
                nuevoChef.Dni = int.Parse(fila["Dni"].ToString());
                nuevoChef.Telefono = int.Parse(fila["Telefono"].ToString());
                nuevoChef.Fecha_Nacimiento = DateTime.Parse(fila["Fecha_Nacimiento"].ToString());
                nuevoChef.Horario_Inicio = DateTime.Parse(fila["Horario_Inicio"].ToString());
                nuevoChef.Horario_Fin = DateTime.Parse(fila["Horario_Fin"].ToString());
                nuevoChef.Id_Sector = int.Parse(fila["Id_Sector"].ToString());
                listaDeChefs.Add(nuevoChef);
            }
            return listaDeChefs;
        }
        public static Chef TraerUno(int idABuscar)
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "SELECT * FROM Chefs WHERE Id_Chef = @Id_Chef";

            parametros.Add(new SqliteParameter("@Id_Chef", idABuscar));

            DataTable tabla = GestorConexion.Instancia.ConsultarBD(consulta, parametros);
            if (tabla == null || tabla.Rows.Count <= 0)
                return null;
            DataRow fila = tabla.Rows[0];

            Chef nuevoChef = new Chef();
            nuevoChef.Id_Chef = int.Parse(fila["Id_Chef"].ToString());
            nuevoChef.Nombre_Completo = fila["Nombre_Completo"].ToString();
            nuevoChef.Dni = int.Parse(fila["Dni"].ToString());
            nuevoChef.Telefono = int.Parse(fila["Telefono"].ToString());
            nuevoChef.Fecha_Nacimiento = DateTime.Parse(fila["Fecha_Nacimiento"].ToString());
            nuevoChef.Horario_Inicio = DateTime.Parse(fila["Horario_Inicio"].ToString());
            nuevoChef.Horario_Fin = DateTime.Parse(fila["Horario_Fin"].ToString());
            nuevoChef.Id_Sector = int.Parse(fila["Id_Sector"].ToString());

            return nuevoChef;
        }
    }
}
