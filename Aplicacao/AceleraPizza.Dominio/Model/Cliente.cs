using AceleraPizza.Comum.Helper;
using System;

namespace AceleraPizza.Dominio.Model
{
    public class Cliente : EntidadeDominio
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string cpf, string telefone, DateTime dataNascimento, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Validar();
        }

        private void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                AdicionarErro("Por favor, preencha o campo com o nome do cliente.");

            if (!Cpf.CpfValido())
                AdicionarErro("O CPF informado é inválido.");

            if (DataNascimento < new DateTime(1900, 01, 01).Date)
                AdicionarErro("A Data de Nascimento é inválida");
        }
    }
}
