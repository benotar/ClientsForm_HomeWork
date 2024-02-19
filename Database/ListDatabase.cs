using ClassWork_17_02_2024.Entities;

namespace ClassWork_17_02_2024.Database;

public class ListDatabase : IDatabase
{
    private List<Client> _clients = new List<Client>
    {
        new Client 
        {
            Id = Guid.NewGuid(),
            Name = "Ivan",
            Surname = "Zhmur",
            Balance = 150000,
            IsAdult = true
        },
        new Client
        {
            Id = Guid.NewGuid(),
            Name = "Vasya",
            Surname = "TopPatsan",
            Balance = 23000,
            IsAdult = false
        },
        new Client
        {
            Id = Guid.NewGuid(),
            Name = "Barak",
            Surname = "Walker",
            Balance = 1233,
            IsAdult = true
        },
        new Client
        {
            Id = Guid.NewGuid(),
            Name = "Taras",
            Surname = "Uzumaki",
            Balance = 153123,
            IsAdult = false
        }
    };

    public IEnumerable<Client> GetAllClients()
        => _clients;

    public Client? GetClientById(Guid id)
        => _clients.FirstOrDefault(c => c.Id.Equals(id));

    public void UpdateClient(Client? client)
    {
        if (client == null)
        {
            MessageBox.Show("Client is empty!");

            return;
        }

        Client? existingClient = _clients
            .FirstOrDefault(c => c.Id.Equals(client.Id));

        if (existingClient == null)
        {
            MessageBox.Show("Client with provided ID not found!");

            return;
        }

        existingClient.Name = client.Name;
        existingClient.Surname = client.Surname;
        existingClient.Balance = client.Balance;
        existingClient.IsAdult = client.IsAdult;
    }
}
