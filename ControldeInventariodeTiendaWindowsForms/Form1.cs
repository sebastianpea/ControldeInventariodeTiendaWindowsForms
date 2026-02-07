namespace ControldeInventariodeTiendaWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text.Trim();
            var password = txtPassword.Text;

            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Por favor ingrese su correo electrónico.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor ingrese su contraseña.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Usar el sistema de datos para autenticar cualquier usuario registrado
            var empleado = SistemaBasedeDatos.Instancia.ObtenerEmpleadoPorCorreoYContraseña(email, password);
            if (empleado != null)
            {
                SistemaBasedeDatos.Instancia.UsuarioActual = empleado;
                string tipo = empleado is EmpleadoAdministrador ? "Administrador" : "Empleado";
                MessageBox.Show($"Bienvenido, {empleado.Nombre}!\nTipo de usuario: {tipo}", "Login exitoso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.\n\nUsuario de prueba:\nCorreo: endmin@gmail.com\nContraseña: endmin123",
                    "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuración inicial del formulario
            txtEmail.Focus();
        }
    }
}
