using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
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
        private TimeOnly Horario;
        private int Id_Sector;

        public int id_chef { get { return Id_Chef; } private set { } }
        public string nombre_completo { get { return Nombre_Completo; } set { Nombre_Completo = value; } }
        public int dni { get { return Dni; } set { Dni = value; } }
        public int telefono { get { return Telefono; } set { Telefono = value; } }
        public DateTime fecha_nacimiento { get { return Fecha_Nacimiento; } set { Fecha_Nacimiento = value; } }
        public TimeOnly horario { get { return Horario; } set { Horario = value; } }
        public int id_sector { get { return Id_Sector; } private set { } }

        public void Insertar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "INSERT INTO Chef (Nombre_Completo, Dni, Telefono, Fecha_Nacimiento, Horario, Id_Sector) VALUES (@Nombre_Completo, @Dni, @Telefono, @Fecha_Nacimiento, @Horario, @Id_Sector)";
            parametros.Add(new SqliteParameter("@Nombre_Completo", Nombre_Completo));
            parametros.Add(new SqliteParameter("@Dni", Dni));
            parametros.Add(new SqliteParameter("@Telefono",Telefono ));
            parametros.Add(new SqliteParameter("@Fecha_Nacimiento", Fecha_Nacimiento));
            parametros.Add(new SqliteParameter("@Horario", Horario));
            parametros.Add(new SqliteParameter("@Id_Sector", Id_Sector));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public void Actualizar()
        {
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            string consulta = "UPDATE Chef SET Nombre_Completo=@Nombre_Completo,Dni=@Dni,Telefono=@Telefono, Fecha_Nacimiento=@Fecha_Nacimiento, Horario= @Horario, Id_Sector= @Id_Sector WHERE Id_Chef = @Id_Chef";
            parametros.Add(new SqliteParameter("@Nombre", Nombre));
            parametros.Add(new SqliteParameter("@Descripcion", Descripcion));
            parametros.Add(new SqliteParameter("@Alcoholica", Alcoholica));
            parametros.Add(new SqliteParameter("@Precio", Precio));
            parametros.Add(new SqliteParameter("@Id_Bebida", Id_Bebida));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public void Eliminar
    }
}
