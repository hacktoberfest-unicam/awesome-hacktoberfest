using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacktoberfest2019DZ.EncryptionDZ
{
    public class EncryptionDZ
    {
        public class CaesarCipher
        {
            int key;
            public CaesarCipher(int key)
            {
                this.key = key;
            }


            public string encrypt(String plainText)
            {
                int offset = key % 26 + 26;
                StringBuilder encoded = new StringBuilder();
                foreach (char i in plainText.ToArray())
                {
                    if (Char.IsLetter(i))
                    {
                        if (Char.IsUpper(i))
                        {
                            encoded.Append((char)('A' + (i - 'A' + offset) % 26));
                        }
                        else
                        {
                            encoded.Append((char)('a' + (i - 'a' + offset) % 26));
                        }
                    }
                    else
                    {
                        encoded.Append(i);
                    }
                }
                return encoded.ToString();
            }


            public string decrypt(String cipherText)
            {
                key = 26 - key;
                String plainText = encrypt(cipherText);
                key = 26 + key;
                return plainText;
            }
        }
    }
}
