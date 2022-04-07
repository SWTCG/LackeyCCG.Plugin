using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using LackeyCCG.Plugin.Objects.PluginInfo;

namespace LackeyCCG.Plugin.Helpers
{
    public class UpdateListHelper
    {

        public UpdateListHelper()
        {

        }

        public dynamic ReadUpdateList(string path)
        {
            using (var reader = new StreamReader(path))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var updateList = new UpdateList();
                    //csv.Read();
                    //csv.ReadHeader();
                    csv.Read();

                    updateList.PluginName = csv.GetField<string>(0);
                    updateList.ReleaseDate = csv.GetField<DateTime>(1);

                    
                }
            }

            return "test";
        }
        
        
    }

    public class UpdateList
    {
        public string PluginName { get; set; }
        public DateTime ReleaseDate { get; set; }
    }

}

