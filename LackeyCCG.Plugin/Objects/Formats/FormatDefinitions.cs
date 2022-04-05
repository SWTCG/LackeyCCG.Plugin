using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects.Formats
{
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "formatdefinitions", DataType = "string", IsNullable = true)]
    public class FormatDefinitions {
    
        [XmlElement(ElementName = "format")]
        public Format[] Formats;
    }
}