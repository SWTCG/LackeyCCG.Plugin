using System;
using System.Globalization;
using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [XmlRoot(ElementName = "uninstall", DataType = "string", IsNullable = true)]
    public class Uninstall {

        [XmlElement(ElementName = "dateYYMMDD")]
        // ReSharper disable once InconsistentNaming
        public string _dateField;

        [XmlIgnore]
        public DateTime Date {
            get {
                CultureInfo provider = CultureInfo.InvariantCulture;

                return DateTime.ParseExact(this._dateField, "yyMMdd", provider);
            }
            set => this._dateField = value.ToString("yyMMdd");
        }

        [XmlElement(ElementName = "removepath")]
        public string[] Path { get; set; }
    }
}


