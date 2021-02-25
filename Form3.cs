using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demka25
{
    public partial class Form3 : Form
    {
        Model1 db = new Model1();
        public static Form3 FORMA { get; set; }
        public static User USER { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // LOGIN
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Необходимо ввести логин и пароль");
                return;
            }
            User usr = db.User.Find(textBox1.Text);
            if (usr != null && usr.Password == textBox2.Text)
            {
                USER = usr;
                FORMA = this;
                if (usr.RoleId == R)
                {
                    Form4 frm = new Form4();
                    this.Close();
                    frm.Show();
                }
                else if (usr.RoleId == C)
                {
                    Form5 frm = new Form5();
                    frm.Show();
                    this.Close();
                }
                else if (usr.RoleId == A)
                {
                    Form6 frm = new Form6();
                    frm.Show();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
                return;
            }
        }
    }
}
