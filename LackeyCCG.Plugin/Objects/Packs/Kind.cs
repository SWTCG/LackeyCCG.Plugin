using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects.Packs
{
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "kind", DataType = "string", IsNullable = true)]
    public class Kind
    {
        [XmlElement(ElementName = "qty")]
        public int Quantity { get; set; }

        [XmlElement(ElementName = "crit")]
        public Criteria[] Criteria { get; set; }

    }

}
