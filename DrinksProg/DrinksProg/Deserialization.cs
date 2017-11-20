using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DrinksProg
{
    public class Deserialization
    {

        private string filePath = @"C:\Users\Firas\Desktop\DrinksProg\Products.xml";
        
        public Deserialization()
        {
            
        }

        public void Serialize<T>(T list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, list);
            }
        }
        public Type Deserialize<Type>()
        {
            Type objType = default(Type);
            XmlSerializer deserializer = new XmlSerializer(typeof(Type));
            if (File.Exists(filePath))
            {
                TextReader reader = new StreamReader(filePath);
                objType = (Type)deserializer.Deserialize(reader);
                reader.Close();
                return objType;
            }
            else
            {
                return objType;
            }
        }
    }
}
