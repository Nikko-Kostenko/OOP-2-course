using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCalc_2
{
    interface IAnalyzerXMLStrategy
    {
        List<Scientist> Search(Scientist _scientist);
    }
}
