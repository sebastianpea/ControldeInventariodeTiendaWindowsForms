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

            using (Form1 loginForm = new Form1())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm());
                }
                else
                {
                    MessageBox.Show("Aplicación cerrada.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}