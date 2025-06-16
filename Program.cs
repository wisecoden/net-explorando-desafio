using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa guest1 = new Pessoa(nome: "Hóspede 1");
Pessoa guest2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(guest1);
hospedes.Add(guest2);

Suite suite = new Suite(tipoSuite: "Master", capacidade: 2, valorDiaria: 50);

Reserva reserva = new Reserva(diasReservados: 8);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");