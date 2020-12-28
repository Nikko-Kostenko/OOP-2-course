<<<<<<< HEAD:LabCalc1/LabCalc1/dataManager.cs
﻿using System;
using System.Collections.Generic;
using System.Data;
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

        public static Cell GetCell(string CellName, DataGridView table)
        {
            int column;
            int row;
            column = (int)(CellName[1] - '0');
            row = (int) (CellName[3] - '0');
            return (Cell) table[column- 1, row -1].Tag; 
        }

       public static Cell GetCell(DataGridViewCell _dataGridViewCell) 
       {
            return (Cell) _dataGridViewCell.Tag; 
       }

       public static void deleteCellReferences(Cell cell)
       {
           cell.DownCells = new List<Cell>();
       }

       public static void updateCellReference(Cell cell, DataGridView table, List<string> names)
       {
            deleteCellReferences(cell);
            foreach (var name in names)
            {
                Cell upperCell = GetCell(name, table);
                if (!upperCell.UpperCells.Contains(cell))
                {
                    upperCell.UpperCells.Add(cell);
                }

                cell.DownCells.Add(GetCell(name, table));
               Cell downCell = (Cell) table[Rpn.ToInt(name[1]), Rpn.ToInt(name[3])].Tag;
               downCell.UpperCells.Add(cell);
            }
           
       }

       


       public static bool CheckRecursion(Cell _cell)
       {
           if ((_cell.DownCells != null) && _cell.DownCells.Count > 0)
           {
               foreach (var cell in _cell.DownCells)
               {
                   if (IsRecurssion(cell, cell.Name))
                   {
                       return true;
                   }
               }
           }

           return false;

       }
        private static bool IsRecurssion(Cell _cell, string _activeCellName)
        {
             if ((_cell.DownCells != null) && _cell.DownCells.Count > 0) 
             {
                  foreach (var variablecCell in _cell.DownCells)
                  {  
                      if (variablecCell.Name.Equals(_activeCellName) || IsRecurssion(variablecCell, _activeCellName) || IsRecurssion(variablecCell, variablecCell.Name))
                      {
                          return true;
                      }
                      else
                      {
                          return false;
                      }
                  }
             }    
             return false;
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
>>>>>>> d215dba0ccdfbc899672df543402fbe121e44fdb:LabCalc1_v_0.9/LabCalc1/dataManager.cs
