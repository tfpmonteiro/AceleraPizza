using System;
using System.Collections.Generic;

namespace AceleraPizza.Dominio.Model
{
    public abstract class EntidadeDominio
    {
        public Guid Id { get; set; }
        private List<string> _erros = new List<string>();

        public void GerarId()
        {
            Id = Guid.NewGuid();
        }

        public List<string> GetErros()
        {
            return _erros;
        }

        public void AdicionarErro(string erro)
        {
            bool existe = false;

            foreach (string error in _erros)
            {
                if(error == erro)
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
                _erros.Add(erro);
        }

        public bool Valido()
        {
            return _erros.Count == 0;
        }
    }
}
