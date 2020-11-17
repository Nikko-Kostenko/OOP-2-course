using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCalc_2
{
    class AnalyzerSAXStrategy : IAnalyzerXMLStrategy
    {
        public List<Scientist> Search(Scientist _scientist)
        {
            List<Scientist> result = new List<Scientist>();
            
            var xmlReader = new XmlTextReader(@"C:\Users\f18ra\source\repos\LabCalc_2\LabCalc_2\XMLFile.xml");

            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes)
                {
                    while (xmlReader.MoveToNextAttribute())
                    {


                        if (xmlReader.Name.Equals("FC_NAME") && ((xmlReader.Value.Equals(_scientist.Faculty)) ||
                                                                 _scientist.Faculty.Equals(string.Empty)))
                        {
                            string faculty = string.Empty;
                            faculty = xmlReader.Value;
                            xmlReader.Read();
                            xmlReader.Read();


                            for (var Name1XmlReader = xmlReader;
                                !Name1XmlReader.Name.Equals("faculty");
                                xmlReader.Read())
                            {
                                if (xmlReader.HasAttributes)
                                {
                                    while (xmlReader.MoveToNextAttribute())
                                    {
                                        if (xmlReader.Name.Equals("CT_NAME") &&
                                            ((xmlReader.Value.Equals(_scientist.Cathedra)) ||
                                             _scientist.Cathedra.Equals(string.Empty)))
                                        {
                                            string cathedra = string.Empty;
                                            cathedra = xmlReader.Value;
                                            xmlReader.Read();
                                            xmlReader.Read();


                                            for (var Name2XmlReader = xmlReader;
                                                !Name2XmlReader.Name.Equals("cathedra");
                                                xmlReader.Read())
                                            {
                                                if (xmlReader.HasAttributes)
                                                {
                                                    while (xmlReader.MoveToNextAttribute())
                                                    {
                                                        string name = string.Empty;
                                                        string post = string.Empty;
                                                        string time = string.Empty;
                                                        if (xmlReader.Name.Equals("SC_NAME") &&
                                                            (xmlReader.Value.Equals(_scientist.Name)) ||
                                                            _scientist.Name.Equals(string.Empty))
                                                        {
                                                            name = xmlReader.Value;
                                                            xmlReader.MoveToNextAttribute();

                                                            if (xmlReader.Name.Equals("SC_POST") &&
                                                                (xmlReader.Value.Equals(_scientist.Post) ||
                                                                 _scientist.Post.Equals(string.Empty)))
                                                            {
                                                                post = xmlReader.Value;
                                                                xmlReader.MoveToNextAttribute();

                                                                if (xmlReader.Name.Equals("SC_WORKED_TIME") &&
                                                                    (Scientist.IsTimeEqual(_scientist.Time,
                                                                         int.Parse(xmlReader.Value)) ||
                                                                     _scientist.Time.Equals(string.Empty)))
                                                                {
                                                                    time = xmlReader.Value;
                                                                }
                                                            }
                                                        }


                                                        if (!name.Equals(string.Empty) &&
                                                            !faculty.Equals(string.Empty) &&
                                                            !cathedra.Equals(string.Empty) &&
                                                            !post.Equals(string.Empty) &&
                                                            !time.Equals(string.Empty))
                                                        {
                                                            Scientist actualScientist =
                                                                new Scientist(name, faculty, cathedra, post, time);
                                                            result.Add(actualScientist);
                                                        }
                                                    }

                                                    Name2XmlReader = xmlReader;
                                                    Name2XmlReader.Read();
                                                }
                                            }

                                            Name1XmlReader = xmlReader;
                                            Name1XmlReader.Read();
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }


            xmlReader.Close();
            return result;

        }
    }
}
