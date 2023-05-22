using System;
using System.Collections.Generic;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                 throw new Exception("A capacidade da suíte é menor que o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite, string tipoSuite)
        {
            if (tipoSuite.Equals("Premium", StringComparison.OrdinalIgnoreCase))
            {
                // Configurações para suíte Premium
                suite.Capacidade = 5;
                suite.ValorDiaria = 30;
            }
            else if (tipoSuite.Equals("Padrão", StringComparison.OrdinalIgnoreCase))
            {
                // Configurações para suíte Padrão
                suite.Capacidade = 2;
                suite.ValorDiaria = 10;
            }
            else
            {
                throw new Exception("Tipo de suíte desconhecido.");
            }

            Suite = suite;
            }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return Hospedes.Count;
        }

        public decimal CalcularValorTotal()
        {
            // TODO: Retorna o valor total
            decimal ValorTotal =  DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados>=10)
            {
                ValorTotal *= 0.9m;
            }

            return ValorTotal;
        }

                public decimal CalcularDiaria()
        {
            // TODO: Retorna o valor total
            
             decimal ValorDiaria = Suite.ValorDiaria;
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados>=10)
            {
                ValorDiaria = Suite.ValorDiaria *= 0.9m;
            }

            return ValorDiaria;
        }
    }
}