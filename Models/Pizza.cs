using PizzariaCSarp.Enums;

namespace PizzariaCSarp.Models
{
    public class Pizza
    {
        public int Id{get;set;}
        public string TipoPizza{get;set;}
        public string TipoBorda{get;set;}
        public List<Sabor> Sabores{get;set;}
        public double Valor{get;set;}
        public Pizza(ETipoPizza tipo, ETipoBorda borda, double valor, List<Sabor> sabores)
        {
           // TipoPizza = tipo;
           // TipoBorda = borda;
            Valor = valor;
            Sabores = sabores;
        }
          
       
    }
}