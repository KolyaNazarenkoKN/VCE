using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Xml2CSharp;

namespace VCE_Designer
{

    public partial class Main : Form
    {
        Body body = new Body();
        Question question = new Question();
        public Main()
        {
            InitializeComponent();
            question.Answer = new List<Answer>();
            body.Question = new List<Question>();
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            XmlSerializer formatter = new XmlSerializer(typeof(Body));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, body);
            }
            MessageBox.Show("Файл збережений!", "Успішно",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            XmlSerializer formatter = new XmlSerializer(typeof(Body));
            XElement xml = XElement.Load(openFileDialog1.OpenFile());
            var Author = xml.Descendants("Author").Select(t => t.Value);
            foreach (var element in Author)
            {
                textBox1.Text = element;
            }
            var TestName = xml.Descendants("TestName").Select(t => t.Value);
            foreach (var element in TestName)
            {
                textBox2.Text = element;
            }
            var NameQuestion = xml.Descendants("NameQuestion").Select(t => t.Value);
            foreach (var element in NameQuestion)
            {
                textBox4.Text = element;
            }
            var description = xml.Descendants("description").Select(t => t.Value);
            foreach (var element in description)
            {
                textBox3.Text = element;
            }
            MessageBox.Show("Файл відкрито!", "Успішно",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);    
     
        }
    
        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button_ok_Click(object sender, EventArgs e)
        {
            string author = textBox_nameauthor.Text;
            string NameTest = textBox_TestName.Text;
            string NameQuestion = textBox_NameQuestion.Text;
            string Description = textBox_Description.Text;
            body.Author = author;
            body.TestName = NameTest;
            question.NameQuestion = NameQuestion;
            body.Question.Add(question);
            textBox_nameauthor.Text = "";
            textBox_TestName.Text = "";
            textBox_NameQuestion.Text = "";
            textBox_Description.Text = "";

        }

        private void button_nextquestion_Click(object sender, EventArgs e)
        {

            string NameQuestion = textBox_NameQuestion.Text;
            string Description = textBox_Description.Text;
            Question question = new Question();
            question.Answer = new List<Answer>();
            Answer answer = new Answer();
            question.NameQuestion = NameQuestion;
            answer.Description = Description;
            question.Answer.Add(answer);
            body.Question.Add(question);
            textBox_NameQuestion.Text = "";
            textBox_Description.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string Description = textBox_Description.Text;
            Answer answer = new Answer();
            answer.Description = Description;
            question.Answer.Add(answer);
            textBox_Description.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string author = textBox_nameauthor.Text;
            string NameTest = textBox_TestName.Text;
            string Namequestion = textBox_NameQuestion.Text;
            string Description = textBox_Description.Text;
            body.Author = author;
            body.TestName = NameTest;
            question.NameQuestion = Namequestion;
            body.Question.Add(question);
            saveFileDialog1.Filter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            XmlSerializer formatter = new XmlSerializer(typeof(Body));
            using (FileStream fs = new FileStream(filename, FileMode.CreateNew))
            {
                formatter.Deserialize(fs);
            }
            MessageBox.Show("Файл змінений!", "Успішно",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
