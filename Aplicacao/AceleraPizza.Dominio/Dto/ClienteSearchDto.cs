﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceleraPizza.Dominio.Dto
{
    public class ClienteSearchDto
    {
        public Guid id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
}
