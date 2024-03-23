using PizzariaCSarp.Models;
using PizzariaCSarp.Repository.Interfaces;

namespace PizzariaCSarp.Repository
{
    public class ClienteRepository : ICrudRrpository<Cliente>
    {
        public ClienteRepository()
        {
        }

        public Cliente Adicionar(Cliente modelo)
        {
            throw new NotImplementedException();
        }

        public Cliente Atualizar(Cliente id)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente Obter(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}