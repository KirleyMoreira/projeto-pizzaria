using PizzariaCSarp.Models;
using PizzariaCSarp.Repository.Interfaces;

namespace PizzariaCSarp.Repository
{
    public class BebidaRepository : ICrudRrpository<Bebida>
    {
        private  List<Bebida> _bebidas;
        private int _ultimoId = 0;
        public BebidaRepository()
        {
            _bebidas = new List<Bebida>();
        }
        public Bebida Adicionar(Bebida bebida)
        {
            _ultimoId++;
            bebida.Id = _ultimoId;

            _bebidas.Add(bebida);
            
            return bebida;
        }
        public List<Bebida> ObterTodos()
        {
             return _bebidas;
        }
        
        public Bebida Obter(int id)
        {
            return _bebidas
                .Where(t => t.Id == t.Id)
                .FirstOrDefault();
                
        }

        public Bebida Atualizar(Bebida bebida)
        {
            var bebidaEncontrada = _bebidas.Where(b => b.Id == bebida.Id).FirstOrDefault();

            if(bebidaEncontrada == null) throw new Exception("Não é possível atualizar uma bebida que não existe. ");

            _bebidas.Remove(bebidaEncontrada);
            _bebidas.Add(bebida);
            return bebida;
        }

        public void Deletar(int id)
        {
            var bebida = Obter(id);
            if(bebida == null) throw new Exception("Não é possivel Remover uma bebida que não existe. ");
            _bebidas.Remove(bebida);
        }
    }


}