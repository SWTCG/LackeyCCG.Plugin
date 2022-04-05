using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects.PluginInfo
{
    [XmlTypeAttribute(AnonymousType = true)]
    public class PlayerStat
    {
        [XmlElement(ElementName = "label")]
        public string Label { get; set; }
    }
}
