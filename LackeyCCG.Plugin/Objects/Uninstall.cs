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
        public string _date;

        [XmlIgnore]
        public DateTime Date {
            get {
                CultureInfo provider = CultureInfo.InvariantCulture;

                return DateTime.ParseExact(this._date, "yyMMdd", provider);
            }
            set => this._date = value.ToString("yyMMdd");
        }

        [XmlElement(ElementName = "removepath")]
        public string[] Path { get; set; }
    }
}


