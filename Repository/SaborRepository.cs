using PizzariaCSarp.Models;
using PizzariaCSarp.Repository.Interfaces;

namespace PizzariaCSarp.Repository
{
    public class SaborRepository : ICrudRrpository<Sabor>
    {
        private  List<Sabor> _sabores;
        private int _ultimoId = 0;
        public SaborRepository()
        {
            _sabores = new List<Sabor>();
        }
        public Sabor Adicionar(Sabor sabor)
        {
            _ultimoId++;
            sabor.Id = _ultimoId;

            _sabores.Add(sabor);
            
            return sabor;
        }
        public List<Sabor> ObterTodos()
        {
             return _sabores;
        }
        
        public Sabor Obter(int id)
        {
            return _sabores
                .Where(t => t.Id == t.Id)
                .FirstOrDefault();
                
        }

        public Sabor Atualizar(Sabor sabor)
        {
            var saborEncontrado
             = _sabores.Where(b => b.Id == sabor.Id).FirstOrDefault();

            if(saborEncontrado
             == null) throw new Exception("Não é possível atualizar um sabor que não existe. ");

            _sabores.Remove(saborEncontrado );
            _sabores.Add(sabor);
            return sabor;
        }

        public void Deletar(int id)
        {
            var sabor = Obter(id);
            if(sabor == null) throw new Exception("Não é possivel Remover um sabor que não existe. ");
            _sabores.Remove(sabor);
        }
    }


}