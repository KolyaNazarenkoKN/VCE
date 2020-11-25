using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //XmlSerializer formatter = new XmlSerializer(typeof(Body));
            XElement xml = XElement.Load(openFileDialog1.OpenFile());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            student.Show();
        }
    }
}
