using System;
using System.Collections.Generic;
using System.Text;

namespace RandomCript
{
    class CriptUtils
    {
        static public Key _key;
        static public string convertByteArrayToString(byte[] byte_word)
        { //Convertează array de byte în reprezentarea string
            return Convert.ToBase64String(byte_word).Replace("-", "");
        }
        static public byte[] convertStringToByteArray(string bytes)
        {//Convertează string în reprezentarea byte array
            return Convert.FromBase64String(bytes);
        }
        static public byte[] encodeStringMsg(string word)
        { //codează un mesaj în ASCII Hex
            byte[] result = Encoding.Default.GetBytes(word);
            return result;
        }
        static public string decodeHex(byte[] hex)
        { //decodează un mesaj din ASCII Hex
            string output = Encoding.Default.GetString(hex);
            return output;
        }
    }
}
