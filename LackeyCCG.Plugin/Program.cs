using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using LackeyCCG.Plugin.Objects;

namespace LackeyCCG.Plugin
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(Objects.PluginInfo.Plugin));
            // To read the file, create a FileStream.
            using (var myFileStream = new FileStream(@"C:\Users\matthewb\Documents\plugininfo.txt", FileMode.Open))
            {
                var myObject = (Objects.PluginInfo.Plugin)mySerializer.Deserialize(myFileStream);

                var settings = new XmlWriterSettings
                {
                    Indent = true,
                    OmitXmlDeclaration = true
                };

                // To write to a file, create a StreamWriter object.  
                StreamWriter myWriter = new StreamWriter(@"C:\Users\matthewb\Documents\plugininfo2.xml");
                using (var writer = XmlWriter.Create(myWriter, settings))
                {
                    mySerializer.Serialize(writer, myObject, new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty }));
                }

                myWriter.Close();

                Console.ReadKey();
            }

            // Call the Deserialize method and cast to the object type.
            
        }
    }
}
