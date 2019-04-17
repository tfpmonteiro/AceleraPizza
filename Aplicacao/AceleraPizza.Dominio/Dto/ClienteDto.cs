using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Dto
{
    public class ClienteDto : EntidadeDto
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
    }

    public class ClienteDtoReturn
    {
        public ClienteDto Cliente { get; set; }
        public List<string> Erros { get; set; }

        public ClienteDtoReturn(ClienteDto cliente)
        {
            Cliente = cliente;
            Erros = new List<string>();
        }

        public ClienteDtoReturn(List<string> erros)
        {
            Erros = erros;
        }
    }
}
