using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace FGPrenotazioni.Models.Persistence
{
    public static class DatBinaryFormatter
    {
        public static void Save<T>(string path, T obj)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {

                // Construct a BinaryFormatter and use it to serialize the data to the stream.
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, obj);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                }

            }
        }
        public static T Load<T>(string path)
        {

            T savedObject = default(T);
            // Open the file containing the data that you want to deserialize.
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    savedObject = (T)formatter.Deserialize(fs);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                }
            }
            return savedObject;
        }
    }
}

