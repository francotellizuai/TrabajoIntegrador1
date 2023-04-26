using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPINTEGRADOR1
{
    public partial class uaiForm : Form
    {
        public ListaAlumno alumnos = new ListaAlumno();
        BindingSource bindingSource = new BindingSource();

        public uaiForm()
        {
            InitializeComponent();
        }

        private void uaiForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            borrarInformacionUsuario();

            viewAlumnos.CellClick += ViewAlumnos_CellClick;
            viewAlumnos.DataSource = bindingSource;
            viewAlumnos.AutoGenerateColumns = true;
            viewAlumnos.ReadOnly = true;
            RefreshViewAlumnos();
        }

        private void agregarAlumno_Click(object sender, EventArgs e)
        {
            FormAgregarAlumno formAgregarAlumno = new FormAgregarAlumno(this,alumnos);
            formAgregarAlumno.Show();
            RefreshViewAlumnos();
        }

        public void RefreshViewAlumnos()
        {
            viewAlumnos.DataSource = null;
            if (alumnos.Alumnos.Count > 0)
            {
                bindingSource.DataSource = alumnos.Alumnos;
                viewAlumnos.DataSource = bindingSource;
                viewAlumnos.Columns[3].Visible = false;
                viewAlumnos.Columns[4].Visible = false;
                viewAlumnos.Columns[6].Visible = false;

                viewAlumnos.Columns[0].Width = 100;

                borrarInformacionUsuario();

            }

        }

        private void borrarAlumno_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = viewAlumnos.CurrentRow;
            if (filaSeleccionada != null)
            {
                string legajo = filaSeleccionada.Cells[0].Value.ToString();
                FormConfirmacion formConfirmacion = new FormConfirmacion("¿Seguro de borrar el alumno " + legajo + "?");
                if (formConfirmacion.ShowDialog() == DialogResult.Yes)
                {
                    alumnos.Alumnos.RemoveAll(objeto => objeto.Legajo == Int32.Parse(legajo));
                    borrarInformacionUsuario();
                    RefreshViewAlumnos();
                }
            }
        }

        private void actualizarAlumno_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = viewAlumnos.CurrentRow;
            if (filaSeleccionada != null)
            {
                string legajo = filaSeleccionada.Cells[0].Value.ToString();
                Alumno alumno = alumnos.Alumnos.Find(a => a.Legajo == Int32.Parse(legajo));

                FormAgregarAlumno formAgregarAlumno = new FormAgregarAlumno(this,alumno);
                formAgregarAlumno.Show();
            }
        }

        private void ViewAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = viewAlumnos.CurrentRow;
            string legajo = filaSeleccionada.Cells[0].Value.ToString();
            Alumno alumno = alumnos.Alumnos.Find(a => a.Legajo == Int32.Parse(legajo));
            if (!legajo.Equals("0"))
            {
                antiguedadText.Text = "Antiguedad en años: " + alumno.GetAntiguedad(DateTime.Now).ToString();
                materiasNoAprobadasText.Text = "Materias no aprobadas: " + alumno.GetMateriasNoAprobadas();
                edadText.Text = "Edad: " + alumno.GetEdad(); ;

            }
            else
            {
                antiguedadText.Text = "";
                materiasNoAprobadasText.Text = "";
                edadText.Text = "";
            }
        }

        private void borrarInformacionUsuario()
        {
            antiguedadText.Text = "";
            materiasNoAprobadasText.Text = "";
            edadText.Text = "";
        }
    }
}