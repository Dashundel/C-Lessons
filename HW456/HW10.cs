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
    private static string path = "flowCards.Card.xml";
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
        doc.Save(path);
    }

    private static void SaveContacts()
    {
        XDocument xDoc = XDocument.Load(path);

        if (xDoc.Root == null)
        {
            return;
        }
        
        foreach (XElement el in xDoc.Root.Elements())
        {
            using (StreamWriter pc = new StreamWriter(path))
            {
                const string attributeName = "IsPromotional";

                var isPromotionalAttribute = el.Attribute(attributeName);

                if (isPromotionalAttribute == null)
                {
                    throw new ArgumentException($"There is no such attribute like {attributeName}");
                }

                switch (isPromotionalAttribute.Value)
                {
                    case "true":
                        pc.WriteLine(el.Value);
                        break;

                    case "false":
                        pc.WriteLine(el.Value);
                        break;

                    default:
                        throw new ArgumentException($"Unknown value of attribute {attributeName}: {isPromotionalAttribute.Value}.");
                }
            }
        }
    } 
}