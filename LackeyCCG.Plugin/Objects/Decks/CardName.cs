using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects.Decks
{
    public class CardName
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlText()]
        public string Value { get; set; }

    }
}
