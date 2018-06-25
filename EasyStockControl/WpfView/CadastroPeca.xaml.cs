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
    /// Lógica interna para CadastroPeca.xaml
    /// </summary>
    public partial class CadastroPeca : Window
    {
        public CadastroPeca()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            EstoqueController estoqueController = new EstoqueController();

            Estoque estoque = new Estoque();

            //estoque.EstoqueID = txtCodigo.Text;
            //NÃO É NECESSÁRIO CRIAR O ID, POIS O BANCO IRÁ GERAR AUTOMATICAMENTE

            estoque.Referencia = txtReferencia.Text;

            estoque.Descricao = txtDescricao.Text;

            estoque.Preco = txtPreco.Text;

            estoque.Quantidade = txtQuantidade.Text;

            estoqueController.Adicionar(estoque);

            MessageBox.Show("Peça salva com sucesso!");
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            txtReferencia.Text = (" ");
            txtDescricao.Text = (" ");
            txtPreco.Text = (" ");
            txtQuantidade.Text = (" ");

            MessageBox.Show("Campos limpos com sucesso!");
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            EstoqueController estoqueController = new EstoqueController();

            Estoque estoque = new Estoque();

            dtGrideEstoque.ItemsSource = estoqueController.ListarTodos();
        }
    }
}
