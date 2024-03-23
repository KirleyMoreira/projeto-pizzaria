using PizzariaCSarp.Models;
using PizzariaCSarp.Repository.Interfaces;


namespace PizzariaCSarp.Repository
{
    public class PedidoRepository : ICrudRrpository<Pedido>
    {
        private  List<Pedido> _pedidos;
        private int _ultimoId = 0;
        public PedidoRepository()
        {
            _pedidos = new List<Pedido>();
        }
        public Pedido Adicionar(Pedido pedido)
        {
            _ultimoId++;
            pedido.Id = _ultimoId;

            _pedidos.Add(pedido);
            
            return pedido;
        }
        public List<Pedido> ObterTodos()
        {
             return _pedidos;
        }
        
        public Pedido Obter(int id)
        {
            return _pedidos
                .Where(t => t.Id == t.Id)
                .FirstOrDefault();
                
        }

        public Pedido Atualizar(Pedido pedido)
        {
            var pizzaEncontrada = _pedidos.Where(b => b.Id == pedido.Id).FirstOrDefault();

            if(pizzaEncontrada == null) throw new Exception("Não é possível atualizar um pedido que não existe. ");

            _pedidos.Remove(pizzaEncontrada);
            _pedidos.Add(pedido);
            return pedido;
        }

        public void Deletar(int id)
        {
            var pedido = Obter(id);
            if(pedido == null) throw new Exception("Não é possivel Remover um pedido que não existe. ");
            _pedidos.Remove(pedido);
        }
    }


}