using System;
using System.Collections.Generic;
using System.Text;

namespace LabCalc1
{
    class RecExceptions : Exception
    {
        public RecExceptions(string massage)
            : base(massage)
        {}
    }
}
