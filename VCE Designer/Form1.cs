using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Xml2CSharp;

namespace VCE_Designer
{

    public partial class Form1 : Form
    {
        Body body = new Body();
        public Form1()
        {
            InitializeComponent();
            body.Question = new List<Question>();
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Body));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("NewTest.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, body);

            }

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
            

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
           
            Question question = new Question();
            question.Answer = new List<Answer>();
            Answer answer = new Answer();
            question.NameQuestion = textBox_nametest.Text;
            answer.Description = textBox_question.Text;
            question.Answer.Add(answer);
            body.Question.Add(question);


        }

        private void button_nextquestion_Click(object sender, EventArgs e)
        {
         


        }
    }
}
