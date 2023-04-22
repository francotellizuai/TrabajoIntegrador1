using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPINTEGRADOR1
{
    public partial class uaiForm : Form
    {
        public List<Alumno> listaAlumnos = new List<Alumno>();
        BindingSource bindingSource = new BindingSource();

        public uaiForm()
        {
            InitializeComponent();
        }

        private void uaiForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            antiguedadText.Text = "";
            materiasNoAprobadasText.Text = "";
            edadText.Text = "";
            viewAlumnos.CellClick += ViewAlumnos_CellClick;
            viewAlumnos.DataSource = bindingSource;
            viewAlumnos.AutoGenerateColumns = true;
            viewAlumnos.ReadOnly = true;
            refreshViewAlumnos();
        }

        private void agregarAlumno_Click(object sender, EventArgs e)
        {
            FormAgregarAlumno formAgregarAlumno = new FormAgregarAlumno(this);
            formAgregarAlumno.Show();
        }

        private void refreshViewAlumnos()
        {
            viewAlumnos.DataSource = null;
            if (listaAlumnos.Count > 0)
            {
                bindingSource.DataSource = listaAlumnos;
                viewAlumnos.DataSource = bindingSource;
            }

        }

        public void AgregaAlumno(Alumno alumno)
        {
            int index = listaAlumnos.FindIndex(a => a.Legajo == alumno.Legajo);
            if (index != -1)
            {
                FormConfirmacion formConfirmacion = new FormConfirmacion("El alumno con legajo " + alumno.Legajo.ToString() +" ya existe. ¿Desea actualizar sus datos?");
                if (formConfirmacion.ShowDialog() == DialogResult.Yes)
                {
                    listaAlumnos[index] = alumno;
                }
                else
                {
                    FormAgregarAlumno formAgregarAlumno = new FormAgregarAlumno(this, alumno);
                    formAgregarAlumno.Show();
                }
            }
            else
            {
                listaAlumnos.Add(alumno);
            }
            refreshViewAlumnos();
        }

        private void borrarAlumno_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = viewAlumnos.CurrentRow;
            if (filaSeleccionada != null)
             {
                string legajo = filaSeleccionada.Cells[0].Value.ToString();
                FormConfirmacion formConfirmacion = new FormConfirmacion("¿Seguro de borrar el alumno "+ legajo + "?");
                if (formConfirmacion.ShowDialog() == DialogResult.Yes)
                {
                    listaAlumnos.RemoveAll(objeto => objeto.Legajo == Int32.Parse(legajo));
                    refreshViewAlumnos();
                }
             }
        }

        private void actualizarAlumno_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = viewAlumnos.CurrentRow;
            if (filaSeleccionada != null)
            {
                string legajo = filaSeleccionada.Cells[0].Value.ToString();
                Alumno alumno = listaAlumnos.Find(a => a.Legajo == Int32.Parse(legajo));

                FormAgregarAlumno formAgregarAlumno = new FormAgregarAlumno(this, alumno);
                formAgregarAlumno.Show();
            }
        }

        private void ViewAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = viewAlumnos.CurrentRow;
            string legajo = filaSeleccionada.Cells[0].Value.ToString();
            Alumno alumno = listaAlumnos.Find(a => a.Legajo == Int32.Parse(legajo));
            if (!legajo.Equals("0"))
            {
                antiguedadText.Text = "Antiguedad en años: " + alumno.Antiguedad(DateTime.Now).ToString();
                materiasNoAprobadasText.Text = "Materias no aprobadas: " + alumno.MateriasNoAprobadas();
                edadText.Text = "Edad: " + alumno.Edad(); ;

            }
            else
            {
                antiguedadText.Text = "";
                materiasNoAprobadasText.Text = "";
                edadText.Text = "";
            }
        }

    }
}