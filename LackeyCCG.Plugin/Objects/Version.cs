using System;
using System.Globalization;
using System.Xml.Serialization;

namespace LackeyCCG.Plugin.Objects
{
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "version", DataType = "string", IsNullable = true)]
    public class Version {

        [XmlElement(ElementName = "lastupdateYYMMDD")]
        // ReSharper disable once InconsistentNaming
        public string _lastupdate;

        [XmlElement(ElementName = "versionurl")]
        public string VersionUrl { get; set; }
    
        [XmlElement(ElementName = "updateurl")]
        public string UpdateUrl { get; set; }

        [XmlElement(ElementName = "message")]
        public string Message { get; set; }

        [XmlIgnore]
        public DateTime? LastUpdate
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_lastupdate))
                {
                    return null;
                }
                CultureInfo provider = CultureInfo.InvariantCulture;

                return DateTime.ParseExact(this._lastupdate, "yyMMdd", provider);
            }
            set => this._lastupdate = value?.ToString("yyMMdd");
        }
    }
}
