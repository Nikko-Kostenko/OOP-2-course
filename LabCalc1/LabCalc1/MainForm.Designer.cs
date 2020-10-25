namespace LabCalc1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolMenuFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuOpenItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuSaveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuPropertiesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuHelpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuDevInfoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolboxAddColumnBtn = new System.Windows.Forms.ToolStripButton();
            this.toolboxAddRowBtn = new System.Windows.Forms.ToolStripButton();
            this.toolboxDelColumnBtn = new System.Windows.Forms.ToolStripButton();
            this.toolboxDelRowBtn = new System.Windows.Forms.ToolStripButton();
            this.toolTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolboxCountBtn = new System.Windows.Forms.ToolStripButton();
            this.toolboxCheck = new System.Windows.Forms.ToolStripButton();
            this.toolboxSplitDelBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuFileItem,
            this.toolMenuHelpItem,
            this.toolMenuDevInfoItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolMenuFileItem
            // 
            this.toolMenuFileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuOpenItem,
            this.toolMenuSaveItem,
            this.toolMenuPropertiesItem});
            this.toolMenuFileItem.Name = "toolMenuFileItem";
            this.toolMenuFileItem.Size = new System.Drawing.Size(37, 20);
            this.toolMenuFileItem.Text = "File";
            // 
            // toolMenuOpenItem
            // 
            this.toolMenuOpenItem.Name = "toolMenuOpenItem";
            this.toolMenuOpenItem.Size = new System.Drawing.Size(116, 22);
            this.toolMenuOpenItem.Text = "Open ";
            // 
            // toolMenuSaveItem
            // 
            this.toolMenuSaveItem.Name = "toolMenuSaveItem";
            this.toolMenuSaveItem.Size = new System.Drawing.Size(116, 22);
            this.toolMenuSaveItem.Text = "Save";
            // 
            // toolMenuPropertiesItem
            // 
            this.toolMenuPropertiesItem.Name = "toolMenuPropertiesItem";
            this.toolMenuPropertiesItem.Size = new System.Drawing.Size(116, 22);
            this.toolMenuPropertiesItem.Text = "Options";
            // 
            // toolMenuHelpItem
            // 
            this.toolMenuHelpItem.Name = "toolMenuHelpItem";
            this.toolMenuHelpItem.Size = new System.Drawing.Size(44, 20);
            this.toolMenuHelpItem.Text = "Help";
            // 
            // toolMenuDevInfoItem
            // 
            this.toolMenuDevInfoItem.Name = "toolMenuDevInfoItem";
            this.toolMenuDevInfoItem.Size = new System.Drawing.Size(52, 20);
            this.toolMenuDevInfoItem.Text = "About";
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Silver;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolboxAddColumnBtn,
            this.toolboxAddRowBtn,
            this.toolboxDelColumnBtn,
            this.toolboxDelRowBtn,
            this.toolTextBox,
            this.toolboxCountBtn,
            this.toolboxCheck});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(780, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "Toolbox";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolboxAddColumnBtn
            // 
            this.toolboxAddColumnBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolboxAddColumnBtn.Image = ((System.Drawing.Image)(resources.GetObject("toolboxAddColumnBtn.Image")));
            this.toolboxAddColumnBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolboxAddColumnBtn.Name = "toolboxAddColumnBtn";
            this.toolboxAddColumnBtn.Size = new System.Drawing.Size(79, 22);
            this.toolboxAddColumnBtn.Text = "Add Column";
            this.toolboxAddColumnBtn.Click += new System.EventHandler(this.AddColumn_ItemClicked);
            // 
            // toolboxAddRowBtn
            // 
            this.toolboxAddRowBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolboxAddRowBtn.Image = ((System.Drawing.Image)(resources.GetObject("toolboxAddRowBtn.Image")));
            this.toolboxAddRowBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolboxAddRowBtn.Name = "toolboxAddRowBtn";
            this.toolboxAddRowBtn.Size = new System.Drawing.Size(59, 22);
            this.toolboxAddRowBtn.Text = "Add Row";
            this.toolboxAddRowBtn.Click += new System.EventHandler(this.AddRow_ButtonClicked);
            // 
            // toolboxDelColumnBtn
            // 
            this.toolboxDelColumnBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolboxDelColumnBtn.Image = ((System.Drawing.Image)(resources.GetObject("toolboxDelColumnBtn.Image")));
            this.toolboxDelColumnBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolboxDelColumnBtn.Name = "toolboxDelColumnBtn";
            this.toolboxDelColumnBtn.Size = new System.Drawing.Size(90, 22);
            this.toolboxDelColumnBtn.Text = "Delete Column";
            this.toolboxDelColumnBtn.Click += new System.EventHandler(this.DeleteColumn_ItemClicked);
            // 
            // toolboxDelRowBtn
            // 
            this.toolboxDelRowBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolboxDelRowBtn.Image = ((System.Drawing.Image)(resources.GetObject("toolboxDelRowBtn.Image")));
            this.toolboxDelRowBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolboxDelRowBtn.Name = "toolboxDelRowBtn";
            this.toolboxDelRowBtn.Size = new System.Drawing.Size(70, 22);
            this.toolboxDelRowBtn.Text = "Delete Row";
            this.toolboxDelRowBtn.Click += new System.EventHandler(this.DelRow_ButtonClicked);
            // 
            // toolTextBox
            // 
            this.toolTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolTextBox.Name = "toolTextBox";
            this.toolTextBox.Size = new System.Drawing.Size(400, 25);
            this.toolTextBox.TextChanged += new System.EventHandler(this.toolTextBox_ExpChanged);
            // 
            // toolboxCountBtn
            // 
            this.toolboxCountBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolboxCountBtn.Image = ((System.Drawing.Image)(resources.GetObject("toolboxCountBtn.Image")));
            this.toolboxCountBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolboxCountBtn.Name = "toolboxCountBtn";
            this.toolboxCountBtn.Size = new System.Drawing.Size(40, 22);
            this.toolboxCountBtn.Text = "apply";
            this.toolboxCountBtn.Click += new System.EventHandler(this.toolboxCountBtn_Click);
            // 
            // toolboxCheck
            // 
            this.toolboxCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolboxCheck.Image = ((System.Drawing.Image)(resources.GetObject("toolboxCheck.Image")));
            this.toolboxCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolboxCheck.Name = "toolboxCheck";
            this.toolboxCheck.Size = new System.Drawing.Size(30, 22);
            this.toolboxCheck.Text = "test";
            this.toolboxCheck.Click += new System.EventHandler(this.toolboxCheck_Click);
            // 
            // toolboxSplitDelBtn
            // 
            this.toolboxSplitDelBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolboxSplitDelBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolboxSplitDelBtn.Name = "toolboxSplitDelBtn";
            this.toolboxSplitDelBtn.Size = new System.Drawing.Size(56, 22);
            this.toolboxSplitDelBtn.Text = "Delete";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView.Location = new System.Drawing.Point(0, 47);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(779, 359);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.Text = "dataGridView1";
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(780, 406);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MyCalc";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolChangeThemeItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolMenuFileItem;
        private System.Windows.Forms.ToolStripMenuItem toolMenuOpenItem;
        private System.Windows.Forms.ToolStripMenuItem toolMenuSaveItem;
        private System.Windows.Forms.ToolStripMenuItem toolMenuPropertiesItem;
        private System.Windows.Forms.ToolStripMenuItem toolMenuHelpItem;
        private System.Windows.Forms.ToolStripMenuItem toolMenuDevInfoItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSplitButton toolboxSplitDelBtn;
        private System.Windows.Forms.ToolStripButton toolboxAddColumnBtn;
        private System.Windows.Forms.ToolStripButton toolboxAddRowBtn;
        private System.Windows.Forms.ToolStripButton toolboxDelColumnBtn;
        private System.Windows.Forms.ToolStripButton toolboxDelRowBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripTextBox toolTextBox;
        private System.Windows.Forms.ToolStripButton toolboxCountBtn;
        private System.Windows.Forms.ToolStripButton toolboxCheck;
    }
}

