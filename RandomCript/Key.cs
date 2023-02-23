using System;
using System.Collections.Generic;
using System.Text;

namespace RandomCript
{
    class Key
    {
        private byte[] value;

        public string RandomString(int length)
        {
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }
        public Key(int length)
        {
            string string_key = RandomString(length);
            value = Encription.encodeStringMsg(string_key);
        }

        public byte[] getKeyValue()
        {
            return value;
        }
        public void setKeyValue(byte[] value)
        {
            this.value = value;
        }
    }
}
