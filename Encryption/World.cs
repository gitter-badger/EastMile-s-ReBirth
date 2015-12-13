using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EastMile_s_ReBirth.Encryption
{
    //Thanks to Smoke and Lucifer

    public class World
    {
        public static string Decrypt(byte[] packet, int length, int session_id)
        {
            string encrypted_string = "";
            byte session_key = (byte)(session_id & 0xFF);
            byte session_number = (byte)(session_id >> 6);
            session_number &= (byte)0xFF;
            session_number &= unchecked((byte)0x80000003);

            switch (session_number)
            {
                case 0:
                    for (int i = 0; i < length; i++)
                    {
                        byte firstbyte = (byte)(session_key + 0x40);
                        byte highbyte = (byte)(packet[i] - firstbyte);
                        encrypted_string += highbyte + " ";
                    }
                    break;

                case 1:
                    for (int i = 0; i < length; i++)
                    {
                        byte firstbyte = (byte)(session_key + 0x40);
                        byte highbyte = (byte)(packet[i] + firstbyte);
                        encrypted_string += highbyte + " ";
                    }
                    break;

                case 2:
                    for (int i = 0; i < length; i++)
                    {
                        byte firstbyte = (byte)(session_key + 0x40);
                        byte highbyte = (byte)(packet[i] - firstbyte ^ 0xC3);
                        encrypted_string += highbyte + " ";
                    }
                    break;

                case 3:
                    for (int i = 0; i < length; i++)
                    {
                        byte firstbyte = (byte)(session_key + 0x40);
                        byte highbyte = (byte)(packet[i] + firstbyte ^ 0xC3);
                        encrypted_string += highbyte + " ";
                    }
                    break;

                default:
                    encrypted_string += 0xF;
                    break;
            }


            string[] var2 = encrypted_string.Split(new string[] { "255 " }, StringSplitOptions.None); //Under 255 
            byte[][] bytes = new byte[var2.Length - 1][];
            for (int i = 0; i < bytes.Length; i++)
            {
                string[] temp = var2[i].Split(' ');
                bytes[i] = new byte[temp.Length - 1];
                for (int j = 0; j < bytes[i].Length; j++)
                {
                    bytes[i][j] = Byte.Parse(temp[j]);
                }
            }
            string save = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                save += Decrypt2(bytes[i]);
                save += (char)0xFF;
            }

            return save.TrimEnd('ÿ');
        }

        public static string Decrypt2(byte[] packet)
        {

            string decrypted_string = "";
            char[] table = { ' ', '-', '.', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'n' };
            int count = 0;


            for (count = 0; count < packet.Length - 1;)
            {
                if (packet[count] <= 0x7A)
                {
                    byte len = packet[count];

                    for (int i = 0; i < (int)len; i++)
                    {
                        count++;

                        decrypted_string += getextendedascii((count < packet.Length ? packet[count] : 0) ^ 0xFF);
                    }
                    int x = decrypted_string[1];
                    count++;
                }
                else
                {
                    byte len = (byte)packet[count];
                    len &= (byte)0x7F;

                    for (int i = 0; i < (int)len;)
                    {
                        count++;

                        byte highbyte = packet[count];
                        highbyte &= 0xF0;
                        highbyte >>= 0x4;

                        byte lowbyte = packet[count];
                        lowbyte &= 0x0F;

                        if (highbyte != 0x0 && highbyte != 0xF)
                        {

                            decrypted_string += table[highbyte - 1];
                            i++;
                        }

                        if (lowbyte != 0x0 && lowbyte != 0xF)
                        {
                            decrypted_string += table[lowbyte - 1];
                            i++;
                        }
                    }
                    count++;
                }
            }

            return decrypted_string;
        }

        public static byte[] Encrypt(string str)
        {

            string encrypted_string = "";
            int length = str.Length;
            int secondlength = (length / 122);
            int compteur = 0;

            for (int i = 0; i < length; i++)
            {
                if (i == (122 * compteur))
                {
                    if (secondlength == 0)
                    {
                        encrypted_string += getextendedascii((char)Math.Abs((((length / 122) * 122) - length)));
                    }
                    else
                    {
                        encrypted_string += getextendedascii((char)0x7A);
                        secondlength--;
                        compteur++;
                    }
                }

                encrypted_string += getextendedascii((byte)(str[i] ^ (byte)0xFF));
            }

            encrypted_string += getextendedascii((char)0xFF);
            byte[] ret = Encoding.GetEncoding(1252).GetBytes(encrypted_string);
            return ret;
        }
        public static string getextendedascii(int x)
        {
            var e = Encoding.GetEncoding("Windows-1252");
            var s = e.GetString(new byte[] { Convert.ToByte(x) });

            return s;
        }

        public static string DecryptCustomParameter(byte[] packet)
        {

            string encrypted_string = "";
            for (int i = 1; i < packet.Length; i++)
            {
                if (Convert.ToChar(packet[i]) == 0xE) { return encrypted_string; }
                string var = (packet[i] - 0xF).ToString();

                int firstbyte = Convert.ToInt32((int)packet[i] - (int)0xF);
                int secondbyte = firstbyte;
                secondbyte &= 0xF0;
                firstbyte = Convert.ToInt32(firstbyte - secondbyte);
                secondbyte >>= 0x4;

                switch (secondbyte)
                {
                    case 0:
                        encrypted_string += ' ';
                        break;

                    case 1:
                        encrypted_string += ' ';
                        break;

                    case 2:
                        encrypted_string += '-';
                        break;

                    case 3:
                        encrypted_string += '.';
                        break;

                    default:
                        secondbyte += 0x2C;
                        encrypted_string += getextendedascii(secondbyte);
                        break;
                }

                switch (firstbyte)
                {
                    case 0:
                        encrypted_string += ' ';
                        break;

                    case 1:
                        encrypted_string += ' ';
                        break;

                    case 2:
                        encrypted_string += '-';
                        break;

                    case 3:
                        encrypted_string += '.';
                        break;

                    default:
                        firstbyte += 0x2C;
                        encrypted_string += getextendedascii(firstbyte);
                        break;
                }
            }

            return encrypted_string;

        }
    }
}
