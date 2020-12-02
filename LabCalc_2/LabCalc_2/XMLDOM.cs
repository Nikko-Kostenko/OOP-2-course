using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;

namespace LabCalc_2
{
    class AnalyzerDOMStrategy : IAnalyzerXMLStrategy
    { 
        public List<Scientist> Search(Scientist _scientist)
        {
            List<Scientist> result = new List<Scientist>();
            XmlDocument document = new XmlDocument();
            document.Load(@"C:\Users\f18ra\source\repos\LabCalc_2\LabCalc_2\XMLFile.xml");

            XmlNode dataBase = document.DocumentElement;
            foreach (XmlNode _faculty in dataBase.ChildNodes)
            {
                foreach (XmlNode _cathedra in _faculty.ChildNodes)
                {
                    foreach (XmlNode __scientist in _cathedra.ChildNodes)
                    {
                        string name = "";
                        string faculty = "";
                        string cathedra = "";
                        string post = "";
                        string time = "";

                        foreach (XmlAttribute _attribute in _faculty.Attributes)
                        {
                            if (_attribute.Name.Equals("FC_NAME") && (_attribute.Value.Equals(_scientist.Faculty)) ||
                                _scientist.Faculty.Equals(string.Empty))
                                faculty = _attribute.Value;
                        }

                        foreach (XmlAttribute _attribute in _cathedra.Attributes)
                        {
                            if (_attribute.Name.Equals("CT_NAME") && (_attribute.Value.Equals(_scientist.Cathedra)) ||
                                _scientist.Cathedra.Equals(string.Empty))
                                cathedra = _attribute.Value;
                        }

                        foreach (XmlAttribute _attribute in __scientist.Attributes)
                        {
                            
                            if(_attribute.Name.Equals("SC_NAME"))
                                name = _attribute.Value;


                            if (_attribute.Name.Equals("SC_POST") && ((_attribute.Value.Equals(_scientist.Post)) ||
                                                                      _scientist.Post.Equals(string.Empty)))
                            {
                                post = _attribute.Value;
                            }

                            if (_attribute.Name.Equals("SC_WORKED_TIME") &&(
                                Scientist.IsTimeEqual(_scientist.Time, int.Parse(_attribute.Value)) ||
                                _scientist.Time.Equals(string.Empty)))
                            {
                                time = _attribute.Value;
                            }

                        }



                        if (!name.Equals(string.Empty) && !faculty.Equals(string.Empty) &&
                            !cathedra.Equals(string.Empty) && !post.Equals(string.Empty) && !time.Equals(string.Empty))
                        {
                            Scientist actualScientist = new Scientist(name, faculty, cathedra, post, time);
                            result.Add(actualScientist);
                        }
                    }
                }
            }

            return result;
        }
    }
}
