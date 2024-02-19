namespace ClassWork_17_02_2024.Forms
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameLabe = new Label();
            surnameLabel = new Label();
            surnameTextBox = new TextBox();
            nameTextBox = new TextBox();
            balanceTextBox = new TextBox();
            balanceLabel = new Label();
            isAdultCheckBox = new CheckBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // nameLabe
            // 
            nameLabe.AutoSize = true;
            nameLabe.Location = new Point(12, 59);
            nameLabe.Name = "nameLabe";
            nameLabe.Size = new Size(39, 15);
            nameLabe.TabIndex = 0;
            nameLabe.Text = "Name";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(12, 9);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(54, 15);
            surnameLabel.TabIndex = 1;
            surnameLabel.Text = "Surname";
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(12, 27);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(308, 23);
            surnameTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 77);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(308, 23);
            nameTextBox.TabIndex = 3;
            // 
            // balanceTextBox
            // 
            balanceTextBox.Location = new Point(12, 129);
            balanceTextBox.Name = "balanceTextBox";
            balanceTextBox.Size = new Size(308, 23);
            balanceTextBox.TabIndex = 5;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new Point(12, 111);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(48, 15);
            balanceLabel.TabIndex = 4;
            balanceLabel.Text = "Balance";
            // 
            // isAdultCheckBox
            // 
            isAdultCheckBox.AutoSize = true;
            isAdultCheckBox.Location = new Point(12, 167);
            isAdultCheckBox.Name = "isAdultCheckBox";
            isAdultCheckBox.Size = new Size(66, 19);
            isAdultCheckBox.TabIndex = 6;
            isAdultCheckBox.Text = "Is Adult";
            isAdultCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 208);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(308, 23);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += UpdateClientForm;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 253);
            Controls.Add(saveButton);
            Controls.Add(isAdultCheckBox);
            Controls.Add(balanceTextBox);
            Controls.Add(balanceLabel);
            Controls.Add(nameTextBox);
            Controls.Add(surnameTextBox);
            Controls.Add(surnameLabel);
            Controls.Add(nameLabe);
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientForm";
            Load += OnFormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabe;
        private Label surnameLabel;
        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private TextBox balanceTextBox;
        private Label balanceLabel;
        private CheckBox isAdultCheckBox;
        private Button saveButton;
    }
}