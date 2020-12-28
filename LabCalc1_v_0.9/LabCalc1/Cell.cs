<<<<<<< HEAD:LabCalc1/LabCalc1/Cell.cs
﻿using System;
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
=======
﻿using System;
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
>>>>>>> d215dba0ccdfbc899672df543402fbe121e44fdb:LabCalc1_v_0.9/LabCalc1/Cell.cs
