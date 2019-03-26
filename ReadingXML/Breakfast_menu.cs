using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReadingXML
{
    [Serializable]
    public class Breakfast_menu
    {
        [XmlElement(ElementName = "food")]
        public Food[] Food { get; set; }

        public Breakfast_menu(Food[] food)
        {
            Food = food;
        }
    }
}
