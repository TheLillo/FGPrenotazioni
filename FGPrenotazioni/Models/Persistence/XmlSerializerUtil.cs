using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FGPrenotazioni.Models.Persistence
{
    public static class XmlSerializerUtil
    {
        public static T Load<T>(string path)
        {
            T savedObject = default(T);
            if (File.Exists(path))
            {
                XmlSerializer x = new XmlSerializer(typeof(T));
                using (FileStream st = File.Open(path, FileMode.Open))
                {
                    savedObject = (T)x.Deserialize(st);
                }
            }
            return savedObject;
        }

        public static void Save<T>(string path, T obj)
        {
            XmlSerializer x = new XmlSerializer(typeof(T));
            using (FileStream st = File.Open(path, FileMode.Create))
            {
                x.Serialize(st, obj);
            }
        }
    }
}
