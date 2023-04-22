namespace TPINTEGRADOR1
{
    partial class uaiForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            agregarAlumno = new Button();
            borrarAlumno = new Button();
            actualizarAlumno = new Button();
            viewAlumnos = new DataGridView();
            label1 = new Label();
            antiguedadText = new Label();
            materiasNoAprobadasText = new Label();
            edadText = new Label();
            ((System.ComponentModel.ISupportInitialize)viewAlumnos).BeginInit();
            SuspendLayout();
            // 
            // agregarAlumno
            // 
            agregarAlumno.Location = new Point(28, 67);
            agregarAlumno.Name = "agregarAlumno";
            agregarAlumno.Size = new Size(201, 59);
            agregarAlumno.TabIndex = 0;
            agregarAlumno.Text = "Agregar Alumno";
            agregarAlumno.UseVisualStyleBackColor = true;
            agregarAlumno.Click += agregarAlumno_Click;
            // 
            // borrarAlumno
            // 
            borrarAlumno.Location = new Point(281, 67);
            borrarAlumno.Name = "borrarAlumno";
            borrarAlumno.Size = new Size(221, 59);
            borrarAlumno.TabIndex = 1;
            borrarAlumno.Text = "Borrar Alumno";
            borrarAlumno.UseVisualStyleBackColor = true;
            borrarAlumno.Click += borrarAlumno_Click;
            // 
            // actualizarAlumno
            // 
            actualizarAlumno.Location = new Point(563, 67);
            actualizarAlumno.Name = "actualizarAlumno";
            actualizarAlumno.Size = new Size(201, 59);
            actualizarAlumno.TabIndex = 2;
            actualizarAlumno.Text = "Actualizar Alumno";
            actualizarAlumno.UseVisualStyleBackColor = true;
            actualizarAlumno.Click += actualizarAlumno_Click;
            // 
            // viewAlumnos
            // 
            viewAlumnos.AllowUserToOrderColumns = true;
            viewAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewAlumnos.EditMode = DataGridViewEditMode.EditOnF2;
            viewAlumnos.Location = new Point(28, 206);
            viewAlumnos.Name = "viewAlumnos";
            viewAlumnos.RowTemplate.Height = 25;
            viewAlumnos.Size = new Size(736, 223);
            viewAlumnos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(311, 20);
            label1.Name = "label1";
            label1.Size = new Size(167, 30);
            label1.TabIndex = 4;
            label1.Text = "UAI | ALUMNOS";
            // 
            // antiguedadText
            // 
            antiguedadText.AutoSize = true;
            antiguedadText.Location = new Point(28, 173);
            antiguedadText.Name = "antiguedadText";
            antiguedadText.Size = new Size(38, 15);
            antiguedadText.TabIndex = 5;
            antiguedadText.Text = "label1";
            // 
            // materiasNoAprobadasText
            // 
            materiasNoAprobadasText.AutoSize = true;
            materiasNoAprobadasText.Location = new Point(281, 173);
            materiasNoAprobadasText.Name = "materiasNoAprobadasText";
            materiasNoAprobadasText.Size = new Size(38, 15);
            materiasNoAprobadasText.TabIndex = 6;
            materiasNoAprobadasText.Text = "label2";
            // 
            // edadText
            // 
            edadText.AutoSize = true;
            edadText.Location = new Point(563, 173);
            edadText.Name = "edadText";
            edadText.Size = new Size(38, 15);
            edadText.TabIndex = 7;
            edadText.Text = "label2";
            // 
            // uaiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(edadText);
            Controls.Add(materiasNoAprobadasText);
            Controls.Add(antiguedadText);
            Controls.Add(label1);
            Controls.Add(viewAlumnos);
            Controls.Add(actualizarAlumno);
            Controls.Add(borrarAlumno);
            Controls.Add(agregarAlumno);
            Name = "uaiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UAI";
            Load += uaiForm_Load;
            ((System.ComponentModel.ISupportInitialize)viewAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button agregarAlumno;
        private Button borrarAlumno;
        private Button actualizarAlumno;
        private DataGridView viewAlumnos;
        private Label label1;
        private Label antiguedadText;
        private Label materiasNoAprobadasText;
        private Label edadText;
    }
}