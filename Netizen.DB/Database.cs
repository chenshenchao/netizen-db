using System.Text.Json;
using System.Collections.Generic;
using Netizen.Text.Json.Flation;

namespace Netizen.DB
{
    public class Database
    {
        public JsonFlattener Flattener { get; private set; }

        public Database()
        {
            Flattener = new JsonFlattener();
        }

        public void Add(string document)
        {
            JsonDocument d = JsonDocument.Parse(document);
            Dictionary<string, object> r = Flattener.Flat(d);
        }
    }
}