using Liquid.Repository;
using System;

namespace BlogProjetoFinal.Domain.Entities
{
    public class ArtigoEntity : LiquidEntity<Guid>
    {
        public string Name { get; set; }
    }
}
