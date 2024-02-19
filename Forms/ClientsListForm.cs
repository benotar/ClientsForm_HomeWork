using ClassWork_17_02_2024.Database;
using ClassWork_17_02_2024.Entities;

namespace ClassWork_17_02_2024.Forms;

public partial class ClientsListForm : Form
{
    private IDatabase _database;



    public ClientsListForm()
    {
        //_database = new ListDatabase();
        _database = new ClientsFormDatabase();
        InitializeComponent();
    }

    // При завантаженні форми
    public void OnFormLoaded(object sender, EventArgs e)
    {
        // Отримуємо клієнтів з бази даних
        var clients = _database.GetAllClients().ToArray();

        // Добавляємо в список лістбоксу клієнтів
        clientsListBox.Items.AddRange(clients);
    }

    // При подвійному кліку на лістбокс
    public void OnListBoxDoubleClick(object sender, EventArgs e)
    {
        // Вибраний клієнт
        var selectedClient = clientsListBox.SelectedItem as Client;

        // Якщо при подвійному кліку не вибраний клієнт - ігнор
        if (selectedClient is null) return;

        // Запускаємо форму з клієнтом
        var clientForm = new ClientForm(selectedClient, _database);

        clientForm.Show();
    }

    public void RefreshClientsList()
    {
        var clients = _database.GetAllClients().ToArray();

        clientsListBox.Items.Clear();

        clientsListBox.Items.AddRange(clients);
    }

}
