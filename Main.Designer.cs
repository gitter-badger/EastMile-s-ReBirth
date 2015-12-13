namespace EastMile_s_ReBirth
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Console = new System.Windows.Forms.RichTextBox();
            this._SrvInfo = new System.Windows.Forms.Label();
            this.CmdLine = new System.Windows.Forms.TextBox();
            this.StartSrv = new System.Windows.Forms.Button();
            this.StopSrv = new System.Windows.Forms.Button();
            this._CmdLine = new System.Windows.Forms.Label();
            this._LgIP = new System.Windows.Forms.Label();
            this._LgPort = new System.Windows.Forms.Label();
            this.LoginIP = new System.Windows.Forms.TextBox();
            this.LoginPort = new System.Windows.Forms.TextBox();
            this.UserList = new System.Windows.Forms.ListBox();
            this.SrvChat = new System.Windows.Forms.RichTextBox();
            this._SrvChat = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this._UserList = new System.Windows.Forms.Label();
            this.WorldIP = new System.Windows.Forms.TextBox();
            this.WorldPort = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this._WorldIP = new System.Windows.Forms.Label();
            this._WorldPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.SystemColors.InfoText;
            this.Console.ForeColor = System.Drawing.SystemColors.Window;
            this.Console.Location = new System.Drawing.Point(382, 115);
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.Size = new System.Drawing.Size(573, 375);
            this.Console.TabIndex = 0;
            this.Console.Text = "";
            // 
            // _SrvInfo
            // 
            this._SrvInfo.AutoSize = true;
            this._SrvInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._SrvInfo.Location = new System.Drawing.Point(379, 99);
            this._SrvInfo.Name = "_SrvInfo";
            this._SrvInfo.Size = new System.Drawing.Size(78, 13);
            this._SrvInfo.TabIndex = 1;
            this._SrvInfo.Text = "Server Info :";
            // 
            // CmdLine
            // 
            this.CmdLine.BackColor = System.Drawing.SystemColors.InfoText;
            this.CmdLine.Location = new System.Drawing.Point(382, 525);
            this.CmdLine.Name = "CmdLine";
            this.CmdLine.Size = new System.Drawing.Size(573, 20);
            this.CmdLine.TabIndex = 2;
            // 
            // StartSrv
            // 
            this.StartSrv.Location = new System.Drawing.Point(382, 44);
            this.StartSrv.Name = "StartSrv";
            this.StartSrv.Size = new System.Drawing.Size(115, 42);
            this.StartSrv.TabIndex = 3;
            this.StartSrv.Text = "Start Server";
            this.StartSrv.UseVisualStyleBackColor = true;
            this.StartSrv.Click += new System.EventHandler(this.StartSrv_Click);
            // 
            // StopSrv
            // 
            this.StopSrv.Enabled = false;
            this.StopSrv.Location = new System.Drawing.Point(517, 44);
            this.StopSrv.Name = "StopSrv";
            this.StopSrv.Size = new System.Drawing.Size(115, 41);
            this.StopSrv.TabIndex = 4;
            this.StopSrv.Text = "Stop Server";
            this.StopSrv.UseVisualStyleBackColor = true;
            this.StopSrv.Click += new System.EventHandler(this.StopSrv_Click);
            // 
            // _CmdLine
            // 
            this._CmdLine.AutoSize = true;
            this._CmdLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CmdLine.Location = new System.Drawing.Point(382, 506);
            this._CmdLine.Name = "_CmdLine";
            this._CmdLine.Size = new System.Drawing.Size(97, 13);
            this._CmdLine.TabIndex = 5;
            this._CmdLine.Text = "Command Line :";
            // 
            // _LgIP
            // 
            this._LgIP.AutoSize = true;
            this._LgIP.Location = new System.Drawing.Point(14, 132);
            this._LgIP.Name = "_LgIP";
            this._LgIP.Size = new System.Drawing.Size(46, 13);
            this._LgIP.TabIndex = 6;
            this._LgIP.Text = "Login IP";
            // 
            // _LgPort
            // 
            this._LgPort.AutoSize = true;
            this._LgPort.Location = new System.Drawing.Point(97, 132);
            this._LgPort.Name = "_LgPort";
            this._LgPort.Size = new System.Drawing.Size(55, 13);
            this._LgPort.TabIndex = 7;
            this._LgPort.Text = "Login Port";
            // 
            // LoginIP
            // 
            this.LoginIP.Location = new System.Drawing.Point(17, 148);
            this.LoginIP.Name = "LoginIP";
            this.LoginIP.Size = new System.Drawing.Size(63, 20);
            this.LoginIP.TabIndex = 8;
            this.LoginIP.Text = "127.0.0.1";
            // 
            // LoginPort
            // 
            this.LoginPort.Location = new System.Drawing.Point(100, 148);
            this.LoginPort.Name = "LoginPort";
            this.LoginPort.Size = new System.Drawing.Size(37, 20);
            this.LoginPort.TabIndex = 9;
            this.LoginPort.Text = "4002";
            // 
            // UserList
            // 
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(188, 139);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(188, 251);
            this.UserList.TabIndex = 10;
            // 
            // SrvChat
            // 
            this.SrvChat.Location = new System.Drawing.Point(9, 396);
            this.SrvChat.Name = "SrvChat";
            this.SrvChat.Size = new System.Drawing.Size(366, 123);
            this.SrvChat.TabIndex = 11;
            this.SrvChat.Text = "";
            // 
            // _SrvChat
            // 
            this._SrvChat.AutoSize = true;
            this._SrvChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._SrvChat.Location = new System.Drawing.Point(6, 380);
            this._SrvChat.Name = "_SrvChat";
            this._SrvChat.Size = new System.Drawing.Size(82, 13);
            this._SrvChat.TabIndex = 12;
            this._SrvChat.Text = "Server Chat :";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(878, 91);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(76, 20);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // _UserList
            // 
            this._UserList.AutoSize = true;
            this._UserList.Location = new System.Drawing.Point(185, 123);
            this._UserList.Name = "_UserList";
            this._UserList.Size = new System.Drawing.Size(40, 13);
            this._UserList.TabIndex = 14;
            this._UserList.Text = "Users :";
            // 
            // WorldIP
            // 
            this.WorldIP.Location = new System.Drawing.Point(17, 203);
            this.WorldIP.Name = "WorldIP";
            this.WorldIP.Size = new System.Drawing.Size(63, 20);
            this.WorldIP.TabIndex = 15;
            // 
            // WorldPort
            // 
            this.WorldPort.Location = new System.Drawing.Point(100, 203);
            this.WorldPort.Name = "WorldPort";
            this.WorldPort.Size = new System.Drawing.Size(37, 20);
            this.WorldPort.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 525);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(363, 20);
            this.textBox3.TabIndex = 17;
            // 
            // _WorldIP
            // 
            this._WorldIP.AutoSize = true;
            this._WorldIP.Location = new System.Drawing.Point(14, 187);
            this._WorldIP.Name = "_WorldIP";
            this._WorldIP.Size = new System.Drawing.Size(48, 13);
            this._WorldIP.TabIndex = 18;
            this._WorldIP.Text = "World IP";
            // 
            // _WorldPort
            // 
            this._WorldPort.AutoSize = true;
            this._WorldPort.Location = new System.Drawing.Point(97, 187);
            this._WorldPort.Name = "_WorldPort";
            this._WorldPort.Size = new System.Drawing.Size(57, 13);
            this._WorldPort.TabIndex = 19;
            this._WorldPort.Text = "World Port";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 563);
            this.Controls.Add(this._WorldPort);
            this.Controls.Add(this._WorldIP);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.WorldPort);
            this.Controls.Add(this.WorldIP);
            this.Controls.Add(this._UserList);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this._SrvChat);
            this.Controls.Add(this.SrvChat);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.LoginPort);
            this.Controls.Add(this.LoginIP);
            this.Controls.Add(this._LgPort);
            this.Controls.Add(this._LgIP);
            this.Controls.Add(this._CmdLine);
            this.Controls.Add(this.StopSrv);
            this.Controls.Add(this.StartSrv);
            this.Controls.Add(this.CmdLine);
            this.Controls.Add(this._SrvInfo);
            this.Controls.Add(this.Console);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "EastMile [Main]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Console;
        private System.Windows.Forms.Label _SrvInfo;
        private System.Windows.Forms.TextBox CmdLine;
        private System.Windows.Forms.Button StartSrv;
        private System.Windows.Forms.Button StopSrv;
        private System.Windows.Forms.Label _CmdLine;
        private System.Windows.Forms.Label _LgIP;
        private System.Windows.Forms.Label _LgPort;
        private System.Windows.Forms.TextBox LoginIP;
        private System.Windows.Forms.TextBox LoginPort;
        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.RichTextBox SrvChat;
        private System.Windows.Forms.Label _SrvChat;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label _UserList;
        private System.Windows.Forms.TextBox WorldIP;
        private System.Windows.Forms.TextBox WorldPort;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label _WorldIP;
        private System.Windows.Forms.Label _WorldPort;
    }
}

