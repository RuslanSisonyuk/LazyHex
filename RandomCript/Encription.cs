using System;
using System.Collections.Generic;
using System.Text;

namespace RandomCript
{
    class Encription:CriptUtils
    {
        static public byte[] shuffleHexBytes(byte[] hex)
        { //misca elementele din array in dreapta
            int i = 1;
            while (i < hex.Length)
            {
                byte tmp = hex[i-1];
                hex[i-1] = hex[i];
                hex[i] = tmp;
                i++;
            }
            return hex;
        }
        static byte[] addASCIIValuesOfSymbols(byte[] hex, byte[] key)
        { //adauga byții  
            int i = 0;
            while (i < hex.Length)
            {
                hex[i] += key[i];
                i++;
            }
            return hex;
        }
        static public byte[] useKey(byte[] hex)
        {
            Key gen_key = new Key(hex.Length);
            _key = gen_key;
            hex = addASCIIValuesOfSymbols(hex, gen_key.getKeyValue());
            return hex;
        }
    }
}