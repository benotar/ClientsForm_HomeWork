using ClassWork_17_02_2024.Entities;

namespace ClassWork_17_02_2024.Database;

class ClientsFormDatabase : IDatabase
{
    private ClientsFormdbContext _db;

    public ClientsFormDatabase()
    {
        _db = new ClientsFormdbContext();


        // Якщо немає даних в бд

        //_db.Clients.AddRange(new Client
        //{
        //    Name = "Ivan",
        //    Surname = "Zhmur",
        //    Balance = 150000,
        //    IsAdult = true
        //},
        //new Client
        //{
        //    Name = "Vasya",
        //    Surname = "TopPatsan",
        //    Balance = 23000,
        //    IsAdult = false
        //},
        //new Client
        //{
        //    Name = "Barak",
        //    Surname = "Walker",
        //    Balance = 1233,
        //    IsAdult = true
        //},
        //new Client
        //{
        //    Name = "Taras",
        //    Surname = "Uzumaki",
        //    Balance = 153123,
        //    IsAdult = false
        //},
        //new Client
        //{
        //    Name = "Pes",
        //    Surname = "Diuk",
        //    Balance = 312312,
        //    IsAdult = true
        //},
        //new Client
        //{
        //    Name = "John",
        //    Surname = "Doe",
        //    Balance = 50000,
        //    IsAdult = true
        //},
        //new Client
        //{
        //    Name = "Jane",
        //    Surname = "Smith",
        //    Balance = 80000,
        //    IsAdult = true
        //},
        //new Client
        //{
        //    Name = "Anna",
        //    Surname = "Johnson",
        //    Balance = 20000,
        //    IsAdult = false
        //},
        //new Client
        //{
        //    Name = "Michael",
        //    Surname = "Brown",
        //    Balance = 75000,
        //    IsAdult = true
        //},
        //new Client
        //{
        //    Name = "Emma",
        //    Surname = "Davis",
        //    Balance = 100000,
        //    IsAdult = true
        //});

        //_db.SaveChanges();
    }


    public IEnumerable<Client> GetAllClients()
    {
        return _db.Clients.ToList();
    }

    public Client? GetClientById(Guid id)
    {
        return _db.Clients.FirstOrDefault(c => c.Id.Equals(id));
    }

    public void UpdateClient(Client client)
    {
        if (client == null)
        {
            MessageBox.Show("Client is empty!");

            return;
        }

        Client? existingClient = _db.Clients
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

        _db.SaveChanges();
    }
}
