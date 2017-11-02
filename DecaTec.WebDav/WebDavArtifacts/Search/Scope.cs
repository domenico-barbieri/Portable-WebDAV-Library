using DecaTec.WebDav.Headers;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace DecaTec.WebDav.WebDavArtifacts.Search
{
    /// <summary>
    /// Class representing an 'propfind' XML element for WebDAV communication.
    /// </summary>
    [DataContract]
    [XmlRoot(Namespace = WebDavConstants.DAV, IsNullable = false)]
    public class Scope
    {
        [XmlElement(ElementName = WebDavConstants.Href)]
        public string Href
        {
            get;
            set;
        }

        [XmlIgnore]
        public WebDavDepthHeaderValue Depth
        {
            get;
            set;
        }

        [XmlElement(ElementName = WebDavConstants.Depth)]
        protected string DepthString
        {
            get => Depth.ToString();
            set
            {
                if(value == WebDavDepthHeaderValue.Zero.ToString())
                {
                    Depth = WebDavDepthHeaderValue.Zero;
                }
                else if (value == WebDavDepthHeaderValue.One.ToString())
                {
                    Depth = WebDavDepthHeaderValue.One;
                }
                else if(value == WebDavDepthHeaderValue.Infinity.ToString())
                {
                    Depth = WebDavDepthHeaderValue.Infinity;
                }
                else
                {
                    Depth = null;
                }
            }
        }
    }
}
