using System;
using System.Windows.Forms;

namespace EastMile_s_ReBirth.Login
{
    public class PacketHandler
    {
        public static void Answer(Client client, byte[] packet)
        {
            Main main = new Main();
            string[] packetSplit = Encryption.Login.Decrypt(packet, packet.Length).Split(' ');

            if (packetSplit[0] == "NoS0575")
            {
                client.Send(Encryption.Login.Encrypt("NsTeST 0 127.0.0.1:4010:1:1.1.EastMile "));
                Server.Logger("new connection", Server._console);

                Server._userList.Invoke((MethodInvoker)delegate
                {
                    Server._userList.Items.Add(packetSplit[2] + "<NONE>"); //NONE will be replaced by the chosen character.
                });
            }
            else
            {
                client.Send(Encryption.Login.Encrypt("fail Error "));
                Server.Logger("new connection", Server._console);
            }
        }

        static void GameServer(TextBox worldIP, TextBox worldPort, TextBox worldName, int worldCount, TextBox channelsCount, Client client)
        {
            for (int chaInd = 0; chaInd < int.Parse(channelsCount.Text); chaInd++)
            {
                client.Send(Encryption.Login.Encrypt(String.Format("NsTeST {0} {1}:{2}:{3}:{4}.{5}.{6}",
                    0, worldIP, worldPort, 0, 1, chaInd, worldName)));
            }
        }

        static void GetUser()
        {

        }
    }
}
