using System.IO;
using System.Xml.Serialization;

namespace Extensions.Xml
{
    public static class StringXMLExtensions
    {
        public static string ToXml<T>(this T target)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, target);
                return writer.ToString();
            }
        }

        public static T FromXml<T>(this string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StringReader reader = new StringReader(xml))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}
