using Liquid.Repository;
using System;

namespace BlogProjetoFinal.Domain.Entities
{
    public class UsuarioEntity : LiquidEntity<Guid>
    {
        public string Name { get; set; }
    }
}
