namespace TPINTEGRADOR1
{
    partial class FormConfirmacion
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
            textQuestion = new Label();
            cancelarButton = new Button();
            aceptarButton = new Button();
            SuspendLayout();
            // 
            // textQuestion
            // 
            textQuestion.AutoSize = true;
            textQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textQuestion.ImageAlign = ContentAlignment.TopCenter;
            textQuestion.Location = new Point(153, 20);
            textQuestion.Name = "textQuestion";
            textQuestion.Padding = new Padding(25, 0, 0, 0);
            textQuestion.Size = new Size(167, 15);
            textQuestion.TabIndex = 0;
            textQuestion.Text = "¿Estas Seguro de borrar?";
            textQuestion.TextAlign = ContentAlignment.TopCenter;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(258, 89);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(147, 36);
            cancelarButton.TabIndex = 1;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(70, 89);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(149, 36);
            aceptarButton.TabIndex = 2;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // FormConfirmacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 153);
            Controls.Add(aceptarButton);
            Controls.Add(cancelarButton);
            Controls.Add(textQuestion);
            Name = "FormConfirmacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmar";
            Load += FormConfirmacion_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textQuestion;
        private Button cancelarButton;
        private Button aceptarButton;
    }
}