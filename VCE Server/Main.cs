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
using System.Xml.Linq;
using System.Xml.Serialization;

namespace VCE_Server
{
    public partial class Main : Form
    {
        NewStudent student = new NewStudent();
        NewGroup newGroup = new NewGroup();
        public Main()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            XElement xml = XElement.Load(openFileDialog1.OpenFile());
            var NameTest = xml.Descendants("TestName").Select(t => t.Value);
            foreach (var element in NameTest)
            {
                listView1.Items.Add(element);
            }
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            student.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            newGroup.Show();
        }
    }
}
