namespace ClassWork_17_02_2024.Forms;

partial class ClientsListForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        clientsListBox = new ListBox();
        SuspendLayout();
        // 
        // clientsListBox
        // 
        clientsListBox.FormattingEnabled = true;
        clientsListBox.ItemHeight = 15;
        clientsListBox.Location = new Point(12, 9);
        clientsListBox.Name = "clientsListBox";
        clientsListBox.Size = new Size(244, 319);
        clientsListBox.TabIndex = 0;
        clientsListBox.DoubleClick += OnListBoxDoubleClick;
        // 
        // ClientsListForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(268, 340);
        Controls.Add(clientsListBox);
        Name = "ClientsListForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Clients";
        Load += OnFormLoaded;
        ResumeLayout(false);
    }

    #endregion

    private ListBox clientsListBox;
}
