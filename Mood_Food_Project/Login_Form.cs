using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mood_Food_Project
{
    public partial class Login_Form : Form
    {
        private string username = "Admin";
        private string password = "Admin123";
        public Login_Form()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == username && textBoxPassword.Text == password)
            {
                MessageBox.Show("Login successful");
                Rating_Suggestion_Form rating_Form = new Rating_Suggestion_Form();
                rating_Form.Show();
                this.Hide(); 
            }

            else
            {
                MessageBox.Show("Please enter valid username and password");
                clearText();
            }
        }
        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearText()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }
    }
}
