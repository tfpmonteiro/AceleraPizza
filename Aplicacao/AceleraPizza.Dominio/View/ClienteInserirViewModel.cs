using System;

namespace AceleraPizza.Dominio.View
{
    public class ClienteInserirViewModel
    {
        public string Nome { get; set; } = "Talita Monteiro";
        public string Cpf { get; set; } = "070.192.189-70";
        public string Telefone { get; set; } = "44999817196";
        public DateTime DataNascimento { get; set; } = new DateTime(1989, 07, 09);
        public string Endereco { get; set; } = "Rua Maringá";
    }
}
