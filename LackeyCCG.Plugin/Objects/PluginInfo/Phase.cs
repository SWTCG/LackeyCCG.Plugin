using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects.PluginInfo
{
    [XmlType(AnonymousType = true)]
    public class Phase
    {
        [XmlElement(ElementName = "label")]
        public string Label { get; set; }
    }
}
