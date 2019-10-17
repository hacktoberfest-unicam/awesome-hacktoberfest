using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganografia
{
    class Crittografia
    {
        public Crittografia()
        {

        }
        private byte[] bytes;
        private string message;
        public Crittografia(byte[] bytes, string message)
        {
            this.bytes = bytes;
            this.message = message;
        }

        public byte[] BYTES
        {
            get {return this.bytes;}
            set {this.bytes = value;}
        }
        public string MESSAGE
        {
            get { return this.message; }
            set { this.message = value; }
        }


        private string GetMessageBytes()
        {
            byte[] messageBuffer = Encoding.ASCII.GetBytes(this.message);
            return string.Join(" ", messageBuffer.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0'))).Replace(" ", "");
        }
        private string GetMusicBytes()
        {
            return string.Join(" ", this.bytes.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }
        public string Crypt()
        {
            string bitFinal = String.Empty;

            string bitMusicString = GetMusicBytes();
            string[] bitMusicArray = bitMusicString.Split(' ');

            string bitMessageString = GetMessageBytes();

            if (bitMusicArray.Length > bitMessageString.Length)
            {
                for (int i = 0; i < bitMusicArray.Length; i++)
                {
                    if (i < bitMessageString.Length)
                    {
                            bitFinal += bitMusicArray[i] = bitMusicArray[i].Remove(7) + bitMessageString[i] + " ";
                    }
                }

          
                bitFinal = bitFinal + bitMusicString.Substring(bitFinal.Length);

                return bitFinal.Replace(" ", "");
            }
            else
            {
                return "Errore: I bit contenuti nell'audio sono minori di quelli del testo.";
            }


        }


        string EOS = "0011110001000101010011110101001100111110";
        public string Decrypt()
        {
            string allBits = GetMusicBytes().Replace(" ", "");

            string completeString = String.Empty;

            int index = 7;
            while (!completeString.Contains(EOS) && index < 400000)
            {
                completeString += allBits[index];
                index += 8;
                Console.WriteLine(index);
            }

            if (index < 400000)
            {
                List<Byte> byteList = new List<Byte>();

                for (int i = 0; i < completeString.Length; i += 8)
                {
                    byteList.Add(Convert.ToByte(completeString.Substring(i, 8), 2));
                }
                return Encoding.ASCII.GetString(byteList.ToArray());
            }else
            {
                return "Errore questo audio non contiene messaggi.";
            }
        }
    }
}
