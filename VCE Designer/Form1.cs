using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Xml2CSharp;

namespace VCE_Designer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Body body = new Body();
            saveFileDialog1.Filter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            NewQuestion();
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, "");
            MessageBox.Show("Файл збережен");
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            textBox_nametest.Text = fileText;
            MessageBox.Show("Файл відкрито", "Успішно!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewQuestion()
        {
            Question question = new Question();
            Body body = new Body();
            XmlDocument Doc = new XmlDocument();
            XmlDeclaration dec = Doc.CreateXmlDeclaration("1.0", null, null);
            Doc.AppendChild(dec);
            XmlElement DocRoot = Doc.CreateElement(body.ToString());
            Doc.AppendChild(DocRoot);

            XmlNode server = Doc.CreateElement(body.Question.Difficulty);
            DocRoot.AppendChild(server);
            server.InnerText = this.textBox_nametest.Text;

            XmlNode server2 = Doc.CreateElement(body.Question.Description);
            DocRoot.AppendChild(server2);
            server2.InnerText = this.textBox_question.Text;

            Doc.Save(Application.StartupPath + "\\xmlfile.xml");

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            Body body = new Body();
            //XElement doc = new XElement("question",
            //   new XElement(body.Question.Difficulty, textBox_nametest.Text),
            //   new XElement(body.Question.Description, textBox_question.Text)
            //   );

            //string filename = saveFileDialog1.FileName;
            //doc.Save(filename);

        }

        private void button_nextquestion_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            question.Description = textBox_question.Text;


        }
    }
}
