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
            File.Copy("password.txt", "tmp.txt");
            string[] linee = File.ReadAllLines("password.txt");
            StreamWriter sw = new StreamWriter("password.txt");
            char continua;
            
            int i = 0;
            do
            {
                bool vuota=false;
                char risposta;
                for (int j = 0; j < linee.Length - 1; j++)
                {
                    vuota = linee[i] == null ? true : false;
                }
                if (vuota)
                {
                    Console.Write("Inserisci la password da aggiungere:");
                    sw.WriteLine(Console.ReadLine());
                }
                do {

                    Console.WriteLine("Cosa vuoi fare? [l,a,r]");
                    Console.Write("LEGENDA:Leggi le password,Aggiungi una password,Rimuovi una password");
                    risposta = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                } while (risposta != 'l' && risposta != 'a' && risposta != 'r');

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

                while (linee[i] != null)
                    {
                        if (risposta == 'l')
                        {
                            Console.WriteLine($"{linee[i]}");
                        }

                        if (risposta=='r' && linee[i]==rimozione)
                        {
                              continue;
                        }
                        else if(risposta == 'r')
                        {
                               sw.WriteLine(linee[i]);
                        }
                        i++;
                    }
                
                    Console.WriteLine("Vuoi continuare?");
                    continua = Convert.ToChar(Console.ReadLine());
                
                } while (continua == 's') ;
            


            Console.ReadKey();
        }
    }
}
