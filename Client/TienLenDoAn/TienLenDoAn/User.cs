using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TienLenDoAn
{
    public class User
    {
        [BsonId] // MongoDB tự tạo ID (nếu không có)
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("username")]
        public string Username { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("roomId")]
        public string RoomID { get; set; }

        public User() { }

        public User(string username, string password, string name, string roomID)
        {
            Username = username;
            Password = password;
            Name = name;
            RoomID = roomID;
        }
    }
}
