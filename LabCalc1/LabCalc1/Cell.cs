using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LabCalc1
{
    class Cell
    {
        private DataGridViewCell mainCell;

        private string name;
        private double _value;
        private string exp;
        public string Exp
        {
            set
            {
                exp = value;
            }
            get
            {
                return exp;
            }
        }

        private List<string> ForwardingList;
        private List<string> UsedList;

        public double Value
        {
            set
            {
                _value = value;
            }
            get
            {
                return _value;
            }
        }
        public DataGridViewCell MainCell
        {
            get
            {
                return mainCell;
            }
        }

        public Cell(DataGridViewCell MainCell, string Name, string Exp)
        {
            name = Name;
            mainCell = MainCell;
            exp = Exp;
            _value = 0;

        }

        Cell()
        {
            name = "";
        }

       
    }
}
