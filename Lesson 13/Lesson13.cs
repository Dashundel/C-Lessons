using System.Xml.Serialization;

namespace HW456.Lesson_13;

/// <summary>
/// Создать список из N дробей, сериализовать их в файл. Десериализовать.
/// </summary>
public class Lesson13
{
    private const string Path = "fraction.xml";

    public static void Task()
    {
        var fractionList = GenerateListFractions();

        Serializator(fractionList);
        Deserializator();

    }
    
    public static List<Fraction> GenerateListFractions()
    {
        Random rnd = new Random();
        var n = rnd.Next(20);
        var list = new List<Fraction>();

        for (int i = 0; i < n; i++)
        {
            list.Add(new Fraction() {Denominator = rnd.Next(100), Numerals = rnd.Next(100)});
        }

        foreach (var j in list)
        {
            Console.WriteLine(j.Numerals.ToString() + "/" + j.Denominator.ToString());
        }
        
        return list;
    }
    public static void Serializator(List<Fraction> fractionList)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Fraction>));
        
        using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate))
        {
            xmlSerializer.Serialize(fs, fractionList);
 
            Console.WriteLine("Object has been serialized");
        }
    }
    
    public static void Deserializator()
    { //не работает
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Fraction>));
        
        using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate))
        {
            List<Fraction>? listFr = xmlSerializer.Deserialize(fs) as List<Fraction>;
      
            Console.WriteLine(listFr);
        }
        Console.ReadLine();
    }

}