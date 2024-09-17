using System;

class Program{
    static void Main(){
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Alfabeto em letras maiúsculas:\n");

        for (int i = 65; i <= 90; i++){
            Console.Write((char)i + " ");
        }

        int referenciaASCII = 90;
        Console.WriteLine("\n");
        Console.WriteLine($"O valor de {(char)referenciaASCII} é {referenciaASCII}");

        Console.WriteLine("\nAlfabeto em letras minúsculas:\n");

        for (int i = 97; i <= 122; i++){
            Console.Write((char)i + " ");
        }

        referenciaASCII = 122;
        Console.WriteLine("\n");
        Console.WriteLine($"O valor de {(char)referenciaASCII} é {referenciaASCII}");
    }
}
