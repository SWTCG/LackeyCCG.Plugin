using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects.PluginInfo
{
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "plugin", DataType = "string", IsNullable = true)]
    public class Plugin {

        [XmlElement(ElementName = "pluginversion")]
        public string Version { get; set; }

        [XmlElement(ElementName = "pluginname")]
        public string Name { get; set; }

        [XmlElement(ElementName = "playerstat")]
        public PlayerStat[] PlayerStats { get; set; }

        [XmlElement(ElementName = "deckzone")]
        public DeckZone[] DeckZones { get; set; }

        [XmlElement(ElementName = "gamezone")]
        public GameZone[] GameZones { get; set; }

        [XmlElement(ElementName = "phase")]
        public Phase[] Phases { get; set; }

        [XmlElement(ElementName = "generalfunction")]
        public GeneralFunction[] GeneralFunctions { get; set; }

        [XmlElement(ElementName = "cardfunction")]
        public CardFunction[] CardFunctions { get; set; }

        [XmlElement(ElementName = "definition")]
        public Definition[] Definitions { get; set; }
    }
}
