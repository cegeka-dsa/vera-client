using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace VeraClient.Helpers
{
    public class Serialization
    {
        public static string SerializeToXml(object objectToSerialize)
        {
            var sb = new StringBuilder();
            using (var writer = XmlWriter.Create(sb))
            {
                var serializer = new XmlSerializer(objectToSerialize.GetType());
                serializer.Serialize(writer, objectToSerialize);

                writer.Flush();
            }

            return sb.ToString();
        }

        public static TModel DeserializeFromXml<TModel>(string xmlData)
        {
            var ms = new MemoryStream(Encoding.Unicode.GetBytes(xmlData));
            using (var reader = new StreamReader(ms, Encoding.Unicode))
            {
                var serializer = new XmlSerializer(typeof(TModel));
                return (TModel)serializer.Deserialize(reader);
            }
        }
    }
}
