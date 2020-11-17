namespace LabCalc_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckBoxFaculty = new System.Windows.Forms.CheckBox();
            this.CheckBoxCathedra = new System.Windows.Forms.CheckBox();
            this.CheckBoxPost = new System.Windows.Forms.CheckBox();
            this.CheckBoxTime = new System.Windows.Forms.CheckBox();
            this.DomBtn = new System.Windows.Forms.RadioButton();
            this.SaxBtn = new System.Windows.Forms.RadioButton();
            this.LinqToXmlBtn = new System.Windows.Forms.RadioButton();
            this.ComboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.ComboBoxCathedra = new System.Windows.Forms.ComboBox();
            this.ComboBoxPost = new System.Windows.Forms.ComboBox();
            this.ComboBoxTime = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.ResultsBox = new System.Windows.Forms.RichTextBox();
            this.transformBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckBoxFaculty
            // 
            this.CheckBoxFaculty.AutoSize = true;
            this.CheckBoxFaculty.Location = new System.Drawing.Point(12, 32);
            this.CheckBoxFaculty.Name = "CheckBoxFaculty";
            this.CheckBoxFaculty.Size = new System.Drawing.Size(79, 17);
            this.CheckBoxFaculty.TabIndex = 0;
            this.CheckBoxFaculty.Text = "факультет";
            this.CheckBoxFaculty.UseVisualStyleBackColor = true;
            this.CheckBoxFaculty.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox1_MouseClick);
            // 
            // CheckBoxCathedra
            // 
            this.CheckBoxCathedra.AutoSize = true;
            this.CheckBoxCathedra.Location = new System.Drawing.Point(12, 68);
            this.CheckBoxCathedra.Name = "CheckBoxCathedra";
            this.CheckBoxCathedra.Size = new System.Drawing.Size(70, 17);
            this.CheckBoxCathedra.TabIndex = 1;
            this.CheckBoxCathedra.Text = "кафедра";
            this.CheckBoxCathedra.UseVisualStyleBackColor = true;
            // 
            // CheckBoxPost
            // 
            this.CheckBoxPost.AutoSize = true;
            this.CheckBoxPost.Location = new System.Drawing.Point(12, 106);
            this.CheckBoxPost.Name = "CheckBoxPost";
            this.CheckBoxPost.Size = new System.Drawing.Size(81, 17);
            this.CheckBoxPost.TabIndex = 2;
            this.CheckBoxPost.Text = "должность";
            this.CheckBoxPost.UseVisualStyleBackColor = true;
            // 
            // CheckBoxTime
            // 
            this.CheckBoxTime.AutoSize = true;
            this.CheckBoxTime.Location = new System.Drawing.Point(12, 147);
            this.CheckBoxTime.Name = "CheckBoxTime";
            this.CheckBoxTime.Size = new System.Drawing.Size(51, 17);
            this.CheckBoxTime.TabIndex = 3;
            this.CheckBoxTime.Text = "стаж";
            this.CheckBoxTime.UseVisualStyleBackColor = true;
            // 
            // DomBtn
            // 
            this.DomBtn.AutoSize = true;
            this.DomBtn.Location = new System.Drawing.Point(12, 234);
            this.DomBtn.Name = "DomBtn";
            this.DomBtn.Size = new System.Drawing.Size(47, 17);
            this.DomBtn.TabIndex = 4;
            this.DomBtn.TabStop = true;
            this.DomBtn.Text = "Dom";
            this.DomBtn.UseVisualStyleBackColor = true;
            // 
            // SaxBtn
            // 
            this.SaxBtn.AutoSize = true;
            this.SaxBtn.Location = new System.Drawing.Point(126, 234);
            this.SaxBtn.Name = "SaxBtn";
            this.SaxBtn.Size = new System.Drawing.Size(46, 17);
            this.SaxBtn.TabIndex = 5;
            this.SaxBtn.TabStop = true;
            this.SaxBtn.Text = "SAX";
            this.SaxBtn.UseVisualStyleBackColor = true;
            // 
            // LinqToXmlBtn
            // 
            this.LinqToXmlBtn.AutoSize = true;
            this.LinqToXmlBtn.Location = new System.Drawing.Point(232, 234);
            this.LinqToXmlBtn.Name = "LinqToXmlBtn";
            this.LinqToXmlBtn.Size = new System.Drawing.Size(80, 17);
            this.LinqToXmlBtn.TabIndex = 6;
            this.LinqToXmlBtn.TabStop = true;
            this.LinqToXmlBtn.Text = "LinqToXML";
            this.LinqToXmlBtn.UseVisualStyleBackColor = true;
            // 
            // ComboBoxFaculty
            // 
            this.ComboBoxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFaculty.FormattingEnabled = true;
            this.ComboBoxFaculty.Location = new System.Drawing.Point(116, 28);
            this.ComboBoxFaculty.Name = "ComboBoxFaculty";
            this.ComboBoxFaculty.Size = new System.Drawing.Size(201, 21);
            this.ComboBoxFaculty.TabIndex = 7;
            // 
            // ComboBoxCathedra
            // 
            this.ComboBoxCathedra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCathedra.FormattingEnabled = true;
            this.ComboBoxCathedra.Location = new System.Drawing.Point(116, 64);
            this.ComboBoxCathedra.Name = "ComboBoxCathedra";
            this.ComboBoxCathedra.Size = new System.Drawing.Size(201, 21);
            this.ComboBoxCathedra.TabIndex = 8;
            // 
            // ComboBoxPost
            // 
            this.ComboBoxPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPost.FormattingEnabled = true;
            this.ComboBoxPost.Location = new System.Drawing.Point(116, 102);
            this.ComboBoxPost.Name = "ComboBoxPost";
            this.ComboBoxPost.Size = new System.Drawing.Size(201, 21);
            this.ComboBoxPost.TabIndex = 9;
            // 
            // ComboBoxTime
            // 
            this.ComboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTime.FormattingEnabled = true;
            this.ComboBoxTime.Location = new System.Drawing.Point(116, 142);
            this.ComboBoxTime.Name = "ComboBoxTime";
            this.ComboBoxTime.Size = new System.Drawing.Size(201, 21);
            this.ComboBoxTime.TabIndex = 10;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(126, 304);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSearch_MouseClick);
            // 
            // ResultsBox
            // 
            this.ResultsBox.Location = new System.Drawing.Point(395, 13);
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.Size = new System.Drawing.Size(334, 425);
            this.ResultsBox.TabIndex = 12;
            this.ResultsBox.Text = "";
            // 
            // transformBtn
            // 
            this.transformBtn.Location = new System.Drawing.Point(7, 415);
            this.transformBtn.Name = "transformBtn";
            this.transformBtn.Size = new System.Drawing.Size(75, 23);
            this.transformBtn.TabIndex = 13;
            this.transformBtn.Text = "transform";
            this.transformBtn.UseVisualStyleBackColor = true;
            this.transformBtn.Click += new System.EventHandler(this.transformBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transformBtn);
            this.Controls.Add(this.ResultsBox);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.ComboBoxTime);
            this.Controls.Add(this.ComboBoxPost);
            this.Controls.Add(this.ComboBoxCathedra);
            this.Controls.Add(this.ComboBoxFaculty);
            this.Controls.Add(this.LinqToXmlBtn);
            this.Controls.Add(this.SaxBtn);
            this.Controls.Add(this.DomBtn);
            this.Controls.Add(this.CheckBoxTime);
            this.Controls.Add(this.CheckBoxPost);
            this.Controls.Add(this.CheckBoxCathedra);
            this.Controls.Add(this.CheckBoxFaculty);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBoxFaculty;
        private System.Windows.Forms.CheckBox CheckBoxCathedra;
        private System.Windows.Forms.CheckBox CheckBoxPost;
        private System.Windows.Forms.CheckBox CheckBoxTime;
        private System.Windows.Forms.RadioButton DomBtn;
        private System.Windows.Forms.RadioButton SaxBtn;
        private System.Windows.Forms.RadioButton LinqToXmlBtn;
        private System.Windows.Forms.ComboBox ComboBoxFaculty;
        private System.Windows.Forms.ComboBox ComboBoxCathedra;
        private System.Windows.Forms.ComboBox ComboBoxPost;
        private System.Windows.Forms.ComboBox ComboBoxTime;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.RichTextBox ResultsBox;
        private System.Windows.Forms.Button transformBtn;
    }
}

