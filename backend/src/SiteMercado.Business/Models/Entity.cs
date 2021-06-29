using System;

namespace SiteMercado.Business.Models.Validations.Documentos
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}