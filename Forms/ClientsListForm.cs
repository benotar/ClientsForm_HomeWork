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

    // ��� ����������� �����
    public void OnFormLoaded(object sender, EventArgs e)
    {
        // �������� �볺��� � ���� �����
        var clients = _database.GetAllClients().ToArray();

        // ���������� � ������ �������� �볺���
        clientsListBox.Items.AddRange(clients);
    }

    // ��� ��������� ���� �� �������
    public void OnListBoxDoubleClick(object sender, EventArgs e)
    {
        // �������� �볺��
        var selectedClient = clientsListBox.SelectedItem as Client;

        // ���� ��� ��������� ���� �� �������� �볺�� - �����
        if (selectedClient is null) return;

        // ��������� ����� � �볺����
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
