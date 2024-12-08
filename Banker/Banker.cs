namespace Banker;

public class Banker
{
    private Dictionary<string,Client> clients;

    public Banker()
    {
        clients = new Dictionary<string, Client>();
    }

    public void CreaClient(string nomNouClient)
    {
        clients.Add(nomNouClient, new Client(nomNouClient));
    }

    public string PosarDiners(string nomClient, int quantitat)
    {
        if (clients.ContainsKey(nomClient))
        {
            var client = clients[nomClient];
            client.Saldo += quantitat;
            return $"{nomClient}: {quantitat} € ingressats correctament";
        } 
        return $"Tu no ets client {nomClient}, fes-te un compte!!";
    }

    public string TreureDiners(string nomClient, int quantitat)
    {
        if (clients.ContainsKey(nomClient))
        {
            var client = clients[nomClient];
            var comissio = (int)quantitat / 100;
            if (quantitat + comissio > client.Saldo)
            {
                return $"{nomClient}: No tens {quantitat + comissio} €, no és prou, ets POBRE!";
            }

            client.Saldo -= quantitat + comissio;
            return $"{nomClient}: Té {quantitat} € et queden {client.Saldo}, segueix estalviant";
        }
        return $"Tu no ets client {nomClient}, fes-te un compte!!";
    }
}