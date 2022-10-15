using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Password_storer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("password.txt");
            StreamReader sr = new StreamReader("password.txt");
            char continua;
            do
            {

                char risposta;
                do {

                    Console.WriteLine("Cosa vuoi fare? [l,a,r]");
                    Console.Write("LEGENDA:Leggi le password,Aggiungi una password,Rimuovi una password");
                    risposta = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                } while (risposta != 'l' && risposta != 'a' && risposta != 'r');

                string linea = sr.ReadLine();
                string rimozione = null;
                
                if (risposta == 'a')
                {
                    Console.Write("Inserisci la password da aggiungere:");
                    sw.WriteLine(Console.ReadLine());
                }
                else if (risposta == 'r')
                {
                    Console.Write("Inserisci la password da rimuovere:");
                    rimozione = Console.ReadLine();

                }
                    while (linea != null)
                    {
                        if (risposta == 'l')
                        {
                            Console.WriteLine($"{linea}");
                        }
                       if (risposta == 'r')
                        {
                            Console.Write("Inserisci la password da rimuovere:");
                            rimozione = Console.ReadLine();
                        
                        }
                        linea = sr.ReadLine();
                    }
                
                    Console.WriteLine("Vuoi continuare?");
                    continua = Convert.ToChar(Console.ReadLine());
                } while (continua == 's') ;
            


            Console.ReadKey();
        }
    }
}
