using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReadingXML
{
    [Serializable]
    //[XmlRoot(ElementName = "food")]
    public class Food
    {
        //[XmlElement(ElementName = "name")]
        public string Name { get; set; }
        //[XmlElement(ElementName = "price")]
        public string Price { get; set; }
        //[XmlElement(ElementName = "description")]
        public string Description { get; set; }
        //[XmlElement(ElementName = "calories")]
        public string Calories { get; set; }

        public Food(string name, string price, string description, string calories)
        {
            Name = name; Price = price; Description = description; Calories = calories;
        }
        
    }
}
