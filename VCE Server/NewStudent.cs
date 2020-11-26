using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCE_Server
{
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MyDBContext dBContext = new MyDBContext())
            {
              
                User user = new User() { Name = textBox1.Text, Password = textBox2.Text };
                dBContext.Users.Add(user);
                dBContext.SaveChanges();
                MessageBox.Show("Успішно!");
            }
        }
    }
}
