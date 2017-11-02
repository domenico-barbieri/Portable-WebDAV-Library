using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace DecaTec.WebDav.WebDavArtifacts.Search
{
    /// <summary>
    /// Class representing an 'propfind' XML element for WebDAV communication.
    /// </summary>
    [DataContract]
    [XmlRoot(Namespace = WebDavConstants.DAV, IsNullable = false)]
    public class From
    {
        [XmlElement(ElementName = WebDavConstants.Scope)]
        public Scope Scope
        {
            get;
            set;
        }
    }
}
