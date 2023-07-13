using Esfe.Store.EN;
using Esfe.StoreBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Esfe.Store.WpfApp
{
    /// <summary>
    /// Lógica de interacción para LoginWPF.xaml
    /// </summary>
    public partial class LoginWPF : Window
    {
        public LoginWPF()
        {
            InitializeComponent();
        }

        private void IniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            string correoElectronico = txtCorreoElectronico.Text;
            string contraseña = txtContraseña.Password;

            // Validar las credenciales ingresadas por el usuario
            if (ValidarCredenciales(correoElectronico, contraseña))
            {
                // Credenciales válidas, abrir la ventana del menú principal
                MenuWPF ventanaMenu = new MenuWPF();
                ventanaMenu.Show();

                // Cerrar la ventana de inicio de sesión
                Window.GetWindow(this)?.Close();
            }
            else
            {
                // Credenciales inválidas, mostrar un mensaje de error al usuario
                MessageBox.Show("Credenciales inválidas. Por favor, inténtalo nuevamente.", "Error de inicio de sesión", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private bool ValidarCredenciales(string correoElectronico, string contraseña)
        {
            // Aquí puedes implementar la lógica para validar las credenciales
            // Utiliza tus métodos de la capa de negocio (BL) para realizar la autenticación
            // Por ejemplo:
            UsuarioEN usuario = UsuarioBL.Login(correoElectronico, contraseña);
            return usuario != null;
        }
    }
}
