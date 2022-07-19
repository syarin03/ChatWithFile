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
    public partial class ChatForm : Form
    {

        Form parentForm;

        public ChatForm(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
            parentForm.Hide();
        }

        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            chatList.AppendText(inputMsg.Text + "\n");
            chatList.ScrollToCaret();
            inputMsg.ResetText();
            inputMsg.Focus();
        }

        private void chatList_Enter(object sender, EventArgs e)
        {
            inputMsg.Focus();
        }

        private void inputMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSendMsg_Click(sender, e);
            }
        }
    }
}
