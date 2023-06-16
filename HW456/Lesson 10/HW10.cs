using System.Xml;
using System.Xml.Linq;

namespace HW456.Lesson_10;

/// <summary>
/// Считать из файла flowCards.Card все контакты, сохранить в 2 разных файла: 
/// рекламные и не рекламные контакты (разделять по атрибуту IsPromotional). 
/// Формат файла:<Contact_Value> [<Description>]
/// </summary>

public static class HW10
{
    public static void Contacts()
    {
        WriteContacts();
        SaveContacts();
    }

    private static void WriteContacts()
    {
        XDocument doc = new XDocument();
        XElement root = new XElement("Contact");
        root.Add(new XElement("Contact_value", "+7(555)5555555", new XAttribute("IsPromotional", true)));
        root.Add(new XElement("Contact_value", "+7(569)8888855", new XAttribute("IsPromotional", false)));
        doc.Add(root);
        doc.Save("C:/Users/d.lazareva/RiderProjects/HW456/HW456/Lesson 10/flowCards.Card.xml");
    }

    private static void SaveContacts()
    {
        XDocument xDoc = XDocument.Load("C:/Users/d.lazareva/RiderProjects/HW456/HW456/Lesson 10/flowCards.Card.xml");

        if (xDoc.Root != null)
            foreach (XElement el in xDoc.Root.Elements())
            {
                if (el.Attribute("IsPromotional")!.Value == "true")
                {
                    using (StreamWriter pc = new StreamWriter("C:/Users/d.lazareva/RiderProjects/HW456/HW456/Lesson 10/promotionalContacts.txt"))
                    {
                        pc.WriteLine(el.Value);
                    }
                }
                else if (el.Attribute("IsPromotional")!.Value == "false")
                {
                    using (StreamWriter pc = new StreamWriter("C:/Users/d.lazareva/RiderProjects/HW456/HW456/Lesson 10/unpromotionalContacts.txt"))
                    {
                        pc.WriteLine(el.Value);
                    }
                }
                else
                {
                    throw new ArgumentException("Unknown value of attribute IsPromotional.");
                }
            }
    } 
}