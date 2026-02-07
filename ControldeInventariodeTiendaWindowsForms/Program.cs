using System;
using System.Windows.Forms;

namespace ControldeInventariodeTiendaWindowsForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Mostrar el formulario de login primero
            using (Form1 loginForm = new Form1())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Si el login fue exitoso, mostrar el formulario principal
                    Application.Run(new MainForm());
                }
                else
                {
                    // Si el login fue cancelado, cerrar la aplicación
                    MessageBox.Show("Aplicación cerrada.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}