using System;
using System.Text;

namespace RandomCript
{
    class Program
    {
        static (string,string) EncriptionSuite(string clear_text)
        {
            byte[] encripted_hex;
            encripted_hex = CriptUtils.encodeStringMsg(clear_text);
            encripted_hex = Encription.useKey(encripted_hex);
            for (int i = 0; i < 5; i++)
                encripted_hex = Encription.shuffleHexBytes(encripted_hex);

            string key = CriptUtils.convertByteArrayToString(CriptUtils._key.getKeyValue());
            string encripted_text = CriptUtils.convertByteArrayToString(encripted_hex);
            return (encripted_text, key);
        }
        static string DecriptionSuite(string encripted_text, string key)
        {
            byte[] hex_text = CriptUtils.convertStringToByteArray(encripted_text);
            byte[] hex_key = CriptUtils.convertStringToByteArray(key);
            for (int i = 0; i < 5; i++)
                hex_text = Decription.unShuffleHexBytes(hex_text);

            string decripted_text = CriptUtils.decodeHex(Decription.subtractASCIIValuesFromSymbols(hex_text, hex_key));
            return decripted_text;
        }
        static void Main(string[] args)
        {
            int mode; 
            Console.WriteLine("####################### ");
            Console.WriteLine("> Encript text: Apasă 1 ");
            Console.WriteLine("> Decript text: Apasă 2 ");
            Console.WriteLine("#######################\n");

            
            mode = Convert.ToInt32(Console.ReadLine());
            switch(mode)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("####################### ");
                    Console.WriteLine(">Rulează encription suite...");
                    Console.WriteLine(">Întroduceti mesajul:");
                    string plain_text = Console.ReadLine();
                    var encription_data = EncriptionSuite(plain_text);
                    Console.WriteLine(">Mesajul criptat: " + encription_data.Item1);
                    Console.WriteLine(">Cheia: " + encription_data.Item2);


                    Console.WriteLine("####################### ");
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("####################### ");
                    Console.WriteLine(">Rulează decription suite...");
                    Console.WriteLine(">Întroduceti mesajul criptat:");
                    string cript_text = Console.ReadLine();
                    Console.WriteLine(">Întroduceti cheia:");
                    string cript_key = Console.ReadLine();
                    string decription_data = DecriptionSuite(cript_text, cript_key);
                    Console.WriteLine(">Mesajul decriptat: " + decription_data);
                    Console.WriteLine("####################### ");
                    break;
            }
        }
    }
}