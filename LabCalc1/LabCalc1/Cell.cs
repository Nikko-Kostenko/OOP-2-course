using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LabCalc1
{
    class Cell
    {
        private DataGridViewCell mainCell;

        private string _name;
        private double _value;
        private string _exp;
        public List<Cell> DownCells;
        public List<Cell> UpperCells;
        

        public string Exp
        {
            set
            {
                _exp = value;
            }
            get
            {
                return _exp;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

       

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
            _name = Name;
            mainCell = MainCell;
            _exp = Exp;
            _value = 0;
            DownCells = new List<Cell>();
            UpperCells = new List<Cell>();

        }

        Cell()
        {
            _name = "";
        }

       
    }
}
