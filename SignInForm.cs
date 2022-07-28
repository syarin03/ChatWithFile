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
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ChatWithFile
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            set_Text(inputID);
            set_Text(inputPW);
            String connStr = "Server=10.10.20.46;Port=3306;Uid=user01;Pwd=user01;Database=cschatdb;CHARSET=UTF8";
            conn = new MySqlConnection(connStr);
            conn.Open();
            cmd = new MySqlCommand("", conn);
        }

        struct LoginUser
        {
            public String userID;
            public String userPW;
            public String userName;
            public String userPhone;
        }

        MySqlConnection conn;
        MySqlCommand cmd;

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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm();
            signup.Show();
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

        private void btnSignin_Click(object sender, EventArgs e)
        {

            cmd.CommandText = "select * from usertbl";
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            LoginUser user;
            while (reader.Read())
            {
                if (reader["userid"].ToString().Equals(inputID.Text))
                {
                    Console.WriteLine("same id");
                    if (reader["userpw"].ToString().Equals(inputPW.Text))
                    {
                        Console.WriteLine("same pw");
                        Console.WriteLine("success");
                        MessageBox.Show("로그인 성공");
                        user.userID = reader["userid"].ToString();
                        user.userPW = reader["userpw"].ToString();
                        user.userName = reader["username"].ToString();
                        user.userPhone = reader["userphone"].ToString();
                        ChatForm chat = new ChatForm(this);
                        chat.Show();
                    }
                }
            }
        }

        private void inputPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSignin_Click(sender, e);
            }
        }

        /*        private void button1_Click(object sender, EventArgs e) // 이미지 불러오기
                {
                    string image_file = string.Empty;

                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.InitialDirectory = @"D:\";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        image_file = dialog.FileName;
                    }
                    else if (dialog.ShowDialog() == DialogResult.Cancel)
                    {
                        return;
                    }

                    pictureBox1.Image = Bitmap.FromFile(image_file);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }*/
    }
}
