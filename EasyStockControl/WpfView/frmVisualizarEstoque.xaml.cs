using Controllers;
using Modelos;
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
    /// Lógica interna para frmVisualizarEstoque.xaml
    /// </summary>
    public partial class frmVisualizarEstoque : Window
    {
        public frmVisualizarEstoque()
        {
            InitializeComponent();
        }

        private void Button_ClickCancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dtGrideEstoque_Initialized(object sender, EventArgs e)
        {
            EstoqueController estoqueController = new EstoqueController();

            Estoque estoque = new Estoque();

            dtGrideEstoque.ItemsSource = estoqueController.ListarTodos();
        }

        private void btnBuscarPorId(object sender, RoutedEventArgs e)
        {
            EstoqueController estoqueController = new EstoqueController();

            Estoque estoque = new Estoque();

            ///var buscarPorId = Convert.ToInt32
            //estoqueController.Excluir();

            //var itemExcluido = Convert.ToInt32(IdPrencheTela.Text);
            //estoqueController.Excluir(itemExcluido);
            //MessageBox.Show("Peça excluída com sucesso");
        }
    }
}
