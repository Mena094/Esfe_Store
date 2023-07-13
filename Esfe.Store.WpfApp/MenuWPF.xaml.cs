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
    /// Lógica de interacción para MenuWPF.xaml
    /// </summary>
    public partial class MenuWPF : Window
    {
        public MenuWPF()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this)?.Close();

            // Mostrar la ventana de inicio de sesión nuevamente
            LoginWPF ventanaInicioSesion = new LoginWPF();
            ventanaInicioSesion.Show();
        }
    }
}
