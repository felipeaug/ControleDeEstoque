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
            btnEditar.Visibility = Visibility.Hidden;
            btnExcluir.Visibility = Visibility.Hidden;
            IdPrencheTela.Visibility = Visibility.Hidden;
            txtPreencheTela.Visibility = Visibility.Hidden;
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

            estoque.CategoriaID = ComboBoxCadastro.SelectedIndex;

            try
            {

                estoqueController.Adicionar(estoque);

                MessageBox.Show("Peça salva com sucesso!");

                dtGrideEstoque.ItemsSource = estoqueController.ListarTodos();

            }
            catch
            {
                MessageBox.Show("Existem campos vazios, favor verificar");
            }
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
            IdPrencheTela.Text = (" ");

            EstoqueController estoqueController = new EstoqueController();

            Estoque estoque = new Estoque();

            dtGrideEstoque.ItemsSource = estoqueController.ListarTodos();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ComboBoxCadastro_Loaded(object sender, RoutedEventArgs e)
        {
            CategoriaEstoqueController categoriaEstoqueController = new CategoriaEstoqueController();

            Categoria categoria = new Categoria();

            ComboBoxCadastro.ItemsSource = categoriaEstoqueController.ListarTodos();

            //ComboBoxCadastro.ItemsSource = Convert.ToString(categoriaEstoqueController.ListarPorDescricao());

        }

        public void Preenche(Estoque a)
        {
            IdPrencheTela.Text = Convert.ToString(a.EstoqueID);
            IdPrencheTela.IsEnabled = false;
            txtDescricao.Text = a.Descricao;
            txtReferencia.Text = a.Referencia;
            txtPreco.Text = a.Preco;
            txtQuantidade.Text = a.Quantidade;
            ComboBoxCadastro.SelectedItem = a.CategoriaID;
            

            btnEditar.Visibility = Visibility.Visible;
            btnExcluir.Visibility = Visibility.Visible;
        }

        private void Button_ClickEditar(object sender, RoutedEventArgs e)
        {
            EstoqueController estoqueController = new EstoqueController();

            Estoque estoque = new Estoque();

            estoque.EstoqueID = Convert.ToInt32(IdPrencheTela.Text);

            estoque.Referencia = txtReferencia.Text;

            estoque.Descricao = txtDescricao.Text;

            estoque.Preco = txtPreco.Text;

            estoque.Quantidade = txtQuantidade.Text;

            estoque.CategoriaID = ComboBoxCadastro.SelectedIndex;

            estoqueController.Editar(estoque);

            MessageBox.Show("Peça editada com sucesso!");
            //dtGrideEstoque.ItemsSource = estoqueController.ListarTodos();

            btnEditar.Visibility = Visibility.Visible;
            IdPrencheTela.Visibility = Visibility.Visible;
            txtPreencheTela.Visibility = Visibility.Visible;

            IdPrencheTela.Text = "";
            txtReferencia.Text = "";
            txtDescricao.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Text = "";
            ComboBoxCadastro.SelectedItem = "";

            
        }

        private void dtGrideEstoque_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EstoqueController estoqueController = new EstoqueController();
            Estoque a = (Estoque)dtGrideEstoque.SelectedItem;

            btnEditar.Visibility = Visibility.Hidden;
            IdPrencheTela.Visibility = Visibility.Visible;
            txtPreencheTela.Visibility = Visibility.Visible;
            Preenche(a);
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            EstoqueController estoqueController = new EstoqueController();

            var itemExcluido = Convert.ToInt32(IdPrencheTela.Text);
            estoqueController.Excluir(itemExcluido);
            MessageBox.Show("Peça excluída com sucesso");
        }

        private void dtGrideEstoque_Initialized(object sender, EventArgs e)
        {
            EstoqueController estoqueController = new EstoqueController();

            Estoque estoque = new Estoque();

            dtGrideEstoque.ItemsSource = estoqueController.ListarTodos();
        }
    }
}
