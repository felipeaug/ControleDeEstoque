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

        private void btnBuscarPorDescricao(object sender, RoutedEventArgs e)
        {
            if (txtBuscaPorDescricao == null)
            {
            MessageBox.Show("Não existe peça cadastrada");
            }
            else
            {
            MessageBox.Show("Achamos!");
            EstoqueController estoqueController = new EstoqueController();
            Estoque estoque = new Estoque();
                    dtGrideEstoque.ItemsSource = new List<Estoque>();
                    dtGrideEstoque.ItemsSource = estoqueController.ListarPorDescricao(txtBuscaPorDescricao.Text);
                }
        }
    }
}
