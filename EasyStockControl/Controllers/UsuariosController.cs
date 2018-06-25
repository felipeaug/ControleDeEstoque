using System.Collections.Generic;
using System.Linq;
using Controllers.Base;
using Controllers.DAL;
using Modelos;

namespace Controllers
{
    public class UsuariosController : IBaseController<Usuario>
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(Usuario enity)
        {
            throw new System.NotImplementedException();
        }

        public Usuario BuscarPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Editar(Usuario entity)
        {
            throw new System.NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Usuario> ListarPorDescricao(string descricao)
        {
            throw new System.NotImplementedException();
        }

        public IList<Usuario> ListarTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}
