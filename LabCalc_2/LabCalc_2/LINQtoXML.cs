using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LabCalc_2
{
    class LINQtoXML : IAnalyzerXMLStrategy
    {

        public List<Scientist> Search(Scientist _scientist)
        {
            List<Scientist> allScientists = new List<Scientist>();
            var document = XDocument.Load(@"C:\Users\f18ra\source\repos\LabCalc_2\LabCalc_2\XMLFile.xml");
            var result = from obj in document.Descendants("scientist")
                where
                (
                    (obj.Parent.Parent.Attribute("FC_NAME").Value.Equals(_scientist.Faculty) || _scientist.Faculty.Equals(string.Empty)) &&
                    (obj.Parent.Attribute("CT_NAME").Value.Equals(_scientist.Cathedra) || _scientist.Cathedra.Equals(string.Empty))  &&
                    (obj.Attribute("SC_POST").Value.Equals(_scientist.Post) || _scientist.Name.Equals(string.Empty)) && (Scientist.IsTimeEqual(_scientist.Time, int.Parse(obj.Attribute("SC_WORKED_TIME").Value)) || _scientist.Time.Equals(string.Empty))
                )
                select new
                {
                    faculty = (string)obj.Parent.Parent.Attribute("FC_NAME"),
                    cathera = (string)obj.Parent.Attribute("CT_NAME"),
                    post = (string)obj.Attribute("SC_POST"),
                    time = (string)obj.Attribute("SC_WORKED_TIME"),
                    name = (string)obj.Attribute("SC_NAME")
                };

            foreach (var iSC in result)
            {
              Scientist   foundScientist = new Scientist();
              foundScientist.Faculty = iSC.faculty;
              foundScientist.Cathedra = iSC.faculty;
              foundScientist.Post = iSC.post;
              foundScientist.Time = iSC.time;
              foundScientist.Name = iSC.name;

              allScientists.Add(foundScientist);
              
            }

            return allScientists;
        }
    }
} 



