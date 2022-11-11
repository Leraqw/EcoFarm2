Base object1 = new Base() { Name = "Object1" };
Derived object2 = new Derived() { Something = "Some other thing" };
List<Base> inheritanceList = new List<Base>() { object1, object2 };

JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

string Serialized = JsonConvert.SerializeObject(inheritanceList, settings);
List<Base> deserializedList = JsonConvert.DeserializeObject<List<Base>>(Serialized, settings);