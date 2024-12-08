using System.Net.Http.Headers;

namespace Banker;

class Program
{
    static void Main(string[] args)
    {
        var banquer = new Banker();

        var accio = "";

        while (accio.ToLower() != "sortir")
        {
            Console.WriteLine($"Que vols fer: crar, ingressar, retirar, sortir");
            accio = Console.ReadLine();

            if (accio.ToLower() == "sortir")
            {
                break;
            }
            
            Console.WriteLine($"El teu nom:"); 
           var nom = Console.ReadLine();
            
            switch (accio)
            {
                case "crear":
                    banquer.CreaClient(nom);
                    break;
                case "ingressar":
                    Console.WriteLine("Quants diners vols ingressar?");
                    var ingress = int.Parse(Console.ReadLine());
                    Console.WriteLine(banquer.PosarDiners(nom, ingress));
                    break;
                case "retirar":
                    Console.WriteLine("Quants diners vols treure?");
                    var treure = int.Parse(Console.ReadLine());
                    Console.WriteLine(banquer.TreureDiners(nom, treure));
                    break;
            }
        }
    }
}