using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ReadingXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = XDocument.Load("cafe.xml");
            Console.WriteLine(xdoc.ToString());
           
            foreach (XElement foodElement in xdoc.Element("Breakfast_menu").Elements("Food"))
            {
                XElement companyElement = foodElement.Element("name");
                XElement priceElement = foodElement.Element("price");

                if (companyElement != null && priceElement != null)
                {
                    Console.WriteLine("Компания: {0}", companyElement.Value);
                    Console.WriteLine("Цена: {0}", priceElement.Value);
                }
                Console.WriteLine();
            }
        }
    }
}
/*1.	С помощью класса XDocument прочитать XML файл и вывести название всех его тегов с сохранением иерархии. 
 * В качестве отступов для иерархии использовать 2 пробела.*/
