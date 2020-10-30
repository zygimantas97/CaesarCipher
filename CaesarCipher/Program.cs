using CaesarCipher.Services;
using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CaesarChipher");
            Console.WriteLine("{0:1} - {1}", "e", "Encrypt");
            Console.WriteLine("{0:1} - {1}", "d", "Decrypt");
            Console.WriteLine("{0:1} - {1}", "q", "Quit");
            string command = "";
            while(command != "q")
            {
                Console.WriteLine();
                Console.Write("{0, -20}", "Enter command: ");
                command = Console.ReadLine();
                
                if(command == "e" || command == "d")
                {
                    Console.Write("{0, -20}", "Enter message: ");
                    string message = Console.ReadLine();

                    string newMessage = "";
                    int key = 0;
                    bool parsed = false;
                    while (!parsed)
                    {
                        Console.Write("{0, -20}", "Enter key: ");
                        var keyString = Console.ReadLine();
                        parsed = int.TryParse(keyString, out key);
                        if (!parsed)
                        {
                            Console.WriteLine("Wrong key format: it must be a number.");
                        }
                    }
                    if(command == "e")
                    {
                        Console.Write("{0, -20}", "Encrypted message:");
                        newMessage = CaesarCipherService.Encrypt(message, key);
                    }
                    else
                    {
                        Console.Write("{0, -20}", "Decrypted message:");
                        newMessage = CaesarCipherService.Decrypt(message, key);
                    }
                    Console.WriteLine(newMessage);
                }
                else
                {
                    Console.WriteLine("Not recognized command");
                }
            }
        }
    }
}
