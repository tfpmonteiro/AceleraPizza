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

        public Cliente(string nome, string cpf, string telefone, DateTime dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            DataNascimento = dataNascimento;
        }

        public Cliente(string nome, string cpf, string telefone, DateTime dataNascimento, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            Endereco = endereco;
        }

        public Cliente()
        {

        }
    }
}
