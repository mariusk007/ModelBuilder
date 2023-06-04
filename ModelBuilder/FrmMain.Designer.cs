namespace ModelBuilder
{
    partial class FrmMain
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
            txtUnitId = new TextBox();
            groupBox1 = new GroupBox();
            btnConnect = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUnitId
            // 
            txtUnitId.Location = new Point(891, 22);
            txtUnitId.Name = "txtUnitId";
            txtUnitId.Size = new Size(149, 23);
            txtUnitId.TabIndex = 3;
            txtUnitId.Text = "Employees";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConnect);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(txtUnitId);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1046, 510);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(860, 470);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(87, 34);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // button1
            // 
            button1.Location = new Point(953, 470);
            button1.Name = "button1";
            button1.Size = new Size(87, 34);
            button1.TabIndex = 5;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 51);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1034, 413);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 534);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Model Builder";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtUnitId;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button btnConnect;
    }
}