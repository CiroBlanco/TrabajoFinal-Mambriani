using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace TrabajoFinal_Mambriani
{
    public class Mesero
    {
        private int Id_Mesero;
        private string Nombre_Completo;
        private int Dni;
        private int Telefono;
        private DateTime Fecha_Nacimiento;
        private DateTime Horario_Inicio;
        private DateTime Horario_Fin;
        private int Id_Sector;

        public int id_mesero { get { return Id_Mesero; } private set { } }
        public string nombre_completo { get { return Nombre_Completo; } set { Nombre_Completo = value; } }
        public int dni { get { return Dni; } set { Dni = value; } }
        public int telefono { get { return Telefono; } set { Telefono = value; } }
        public DateTime fecha_nacimiento { get { return Fecha_Nacimiento; } set { Fecha_Nacimiento = value; } }
        public DateTime horario_inicio { get { return Horario_Inicio; } set { Horario_Inicio = value; } }
        public DateTime horario_fin { get { return Horario_Fin; } set { Horario_Fin = value; } }
        public int id_sector { get { return Id_Sector; } set { } }

        public void Insertar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "INSERT INTO Mesero (Nombre_Completo, Dni, Telefono, Fecha_Nacimiento, Horario_Inicio, Horario_Fin, Id_Sector) VALUES (@Nombre_Completo, @Dni, @Telefono, @Fecha_Nacimiento, @Horario_Inicio,@Horario_Fin, @Id_Sector)";
            parametros.Add(new SqliteParameter("@Nombre_Completo", Nombre_Completo));
            parametros.Add(new SqliteParameter("@Dni", Dni));
            parametros.Add(new SqliteParameter("@Telefono", Telefono));
            parametros.Add(new SqliteParameter("@Fecha_Nacimiento", Fecha_Nacimiento));
            parametros.Add(new SqliteParameter("@Horario_Inicio", Horario_Inicio));
            parametros.Add(new SqliteParameter("@Horario_Fin", Horario_Fin));
            parametros.Add(new SqliteParameter("@Id_Sector", Id_Sector));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public void Actualizar()
        {
                List<SqliteParameter> parametros = new List<SqliteParameter>();
                string consulta = "UPDATE Mesero SET Nombre_Completo=@Nombre_Completo,Dni=@Dni,Telefono=@Telefono, Fecha_Nacimiento=@Fecha_Nacimiento, Horario_Inicio= @Horario_Inicio, Horario_Fin= @Horario_Fin, Id_Sector= @Id_Sector WHERE Id_Mesero = @Id_Mesero";
                parametros.Add(new SqliteParameter("@Nombre_Completo", Nombre_Completo));
                parametros.Add(new SqliteParameter("@Dni", Dni));
                parametros.Add(new SqliteParameter("@Telefono", Telefono));
                parametros.Add(new SqliteParameter("@Fecha_Nacimiento", Fecha_Nacimiento));
                parametros.Add(new SqliteParameter("@Horario_Inicio", Horario_Inicio));
                parametros.Add(new SqliteParameter("@Horario_Fin", Horario_Fin));
                parametros.Add(new SqliteParameter("@Id_Sector", Id_Sector));
                parametros.Add(new SqliteParameter("@Id_Chef", Id_Mesero));
                GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public void Eliminar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "DELETE FROM Chefs WHERE Id_Mesero = @Id_Mesero";
            parametros.Add(new SqliteParameter("@Id_Chef", Id_Mesero));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        sdsd
    }
}
