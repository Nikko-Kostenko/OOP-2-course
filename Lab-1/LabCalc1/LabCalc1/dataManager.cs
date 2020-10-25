using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LabCalc1
{
    class dataManager
    {
        private DataGridView table;
        private static dataManager actualDataManager;

        public DataGridView Table
        {
             set
             {
                 table = value;
             }
        }
        public static dataManager ActualDataManager
        {
            get
            {
                if (actualDataManager == null)
                {
                    actualDataManager = new dataManager();
                }

                return actualDataManager;
            }
        }

        private dataManager() {}

        public Cell GetCell(string CellName)
        {
            int column;
            int row;
            column = (int)(CellName[1] - '0');
            row = (int) (CellName[3] - '0');
            return (Cell) table[column, row].Tag; 
        }


    }
}
