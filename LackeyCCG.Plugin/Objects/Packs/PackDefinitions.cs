using System;
using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects.Packs
{
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "packdefinitions", DataType = "string", IsNullable = true)]
    public class PackDefinitions
    {
        [XmlElement(ElementName = "pack")]
        public Pack[] Packs {get; set;}

        [XmlAttributeAttribute("version")]
        public string Version { get; set; }
    }
}