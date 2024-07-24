using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HebrewDate
{
    internal class XmlService
    {
        string path;
        XDocument document;
        public XmlService(string path)
        {
            this.path = path;

            if (!File.Exists(path))
            {
                new XDocument(new XElement("Queries")).Save(path);
            }
            document = XDocument.Load(path);
        }

        public HebrewDateModel Add(HebrewDateModel date)
        {
            document.Root.Add(ToXml(date));
            document.Root.Save(path);
            return date;
        }
        private XElement ToXml(HebrewDateModel date)
        {
            return new XElement("Todo",
                new XElement("Day", date.day),
                new XElement("DayMonth", date.dayMonth),
                new XElement("Month", date.month),
                new XElement("Year", date.year ),
                new XElement("Result", date.result)
            );
        }

    }
}
