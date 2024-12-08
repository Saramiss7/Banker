namespace Banker;

public class Client
{ 
    public Client(string nomClient)
    {
        Nom = nomClient;
        Saldo = 0;
    }
    public string Nom { get; }

    // private saldo;
    // public getSaldo() { return saldo; }
    // public setSaldo(int x) { saldo = x; }

    public int Saldo { get; set; } = 0;
}