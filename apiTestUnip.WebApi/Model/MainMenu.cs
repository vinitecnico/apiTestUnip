using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace apiTestUnip.WebApi.Model {
    public class MainMenu
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string name { get; set; }

        public string icon { get; set; }

        public IEnumerable<SubMenu> items {get; set;}
    }
}