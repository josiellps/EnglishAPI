using Domain.Models.Base;

namespace Domain.Models
{
    public class Verbs : BaseEntity
    {                
        public string TranslatedVerb { get; set; }
        public string PastSimple { get; set; }
        public string PastParticiple { get; set; }
        public string Infinitive { get; set; }
    }
}