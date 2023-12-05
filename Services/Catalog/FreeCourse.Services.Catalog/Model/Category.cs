using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FreeCourse.Services.Catalog.Model
{
	public class Category
	{
		[BsonId] // Id attributü
		[BsonRepresentation(BsonType.ObjectId)] // Tipi de ID
		public string Id { get; set; }
		public string Name { get; set; }
	}
}
