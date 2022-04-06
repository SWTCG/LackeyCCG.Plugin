using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects.Decks
{
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "deck", DataType = "string", IsNullable = true)]
    public class Deck
    {
        [XmlArray("meta")]
        [XmlArrayItem("game")]
        public string[] Meta { get; set; }

        [XmlElement("superzone")]
        public SuperZone[] SuperZones { get; set; }

        [XmlAttribute("version")]
        public string Version { get; set; }
    }
}
