using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace LackeyCCG.Plugin.Helpers
{
    // ReSharper disable once InconsistentNaming
    public class SetFile<T> where T : Objects.Card
    {
        public CsvConfiguration Configuration { get; set; }
        private StreamReader Stream { get; set; }
        public CsvReader TSVReader { get; set; }

        public SetFile()
        {
            this.Configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                Delimiter = "\t",
                IgnoreBlankLines = true,
                BadDataFound = null

            };
        }

        public SetFile(CsvConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public List<T> ReadSetFile (string path, Encoding encoding = null)
        {
            if (encoding == null)
            {
                encoding = Encoding.Default;
            }
            this.Configuration.Encoding = encoding;
            using (this.Stream = new StreamReader(path, encoding, true))
            {
                using (this.TSVReader = new CsvReader(this.Stream, this.Configuration))
                {
                    var records = TSVReader.GetRecords<T>();
                    return records.ToList();
                }
            }
        }

        
    }
}
