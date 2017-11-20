using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DrinksProg
{
    public class XmlService
    {
        private static List<Product> listOfProducts;
        private static string filePath;

        public static List<Product> ListOfProducts
        {
            get
            {
                return listOfProducts;
            }
            set
            {
                listOfProducts = value;
            }
        }

        public static string FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
            }
        }

        //private static string filePathHard = @"C:\Users\firas.al-husari\Desktop\DrinksProg\Products.xml";


        public static void Serialize<T>(T list)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, list);
            }
        }
        public static Type Deserialize<Type>()
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
