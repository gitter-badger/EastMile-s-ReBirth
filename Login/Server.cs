using System;
using System.Windows.Forms;
using RubySock;

namespace EastMile_s_ReBirth.Login
{
    class Server
    {
        static RubyServer server;

        public static RichTextBox _console;
        public static ListBox _userList;

        public static void Start(TextBox lgIP, TextBox lgPort, RichTextBox console, ListBox userList)
        {
            try
            {
                server = new RubyServer(lgIP.Text, int.Parse(lgPort.Text));

                server.OnClientConnected += Server_OnClientConnected;
                server.OnClientDisconnected += Server_OnClientDisconnected;

                server.Start();

                _console = console;

                _userList = userList;

                Logger("Server started on : " + server.IPEndPoint, console);
            }
            catch (Exception ex)
            {
                Logger("An error occured " + ex.ToString(), console);
            }

        }

        public static void Stop(RichTextBox console)
        {
            try {
                server.Stop();
                Logger("Server stopped.", console);
            }
            catch (Exception ex)
            {
                Logger("An error occured " + ex.ToString(), console);
            }
        }


        private static void Server_OnClientConnected(RubyClient client)
        {            
            Logger(client.IPEndPoint + " connected", _console);
            Client cli = new Client();
            cli.Setup(client);
        }

        private static void Server_OnClientDisconnected(RubyClient client)
        {
            Logger(client.IPEndPoint + " has disconnected", _console);
        }

        public static void Logger(string msg, RichTextBox console)
        {
            console.Invoke((MethodInvoker)delegate
            {
                console.ForeColor = System.Drawing.Color.Yellow;
                console.AppendText("[");
                console.ForeColor = System.Drawing.Color.DarkCyan;
                console.AppendText("LOGIN");
                console.ForeColor = System.Drawing.Color.Yellow;
                console.AppendText("]"); ;
                console.ForeColor = System.Drawing.Color.White;
                console.AppendText(msg + "\n");
            });
        }
    }

    public class Client
    {
        static RubyClient client;

        public void Setup(RubyClient _client)
        {
            client = _client;
            client.OnDataReceived += Client_OnDataReceived;
        }

        private void Client_OnDataReceived(byte[] buffer)
        {
            PacketHandler.Answer(this, buffer);
        }

        public void Send(byte[] packet)
        {
            client.Send(packet);
        }
    }
}
