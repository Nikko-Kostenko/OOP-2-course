using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabCalc1
{
    public partial class MainForm : Form
    {
        private const int maxColumn = 15;
        private const int maxRow = 15;

        public MainForm()
        {
            InitializeComponent();
            DataGridViewInitialization();
            TableCellInitialization();
            dataManager.ActualDataManager.Table = dataGridView;
        }

        private void CellUpdate(DataGridViewCell _cell)
        {
            Cell cell = (Cell) _cell.Tag;
        }

        private void CellInitialization(DataGridViewRow row, DataGridViewCell cell)
        {
            string cellName = "C" + (cell.ColumnIndex + 1).ToString() + "R" + (row.Index + 1).ToString();
            cell.Tag = new Cell(cell, cellName, "0");

        }

        private void TableCellInitialization()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    CellInitialization(row, cell);
                }
            }
        }

        private void HeadersInitialization()
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.HeaderText = "C" + (column.Index + 1);
                column.Name = column.HeaderText;
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.HeaderCell.Value = "R" + (row.Index + 1);
            }
        }


        private void DataGridViewInitialization()
        {
            dataGridView.ColumnCount = maxColumn;
            dataGridView.RowCount = maxRow;

            HeadersInitialization();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AddColum_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void deleteColum_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AddColumn_ItemClicked(object sender, EventArgs e)
        {
            dataGridView.Columns.Add("1", "1");
            HeadersInitialization();
        }

        private void DeleteColumn_ItemClicked(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn item in dataGridView.SelectedColumns)
            {
                dataGridView.Columns.Remove(item.Name);
            }
        }

        private void AddRow_ButtonClicked(object sender, EventArgs e)
        {
            dataGridView.Rows.Add();
            HeadersInitialization();
        }

        private void DelRow_ButtonClicked(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView.SelectedRows)
            {
                dataGridView.Rows.RemoveAt(item.Index);
            }
        }

        private void toolTextBox_ExpChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewCell _cell in dataGridView.SelectedCells)
            {
                Cell cell = (Cell) _cell.Tag;
                cell.Exp = toolTextBox.TextBox.Text;
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.Equals(-1) || e.ColumnIndex.Equals(-1))
            {
                return;
            }
            
            
            Cell cell = (Cell) dataGridView[e.ColumnIndex, e.RowIndex].Tag;
            toolTextBox.TextBox.Text = cell.Exp;
            dataGridView[dataGridView.CurrentCell.ColumnIndex, dataGridView.CurrentCell.RowIndex].Value = cell.Value;
        }

        private void toolboxCountBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell _cell in dataGridView.SelectedCells)
            {
                Cell cell = (Cell) _cell.Tag;
                
                    cell.Value = Rpn.Calculate(cell.Exp, dataGridView, cell);
               
                _cell.Value = cell.Value;
               
                foreach (var uppercell in cell.UpperCells)
                {
                    uppercell.Value = Rpn.Calculate(uppercell.Exp, dataGridView, uppercell);
                }
                updateAllCells();
            }

        }
        
        

        private void toolboxCheck_Click(object sender, EventArgs e)
        {
            try
            {
                String s = dataGridView[3, 3].Value.ToString();
                MessageBox.Show(s);
            }
            catch
            {
                MessageBox.Show("Данной ячейки не существует!");
            }
        }

        private void updateAllCells()
        {
            foreach (DataGridViewRow rows in dataGridView.Rows)
            {
                foreach (DataGridViewCell currentCell in rows.Cells )
                {
                   
                    if (currentCell.ColumnIndex >= 0 && currentCell.RowIndex >= 0)
                    {
                        Cell cell = (Cell)currentCell.Tag;
                        cell.Value = Rpn.Calculate(cell.Exp, dataGridView, cell);
                        dataGridView[currentCell.ColumnIndex, currentCell.RowIndex].Value =
                            cell.Value;
                    }
                }
            }
        }

        private void SaveData()
        {
            
            DataTable table = new DataTable("data");
            MakeDataTable(table);
            table.WriteXml(@"C:\Users\f18ra\source\repos\LabCalc1\mytable.xml");

        }

        private void MakeDataTable(DataTable table)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                table.Columns.Add(column.Index.ToString());
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow dataRow = table.NewRow();
                foreach (DataColumn col in table.Columns)
                {
                    Cell cell = (Cell) row.Cells[int.Parse(col.ColumnName)].Tag;
                    dataRow[col.ColumnName] = cell.Exp;
                }

                table.Rows.Add(dataRow);
            }
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Cell cell = (Cell)dataGridView[e.ColumnIndex, e.RowIndex].Tag;
        }

        private void loadData()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"C:\Users\f18ra\source\repos\LabCalc1\mytable.xml");
            DataTable table = dataSet.Tables[0];

            dataGridView.ColumnCount = table.Columns.Count;
            dataGridView.RowCount = table.Rows.Count;

            foreach (DataGridViewRow currentRow in dataGridView.Rows)
            {
                foreach (DataGridViewCell currentCell in currentRow.Cells)
                {
                    string cellName = "C" + (currentCell.ColumnIndex).ToString() + "R" + (currentRow.Index).ToString();
                    string exp = table.Rows[currentCell.RowIndex][currentCell.ColumnIndex].ToString();
                    currentCell.Tag = new Cell(currentCell, cellName, exp);
                }
            }
        }

        private void toolMenuSaveItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void toolMenuOpenItem_Click(object sender, EventArgs e)
        {
            loadData();
            updateAllCells();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("выйти не сохраняя", "системное оповещение", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.No)
            {
                SaveData();
               
                return;
            }
            else if(result == DialogResult.Yes)
            {
               
                return;
            }
            else if(result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
             
        }

        private void toolMenuHelpItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лабараторна підтримує взаємодію з клітинками, а також ви можете завантажити файл ");
        }
    }
}
