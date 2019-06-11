using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace apiTestUnip.WebApi.Model {
    public class SubMenu
    {
        public Item item { get; set; }

        public IEnumerable<Item> listItem { get; set; }
        
    }
}