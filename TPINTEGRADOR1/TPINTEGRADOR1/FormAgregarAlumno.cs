using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPINTEGRADOR1
{
    public partial class FormAgregarAlumno : Form
    {
        private ListaAlumno alumnnos = new ListaAlumno();
        private uaiForm parentForm;

        public FormAgregarAlumno(uaiForm parentForm, ListaAlumno alumnos)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.parentForm = parentForm;
            this.alumnnos = alumnos;

        }

        public FormAgregarAlumno(uaiForm parentForm, Alumno alumno)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            legajoText.Text = alumno.Legajo.ToString();
            legajoText.ReadOnly = true;
            nombreText.Text = alumno.Nombre;
            apellidoText.Text = alumno.Apellido;
            fechaNacimientoDate.Value = alumno.Fecha_Nacimiento;
            fechaIngresoDate.Value = alumno.Fecha_Ingreso;
            if (alumno.Activo)
            {
                activoCheck.Checked = true;
            }
            else
            {
                activoCheck.Checked = false;
            }
            totalMateriasBox.Text = alumno.Cantidad_Materias_Aprobadas.ToString();
            tituloText.Text = "ACTUALIZAR ALUMNO";
        }

        private void FormAgregarAlumno_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            for (int i = 0; i <= 36; i++)
            {
                totalMateriasBox.Items.Add(i);
            }

            totalMateriasBox.Text = "0";
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
          
            if (int.TryParse(legajoText.Text, out int lejago))
            {
                Alumno alumno = new Alumno(lejago, nombreText.Text, apellidoText.Text, DateTime.Parse(fechaNacimientoDate.Text), DateTime.Parse(fechaIngresoDate.Text), activoCheck.Checked, Int32.Parse(totalMateriasBox.Text));
                alumnnos.Agregar(alumno);
                parentForm.RefreshViewAlumnos();
                Close();
            }

        }

    }
}
