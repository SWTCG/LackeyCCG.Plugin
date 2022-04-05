using System.Xml.Serialization;
// ReSharper disable InconsistentNaming
namespace LackeyCCG.Plugin.Objects.PluginInfo
{
    [XmlType(AnonymousType = true)]
    public class GeneralFunction
    {
        [XmlElement(ElementName = "label")]
        public string Label { get; set; }

        [XmlElement(ElementName = "kind")]
        public string Kind { get; set; }

        [XmlElement(ElementName = "sourceowner")]
        public string SourceOwner { get; set; }

        [XmlElement(ElementName = "sourcegamezone")]
        public string SourceGameZone { get; set; }

        [XmlElement(ElementName = "sourceposition")]
        public string SourcePosition { get; set; }

        [XmlElement(ElementName = "destinationowner")]
        public string DestinationOwner { get; set; }

        [XmlElement(ElementName = "destinationposition")]
        public string DestinationPosition { get; set; }

        [XmlElement(ElementName = "includeasbutton")]
        public string _includeAsButton { get; set; }

        [XmlIgnore]
        public bool? IncludeAsButton
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_includeAsButton))
                {
                    return null;
                }
                return _includeAsButton == "yes";
            }
            set
            {
                if (value == null)
                {
                    _includeAsButton = null;
                }
                else
                {
                    _includeAsButton = (bool)value ? "yes" : "no";
                }
            }
        }

        [XmlElement(ElementName = "sourcezone")]
        public string SourceZone { get; set; }

        [XmlElement(ElementName = "destinationgamezone")]
        public string DestinationGameZone { get; set; }
    }
}
