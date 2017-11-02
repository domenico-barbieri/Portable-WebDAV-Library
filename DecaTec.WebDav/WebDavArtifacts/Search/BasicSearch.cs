using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace DecaTec.WebDav.WebDavArtifacts.Search
{
    /// <summary>
    /// Class representing an 'propfind' XML element for WebDAV communication.
    /// </summary>
    [DataContract]
    [XmlRoot(Namespace = WebDavConstants.DAV, IsNullable = false)]
    public class BasicSearch
    {
        [XmlElement(ElementName = WebDavConstants.Select)]
        public Select Select
        {
            get;
            set;
        }

        [XmlElement(ElementName = WebDavConstants.From)]
        public From From
        {
            get;
            set;
        }

        [XmlArray(WebDavConstants.Where)]
        [XmlArrayItem(typeof(Like), ElementName = WebDavConstants.Like)]
        [XmlArrayItem(typeof(Eq), ElementName = WebDavConstants.Eq)]
        public List<object> Where
        {
            get;
            set;
        }
    }
}
