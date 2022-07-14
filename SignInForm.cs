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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

/*        MySqlConnection conn;
        MySqlCommand cmd;*/

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Console.WriteLine("click");
            SignUpForm signup = new SignUpForm();
            signup.Show();
        }
    }
}
