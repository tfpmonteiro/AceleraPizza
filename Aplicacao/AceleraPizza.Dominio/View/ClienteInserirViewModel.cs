using System;

namespace AceleraPizza.Dominio.View
{
    public class ClienteInserirViewModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
    }
}
