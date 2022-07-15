using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatWithFile
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            set_Text(inputID);
            set_Text(inputPW);
            set_Text(inputChkPW);
            set_Text(inputName);
            set_Text(inputPhone);
        }

        void set_Text(TextBox textBox)
        {
            textBox.Text = textBox.Tag.ToString();
            textBox.ForeColor = Color.Gray;
        }

        void input_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.ForeColor == Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                if (textBox.Tag.ToString().StartsWith("비밀번호"))
                    textBox.PasswordChar = '*';
            }
        }

        void input_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "")
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.ForeColor = Color.Gray;
                textBox.PasswordChar = default;
            }
        }

        private void inputID_Enter(object sender, EventArgs e)
        {
            input_Enter(sender, e);
        }

        private void inputID_Leave(object sender, EventArgs e)
        {
            input_Leave(sender, e);
        }

        private void inputPW_Enter(object sender, EventArgs e)
        {
            input_Enter(sender, e);
        }

        private void inputPW_Leave(object sender, EventArgs e)
        {
            input_Leave(sender, e);
        }

        private void inputChkPW_Enter(object sender, EventArgs e)
        {
            input_Enter(sender, e);
        }

        private void inputChkPW_Leave(object sender, EventArgs e)
        {
            input_Leave(sender, e);
        }

        private void inputName_Enter(object sender, EventArgs e)
        {
            input_Enter(sender, e);
        }

        private void inputName_Leave(object sender, EventArgs e)
        {
            input_Leave(sender, e);
        }

        private void inputPhone_Enter(object sender, EventArgs e)
        {
            input_Enter(sender, e);
        }

        private void inputPhone_Leave(object sender, EventArgs e)
        {
            input_Leave(sender, e);
        }
    }
}
