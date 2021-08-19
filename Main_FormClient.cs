using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;


namespace ClientTest
{
    public partial class Main_FormClient : Form
    {
        public Main_FormClient()
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
                string IP_Adress = SET_IP_Adress_Server.Text;
                string Port = SET_Port_Server.Text;
                string Message = MessageText.Text;

                Sending sending = new Sending();
                sending.Send_message(IP_Adress, Port, Message, out string error_report, out string response_message);

                if (!String.IsNullOrWhiteSpace(error_report))
                {
                    Button_Start.BackColor = Color.FromArgb(200, 200, 200, 200);
                    TextBox_IncomigMessages.Text = TextBox_IncomigMessages.Text + error_report + "\r\n";
                    return;
                }

                TextBox_IncomigMessages.Text = TextBox_IncomigMessages.Text + "Ответ сервера: " + response_message + "\r\n";
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
    }
}
