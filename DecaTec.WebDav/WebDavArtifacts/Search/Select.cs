using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace DecaTec.WebDav.WebDavArtifacts.Search
{
    /// <summary>
    /// Class representing an 'propfind' XML element for WebDAV communication.
    /// </summary>
    [DataContract]
    [XmlRoot(Namespace = WebDavConstants.DAV, IsNullable = false)]
    public class Select
    {
        [XmlElement(ElementName = WebDavConstants.Prop)]
        public Prop Prop
        {
            get;
            set;
        }
    }
}
