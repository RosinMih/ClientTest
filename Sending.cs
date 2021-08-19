using System;
using System.Text;
using System.Net;
using System.Net.Sockets;


namespace ClientTest
{
    class Sending : Main_FormClient
    {
        internal void Send_message(string IP_adress, string Port, string Sending_Message, out string error_report, out string response_message)
        {
            try
            {
                IPEndPoint ipPointServer = new IPEndPoint(IPAddress.Parse(IP_adress), Convert.ToInt32(Port));
                Socket Socket_Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Socket_Server.Connect(ipPointServer);
                byte[] message_by_bytes = Encoding.UTF8.GetBytes(Sending_Message);
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
                response_message = answer_builder.ToString();
                Socket_Server.Shutdown(SocketShutdown.Both);
                Socket_Server.Close();
                error_report = "";
            }
            catch (Exception ex)
            {
                response_message = "";
                error_report = ex.ToString();
            }
        }
    }
}
