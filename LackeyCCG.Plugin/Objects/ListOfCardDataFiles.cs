using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects
{
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "listofcarddatafiles", DataType = "string", IsNullable = true)]
    public class CardDataFiles
    {
        [XmlElement(ElementName = "filetoinclude")]
        public string[] Files { get; set; }
    }
}

