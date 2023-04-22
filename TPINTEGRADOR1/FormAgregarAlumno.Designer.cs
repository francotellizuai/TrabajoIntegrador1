namespace TPINTEGRADOR1
{
    partial class FormAgregarAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            legajoText = new TextBox();
            nombreText = new TextBox();
            label3 = new Label();
            apellidoText = new TextBox();
            label4 = new Label();
            fechaNacimientoDate = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            fechaIngresoDate = new DateTimePicker();
            activoCheck = new CheckBox();
            totalMateriasBox = new ComboBox();
            label8 = new Label();
            guardarButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(234, 18);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR ALUMNO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 91);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Legajo:";
            // 
            // legajoText
            // 
            legajoText.Location = new Point(191, 88);
            legajoText.Name = "legajoText";
            legajoText.Size = new Size(312, 23);
            legajoText.TabIndex = 2;
            // 
            // nombreText
            // 
            nombreText.Location = new Point(191, 117);
            nombreText.Name = "nombreText";
            nombreText.Size = new Size(312, 23);
            nombreText.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 120);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // apellidoText
            // 
            apellidoText.Location = new Point(191, 150);
            apellidoText.Name = "apellidoText";
            apellidoText.Size = new Size(312, 23);
            apellidoText.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 153);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 5;
            label4.Text = "Apellido";
            // 
            // fechaNacimientoDate
            // 
            fechaNacimientoDate.Location = new Point(234, 185);
            fechaNacimientoDate.Name = "fechaNacimientoDate";
            fechaNacimientoDate.Size = new Size(269, 23);
            fechaNacimientoDate.TabIndex = 7;
            fechaNacimientoDate.Value = new DateTime(1999, 8, 21, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(114, 191);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 8;
            label5.Text = "Fecha Nacimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(327, 175);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(114, 225);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 10;
            label7.Text = "Fecha Ingreso";
            // 
            // fechaIngresoDate
            // 
            fechaIngresoDate.Location = new Point(234, 219);
            fechaIngresoDate.Name = "fechaIngresoDate";
            fechaIngresoDate.Size = new Size(269, 23);
            fechaIngresoDate.TabIndex = 11;
            // 
            // activoCheck
            // 
            activoCheck.AutoSize = true;
            activoCheck.Location = new Point(443, 306);
            activoCheck.Name = "activoCheck";
            activoCheck.Size = new Size(60, 19);
            activoCheck.TabIndex = 12;
            activoCheck.Text = "Activo";
            activoCheck.UseVisualStyleBackColor = true;
            // 
            // totalMateriasBox
            // 
            totalMateriasBox.FormattingEnabled = true;
            totalMateriasBox.Location = new Point(234, 260);
            totalMateriasBox.Name = "totalMateriasBox";
            totalMateriasBox.Size = new Size(269, 23);
            totalMateriasBox.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(114, 263);
            label8.Name = "label8";
            label8.Size = new Size(112, 15);
            label8.TabIndex = 14;
            label8.Text = "Materias Aprobadas";
            // 
            // guardarButton
            // 
            guardarButton.Location = new Point(352, 342);
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(151, 41);
            guardarButton.TabIndex = 15;
            guardarButton.Text = "GUARDAR";
            guardarButton.UseVisualStyleBackColor = true;
            guardarButton.Click += guardarButton_Click;
            // 
            // FormAgregarAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 408);
            Controls.Add(guardarButton);
            Controls.Add(label8);
            Controls.Add(totalMateriasBox);
            Controls.Add(activoCheck);
            Controls.Add(fechaIngresoDate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(fechaNacimientoDate);
            Controls.Add(apellidoText);
            Controls.Add(label4);
            Controls.Add(nombreText);
            Controls.Add(label3);
            Controls.Add(legajoText);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAgregarAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alumno";
            Load += FormAgregarAlumno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox legajoText;
        private TextBox nombreText;
        private Label label3;
        private TextBox apellidoText;
        private Label label4;
        private DateTimePicker fechaNacimientoDate;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker fechaIngresoDate;
        private CheckBox activoCheck;
        private ComboBox totalMateriasBox;
        private Label label8;
        private Button guardarButton;
    }
}