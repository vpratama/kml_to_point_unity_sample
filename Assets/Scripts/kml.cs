using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/kml/2.2", IsNullable = false)]
public partial class kml
{

    private kmlDocument documentField;

    /// <remarks/>
    public kmlDocument Document
    {
        get
        {
            return this.documentField;
        }
        set
        {
            this.documentField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
public partial class kmlDocument
{

    private kmlDocumentLookAt lookAtField;

    private kmlDocumentFolder folderField;

    /// <remarks/>
    public kmlDocumentLookAt LookAt
    {
        get
        {
            return this.lookAtField;
        }
        set
        {
            this.lookAtField = value;
        }
    }

    /// <remarks/>
    public kmlDocumentFolder Folder
    {
        get
        {
            return this.folderField;
        }
        set
        {
            this.folderField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
public partial class kmlDocumentLookAt
{

    private decimal longitudeField;

    private decimal latitudeField;

    private decimal altitudeField;

    private decimal headingField;

    private decimal tiltField;

    private decimal rangeField;

    private string altitudeModeField;

    /// <remarks/>
    public decimal longitude
    {
        get
        {
            return this.longitudeField;
        }
        set
        {
            this.longitudeField = value;
        }
    }

    /// <remarks/>
    public decimal latitude
    {
        get
        {
            return this.latitudeField;
        }
        set
        {
            this.latitudeField = value;
        }
    }

    /// <remarks/>
    public decimal altitude
    {
        get
        {
            return this.altitudeField;
        }
        set
        {
            this.altitudeField = value;
        }
    }

    /// <remarks/>
    public decimal heading
    {
        get
        {
            return this.headingField;
        }
        set
        {
            this.headingField = value;
        }
    }

    /// <remarks/>
    public decimal tilt
    {
        get
        {
            return this.tiltField;
        }
        set
        {
            this.tiltField = value;
        }
    }

    /// <remarks/>
    public decimal range
    {
        get
        {
            return this.rangeField;
        }
        set
        {
            this.rangeField = value;
        }
    }

    /// <remarks/>
    public string altitudeMode
    {
        get
        {
            return this.altitudeModeField;
        }
        set
        {
            this.altitudeModeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
public partial class kmlDocumentFolder
{

    private string nameField;

    private kmlDocumentFolderLookAt lookAtField;

    private kmlDocumentFolderPlacemark[] placemarkField;

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public kmlDocumentFolderLookAt LookAt
    {
        get
        {
            return this.lookAtField;
        }
        set
        {
            this.lookAtField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Placemark")]
    public kmlDocumentFolderPlacemark[] Placemark
    {
        get
        {
            return this.placemarkField;
        }
        set
        {
            this.placemarkField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
public partial class kmlDocumentFolderLookAt
{

    private decimal longitudeField;

    private decimal latitudeField;

    private decimal altitudeField;

    private decimal headingField;

    private decimal tiltField;

    private decimal rangeField;

    private string altitudeModeField;

    /// <remarks/>
    public decimal longitude
    {
        get
        {
            return this.longitudeField;
        }
        set
        {
            this.longitudeField = value;
        }
    }

    /// <remarks/>
    public decimal latitude
    {
        get
        {
            return this.latitudeField;
        }
        set
        {
            this.latitudeField = value;
        }
    }

    /// <remarks/>
    public decimal altitude
    {
        get
        {
            return this.altitudeField;
        }
        set
        {
            this.altitudeField = value;
        }
    }

    /// <remarks/>
    public decimal heading
    {
        get
        {
            return this.headingField;
        }
        set
        {
            this.headingField = value;
        }
    }

    /// <remarks/>
    public decimal tilt
    {
        get
        {
            return this.tiltField;
        }
        set
        {
            this.tiltField = value;
        }
    }

    /// <remarks/>
    public decimal range
    {
        get
        {
            return this.rangeField;
        }
        set
        {
            this.rangeField = value;
        }
    }

    /// <remarks/>
    public string altitudeMode
    {
        get
        {
            return this.altitudeModeField;
        }
        set
        {
            this.altitudeModeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
public partial class kmlDocumentFolderPlacemark
{

    private string nameField;

    private string descriptionField;

    private kmlDocumentFolderPlacemarkLookAt lookAtField;

    private kmlDocumentFolderPlacemarkStyle styleField;

    private kmlDocumentFolderPlacemarkMultiGeometry multiGeometryField;

    private string idField;

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    public kmlDocumentFolderPlacemarkLookAt LookAt
    {
        get
        {
            return this.lookAtField;
        }
        set
        {
            this.lookAtField = value;
        }
    }

    /// <remarks/>
    public kmlDocumentFolderPlacemarkStyle Style
    {
        get
        {
            return this.styleField;
        }
        set
        {
            this.styleField = value;
        }
    }

    /// <remarks/>
    public kmlDocumentFolderPlacemarkMultiGeometry MultiGeometry
    {
        get
        {
            return this.multiGeometryField;
        }
        set
        {
            this.multiGeometryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
public partial class kmlDocumentFolderPlacemarkLookAt
{

    private decimal longitudeField;

    private decimal latitudeField;

    private decimal altitudeField;

    private decimal headingField;

    private decimal tiltField;

    private decimal rangeField;

    private string altitudeModeField;

    /// <remarks/>
    public decimal longitude
    {
        get
        {
            return this.longitudeField;
        }
        set
        {
            this.longitudeField = value;
        }
    }

    /// <remarks/>
    public decimal latitude
    {
        get
        {
            return this.latitudeField;
        }
        set
        {
            this.latitudeField = value;
        }
    }

    /// <remarks/>
    public decimal altitude
    {
        get
        {
            return this.altitudeField;
        }
        set
        {
            this.altitudeField = value;
        }
    }

    /// <remarks/>
    public decimal heading
    {
        get
        {
            return this.headingField;
        }
        set
        {
            this.headingField = value;
        }
    }

    /// <remarks/>
    public decimal tilt
    {
        get
        {
            return this.tiltField;
        }
        set
        {
            this.tiltField = value;
        }
    }

    /// <remarks/>
    public decimal range
    {
        get
        {
            return this.rangeField;
        }
        set
        {
            this.rangeField = value;
        }
    }

    /// <remarks/>
    public string altitudeMode
    {
        get
        {
            return this.altitudeModeField;
        }
        set
        {
            this.altitudeModeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
public partial class kmlDocumentFolderPlacemarkStyle
{

    private kmlDocumentFolderPlacemarkStyleIconStyle iconStyleField;

    private kmlDocumentFolderPlacemarkStyleLabelStyle labelStyleField;

    private kmlDocumentFolderPlacemarkStyleLineStyle lineStyleField;

    /// <remarks/>
    public kmlDocumentFolderPlacemarkStyleIconStyle IconStyle
    {
        get
        {
            return this.iconStyleField;
        }
        set
        {
            this.iconStyleField = value;
        }
    }

    /// <remarks/>
    public kmlDocumentFolderPlacemarkStyleLabelStyle LabelStyle
    {
        get
        {
            return this.labelStyleField;
        }
        set
        {
            this.labelStyleField = value;
        }
    }

    /// <remarks/>
    public kmlDocumentFolderPlacemarkStyleLineStyle LineStyle
    {
        get
        {
            return this.lineStyleField;
        }
        set
        {
            this.lineStyleField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
public partial class kmlDocumentFolderPlacemarkStyleIconStyle
{

    private string colorField;

    private decimal scaleField;

    private decimal headingField;

    private kmlDocumentFolderPlacemarkStyleIconStyleIcon iconField;

    /// <remarks/>
    public string color
    {
        get
        {
            return this.colorField;
        }
        set
        {
            this.colorField = value;
        }
    }

    /// <remarks/>
    public decimal scale
    {
        get
        {
            return this.scaleField;
        }
        set
        {
            this.scaleField = value;
        }
    }

    /// <remarks/>
    public decimal heading
    {
        get
        {
            return this.headingField;
        }
        set
        {
            this.headingField = value;
        }
    }

    /// <remarks/>
    public kmlDocumentFolderPlacemarkStyleIconStyleIcon Icon
    {
        get
        {
            return this.iconField;
        }
        set
        {
            this.iconField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
public partial class kmlDocumentFolderPlacemarkStyleIconStyleIcon
{

    private string hrefField;

    /// <remarks/>
    public string href
    {
        get
        {
            return this.hrefField;
        }
        set
        {
            this.hrefField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
public partial class kmlDocumentFolderPlacemarkStyleLabelStyle
{

    private string colorField;

    private decimal scaleField;

    /// <remarks/>
    public string color
    {
        get
        {
            return this.colorField;
        }
        set
        {
            this.colorField = value;
        }
    }

    /// <remarks/>
    public decimal scale
    {
        get
        {
            return this.scaleField;
        }
        set
        {
            this.scaleField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
public partial class kmlDocumentFolderPlacemarkStyleLineStyle
{

    private string colorField;

    private decimal widthField;

    /// <remarks/>
    public string color
    {
        get
        {
            return this.colorField;
        }
        set
        {
            this.colorField = value;
        }
    }

    /// <remarks/>
    public decimal width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
public partial class kmlDocumentFolderPlacemarkMultiGeometry
{

    private kmlDocumentFolderPlacemarkMultiGeometryPoint pointField;

    private kmlDocumentFolderPlacemarkMultiGeometryLineString[] multiGeometryField;

    private kmlDocumentFolderPlacemarkMultiGeometryLineString1 lineStringField;

    /// <remarks/>
    public kmlDocumentFolderPlacemarkMultiGeometryPoint Point
    {
        get
        {
            return this.pointField;
        }
        set
        {
            this.pointField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("LineString", IsNullable = false)]
    public kmlDocumentFolderPlacemarkMultiGeometryLineString[] MultiGeometry
    {
        get
        {
            return this.multiGeometryField;
        }
        set
        {
            this.multiGeometryField = value;
        }
    }

    /// <remarks/>
    public kmlDocumentFolderPlacemarkMultiGeometryLineString1 LineString
    {
        get
        {
            return this.lineStringField;
        }
        set
        {
            this.lineStringField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
public partial class kmlDocumentFolderPlacemarkMultiGeometryPoint
{

    private string coordinatesField;

    /// <remarks/>
    public string coordinates
    {
        get
        {
            return this.coordinatesField;
        }
        set
        {
            this.coordinatesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
public partial class kmlDocumentFolderPlacemarkMultiGeometryLineString
{

    private string coordinatesField;

    /// <remarks/>
    public string coordinates
    {
        get
        {
            return this.coordinatesField;
        }
        set
        {
            this.coordinatesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/kml/2.2")]
public partial class kmlDocumentFolderPlacemarkMultiGeometryLineString1
{

    private string coordinatesField;

    /// <remarks/>
    public string coordinates
    {
        get
        {
            return this.coordinatesField;
        }
        set
        {
            this.coordinatesField = value;
        }
    }
}


