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
            XDocument doc = XDocument.Load("cafe.xml");

            foreach (XElement foodElement in doc.Element("breakfast_menu").Elements("food"))
            {
                XAttribute nameAttribute = foodElement.Attribute("name");
                XElement priceElement = foodElement.Element("price");
                XElement descriptionElement = foodElement.Element("description");

                if (nameAttribute != null && priceElement != null && descriptionElement != null)
                {
                    Console.WriteLine("Смартфон: {0}", nameAttribute.Value);
                    Console.WriteLine("Цена: {0}", priceElement.Value);
                    Console.WriteLine("Описание: {0}", descriptionElement.Value);
                }
                Console.WriteLine();
            }
        }
    }
}
/*1.	С помощью класса XDocument прочитать XML файл и вывести название всех его тегов с сохранением иерархии. 
 * В качестве отступов для иерархии использовать 2 пробела.*/

/* private void button1_Click(object sender, EventArgs e)
    {

        string s = "";

        s = textBox1.Text; // ввожу текст (Немецкий язык)

        if (s != "") // файл , и тест поиска не должен быть пустым
        {


            string fileName = "lang.xml";
            //читаем данные из файла
            XDocument doc = XDocument.Load(fileName);
            foreach (XElement el in doc.Root.Elements())
            {
                foreach (XAttribute attr in el.Attributes())
                {
                    if (attr.Value == s)
                    {
                        //MessageBox.Show(el.Name.LocalName);
                        textBox2.Text = el.Name.LocalName;
                    }


                }

            }



        }*/
