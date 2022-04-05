using System.Xml.Serialization;
// ReSharper disable InconsistentNaming

namespace LackeyCCG.Plugin.Objects.PluginInfo
{
    [XmlType(AnonymousType = true)]
    public class DeckZone
    {

        [XmlElement(ElementName = "label")]
        public string Label { get; set; }

        [XmlElement(ElementName = "zonetoloadto")]
        public string ZoneToLoadTo { get; set; }

        [XmlElement(ElementName = "shuffle")]
        public string _shuffle { get; set; }

        [XmlIgnore]
        public bool? Shuffle
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_shuffle))
                {
                    return null;
                }
                return _shuffle == "yes";
            }
            set
            {
                if (value == null)
                {
                    _shuffle = null;
                }
                else
                {
                    _shuffle = (bool)value ? "yes" : "no";
                }
            }
        }

        [XmlElement(ElementName = "gamezonetoloadto")]
        public string GameZoneToLoadTo { get; set; }
    }
}
