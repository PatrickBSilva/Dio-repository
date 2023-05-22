using System;
using System.Collections.Generic;
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

//Tipo de Suíte
Console.WriteLine("Por favor Digite o tipo de suíte (Premium ou Padrão):");
string tipoSuite = Console.ReadLine();

// Cria a suíte
Suite suite = new Suite();

// Cria uma nova reserva, passando a suíte e os hóspedes

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite, tipoSuite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da Diária: {reserva.CalcularDiaria()}");
Console.WriteLine($"Valor total em Reais: {reserva.CalcularValorTotal()} para dias: {reserva.DiasReservados}");
