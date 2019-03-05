using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReadingXML
{
    public class Breakfast_menu
    {
        [XmlElement(ElementName = "food")]
        public List<Food> Food { get; set; }
    }
}
