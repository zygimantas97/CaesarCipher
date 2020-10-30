using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher.Services
{
    public class CaesarCipherService
    {
        public static string Encrypt(string message, int key)
        {
            var encryptedMessage = "";
            foreach (var letter in message)
            {
                byte tmpLetter = (byte)(letter + key);
                encryptedMessage += Char.ConvertFromUtf32(tmpLetter).ToString();
            }
            return encryptedMessage;
        }

        public static string Decrypt(string message, int key)
        {
            var decryptedMessage = "";
            foreach (var letter in message)
            {
                byte tmpLetter = (byte)(letter - key);
                decryptedMessage += Char.ConvertFromUtf32(tmpLetter).ToString();
            }
            return decryptedMessage;
        }
    }
}
