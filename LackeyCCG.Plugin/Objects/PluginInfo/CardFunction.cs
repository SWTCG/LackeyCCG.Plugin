using System;
using System.Xml.Serialization;
// ReSharper disable InconsistentNaming
namespace LackeyCCG.Plugin.Objects.PluginInfo
{
    [XmlType(AnonymousType = true)]
    public class CardFunction
    {

        [XmlElement(ElementName = "label")]
        public string Label { get; set; }

        [XmlElement(ElementName = "kind")]
        public string Kind { get; set; }

        [XmlElement(ElementName = "color")]
        public string Color { get; set; }

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

        [XmlElement(ElementName = "PositionX")]
        public string _positionX { get; set; }

        [XmlIgnore]
        public double? PositionX
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_positionX))
                {
                    return null;
                }
                return double.Parse(_positionX);
            }
            set => _positionX = value?.ToString();
        }

        [XmlElement(ElementName = "PositionY")]
        public string _positionY { get; set; }

        [XmlIgnore]
        public double? PositionY
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_positionY))
                {
                    return null;
                }
                return double.Parse(_positionY);
            }
            set => _positionY = value?.ToString();
        }
    }
}
