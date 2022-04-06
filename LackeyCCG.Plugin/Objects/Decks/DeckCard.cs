using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects.Decks
{
    [XmlRoot(ElementName = "card", DataType = "string", IsNullable = true)]
    public class DeckCard
    {
        [XmlElement("set")]
        public string Set { get; set; }

        [XmlElement("name")]
        public CardName Name { get; set; }
    }
}
