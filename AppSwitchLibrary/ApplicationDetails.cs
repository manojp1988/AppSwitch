using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AppSwitchLibrary
{
    [XmlRoot("act")]
    public class ActiveApp
    {
        [XmlElement(ElementName = "app")]
       public List<ApplicationDetails> details = new List<ApplicationDetails>();
    }
    
    [XmlRoot("app")]
    public class ApplicationDetails
    {
        [XmlElement(ElementName = "name")]
        public String Name { get; set; }

        [XmlElement(ElementName = "ts")]
        public ActiveData data { get; set; }
    }


    public class ActiveData
    {
        [XmlAttribute("d")]
        public String Date { get; set; }

        [XmlAttribute("t")]
        public String Time { get; set; }
    }
}
