using ClassWork_17_02_2024.Entities;

namespace ClassWork_17_02_2024.Database;

public interface IDatabase
{
    // Отримати всіх клієнтів
    IEnumerable<Client> GetAllClients();

    // Отримати клієнта по id
    Client? GetClientById(Guid id);

    // Оновити дані клієнта
    void UpdateClient(Client client);
}
