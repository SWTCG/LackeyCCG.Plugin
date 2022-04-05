using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects.PluginInfo
{
    [XmlType(AnonymousType = true)]
    public class Definition
    {
        [XmlElement(ElementName = "kind")]
        public string Kind { get; set; }
    }
}
