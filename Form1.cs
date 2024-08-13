namespace RegistroContactosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarContac_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(TextBoxTelefono.Text) ||
                string.IsNullOrWhiteSpace(TextBoxEmail.Text))
            {
                MessageBox.Show("Completar formulario. Las casillas se encuentran vacías.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                string listadoforms = $"Nombre: {TextBoxNombre.Text} | Teléfono: {TextBoxTelefono.Text} | Correo Electrónico: {TextBoxEmail.Text}";
                RegistroContac.Items.Add(listadoforms);

                MessageBox.Show("Información guardada con exito.",
                    "Contacto Registrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            TextBoxNombre.Clear();
            TextBoxTelefono.Clear();
            TextBoxEmail.Clear();
        }
    }
}
