using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ReadingXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Food first = new Food("Бельгийские Вафли", "$5.95",
                "две известных Бельгийских Вафли с обилием настоящего кленового сиропа", "650");
            Food second = new Food("Французский Тост", "$4.50",
                "толстые куски, сделанные из кусочков домашнего хлеба из опары", "600");
            
            string path = "cafe.xml";

            List<Food> food = new List<Food>
            {
                first, second
            };

            XmlSerializer formatter = new XmlSerializer(typeof(List<Food>));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, food);
            }

            XDocument xdoc = XDocument.Load("cafe.xml");

            Console.WriteLine("<{0}>\n", xdoc.Element("ArrayOfFood").Name);
            foreach (XElement foodElement in xdoc.Element("ArrayOfFood").Elements("Food"))
            {
                XElement nameElement = foodElement.Element("name");
                XElement priceElement = foodElement.Element("price");
                XElement descriptionElement = foodElement.Element("description");
                XElement caloriesElement = foodElement.Element("calories");

                if (nameElement != null && priceElement != null && descriptionElement != null)
                {
                    Console.WriteLine("<{0}>", foodElement.Name);

                    Console.WriteLine("<{0}>  </{0}>", nameElement.Name);
                    Console.WriteLine("<{0}>  </{0}>", priceElement.Name);
                    Console.WriteLine("<{0}>  </{0}>", descriptionElement.Name);
                    Console.WriteLine("<{0}>  </{0}>", caloriesElement.Name);

                    Console.WriteLine("</{0}>\n", foodElement.Name);
                }
            }
            Console.WriteLine("</{0}>", xdoc.Element("ArrayOfFood").Name);
        }
    }
}
/*1.	С помощью класса XDocument прочитать XML файл и вывести название всех его тегов с сохранением иерархии. 
 * В качестве отступов для иерархии использовать 2 пробела.*/
