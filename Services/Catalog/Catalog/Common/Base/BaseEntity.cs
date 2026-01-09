using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.Common;

public class BaseEntity
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}