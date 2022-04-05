using System.Xml.Serialization;


[XmlType(AnonymousType = true)]
public class GameZone
{
    [XmlElement(ElementName = "label")] 
    public string Label { get; set; }

    [XmlElement(ElementName = "visibletoowner")]
    public string _visibleToOwner { get; set; }

    [XmlIgnore]
    public bool? VisibleToOwner
    {
        get
        {
            if (string.IsNullOrWhiteSpace(_visibleToOwner))
            {
                return null;
            }
            return _visibleToOwner == "yes";
        }
        set
        {
            if (value == null)
            {
                _visibleToOwner = null;
            }
            else
            {
                _visibleToOwner = (bool)value ? "yes" : "no";
            }
        }
    }

    [XmlElement(ElementName = "visibletoothers")]
    public string _visibleToOthers { get; set; }

    [XmlIgnore]
    public bool? VisibleToOthers
    {
        get
        {
            if (string.IsNullOrWhiteSpace(_visibleToOthers))
            {
                return null;
            }
            return _visibleToOthers == "yes";
        }
        set
        {
            if (value == null)
            {
                _visibleToOthers = null;
            }
            else
            {
                _visibleToOthers = (bool)value ? "yes" : "no";
            }
        }
    }
}