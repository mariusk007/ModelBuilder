namespace ModelBuilder
{
    partial class FrmConnect
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
            tableLayoutPanel1 = new TableLayoutPanel();
            txtPassword = new TextBox();
            txtUserID = new TextBox();
            txtDatabase = new TextBox();
            lblPassword = new Label();
            lblUserID = new Label();
            lblDatabase = new Label();
            lblServer = new Label();
            txtServer = new TextBox();
            btnConnect = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 3);
            tableLayoutPanel1.Controls.Add(txtUserID, 1, 2);
            tableLayoutPanel1.Controls.Add(txtDatabase, 1, 1);
            tableLayoutPanel1.Controls.Add(lblPassword, 0, 3);
            tableLayoutPanel1.Controls.Add(lblUserID, 0, 2);
            tableLayoutPanel1.Controls.Add(lblDatabase, 0, 1);
            tableLayoutPanel1.Controls.Add(lblServer, 0, 0);
            tableLayoutPanel1.Controls.Add(txtServer, 1, 0);
            tableLayoutPanel1.Controls.Add(btnConnect, 1, 4);
            tableLayoutPanel1.Location = new Point(159, 121);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(413, 225);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(209, 90);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(201, 23);
            txtPassword.TabIndex = 7;
            txtPassword.Text = "123";
            // 
            // txtUserID
            // 
            txtUserID.Dock = DockStyle.Fill;
            txtUserID.Location = new Point(209, 61);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(201, 23);
            txtUserID.TabIndex = 6;
            txtUserID.Text = "developer";
            // 
            // txtDatabase
            // 
            txtDatabase.Dock = DockStyle.Fill;
            txtDatabase.Location = new Point(209, 32);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(201, 23);
            txtDatabase.TabIndex = 5;
            txtDatabase.Text = "Northwind";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Gray;
            lblPassword.Dock = DockStyle.Fill;
            lblPassword.Location = new Point(5, 92);
            lblPassword.Margin = new Padding(5);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(196, 19);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            lblPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.BackColor = Color.Gray;
            lblUserID.Dock = DockStyle.Fill;
            lblUserID.Location = new Point(5, 63);
            lblUserID.Margin = new Padding(5);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(196, 19);
            lblUserID.TabIndex = 3;
            lblUserID.Text = "User ID:";
            lblUserID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.BackColor = Color.Gray;
            lblDatabase.Dock = DockStyle.Fill;
            lblDatabase.Location = new Point(5, 34);
            lblDatabase.Margin = new Padding(5);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(196, 19);
            lblDatabase.TabIndex = 1;
            lblDatabase.Text = "Database:";
            lblDatabase.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.BackColor = Color.Gray;
            lblServer.Dock = DockStyle.Fill;
            lblServer.Location = new Point(5, 5);
            lblServer.Margin = new Padding(5);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(196, 19);
            lblServer.TabIndex = 0;
            lblServer.Text = "Server:";
            lblServer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtServer
            // 
            txtServer.Dock = DockStyle.Fill;
            txtServer.Location = new Point(209, 3);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(201, 23);
            txtServer.TabIndex = 2;
            txtServer.Text = "VIRTUALPC";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(209, 119);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 8;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // FrmConnect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmConnect";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmConnect";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDatabase;
        private Label lblServer;
        private TextBox txtPassword;
        private TextBox txtUserID;
        private TextBox txtDatabase;
        private Label lblPassword;
        private Label lblUserID;
        private TextBox txtServer;
        private Button btnConnect;
    }
}