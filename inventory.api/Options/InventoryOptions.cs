using System.Collections.Generic;

namespace inventory.api.Options
{
    public class InventoryOptions
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
        public Dictionary<string, string> Collections { get; set; }

    }
}