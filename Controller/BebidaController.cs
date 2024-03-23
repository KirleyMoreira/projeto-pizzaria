using PizzariaCSarp.Controller.Interfaces;
using PizzariaCSarp.Models;
using PizzariaCSarp.Repository;

namespace PizzariaCSarp.Controller
{
    public class BebidaController : ICrudController<Bebida>
    {
        private BebidaRepository _repositoryBebida;

        public BebidaController(BebidaRepository repositoryBebida)
        {
            _repositoryBebida = repositoryBebida;
        }

        public List<Bebida> ObterTodos()
        {
            return _repositoryBebida.ObterTodos();
        }

        public Bebida Obter(int id)
        {
            return _repositoryBebida.Obter(id);
        }

        public Bebida Adicionar(Bebida bebida)
        {
            return _repositoryBebida.Adicionar(bebida);
        }

        public void Deletar(int id)
        {
            _repositoryBebida.Deletar(id);
        }

        public Bebida Atualizar(int id, Bebida bebida)
        {
            bebida.Id = id;
            return _repositoryBebida.Atualizar(bebida);
        }


    }

   
}