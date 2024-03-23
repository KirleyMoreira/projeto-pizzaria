using PizzariaCSarp.Controller.Interfaces;
using PizzariaCSarp.Models;
using PizzariaCSarp.Repository;

namespace PizzariaCSarp.Controller
{
    public class ClienteController : ICrudController<Cliente>
    {
        private ClienteRepository _repositoryCliente;

        public ClienteController(ClienteRepository repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
        }

        public List<Cliente> ObterTodos()
        {
            return _repositoryCliente.ObterTodos();
        }

        public Cliente Obter(int id)
        {
            return _repositoryCliente.Obter(id);
        }

        public Cliente Adicionar(Cliente cliente)
        {
            return _repositoryCliente.Adicionar(cliente);
        }

        public void Deletar(int id)
        {
            _repositoryCliente.Deletar(id);
        }

        public Cliente Atualizar(int id, Cliente cliente)
        {
            cliente.Id = id;
            return _repositoryCliente.Atualizar(cliente);
        }


    }

   
}