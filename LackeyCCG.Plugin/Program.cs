using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using CsvHelper.Configuration.Attributes;
using LackeyCCG.Plugin.Helpers;
using LackeyCCG.Plugin.Objects;
using LackeyCCG.Plugin.Objects.Decks;
using LackeyCCG.Plugin.Objects.Formats;
using LackeyCCG.Plugin.Objects.Packs;

namespace LackeyCCG.Plugin
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlSerializer mySerializer = new XmlSerializer(typeof(Deck));
            //// To read the file, create a FileStream.
            //using (var myFileStream = new FileStream(@"C:\Users\matthewb\Documents\deckfile.xml", FileMode.Open))
            //{
            //    var myObject = (Deck)mySerializer.Deserialize(myFileStream);

            //    var settings = new XmlWriterSettings
            //    {
            //        Indent = true,
            //        OmitXmlDeclaration = true
            //    };

            //    // To write to a file, create a StreamWriter object.  
            //    StreamWriter myWriter = new StreamWriter(@"C:\Users\matthewb\Documents\deckfile2.xml");
            //    using (var writer = XmlWriter.Create(myWriter, settings))
            //    {
            //        mySerializer.Serialize(writer, myObject, new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty }));
            //    }

            //    myWriter.Close();

            //    //Console.ReadKey();
            //}

            ////SetFile<SWTCGCard> tsv = new SetFile<SWTCGCard>();
            ////List<SWTCGCard> tsvRows = tsv.ReadSetFile(@"C:\Users\matthewb\Documents\15TH.txt", Encoding.Default);

            ////Card card = tsvRows[0];

            int checksum = Checksum.GetCheckSumFromFile(@"C:\Users\matthewb\Documents\dan.jpg");

            Console.ReadKey();
        }
    }



    public class SWTCGCard : Card
    {
        public string Side { get; set; }
        public string Subtype { get; set; }
        public string Cost { get; set; }
        public string Speed { get; set; }
        public string Power { get; set; }
        public string Health { get; set; }
        public string Rarity { get; set; }
        public string Number { get; set; }
        public string Usage { get; set; }
        public string Text { get; set; }
        public string Script { get; set; }
        public string Classification { get; set; }
    }
}
