using System;

namespace Laboratory_work.Classes
{
    internal class ACipher: ICipher
    {
        string encoded_string;
        string decoded_string;

        public void Encode()
        {
            if (decoded_string != String.Empty && decoded_string == String.Empty)
            {
                for (int i = 0; i < decoded_string.Length; i++)
                {
                    if (decoded_string.ToLower()[i] == 'я')
                    {
                        encoded_string += (Convert.ToChar(Convert.ToInt32(decoded_string) - 32));
                    }
                    else if (decoded_string.ToLower()[i] == 'z')
                    {
                        encoded_string += (Convert.ToChar(Convert.ToInt32(decoded_string) - 25));
                    }
                    else
                    {
                        encoded_string += (Convert.ToChar(Convert.ToInt32(decoded_string) +1));
                    }
                }
            }
            else
            {
                Console.WriteLine("Строка кодирования не пустая");
            }
        }
        public void Dencode()
        {
            if (decoded_string != String.Empty && decoded_string == String.Empty)
            {
                for (int i = 0; i < decoded_string.Length; i++)
                {
                    if (decoded_string.ToLower()[i] == 'а')
                    {
                        encoded_string += (Convert.ToChar(Convert.ToInt32(decoded_string) + 32));
                    }
                    else if (decoded_string.ToLower()[i] == 'a')
                    {
                        encoded_string += (Convert.ToChar(Convert.ToInt32(decoded_string) + 25));
                    }
                    else
                    {
                        encoded_string += (Convert.ToChar(Convert.ToInt32(decoded_string) - 1));
                    }
                }
            }
            else
            {
                Console.WriteLine("Строка кодирования не пустая");
            }
        }

        public string OutputaLine
        {
            get
            {
                if (decoded_string != "")
                {
                    return decoded_string;
                }
                else
                {
                    return encoded_string;
                }
            }
        }
        public ACipher(string decoded_string)
        {
            this.decoded_string = decoded_string;
            encoded_string = "";
        }
    }
}
