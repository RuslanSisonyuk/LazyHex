using System;
using System.Collections.Generic;
using System.Text;

namespace RandomCript
{
    class Decription:CriptUtils
    {
        static public byte[] unShuffleHexBytes(byte[] hex)
        {
            int i = hex.Length-2;
            while (i > -1)
            {
                byte tmp = hex[i + 1];
                hex[i + 1] = hex[i];
                hex[i] = tmp;
                i--;

            }
            return hex;
        }
        static public byte[] subtractASCIIValuesFromSymbols(byte[] hex, byte[] key)
        { //scade byții
            int i = 0;
            while (i < hex.Length)
            {
                hex[i] -= key[i];
                i++;
            }
            return hex;
        }
    }
}
