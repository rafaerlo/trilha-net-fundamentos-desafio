using DesafioFundamentos.configs;
using DesafioFundamentos.menu;
using DesafioFundamentos.Models;
using static DesafioFundamentos.configs.GeneralParams;

Console.OutputEncoding = new GeneralParams().EncodeType;
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                "Digite o preço inicial:");

decimal precoInicial = 0;
decimal precoPorHora = 0;


precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);
Menu menu = new Menu(es);

Console.WriteLine("O programa se encerrou");
