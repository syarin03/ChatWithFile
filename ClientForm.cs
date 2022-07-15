using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ChatWithFile
{
    public partial class ClientForm : Form
    {
        TcpClient client;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient(); //연결
                client.Connect("127.0.0.1", 8080); //설정
                button1.Enabled = false;
            }
            catch (SocketException)
            {
                button1.Enabled = true;
                MessageBox.Show("실패");
            }
            catch (Exception)
            {
                button1.Enabled = true;
                MessageBox.Show("실패");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1024];
            string str = string.Empty;
            str = textBox1.Text;

            try
            {
                for (int i = 0; i < 1024; i++) buffer[i] = 0; //서버설명과 같음.
                buffer = Encoding.Default.GetBytes(str);
                NetworkStream net = client.GetStream(); //서버설명과 같음.
                net.Write(buffer, 0, buffer.Length); //버퍼에 데이터를 씀 c++로따지면 send함수
                net.Flush(); //버퍼비우기
                textBox1.Clear();
            }
            catch (SocketException se)
            {
                MessageBox.Show("실패");
            }
            catch (Exception ee)
            {
                MessageBox.Show("실패");
            }
        }
    }
}
