using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPINTEGRADOR1
{
    public partial class FormConfirmacion : Form
    {

        private string text;

        public FormConfirmacion()
        {
            InitializeComponent();
        }
        public FormConfirmacion(string text)
        {
            this.text = text;
            InitializeComponent();
        }

        private void FormConfirmacion_Load_1(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            textQuestion.TextAlign = ContentAlignment.MiddleCenter;
            textQuestion.Dock = DockStyle.Fill;
            textQuestion.AutoSize = false;
            textQuestion.Width = 300;

            textQuestion.Text = text;

        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;

        }
    }
}
