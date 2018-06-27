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

namespace WpfView
{
    /// <summary>
    /// Lógica interna para frmConfiguracoes.xaml
    /// </summary>
    public partial class frmConfiguracoes : Window
    {
        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        private void btnCadastroUsuario_Click(object sender, RoutedEventArgs e)
        {
            frmCadastroUsuario cadastroUsuario = new frmCadastroUsuario();
            cadastroUsuario.ShowDialog();
        }

        private void btnCadastroCategoria_Click(object sender, RoutedEventArgs e)
        {
            frmCadastroCategoria cadastroCategoria = new frmCadastroCategoria();
            cadastroCategoria.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
