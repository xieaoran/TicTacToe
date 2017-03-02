using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TicTacToe.Core
{
    public static class XMLHelper
    {
        private static XmlSerializer _xmlSerializer = new XmlSerializer(typeof (List<Record>));
        public static List<Record> Records = Deserialize();

        public static List<Record> Deserialize()
        {
            if (File.Exists("Records.xml"))
            {
                var xmlFile = new FileStream("Records.xml", FileMode.Open, FileAccess.Read);
                var records = (List<Record>) _xmlSerializer.Deserialize(xmlFile);
                xmlFile.Close();
                return records;
            }
            return new List<Record>();
        }

        public static void Serialize()
        {
            var xmlFile = new FileStream("Records.xml", FileMode.Create, FileAccess.ReadWrite);
            _xmlSerializer.Serialize(xmlFile, Records);
            xmlFile.Close();
        }
    }
}