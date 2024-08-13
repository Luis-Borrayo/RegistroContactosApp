namespace RegistroContactosApp
{
    partial class Form1
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
            namelbl = new Label();
            numberlbl = new Label();
            emailbl = new Label();
            Limpiar = new Button();
            AgregarContac = new Button();
            TextBoxNombre = new TextBox();
            TextBoxEmail = new TextBox();
            TextBoxTelefono = new TextBox();
            RegistroContac = new ListBox();
            SuspendLayout();
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Sitka Banner", 12F);
            namelbl.Location = new Point(71, 33);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(64, 23);
            namelbl.TabIndex = 0;
            namelbl.Text = "Nombre:";
            // 
            // numberlbl
            // 
            numberlbl.AutoSize = true;
            numberlbl.Font = new Font("Sitka Banner", 12F);
            numberlbl.Location = new Point(400, 36);
            numberlbl.Name = "numberlbl";
            numberlbl.Size = new Size(66, 23);
            numberlbl.TabIndex = 1;
            numberlbl.Text = "Teléfono:";
            // 
            // emailbl
            // 
            emailbl.AutoSize = true;
            emailbl.Font = new Font("Sitka Banner", 12F);
            emailbl.Location = new Point(64, 72);
            emailbl.Name = "emailbl";
            emailbl.Size = new Size(128, 23);
            emailbl.TabIndex = 2;
            emailbl.Text = "Correo Electrónico:";
            // 
            // Limpiar
            // 
            Limpiar.Font = new Font("Sitka Banner", 11.249999F);
            Limpiar.Location = new Point(102, 121);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(124, 29);
            Limpiar.TabIndex = 3;
            Limpiar.Text = "Limpiar Campos";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // AgregarContac
            // 
            AgregarContac.Font = new Font("Sitka Banner", 11.249999F);
            AgregarContac.Location = new Point(435, 121);
            AgregarContac.Name = "AgregarContac";
            AgregarContac.Size = new Size(124, 29);
            AgregarContac.TabIndex = 4;
            AgregarContac.Text = "Agregar Contacto";
            AgregarContac.UseVisualStyleBackColor = true;
            AgregarContac.Click += AgregarContac_Click;
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Location = new Point(141, 36);
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(234, 23);
            TextBoxNombre.TabIndex = 5;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(198, 75);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(311, 23);
            TextBoxEmail.TabIndex = 6;
            // 
            // TextBoxTelefono
            // 
            TextBoxTelefono.Location = new Point(481, 36);
            TextBoxTelefono.Name = "TextBoxTelefono";
            TextBoxTelefono.Size = new Size(100, 23);
            TextBoxTelefono.TabIndex = 7;
            TextBoxTelefono.TextChanged += textBox3_TextChanged;
            // 
            // RegistroContac
            // 
            RegistroContac.FormattingEnabled = true;
            RegistroContac.ItemHeight = 15;
            RegistroContac.Location = new Point(19, 172);
            RegistroContac.Name = "RegistroContac";
            RegistroContac.Size = new Size(613, 184);
            RegistroContac.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 390);
            Controls.Add(RegistroContac);
            Controls.Add(TextBoxTelefono);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxNombre);
            Controls.Add(AgregarContac);
            Controls.Add(Limpiar);
            Controls.Add(emailbl);
            Controls.Add(numberlbl);
            Controls.Add(namelbl);
            Name = "Form1";
            Text = "Agregar Contacto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namelbl;
        private Label numberlbl;
        private Label emailbl;
        private Button Limpiar;
        private Button AgregarContac;
        private TextBox TextBoxNombre;
        private TextBox TextBoxEmail;
        private TextBox TextBoxTelefono;
        private ListBox RegistroContac;
    }
}
