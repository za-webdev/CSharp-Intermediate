using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SchoolManagement2
{
    class Repository
    {
        /// <summary>
        /// Writes the serialized form of the object, in xml format, to the file
        /// location specified.
        /// </summary>
        /// <typeparam name="T">type to serialize from</typeparam>
        /// <param name="toSerialize">data to serialize</param>
        /// <param name="fileLocation">to serialize the data too</param>

        public static void Serialize<T>(T toSerialize, string fileLocation)
        {
            if (toSerialize == null)
                throw new ArgumentException("The data to serialize cannot be null.");

            if (string.IsNullOrEmpty(fileLocation))
                throw new ArgumentException("You must provide a file location to output the data to.");

            using (var textWriter = new StreamWriter(fileLocation))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", ""); //turn off namespaces
                serializer.Serialize(textWriter, toSerialize, ns);
            }
        }

        /// <summary>
        /// Reads the data from the file location specified and creates an instance
        /// of the object type. The object must be serializable.
        /// </summary>
        /// <typeparam name="T">type to deserialize the data too</typeparam>
        /// <param name="fileLocation">data to deserialize from</param>
        /// <returns>new object of type T with properties filled out</returns>
        public static T Deserialize<T>(string fileLocation)
        {
            if (string.IsNullOrEmpty(fileLocation))
                throw new ArgumentException("You must provide a file location to read the data from.");

            using (var reader = XmlReader.Create(fileLocation))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
        }

    }
}
