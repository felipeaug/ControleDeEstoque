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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfView
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, RoutedEventArgs e)
        {
            CadastroPeca cadastroPeca = new CadastroPeca();
            cadastroPeca.ShowDialog();
        }

        private void btnVisualizar_Click(object sender, RoutedEventArgs e)
        {
            frmVisualizarEstoque visualizarEstoque = new frmVisualizarEstoque();
            visualizarEstoque.ShowDialog();
        }

        private void btnConfiguracoes_Click(object sender, RoutedEventArgs e)
        {
            frmConfiguracoes configuracoes = new frmConfiguracoes();
            configuracoes.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MessageBox.Show("Tchau!");
        }
    }
}
