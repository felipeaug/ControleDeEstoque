using Controllers.Base;
using Controllers.DAL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class EstoqueController : IBaseController<Estoque>
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(Estoque enity)
        {
            contexto.Estoque.Add(enity);
            contexto.SaveChanges();
        }

        public Estoque BuscarPorId(int id)
        {
            return contexto.Estoque.Find(id);
        }

        public void Editar(Estoque entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            Estoque est = BuscarPorId(id);

            if(est != null)
            {
                contexto.Estoque.Remove(est);

                contexto.SaveChanges();
            }
        }

        public IList<Estoque> ListarPorDescricao(string descricao)
        {
            return contexto.Estoque.Where(est => est.Descricao.Contains(descricao)).ToList();
        }

        public IList<Estoque> ListarTodos()
        {
            return contexto.Estoque.ToList();
        }
    }
}
