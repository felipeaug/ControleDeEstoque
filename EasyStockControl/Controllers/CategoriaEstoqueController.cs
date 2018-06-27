using Controllers.DAL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CategoriaEstoqueController : Base.IBaseController<Categoria>
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(Categoria enity)
        {
            contexto.Categorias.Add(enity);
            contexto.SaveChanges();
        }

        public Categoria BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Categoria> ListarPorDescricao(string descricao)
        {
            throw new NotImplementedException();
        }

        public IList<Categoria> ListarTodos()
        {
            return contexto.Categorias.ToList();
        }
    }
}
