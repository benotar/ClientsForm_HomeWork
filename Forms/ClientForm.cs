using ClassWork_17_02_2024.Database;
using ClassWork_17_02_2024.Entities;

namespace ClassWork_17_02_2024.Forms;

public partial class ClientForm : Form
{
    private Client _client;

    private IDatabase _database;
    public ClientForm(Client client, IDatabase database)
    {
        this._client = client;

        this._database = database;

        InitializeComponent();
    }

    // При завантаженні форми
    public void OnFormLoad(object sender, EventArgs e)
    {
        // Заповнюємо всі поля про клієнта
        surnameTextBox.Text = _client.Surname;

        nameTextBox.Text = _client.Name;

        balanceTextBox.Text = _client.Balance.ToString();

        isAdultCheckBox.Checked = _client.IsAdult;
    }

    public void UpdateClientForm(object sender, EventArgs e)
    {
        if (_client == null || _database == null)
        {
            MessageBox.Show("Client or database is null!");

            return;
        }

        _client.Surname = surnameTextBox.Text;

        _client.Name = nameTextBox.Text;

        if (!decimal.TryParse(balanceTextBox.Text, out decimal newBalance))
        {
            MessageBox.Show("The balance should be a number!");

            return;
        }

        _client.Balance = newBalance;

        _client.IsAdult = isAdultCheckBox.Checked;

        _database.UpdateClient(_client);

        var clientsListForm = Application.OpenForms["ClientsListForm"] as ClientsListForm;

        clientsListForm?.RefreshClientsList();

        MessageBox.Show("Data updated successfully!");

        this.Close();
    }
}
