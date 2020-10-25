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
            string cellName = "R" + (row.Index + 1).ToString() + "C" + (cell.ColumnIndex + 1).ToString();
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
            if (e.RowIndex.Equals(-1) && e.ColumnIndex.Equals(-1))
            {
                return;
            }

            Cell cell = (Cell) dataGridView[e.ColumnIndex, e.RowIndex].Tag;
            dataGridView[dataGridView.CurrentCell.ColumnIndex, dataGridView.CurrentCell.RowIndex].Value =
                cell.Value;
        }

        private void toolboxCountBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell _cell in dataGridView.SelectedCells)
            {
                Cell cell = (Cell) _cell.Tag;
                cell.Value = Rpn.Calculate(cell.Exp, dataGridView);
                _cell.Value = cell.Value;
                dataGridView[dataGridView.CurrentCell.ColumnIndex, dataGridView.CurrentCell.RowIndex].Value =
                    cell.Value;
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

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Cell cell = (Cell)dataGridView[e.ColumnIndex, e.RowIndex].Tag;
        }
    }
}
