using PizzariaCSarp.Models;

namespace PizzariaCSarp.Repository.Interfaces
{
    public interface ICrudRrpository<T>
    {
         T Adicionar(T modelo);
       
         List<T> ObterTodos();
       
         T Obter(int id);
                
        T Atualizar(T id);

         void Deletar(int id);
    }
}