using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects.Formats
{
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "format", DataType = "string", IsNullable = true)]
    public class Format {
    
        [XmlElement(ElementName = "label")]
        public string Label {get; set;}
    
        [XmlElement(ElementName = "set")]
        public string[] Sets {get; set;}
    }
}