using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace LabCalc_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateComboBoxes();
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        public void UpdateComboBoxes()
        {

            XmlDocument document = new XmlDocument();
            document.Load(@"C:\Users\f18ra\source\repos\LabCalc_2\LabCalc_2\XMLFile.xml");

            XmlElement MainBase = document.DocumentElement;
            XmlNodeList ChildFacultyNodes = MainBase.SelectNodes("faculty");

            foreach (XmlNode _childFacultyNode in ChildFacultyNodes)
            {
                XmlNodeList ChildCathedraNodes = _childFacultyNode.SelectNodes("cathedra");
                foreach (XmlNode _childCathedraNode in ChildCathedraNodes)
                {
                    XmlNodeList ChildScientistNodes = _childCathedraNode.SelectNodes("scientist");
                    foreach (XmlNode _childScientistNode in ChildScientistNodes)
                    {
                        addScientist(_childScientistNode);
                    }
                }
            }
        }

        private void SetTime(int years)
        {
            string newFag = "0 - 5 years";
            string mediumTime = "6 - 15 years";
            string old = "16-60 years";

            if (years >= 0 && years <= 5)
            {
                if (!ComboBoxPost.Items.Contains(newFag))
                    ComboBoxTime.Items.Add(newFag);

            }
            else if (years >= 6 && years <= 15)
            {
                if (!ComboBoxPost.Items.Contains(mediumTime))
                    ComboBoxTime.Items.Add(mediumTime);
            }
            else if (years >= 16)
            {
                if (!ComboBoxPost.Items.Contains(old))
                    ComboBoxTime.Items.Add(old);
            }
        }



        private void addScientist(XmlNode scientist)
        {
            foreach (XmlAttribute _attribute in scientist.ParentNode.ParentNode.Attributes)
            {
                if (!ComboBoxFaculty.Items.Contains(_attribute.Value))
                    ComboBoxFaculty.Items.Add(_attribute.Value);
            }

            foreach (XmlAttribute _attribute in scientist.ParentNode.Attributes)
            {
                if (!ComboBoxCathedra.Items.Contains(_attribute.Value))
                    ComboBoxCathedra.Items.Add(_attribute.Value);
            }

            foreach (XmlAttribute _attribute in scientist.Attributes)
            {
                if (_attribute.Name.Equals("SC_POST") && !(ComboBoxPost.Items.Contains(_attribute.Value)))
                    ComboBoxPost.Items.Add(_attribute.Value);

                if (_attribute.Name.Equals("SC_WORKED_TIME") && !(ComboBoxTime.Items.Contains(Scientist.GetTimeString(int.Parse(_attribute.Value)))))
                    SetTime(int.Parse(_attribute.Value));

            }
        }

        private void buttonSearch_MouseClick(object sender, MouseEventArgs e)
        {
            search();
        }

        private void search()
        {
            List<Scientist> result = new List<Scientist>();

            Scientist scientist = new Scientist();

            if (CheckBoxFaculty.Checked && ComboBoxFaculty.SelectedText.Length > 0)
                scientist.Faculty = ComboBoxFaculty.SelectedItem.ToString();

            if (CheckBoxCathedra.Checked && ComboBoxCathedra.SelectedText.Length > 0)
                scientist.Cathedra = ComboBoxCathedra.SelectedItem.ToString();

            if (CheckBoxPost.Checked && ComboBoxPost.SelectedText.Length > 0)
                scientist.Post = ComboBoxPost.SelectedItem.ToString();

            if (CheckBoxTime.Checked && ComboBoxTime.SelectedText.Length > 0)
                scientist.Time = ComboBoxTime.SelectedItem.ToString();




            if (SaxBtn.Checked)
            {
                IAnalyzerXMLStrategy analyzer = new AnalyzerSAXStrategy();
                analyzer = new AnalyzerSAXStrategy();
                result = analyzer.Search(scientist);
            }
            else if (DomBtn.Checked)
            {
                IAnalyzerXMLStrategy analyzer = new AnalyzerDOMStrategy();
                analyzer = new AnalyzerDOMStrategy();
                result = analyzer.Search(scientist);
            }
            else if (LinqToXmlBtn.Checked)
            {
                IAnalyzerXMLStrategy analyzer = new LINQtoXML();
                analyzer = new LINQtoXML();
                result = analyzer.Search(scientist);
            }

            ResultsBox.Text = "";

            foreach (var VARIABLE in result)
            {
                ResultsBox.Text += "факультет: " + VARIABLE.Faculty + "\n";
                ResultsBox.Text += "кафедра: " + VARIABLE.Cathedra + "\n";
                ResultsBox.Text += "ім'я: " + VARIABLE.Name + "\n";
                ResultsBox.Text += "степінь: " + VARIABLE.Post + "\n";
                ResultsBox.Text += "стаж: " + VARIABLE.Time + "\n";
                ResultsBox.Text +=  "\n";
            }

        }

        private void transformBtn_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xslTable = new XslCompiledTransform();
            xslTable.Load(@"C:\Users\f18ra\source\repos\LabCalc_2\LabCalc_2\scientist.xsl");
            string InXML = @"C:\Users\f18ra\source\repos\LabCalc_2\LabCalc_2\XMLFile.xml";
            string OutHTML = @"C:\Users\f18ra\source\repos\LabCalc_2\LabCalc_2\scientist.html";
            xslTable.Transform(InXML, OutHTML);
        }
    }
}
