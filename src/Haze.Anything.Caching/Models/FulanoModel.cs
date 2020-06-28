using Haze.Core.Caching.Models;
using Haze.Core.Domain.ValueObjects;
using System.Reflection.Metadata;

namespace Haze.Anything.Caching.Models
{
    public class FulanoModel : Model
    {
        public string Nome { get; set; }
        public decimal ValorUnitario { get; set; }
        public bool Ativo { get; set; }
        public Documento Documento { get; set; }
    }
}