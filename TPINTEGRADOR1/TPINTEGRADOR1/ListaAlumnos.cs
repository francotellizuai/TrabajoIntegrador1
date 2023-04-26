using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPINTEGRADOR1
{
    public class ListaAlumno
    {
        private List<Alumno> alumnos;

        public ListaAlumno()
        {
            alumnos = new List<Alumno>();
        }

        public List<Alumno> Alumnos
        {
            get { return alumnos; }
        }

        public bool Agregar(Alumno alumno)
        {
            bool creadoExitosamente = false;
            var alumnoExiste = alumnos.FirstOrDefault(alumnoExistente => alumnoExistente.Legajo == alumno.Legajo);
            if(alumnoExiste == null)
            {
                alumnos.Add(alumno);
                creadoExitosamente = true;
            }
            return creadoExitosamente;
        }



        public bool Borrar(int legajo)
        {
            bool borradoCorrectamente = false;
            var alumnoExiste = alumnos.FirstOrDefault(alumnoExistente => alumnoExistente.Legajo == legajo);
            if(alumnoExiste == null)
            {
                alumnos.RemoveAll(objeto => objeto.Legajo == legajo);
                borradoCorrectamente = true;
            }
            return borradoCorrectamente;
        }
        



    }
}
