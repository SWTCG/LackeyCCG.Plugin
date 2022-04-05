using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects.Packs
{
    [XmlType(AnonymousType = true)]
    public class Criteria
    {
        [XmlElement(ElementName = "field")]
        public string Field { get; set; }

        [XmlElement(ElementName = "eval")]
        public string Evaluator { get; set; }

        [XmlElement(ElementName = "data")]
        public string Data { get; set; }
    }
}
