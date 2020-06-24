using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace Fridge_Management
{
   public class My_storage
    {

        public static void writeXML<T>(T data, string filename)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                FileStream stream;
                stream = new FileStream(filename, FileMode.Create);

                serializer.Serialize(stream, data);
                stream.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Error");
                throw;
            }
        }

        public static T ReadXML<T>(string file)
        {
            try
            {
                using(StreamReader sr = new StreamReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(sr);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Error");
                return default(T);
            }
        }
         

    }
}
