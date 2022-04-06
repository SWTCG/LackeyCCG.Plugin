using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects.Decks
{
    [XmlType(AnonymousType = true)]
    public class SuperZone
    {
        [XmlElement("card")]
        public DeckCard[] Cards { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
