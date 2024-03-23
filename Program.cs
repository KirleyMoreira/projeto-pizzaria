using PizzariaCSarp.Controller;
using PizzariaCSarp.Models;
using PizzariaCSarp.Repository;

Console.WriteLine(" Simulnado API. ");
Console.WriteLine();
Console.WriteLine("*******************************");
Console.WriteLine("******* Pizzaria CSharp *******");
Console.WriteLine("*******************************");
Console.WriteLine();

// Criando os controllers
var controllerBebida = new BebidaController(new BebidaRepository());
var controllerSabor = new SaborController(SaborRepository());

SaborRepository SaborRepository()
{
    throw new NotImplementedException();
}

var controllerPizza = new PizzaController(PizzaRepository());

PizzaRepository PizzaRepository()
{
    throw new NotImplementedException();
}

var contrllerCliente = new ClienteController(ClienteRepository());

ClienteRepository ClienteRepository()
{
    throw new NotImplementedException();
}

var controllerPedido = new PedidoController(PedidoRepository());

PedidoRepository PedidoRepository()
{
    throw new NotImplementedException();
}

// Simulando a API

//1º Cadastrar duas bebidas
var bebida1 = controllerBebida.Adicionar(new Bebida("Coca cola 2lt", 10.0));
var bebida2 = controllerBebida.Adicionar(new Bebida("Iti lemoneto 2lt", 10.0));


//2º Cadasdrar 4 sabores 
var sabor1 = controllerSabor.Adicionar(new Sabor("4 queijos", ""));
var sabor2 = controllerSabor.Adicionar(new Sabor("Calabresa ", ""));
var sabor3 = controllerSabor.Adicionar(new Sabor("Nordestina", ""));
var sabor4 = controllerSabor.Adicionar(new Sabor("portuguesa", ""));

//3º Cadastrar clientes
var cliente1 = contrllerCliente.Adicionar(new Cliente(){Nome= "Alice Maria", Telefone="8195552336"});
var cliente2 = contrllerCliente.Adicionar(new Cliente(){Nome= "Serena Muniz", Telefone="8195555456"});

//4º Cadastrar pizzas
var pizza1 = new Pizza(PizzariaCSarp.Enums.ETipoPizza.GIGANTE, PizzariaCSarp.Enums.ETipoBorda.COM_CHEDDAR, 50.0, new List<Sabor>(){sabor1, sabor3});
var pizza2 = new Pizza(PizzariaCSarp.Enums.ETipoPizza.PEQUENA, PizzariaCSarp.Enums.ETipoBorda.COM_GORGONZOLA, 60.0, new List<Sabor>(){sabor1, sabor4});
var pizza3 = new Pizza(PizzariaCSarp.Enums.ETipoPizza.MEDIA, PizzariaCSarp.Enums.ETipoBorda.COM_MUSSARELA, 40.0, new List<Sabor>(){sabor2, sabor3});
var pizza4 = new Pizza(PizzariaCSarp.Enums.ETipoPizza.SUPER_GIGANTE, PizzariaCSarp.Enums.ETipoBorda.COM_CHEDDAR, 70.0, new List<Sabor>(){sabor2, sabor4});

// Cadastar pedido
var pedido1 = new Pedido(cliente1);
var valor = pedido1
    .AdicionarBebida(bebida1)
    .AdicionarBebida(bebida2)
    .AdicinarPizza(pizza1)
    .AdicinarPizza(pizza2)
    .ObterValorTotal();

    pedido1.FinalizarPedido();
    controllerPedido.Adicionar(pedido1);

var pedido2 = new Pedido(cliente2);
var _ = pedido2
    .AdicinarPizza(pizza4)
    .AdicionarBebida(bebida2)
    .ObterValorTotal();

pedido2.FinalizarPedido();
controllerPedido.Adicionar(pedido2);

