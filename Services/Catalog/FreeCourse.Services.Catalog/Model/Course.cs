using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FreeCourse.Services.Catalog.Model
{
	public class Course
	{
		[BsonId] // Id attributü
		[BsonRepresentation(BsonType.ObjectId)] // Tipi de ID
		public string Id { get; set; }
		public string Name { get; set; }

		[BsonRepresentation(BsonType.ObjectId)]
		public string CategoryId { get; set; }

		[BsonIgnore] // mongoDb collection'a yansıtma
        public Category Category { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
		public string Price { get; set; }
		public string UserId { get; set; }

		[BsonRepresentation(BsonType.Decimal128)]
		public string Picture { get; set; }
		public DateTime CreatedTime { get; set; }
		public string Description { get; set; }
		public Feature Feature { get; set; }
	}
}
