using Liquid.Repository;
using System;

namespace BlogProjetoFinal.Domain.Entities
{
    public class ArtigoEntity : LiquidEntity<int>
    {
        public string Name { get; set; }
    }
}
