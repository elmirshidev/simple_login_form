using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<User> users = new List<User>()
            {
                new User(1,"Elmir", "elmir@nasa.com" ,  "elmir123"),
                new User(2,"Nihat", "nihat@nasa.com" ,  "nihat123"),
                new User(3,"Nurlan", "nurlan@nasa.com" ,  "nurlan123"),
                new User(4,"Amin", "amin@nasa.com" ,  "amin123"),
            };
            var username = textBox1.Text;
            var password = textBox2.Text;
            if(username.Trim() == "" || password.Trim() == "")
            {
                MessageBox.Show("Fill all fields please!");
                return;
            }
            var foundUser = users.Find(u => u.Name == username);
            if(foundUser == null)
            {
                MessageBox.Show("Username is incorrect!");
                return;
            }
            if(foundUser.Password != password)
            {
                MessageBox.Show("Password is incorrect!");
                return;
            }
            MessageBox.Show("Correct credentials!");
        }
    }
}
