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
    public partial class LoginAdmin : Form
    {
        Main main = new Main();
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                main.Show();
            }
            else
            {
                MessageBox.Show("Логін або пароль не правильний!", "Помилка",
         MessageBoxButtons.OK,
         MessageBoxIcon.Error);
            }
            this.Hide();
        }
    }
}
