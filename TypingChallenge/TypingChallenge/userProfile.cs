using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingChallenge
{
    public partial class userProfile : Form
    {
        public userProfile()
        {
            InitializeComponent();
        }
        public bool DataOk()
        {
            bool player = true;
            if(firstName.Text.Length==0 || firstName.Text is null)
            {
                firstNameMsg.Text = "First Name Is Required";
                firstNameMsg.ForeColor = Color.Red;
                player = false;
            }
            if (lastName.Text.Length == 0 || lastName.Text is null)
            {
                lastNameMsg.Text = "Last Name Is Required";
                lastNameMsg.ForeColor = Color.Red;
                player = false;
            }
            return player;
        }
        private void userProfile_Load(object sender, EventArgs e)
        {
            salutation.SelectedIndex = 0;
            firstName.Text = null;
            firstNameMsg.Text = null;
            lastName.Text = null;
            lastNameMsg.Text = null;
            firstNameMsg.ForeColor = Color.Black;
            lastNameMsg.ForeColor = Color.Black;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            salutation.SelectedIndex = 0;
            firstName.Text = null;
            firstNameMsg.Text = null;
            lastName.Text = null;
            lastNameMsg.Text = null;
            firstNameMsg.ForeColor = Color.Black;
            lastNameMsg.ForeColor = Color.Black;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if(DataOk())
            {
                this.Hide();
                Form1 TypingSpeed = new Form1(salutation.SelectedItem.ToString(),firstName.Text,lastName.Text);
                //when close the typing_challenge form close the program
                TypingSpeed.FormClosed += new FormClosedEventHandler(TypingSpeed_FormClosed);
                //open the start programe
                TypingSpeed.ShowDialog();
            }
        }
        private void TypingSpeed_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
