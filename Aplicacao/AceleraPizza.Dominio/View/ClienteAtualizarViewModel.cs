using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceleraPizza.Dominio.View
{
    public class ClienteAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Endereco { get; set; } = "";
    }
}
