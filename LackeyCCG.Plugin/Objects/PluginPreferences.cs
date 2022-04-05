using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;
// ReSharper disable InconsistentNaming

namespace LackeyCCG.Plugin.Objects
{
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName = "pluginpreferences", DataType = "string", IsNullable = true)]
    public class PluginPreferences {

        [XmlElement(ElementName = "lastversionupdate")]
        public string LastVersionUpdate { get; set; }

        [XmlElement(ElementName = "counterstyleimagesizetextoverimage")]
        public int? CounterStyleImageSizeTextOverImage { get; set; }

        [XmlElement(ElementName = "counterstyleimagesizeimagesonly")]
        public int? CounterStyleImageSizeImagesOnly { get; set; }

        [XmlElement(ElementName = "recentskins")]
        public string RecentSkins { get; set; }

        [XmlElement(ElementName = "recenttablebackgrounds")]
        public string RecentTableBackgrounds { get; set; }

        [XmlElement(ElementName = "fontkind0pos0")]
        public string Font0Position0 { get; set; }

        [XmlElement(ElementName = "fontkind0pos1")]
        public string Font0Position1 { get; set; }

        [XmlElement(ElementName = "fontkind1pos0")]
        public string Font1Position0 { get; set; }

        [XmlElement(ElementName = "fontkind1pos1")]
        public string Font1Position1 { get; set; }

        [XmlElement(ElementName = "fontkind2pos0")]
        public string Font2Position0 { get; set; }

        [XmlElement(ElementName = "fontkind2pos1")]
        public string Font2Position1 { get; set; }

        [XmlElement(ElementName = "fontkind3pos0")]
        public string Font3Position0 { get; set; }

        [XmlElement(ElementName = "fontkind3pos1")]
        public string Font3Position1 { get; set; }

        [XmlElement(ElementName = "fontsize0")]
        public int? FontSize0 { get; set; }

        [XmlElement(ElementName = "fontsize1")]
        public int? FontSize1 { get; set; }

        [XmlElement(ElementName = "fontsize2")]
        public int? FontSize2 { get; set; }

        [XmlElement(ElementName = "fontsize3")]
        public int? FontSize3 { get; set; }

        [XmlElement(ElementName = "bindingmain0")]
        public string BindingMain0 { get; set; }

        [XmlElement(ElementName = "bindingmain1")]
        public string BindingMain1 { get; set; }

        [XmlElement(ElementName = "bindingmain2")]
        public string BindingMain2 { get; set; }

        [XmlElement(ElementName = "bindingmain3")]
        public string BindingMain3 { get; set; }

        [XmlElement(ElementName = "bindingmain4")]
        public string BindingMain4 { get; set; }

        [XmlElement(ElementName = "bindingmain5")]
        public string BindingMain5 { get; set; }

        [XmlElement(ElementName = "bindingmain6")]
        public string BindingMain6 { get; set; }

        [XmlElement(ElementName = "bindingmain7")]
        public string BindingMain7 { get; set; }

        [XmlElement(ElementName = "bindingmain8")]
        public string BindingMain8 { get; set; }

        [XmlElement(ElementName = "bindingmain9")]
        public string BindingMain9 { get; set; }

        [XmlElement(ElementName = "bindingmain10")]
        public string BindingMain10 { get; set; }

        [XmlElement(ElementName = "bindingmain11")]
        public string BindingMain11 { get; set; }

        [XmlElement(ElementName = "bindingmain12")]
        public string BindingMain12 { get; set; }

        [XmlElement(ElementName = "bindingmain13")]
        public string BindingMain13 { get; set; }

        [XmlElement(ElementName = "bindingmain14")]
        public string BindingMain14 { get; set; }

        [XmlElement(ElementName = "bindingmain15")]
        public string BindingMain15 { get; set; }

        [XmlElement(ElementName = "bindingmain16")]
        public string BindingMain16 { get; set; }

        [XmlElement(ElementName = "bindingmain17")]
        public string BindingMain17 { get; set; }

        [XmlElement(ElementName = "bindingmain18")]
        public string BindingMain18 { get; set; }

        [XmlElement(ElementName = "bindinggeneral0")]
        public string BindingGeneral0 { get; set; }

        [XmlElement(ElementName = "bindinggeneral1")]
        public string BindingGeneral1 { get; set; }

        [XmlElement(ElementName = "bindinggeneral2")]
        public string BindingGeneral2 { get; set; }

        [XmlElement(ElementName = "bindinggeneral3")]
        public string BindingGeneral3 { get; set; }

        [XmlElement(ElementName = "bindinggeneral4")]
        public string BindingGeneral4 { get; set; }

        [XmlElement(ElementName = "bindinggeneral5")]
        public string BindingGeneral5 { get; set; }

        [XmlElement(ElementName = "bindinggeneral6")]
        public string BindingGeneral6 { get; set; }

        [XmlElement(ElementName = "bindinggeneral7")]
        public string BindingGeneral7 { get; set; }

        [XmlElement(ElementName = "bindinggeneral8")]
        public string BindingGeneral8 { get; set; }

        [XmlElement(ElementName = "bindinggeneral9")]
        public string BindingGeneral9 { get; set; }

        [XmlElement(ElementName = "bindinggeneral10")]
        public string BindingGeneral10 { get; set; }

        [XmlElement(ElementName = "bindinggeneral11")]
        public string BindingGeneral11 { get; set; }

        [XmlElement(ElementName = "bindinggeneral12")]
        public string BindingGeneral12 { get; set; }

        [XmlElement(ElementName = "bindinggeneral13")]
        public string BindingGeneral13 { get; set; }

        [XmlElement(ElementName = "bindingcard0")]
        public string BindingCard0 { get; set; }

        [XmlElement(ElementName = "bindingcard1")]
        public string BindingCard1 { get; set; }

        [XmlElement(ElementName = "bindingcard2")]
        public string BindingCard2 { get; set; }

        [XmlElement(ElementName = "bindingcard3")]
        public string BindingCard3 { get; set; }

        [XmlElement(ElementName = "bindingcard4")]
        public string BindingCard4 { get; set; }

        [XmlElement(ElementName = "bindingcard5")]
        public string BindingCard5 { get; set; }

        [XmlElement(ElementName = "bindingcard6")]
        public string BindingCard6 { get; set; }

        [XmlElement(ElementName = "bindingcard7")]
        public string BindingCard7 { get; set; }

        [XmlElement(ElementName = "bindingcard8")]
        public string BindingCard8 { get; set; }

        [XmlElement(ElementName = "bindingcard9")]
        public string BindingCard9 { get; set; }

        [XmlElement(ElementName = "bindingcard10")]
        public string BindingCard10 { get; set; }

        [XmlElement(ElementName = "bindingcard11")]
        public string BindingCard11 { get; set; }

        [XmlElement(ElementName = "bindingcanned0")]
        public string BindingCanned0 { get; set; }

        [XmlElement(ElementName = "bindingcanned1")]
        public string BindingCanned1 { get; set; }

        [XmlElement(ElementName = "bindingcanned2")]
        public string BindingCanned2 { get; set; }

        [XmlElement(ElementName = "bindingcanned3")]
        public string BindingCanned3 { get; set; }

        [XmlElement(ElementName = "bindingcanned4")]
        public string BindingCanned4 { get; set; }

        [XmlElement(ElementName = "bindingcanned5")]
        public string BindingCanned5 { get; set; }

        [XmlElement(ElementName = "bindingcanned6")]
        public string BindingCanned6 { get; set; }

        [XmlElement(ElementName = "bindingcanned7")]
        public string BindingCanned7 { get; set; }

        [XmlElement(ElementName = "bindingcanned8")]
        public string BindingCanned8 { get; set; }

        [XmlElement(ElementName = "bindingcanned9")]
        public string BindingCanned9 { get; set; }

        [XmlElement(ElementName = "libraryignoredoubles")]
        public int? _libraryIgnoreDoubles { get; set; }

        [XmlIgnore]
        public bool? LibraryIgnoreDoubles
        {
            get
            {
                if (_libraryIgnoreDoubles == null)
                {
                    return null;
                }
                return _libraryIgnoreDoubles == 1;
            }
            set
            {
                if (value == null)
                {
                    _libraryIgnoreDoubles = null;
                }else{
                    _libraryIgnoreDoubles = (bool)value ? 1 : 0;
                }
                
            }

            
        }

        [XmlElement(ElementName = "filterkeystroke")]
        public int? _filterKeyStroke { get; set; }

        [XmlIgnore]
        public bool? FilterKeyStroke
        {
            get
            {
                if (_filterKeyStroke == null)
                {
                    return null;
                }
                return _filterKeyStroke == 1;
            }
            set
            {
                if (value == null)
                {
                    _filterKeyStroke = null;
                }
                else
                {
                    _filterKeyStroke = (bool)value ? 1 : 0;
                }

            }
        }

        [XmlElement(ElementName = "deckeditorloadtozoneiscollapse")]
        public int? _deckEditorLoadToZoneIsCollapse { get; set; }

        [XmlIgnore]
        public bool? DeckEditorLoadToZoneIsCollapse
        {
            get
            {
                if (_deckEditorLoadToZoneIsCollapse == null)
                {
                    return null;
                }
                return _deckEditorLoadToZoneIsCollapse == 1;
            }
            set
            {
                if (value == null)
                {
                    _deckEditorLoadToZoneIsCollapse = null;
                }
                else
                {
                    _deckEditorLoadToZoneIsCollapse = (bool)value ? 1 : 0;
                }

            }
        }

        [XmlElement(ElementName = "scalefactor")]
        public double? ScaleFactor { get; set; }

        [XmlElement(ElementName = "zoomfactor")]
        public double? ZoomFactor { get; set; }

        [XmlElement(ElementName = "quickzoom")]
        public double? QuickZoom { get; set; }

        [XmlElement(ElementName = "isdownloadallmissing")]
        public int? _isDownloadAllMissing { get; set; }

        [XmlIgnore]
        public bool? IsDownloadAllMissing
        {
            get
            {
                if (_isDownloadAllMissing == null)
                {
                    return null;
                }
                return _isDownloadAllMissing == 1;
            }
            set
            {
                if (value == null)
                {
                    _isDownloadAllMissing = null;
                }
                else
                {
                    _isDownloadAllMissing = (bool)value ? 1 : 0;
                }

            }
        }

        [XmlElement(ElementName = "canned")]
        public string[] Canned { get; set; }
    }
}
