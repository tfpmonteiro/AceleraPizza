using System;

namespace AceleraPizza.Dominio.Model
{
    public abstract class EntidadeDominio
    {
        public Guid Id { get; set; }

        public void GerarId()
        {
            Id = Guid.NewGuid();
        }
    }
}
