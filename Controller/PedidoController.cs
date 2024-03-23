using PizzariaCSarp.Controller.Interfaces;
using PizzariaCSarp.Models;
using PizzariaCSarp.Repository;

namespace PizzariaCSarp.Controller
{
    public class PedidoController : ICrudController<Pedido>
    {
        private PedidoRepository _repositoryPedido;

        public PedidoController(PedidoRepository repositoryPedido)
        {
            _repositoryPedido = repositoryPedido;
        }

        public List<Pedido> ObterTodos()
        {
            return _repositoryPedido.ObterTodos();
        }

        public Pedido Obter(int id)
        {
            return _repositoryPedido.Obter(id);
        }

        public Pedido Adicionar(Pedido pedido)
        {
            return _repositoryPedido.Adicionar(pedido);
        }

        public void Deletar(int id)
        {
            _repositoryPedido.Deletar(id);
        }

        public Pedido Atualizar(int id, Pedido pedido)
        {
            pedido.Id = id;
            return _repositoryPedido.Atualizar(pedido);
        }


    }

   
}