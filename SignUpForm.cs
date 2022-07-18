using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

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
            String connStr = "Server=10.10.20.46;Port=3306;Uid=admin;Pwd=admin1234;Database=cschatdb;CHARSET=UTF8";
            conn = new MySqlConnection(connStr);
            conn.Open();
            cmd = new MySqlCommand("", conn);
            Console.WriteLine("연결성공");
        }

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        String userid;

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

        private void btnChkID_Click(object sender, EventArgs e)
        {
            bool chkID = false;
            cmd.CommandText = "select * from users";
            reader = cmd.ExecuteReader();
            if (inputID.Text.Equals(inputID.Tag.ToString()) || inputID.TextLength == 0)
            {
                warnID.Text = "빈 칸 ㄴㄴ";
                reader.Close();
            }
            else
            {
                while (reader.Read())
                {
                    if (reader["userid"].ToString().Equals(inputID.Text))
                    {
                        chkID = false;
                    }
                    else
                    {
                        chkID = true;
                    }
                }
                if (chkID)
                {
                    MessageBox.Show("사용 가능 아이디");
                    userid = inputID.Text;
                }
                else
                {
                    MessageBox.Show("중복 아이디");
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
