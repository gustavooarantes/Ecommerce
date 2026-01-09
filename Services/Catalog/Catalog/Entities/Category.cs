using Catalog.Common;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.Entities;

public class Category : BaseEntity
{
    [BsonElement("Name")]
    public string Name { get; set; }
}