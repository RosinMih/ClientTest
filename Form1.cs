using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Threading.Tasks;


namespace ClientTest
{
    public partial class Form1 : Form
    {
 
        void Send ()
        {
            try
            {
                IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(IP.Text), Convert.ToInt32(Port.Text));
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ipPoint);	// подключаемся к удаленному хосту
                string message = TextSend.Text;
                byte[] data = Encoding.UTF8.GetBytes(message);
                socket.Send(data);			//Отправляем сообщение

                // получаем ответ
                byte[] data2 = new byte[10000]; // буфер для ответа
                StringBuilder builder = new StringBuilder();
                int bytes = 0; // количество полученных байт
                do
                {
                    bytes = socket.Receive(data2, data2.Length, 0);
                    builder.Append(Encoding.UTF8.GetString(data2, 0, bytes));
                }
                while (socket.Available > 0);
                //MessageBox.Show("ответ сервера: " + builder.ToString());
                textBox4.Text = textBox4.Text + "Ответ сервера: " + builder.ToString() + "\r\n";
                // закрываем сокет
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                button1.BackColor = Color.FromArgb(200, 200, 200, 200);
                textBox4.Text = textBox4.Text + ex.Message + "\r\n";
                //MessageBox.Show(ex.Message);
            }

        }

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           button1.BackColor = Color.Red;

            if (!IPAddress.TryParse(IP.Text, out IPAddress address))     // Определяем является ли строка ip-адресом
            {
                button1.BackColor = Color.FromArgb(200, 200, 200, 200);
                textBox4.Text = textBox4.Text + "Ошибочно введен IP адрес \r\n";
                return;
            }

                try
                {
                    // Проверяем, корректно ли введен порт
                    int Prt = Convert.ToInt32(Port.Text);
                }
                catch
                {
                    button1.BackColor = Color.FromArgb(200, 200, 200, 200);
                    textBox4.Text = textBox4.Text + "Ошибочно введен номер порта \r\n";
                    return;
                }

            
         }

            private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(200, 200, 200, 200);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Red)
            {
                Send();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            textBox4.Height = this.Height - 230;
        }
    }
}
