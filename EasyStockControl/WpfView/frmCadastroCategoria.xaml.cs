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
    /// Lógica interna para frmCadastroCategoria.xaml
    /// </summary>
    public partial class frmCadastroCategoria : Window
    {
        public frmCadastroCategoria()
        {
            InitializeComponent();
        }

        private void btnSalvarCategoria_Click(object sender, RoutedEventArgs e)
        {
            CategoriaEstoqueController categoriaEstoqueController = new CategoriaEstoqueController();

            Categoria categoria = new Categoria();

            if (txtDescricaoCategoria.Text == "")
            {
                MessageBox.Show("Descrição não pode estar vazia!");
            }
            else
            {

                categoria.DescricaoCategoria = txtDescricaoCategoria.Text;

                categoria.AtivoCategoria = rbSim.IsChecked.Value;

                categoriaEstoqueController.Adicionar(categoria);

                MessageBox.Show("Categoria incluída com sucesso!");

            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnListarCategoria_Click(object sender, RoutedEventArgs e)
        {
            CategoriaEstoqueController categoriaEstoqueController = new CategoriaEstoqueController();

            //Categoria categoria = new Categoria();

            dtGridCategoria.ItemsSource = categoriaEstoqueController.ListarTodos();
        }
    }
}
