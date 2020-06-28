using Haze.Core.Domain.Entities;
using Haze.Core.Domain.ValueObjects;

namespace Haze.Anything.Domain.Entities
{
    public class Fulano : Entity
    {
        public string Nome { get; set; }
        public decimal ValorUnitario { get; set; }
        public bool Ativo { get; set; }
        public Documento Documento { get; set; }
    }
}