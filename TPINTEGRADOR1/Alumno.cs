using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPINTEGRADOR1
{
    public class Alumno
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private DateTime fecha_nacimiento;
        private DateTime fecha_ingreso;
        private bool activo;
        private int cantidad_materias_aprobadas;

        public Alumno() { }

        public Alumno(int legajo, string nombre, string apellido, DateTime fecha_nacimiento, DateTime fecha_ingreso, bool activo, int cantidad_materias_aprobadas)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha_nacimiento = fecha_nacimiento;
            this.fecha_ingreso = fecha_ingreso; 
            this.activo = activo;
            this.cantidad_materias_aprobadas = cantidad_materias_aprobadas;
        }
        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public DateTime Fecha_Nacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }

        public DateTime Fecha_Ingreso
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public int Cantidad_Materias_Aprobadas
        {
            get { return cantidad_materias_aprobadas; }
            set { cantidad_materias_aprobadas = value; }
        }

        public int Antiguedad(DateTime fecha)
        {
            TimeSpan antiguedad = fecha.Subtract(this.fecha_ingreso);
            return Convert.ToInt32(antiguedad.TotalDays / 365);
        }

        public int MateriasNoAprobadas()
        {
            int materiasNoAprobadas = (int)Materias.TotalMaterias - this.cantidad_materias_aprobadas;
            return materiasNoAprobadas;
        }

        public int Edad()
        {
            TimeSpan edadIngreso = this.fecha_ingreso.Subtract(this.fecha_nacimiento);
            return Convert.ToInt32(edadIngreso.TotalDays / 365);
        }

        ~Alumno() => Console.WriteLine($"El alumno {nombre} {apellido} con legajo {legajo} ha sido liberado.");

    }
}
