using PizzariaCSarp.Controller.Interfaces;
using PizzariaCSarp.Models;
using PizzariaCSarp.Repository;

namespace PizzariaCSarp.Controller
{
    public class PizzaController : ICrudController<Pizza>
    {
        private PizzaRepository _repositoryPizza;

        public PizzaController(PizzaRepository repositoryPizza)
        {
            _repositoryPizza = repositoryPizza;
        }

        public List<Pizza> ObterTodos()
        {
            return _repositoryPizza.ObterTodos();
        }

        public Pizza Obter(int id)
        {
            return _repositoryPizza.Obter(id);
        }

        public Pizza Adicionar(Pizza pizza)
        {
            return _repositoryPizza.Adicionar(pizza);
        }

        public void Deletar(int id)
        {
            _repositoryPizza.Deletar(id);
        }

        public Pizza Atualizar(int id, Pizza pizza)
        {
            pizza.Id = id;
            return _repositoryPizza.Atualizar(pizza);
        }


    }

   
}