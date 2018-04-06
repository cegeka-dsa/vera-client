namespace Onderhoudsverzoek
{
    partial class frmKeuzeboom
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbRuimteSoorten = new System.Windows.Forms.ComboBox();
            this.cmbBouwElementen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOnderdeel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGebrek = new System.Windows.Forms.ComboBox();
            this.txtEenheid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOorzaken = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnToggleLog = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHuurderNummer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(6, 27);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(600, 20);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "https://vera-r17-test-win.meerstedewonen.nl/dgo";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(387, 67);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(217, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(545, 88);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(57, 22);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Connect";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmbRuimteSoorten
            // 
            this.cmbRuimteSoorten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRuimteSoorten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRuimteSoorten.FormattingEnabled = true;
            this.cmbRuimteSoorten.Location = new System.Drawing.Point(6, 174);
            this.cmbRuimteSoorten.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRuimteSoorten.Name = "cmbRuimteSoorten";
            this.cmbRuimteSoorten.Size = new System.Drawing.Size(600, 21);
            this.cmbRuimteSoorten.TabIndex = 5;
            this.cmbRuimteSoorten.SelectedIndexChanged += new System.EventHandler(this.cmbRuimteSoorten_SelectedIndexChanged);
            // 
            // cmbBouwElementen
            // 
            this.cmbBouwElementen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBouwElementen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBouwElementen.FormattingEnabled = true;
            this.cmbBouwElementen.Location = new System.Drawing.Point(6, 216);
            this.cmbBouwElementen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBouwElementen.Name = "cmbBouwElementen";
            this.cmbBouwElementen.Size = new System.Drawing.Size(600, 21);
            this.cmbBouwElementen.TabIndex = 6;
            this.cmbBouwElementen.SelectedIndexChanged += new System.EventHandler(this.cmbBouwElementen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ruimtesoort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bouwelement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Onderdeel";
            // 
            // cmbOnderdeel
            // 
            this.cmbOnderdeel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOnderdeel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOnderdeel.FormattingEnabled = true;
            this.cmbOnderdeel.Location = new System.Drawing.Point(6, 257);
            this.cmbOnderdeel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOnderdeel.Name = "cmbOnderdeel";
            this.cmbOnderdeel.Size = new System.Drawing.Size(600, 21);
            this.cmbOnderdeel.TabIndex = 7;
            this.cmbOnderdeel.SelectedIndexChanged += new System.EventHandler(this.cmbOnderdeel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gebrek";
            // 
            // cmbGebrek
            // 
            this.cmbGebrek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGebrek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGebrek.FormattingEnabled = true;
            this.cmbGebrek.Location = new System.Drawing.Point(6, 299);
            this.cmbGebrek.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGebrek.Name = "cmbGebrek";
            this.cmbGebrek.Size = new System.Drawing.Size(600, 21);
            this.cmbGebrek.TabIndex = 8;
            this.cmbGebrek.SelectedIndexChanged += new System.EventHandler(this.cmbGebrek_SelectedIndexChanged);
            // 
            // txtEenheid
            // 
            this.txtEenheid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEenheid.Location = new System.Drawing.Point(387, 131);
            this.txtEenheid.Margin = new System.Windows.Forms.Padding(2);
            this.txtEenheid.Name = "txtEenheid";
            this.txtEenheid.Size = new System.Drawing.Size(112, 20);
            this.txtEenheid.TabIndex = 3;
            this.txtEenheid.Text = "1309003";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 322);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Oorzaak";
            // 
            // cmbOorzaken
            // 
            this.cmbOorzaken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOorzaken.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOorzaken.FormattingEnabled = true;
            this.cmbOorzaken.Location = new System.Drawing.Point(6, 341);
            this.cmbOorzaken.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOorzaken.Name = "cmbOorzaken";
            this.cmbOorzaken.Size = new System.Drawing.Size(600, 21);
            this.cmbOorzaken.TabIndex = 9;
            this.cmbOorzaken.SelectedIndexChanged += new System.EventHandler(this.cmbOorzaken_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 404);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(597, 0);
            this.textBox1.TabIndex = 19;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(8, 383);
            this.lblLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(25, 13);
            this.lblLog.TabIndex = 20;
            this.lblLog.Text = "Log";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Wachtwoord";
            // 
            // btnToggleLog
            // 
            this.btnToggleLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleLog.Location = new System.Drawing.Point(579, 380);
            this.btnToggleLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnToggleLog.Name = "btnToggleLog";
            this.btnToggleLog.Size = new System.Drawing.Size(26, 18);
            this.btnToggleLog.TabIndex = 10;
            this.btnToggleLog.Text = "v";
            this.btnToggleLog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnToggleLog.UseVisualStyleBackColor = true;
            this.btnToggleLog.Click += new System.EventHandler(this.btnToggleLog_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Url";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Eenheidnummer";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Huurdernummer";
            // 
            // txtHuurderNummer
            // 
            this.txtHuurderNummer.Location = new System.Drawing.Point(6, 131);
            this.txtHuurderNummer.Margin = new System.Windows.Forms.Padding(2);
            this.txtHuurderNummer.Name = "txtHuurderNummer";
            this.txtHuurderNummer.Size = new System.Drawing.Size(112, 20);
            this.txtHuurderNummer.TabIndex = 26;
            this.txtHuurderNummer.Text = "K00001285";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(537, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 22);
            this.button1.TabIndex = 28;
            this.button1.Text = "Webclient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 49);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Domein";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(6, 67);
            this.txtDomain.Margin = new System.Windows.Forms.Padding(2);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(112, 20);
            this.txtDomain.TabIndex = 29;
            this.txtDomain.Text = "DE";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(202, 67);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(112, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "InspireDemo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(202, 49);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Gebruiker";
            // 
            // frmKeuzeboom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 406);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHuurderNummer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnToggleLog);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbOorzaken);
            this.Controls.Add(this.txtEenheid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbGebrek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOnderdeel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBouwElementen);
            this.Controls.Add(this.cmbRuimteSoorten);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUrl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(626, 445);
            this.Name = "frmKeuzeboom";
            this.Text = "Onderhoudsverzoek maken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmbRuimteSoorten;
        private System.Windows.Forms.ComboBox cmbBouwElementen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOnderdeel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGebrek;
        private System.Windows.Forms.TextBox txtEenheid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOorzaken;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnToggleLog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHuurderNummer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label12;
    }
}

