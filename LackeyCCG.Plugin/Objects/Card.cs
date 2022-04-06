using CsvHelper.Configuration.Attributes;

namespace LackeyCCG.Plugin.Objects
{
    public class Card
    {
        [Name("Name")]
        public string Name { get; set; }

        [Name("Set")]
        public string Set { get; set; }

        [Name("ImageFile")]
        public string ImageFile { get; set; }

        [Name("Type")]
        public string Type { get; set; }
    }
}
