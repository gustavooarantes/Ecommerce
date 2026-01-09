using Catalog.Common;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Summary { get; set; }
    public string Description { get; set; }
    public string ImageFile { get; set; }
    
    [BsonRepresentation(BsonType.Decimal128)]
    public decimal Price { get; set; }
    
    public Brand Brand { get; set; }
    public Category Category { get; set; }
    
    // public DateTimeOffset DeletedAt { get; set; }
    // public bool? IsDeleted { get; set; }
}