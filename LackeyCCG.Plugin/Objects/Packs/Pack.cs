using System;
using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects.Packs
{
    [XmlType(AnonymousType = true)]
    public class Pack
    {
        [XmlElement(ElementName = "packtitle")]
        public string Title {get; set;}

        [XmlElement(ElementName = "packimage")]
        public string Image {get; set;}

        [XmlElement(ElementName = "packkind")]
        public string Kind {get; set;}

        [XmlElement(ElementName = "packformat")]
        public string Format {get; set;}

        [XmlElement(ElementName = "packcommoncrit")]
        public Criteria[] CommonCriteria {get; set;}

        [XmlArray("chance")]
        [XmlArrayItem("kind")]
        public Kind[] Chances {get; set;}
    }
}