using MongoDB.Bson.Serialization.Attributes;
using MongoRepository;
using System;
using System.Collections.Generic;

namespace CheckThisData.Models
{
    [CollectionName("Lists")]
    public class CheckThisList : Entity
    {
        public long PersonId { get; set; }
        public ListTypes ListType { get; set; }
        public string ListName { get; set; }
        [BsonIgnoreIfNull]
        public List<string> KeyWords { get; set; }
        [BsonIgnoreIfNull]
        public List<ListItem> Items { get; set; }
        public DateTime CreatedDate { get; set; }
        public string PhotoId { get; set; }
    }

    public enum ListTypes
    {
        Action = 1,
        Interest = 2
    }
}
