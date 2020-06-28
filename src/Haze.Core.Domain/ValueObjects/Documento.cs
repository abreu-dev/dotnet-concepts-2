using Haze.Core.Domain.Enums;

namespace Haze.Core.Domain.ValueObjects
{
    public class Documento : ValueObject
    {
        public string Numero { get; set; }
        public EDocumentType Tipo { get; set; }
    }
}
