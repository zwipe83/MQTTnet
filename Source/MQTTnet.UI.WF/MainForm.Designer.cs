namespace MQTTnet.UI.WF
{
    partial class MainForm
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
            btnConnect = new Button();
            txtBroker = new TextBox();
            lblBroker = new Label();
            lblPort = new Label();
            txtPort = new TextBox();
            lblUser = new Label();
            txtUser = new TextBox();
            lblPassword = new Label();
            txtPass = new TextBox();
            lstResponse = new ListView();
            lblTopic = new Label();
            txtTopic = new TextBox();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(176, 129);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(81, 23);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Subscribe";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtBroker
            // 
            txtBroker.Location = new Point(59, 12);
            txtBroker.Name = "txtBroker";
            txtBroker.Size = new Size(729, 23);
            txtBroker.TabIndex = 1;
            // 
            // lblBroker
            // 
            lblBroker.AutoSize = true;
            lblBroker.Location = new Point(11, 15);
            lblBroker.Name = "lblBroker";
            lblBroker.Size = new Size(41, 15);
            lblBroker.TabIndex = 2;
            lblBroker.Text = "Broker";
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(23, 44);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(29, 15);
            lblPort.TabIndex = 3;
            lblPort.Text = "Port";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(59, 41);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(100, 23);
            txtPort.TabIndex = 4;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(23, 73);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(30, 15);
            lblUser.TabIndex = 5;
            lblUser.Text = "User";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(59, 70);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(100, 23);
            txtUser.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(22, 103);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(30, 15);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Pass";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(59, 100);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 8;
            // 
            // lstResponse
            // 
            lstResponse.Location = new Point(12, 212);
            lstResponse.Name = "lstResponse";
            lstResponse.Size = new Size(776, 226);
            lstResponse.TabIndex = 9;
            lstResponse.UseCompatibleStateImageBehavior = false;
            // 
            // lblTopic
            // 
            lblTopic.AutoSize = true;
            lblTopic.Location = new Point(15, 132);
            lblTopic.Name = "lblTopic";
            lblTopic.Size = new Size(35, 15);
            lblTopic.TabIndex = 10;
            lblTopic.Text = "Topic";
            // 
            // txtTopic
            // 
            txtTopic.Location = new Point(59, 129);
            txtTopic.Name = "txtTopic";
            txtTopic.Size = new Size(100, 23);
            txtTopic.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTopic);
            Controls.Add(lblTopic);
            Controls.Add(lstResponse);
            Controls.Add(txtPass);
            Controls.Add(lblPassword);
            Controls.Add(txtUser);
            Controls.Add(lblUser);
            Controls.Add(txtPort);
            Controls.Add(lblPort);
            Controls.Add(lblBroker);
            Controls.Add(txtBroker);
            Controls.Add(btnConnect);
            Name = "MainForm";
            Text = "MQTT Studio 0.0.0.1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private TextBox txtBroker;
        private Label lblBroker;
        private Label lblPort;
        private TextBox txtPort;
        private Label lblUser;
        private TextBox txtUser;
        private Label lblPassword;
        private TextBox txtPass;
        private ListView lstResponse;
        private Label lblTopic;
        private TextBox txtTopic;
    }
}
