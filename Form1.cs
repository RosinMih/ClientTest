using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace ClientTest
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }
        private void Button_Start_Click(object sender, EventArgs e)
        {
           Button_Start.BackColor = Color.Red;

            if (!IPAddress.TryParse(SET_IP_Adress_Server.Text, out IPAddress address))  
            {
                Button_Start.BackColor = Color.FromArgb(200, 200, 200, 200);
                TextBox_IncomigMessages.Text = TextBox_IncomigMessages.Text + "Ошибочно введен IP адрес \r\n";
                return;
            }

                try
                {
                    int Checking_for_a_Port = Convert.ToInt32(SET_Port_Server.Text);
                }
                catch
                {
                    Button_Start.BackColor = Color.FromArgb(200, 200, 200, 200);
                    TextBox_IncomigMessages.Text = TextBox_IncomigMessages.Text + "Ошибочно введен номер порта \r\n";
                    return;
                }
         }

        private void Button_Stop_Click(object sender, EventArgs e)
        {
            Button_Start.BackColor = Color.FromArgb(200, 200, 200, 200);
        }

        private void Timer_Sending_a_message_Tick(object sender, EventArgs e)
        {
            if (Button_Start.BackColor == Color.Red)
            {
                Sending_a_message();
            }
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            TextBox_IncomigMessages.Clear();
        }

        private void FormClient_SizeChanged(object sender, EventArgs e)
        {
            TextBox_IncomigMessages.Height = this.Height - 230;
        }

        //Method of sending a message to the server and receiving a response
        void Sending_a_message()
        {
            try
            {
                IPEndPoint ipPointServer = new IPEndPoint(IPAddress.Parse(SET_IP_Adress_Server.Text), Convert.ToInt32(SET_Port_Server.Text));
                Socket Socket_Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Socket_Server.Connect(ipPointServer);	
                string Sending_a_message = MessageText.Text;
                byte[] message_by_bytes = Encoding.UTF8.GetBytes(Sending_a_message);
                Socket_Server.Send(message_by_bytes);
                byte[] buffer_for_receiving = new byte[10000];
                StringBuilder answer_builder = new StringBuilder();
                int bytes = 0; 
                do
                {
                    bytes = Socket_Server.Receive(buffer_for_receiving, buffer_for_receiving.Length, 0);
                    answer_builder.Append(Encoding.UTF8.GetString(buffer_for_receiving, 0, bytes));
                }
                while (Socket_Server.Available > 0);
                TextBox_IncomigMessages.Text = TextBox_IncomigMessages.Text + "Ответ сервера: " + answer_builder.ToString() + "\r\n";
                Socket_Server.Shutdown(SocketShutdown.Both);
                Socket_Server.Close();
            }
            catch (Exception ex)
            {
                Button_Start.BackColor = Color.FromArgb(200, 200, 200, 200);
                TextBox_IncomigMessages.Text = TextBox_IncomigMessages.Text + ex.Message + "\r\n";
            }

        }

    }
}
