using System;
using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects.Packs
{
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "pack", DataType = "string", IsNullable = true)]
    public class Pack
    {
        [XmlElement(ElementName = "packtitle")]
        public string title {get; set;}

        [XmlElement(ElementName = "packimage")]
        public string image {get; set;}

        [XmlElement(ElementName = "packkind")]
        public string kind {get; set;}

        [XmlElement(ElementName = "packformat")]
        public string packformat {get; set;}

        [XmlElement(ElementName = "packcommoncrit")]
        public packdefinitionsPackPackcommoncrit[] packcommoncrit {get; set;}

        //TODO:: MATT - FIND ATTRIBUTE TO REMOVE 'CHANCE' OBJECT DEFINITION AND JUST USE 'KIND' OBJECTS
        [XmlElement(ElementName = "chance")]
        public packdefinitionsPackChanceKind[][] chance {get; set;}
    }
}