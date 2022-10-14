using System.Collection.Generic;
using System.IO;
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        StreamWriter sw = new StreamWriter("password.txt");
        StreamReader sr = new StreamReader("password.txt");
        do{
            char risposta;
            Console.WriteùLine("Cosa vuoi fare? [l,a,r]");
            Console.Write("LEGENDA:Leggi le password,Aggiungi una password,Rimuovi una password");
            risposta = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            
            if(risposta == 'l'){
                if
            }
            
            char continua;
            Console.WriteLine("Vuoi continuare?");
            continua = Convert.ToChar(Console.ReadLine());
        }while(continua == 's');
        
        
        Console.ReadKey();
    }
}