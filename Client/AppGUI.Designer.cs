using System;
using Domain;


namespace Client
{
    partial class AppGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppGUI));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.labelLoginBunVenit = new System.Windows.Forms.Label();
            this.labelLoginError = new System.Windows.Forms.Label();
            this.buttonJumpToMain = new System.Windows.Forms.Button();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.textBoxLoginUser = new System.Windows.Forms.TextBox();
            this.labelLoginUser = new System.Windows.Forms.Label();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.comboBoxMainVarstaFiltrare = new System.Windows.Forms.ComboBox();
            this.checkBoxMainVarsta = new System.Windows.Forms.CheckBox();
            this.comboBoxMainProbaFiltrare = new System.Windows.Forms.ComboBox();
            this.checkBoxMainProba = new System.Windows.Forms.CheckBox();
            this.labelMainFiltrare = new System.Windows.Forms.Label();
            this.numericUpDownVarsta = new System.Windows.Forms.NumericUpDown();
            this.textBoxMainNrPartic = new System.Windows.Forms.TextBox();
            this.comboBoxMainProbaNrPart = new System.Windows.Forms.ComboBox();
            this.labelMainNrParticipanti = new System.Windows.Forms.Label();
            this.buttonMainAdaugaParticipare = new System.Windows.Forms.Button();
            this.buttonMainAdaugaParticipant = new System.Windows.Forms.Button();
            this.comboBoxMainProba = new System.Windows.Forms.ComboBox();
            this.labelMainProba = new System.Windows.Forms.Label();
            this.labelMainVarsta = new System.Windows.Forms.Label();
            this.textBoxMainNume = new System.Windows.Forms.TextBox();
            this.labelMainNume = new System.Windows.Forms.Label();
            this.dataGridViewParticipari = new System.Windows.Forms.DataGridView();
            this.dataGridViewParticipanti = new System.Windows.Forms.DataGridView();
            this.ColumnIDParticipanti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumeParticipanti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVarstaParticipanti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNrParticipariParticipanti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonJumpToExit = new System.Windows.Forms.Button();
            this.tabPageExit = new System.Windows.Forms.TabPage();
            this.buttonJumpToLogin = new System.Windows.Forms.Button();
            this.labelExitMessage = new System.Windows.Forms.Label();
            this.ColumnIDParticipari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIDParticipantParticipari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProbaParticipari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVarsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipanti)).BeginInit();
            this.tabPageExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageLogin);
            this.tabControl.Controls.Add(this.tabPageMain);
            this.tabControl.Controls.Add(this.tabPageExit);
            this.tabControl.Location = new System.Drawing.Point(-13, -47);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(996, 598);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.BackgroundImage = global::Client.Properties.Resources.background_login_logout;
            this.tabPageLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageLogin.Controls.Add(this.labelLoginBunVenit);
            this.tabPageLogin.Controls.Add(this.labelLoginError);
            this.tabPageLogin.Controls.Add(this.buttonJumpToMain);
            this.tabPageLogin.Controls.Add(this.textBoxLoginPassword);
            this.tabPageLogin.Controls.Add(this.labelLoginPassword);
            this.tabPageLogin.Controls.Add(this.textBoxLoginUser);
            this.tabPageLogin.Controls.Add(this.labelLoginUser);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 25);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(988, 569);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // labelLoginBunVenit
            // 
            this.labelLoginBunVenit.AutoSize = true;
            this.labelLoginBunVenit.BackColor = System.Drawing.Color.Salmon;
            this.labelLoginBunVenit.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginBunVenit.ForeColor = System.Drawing.Color.Purple;
            this.labelLoginBunVenit.Location = new System.Drawing.Point(341, 249);
            this.labelLoginBunVenit.Name = "labelLoginBunVenit";
            this.labelLoginBunVenit.Size = new System.Drawing.Size(259, 72);
            this.labelLoginBunVenit.TabIndex = 6;
            this.labelLoginBunVenit.Text = "Bun venit!";
            // 
            // labelLoginError
            // 
            this.labelLoginError.AutoSize = true;
            this.labelLoginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginError.ForeColor = System.Drawing.Color.Red;
            this.labelLoginError.Location = new System.Drawing.Point(369, 407);
            this.labelLoginError.Name = "labelLoginError";
            this.labelLoginError.Size = new System.Drawing.Size(0, 20);
            this.labelLoginError.TabIndex = 5;
            // 
            // buttonJumpToMain
            // 
            this.buttonJumpToMain.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonJumpToMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonJumpToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJumpToMain.ForeColor = System.Drawing.Color.Brown;
            this.buttonJumpToMain.Location = new System.Drawing.Point(362, 443);
            this.buttonJumpToMain.Name = "buttonJumpToMain";
            this.buttonJumpToMain.Size = new System.Drawing.Size(228, 30);
            this.buttonJumpToMain.TabIndex = 4;
            this.buttonJumpToMain.Text = "Autentificare";
            this.buttonJumpToMain.UseVisualStyleBackColor = false;
            this.buttonJumpToMain.Click += new System.EventHandler(this.buttonJumpToMain_Click);
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Location = new System.Drawing.Point(442, 373);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.PasswordChar = '*';
            this.textBoxLoginPassword.Size = new System.Drawing.Size(148, 22);
            this.textBoxLoginPassword.TabIndex = 3;
            this.textBoxLoginPassword.UseSystemPasswordChar = true;
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPassword.Location = new System.Drawing.Point(369, 375);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(63, 20);
            this.labelLoginPassword.TabIndex = 2;
            this.labelLoginPassword.Text = "Parola";
            // 
            // textBoxLoginUser
            // 
            this.textBoxLoginUser.Location = new System.Drawing.Point(442, 333);
            this.textBoxLoginUser.Name = "textBoxLoginUser";
            this.textBoxLoginUser.Size = new System.Drawing.Size(148, 22);
            this.textBoxLoginUser.TabIndex = 1;
            // 
            // labelLoginUser
            // 
            this.labelLoginUser.AutoSize = true;
            this.labelLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginUser.Location = new System.Drawing.Point(383, 333);
            this.labelLoginUser.Name = "labelLoginUser";
            this.labelLoginUser.Size = new System.Drawing.Size(49, 20);
            this.labelLoginUser.TabIndex = 0;
            this.labelLoginUser.Text = "User";
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabPageMain.Controls.Add(this.comboBoxMainVarstaFiltrare);
            this.tabPageMain.Controls.Add(this.checkBoxMainVarsta);
            this.tabPageMain.Controls.Add(this.comboBoxMainProbaFiltrare);
            this.tabPageMain.Controls.Add(this.checkBoxMainProba);
            this.tabPageMain.Controls.Add(this.labelMainFiltrare);
            this.tabPageMain.Controls.Add(this.numericUpDownVarsta);
            this.tabPageMain.Controls.Add(this.textBoxMainNrPartic);
            this.tabPageMain.Controls.Add(this.comboBoxMainProbaNrPart);
            this.tabPageMain.Controls.Add(this.labelMainNrParticipanti);
            this.tabPageMain.Controls.Add(this.buttonMainAdaugaParticipare);
            this.tabPageMain.Controls.Add(this.buttonMainAdaugaParticipant);
            this.tabPageMain.Controls.Add(this.comboBoxMainProba);
            this.tabPageMain.Controls.Add(this.labelMainProba);
            this.tabPageMain.Controls.Add(this.labelMainVarsta);
            this.tabPageMain.Controls.Add(this.textBoxMainNume);
            this.tabPageMain.Controls.Add(this.labelMainNume);
            this.tabPageMain.Controls.Add(this.dataGridViewParticipari);
            this.tabPageMain.Controls.Add(this.dataGridViewParticipanti);
            this.tabPageMain.Controls.Add(this.buttonJumpToExit);
            this.tabPageMain.Location = new System.Drawing.Point(4, 25);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(988, 569);
            this.tabPageMain.TabIndex = 1;
            this.tabPageMain.Text = "Main";
            // 
            // comboBoxMainVarstaFiltrare
            // 
            this.comboBoxMainVarstaFiltrare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboBoxMainVarstaFiltrare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMainVarstaFiltrare.Items.AddRange(new object[] {
            "6-8",
            "9-11",
            "12-15"});
            this.comboBoxMainVarstaFiltrare.Location = new System.Drawing.Point(806, 70);
            this.comboBoxMainVarstaFiltrare.Name = "comboBoxMainVarstaFiltrare";
            this.comboBoxMainVarstaFiltrare.Size = new System.Drawing.Size(161, 24);
            this.comboBoxMainVarstaFiltrare.TabIndex = 19;
            this.comboBoxMainVarstaFiltrare.SelectedIndexChanged += new System.EventHandler(this.comboBoxMainVarstaFiltrare_SelectedIndexChanged);
            // 
            // checkBoxMainVarsta
            // 
            this.checkBoxMainVarsta.AutoSize = true;
            this.checkBoxMainVarsta.BackColor = System.Drawing.Color.MediumVioletRed;
            this.checkBoxMainVarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMainVarsta.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBoxMainVarsta.Location = new System.Drawing.Point(716, 73);
            this.checkBoxMainVarsta.Name = "checkBoxMainVarsta";
            this.checkBoxMainVarsta.Size = new System.Drawing.Size(77, 21);
            this.checkBoxMainVarsta.TabIndex = 18;
            this.checkBoxMainVarsta.Text = "Varsta";
            this.checkBoxMainVarsta.UseVisualStyleBackColor = false;
            this.checkBoxMainVarsta.CheckedChanged += new System.EventHandler(this.checkBoxMainVarsta_CheckedChanged);
            // 
            // comboBoxMainProbaFiltrare
            // 
            this.comboBoxMainProbaFiltrare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboBoxMainProbaFiltrare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMainProbaFiltrare.Items.AddRange(new object[] {
            "Desen",
            "Cautare comoara",
            "Poezie"});
            this.comboBoxMainProbaFiltrare.Location = new System.Drawing.Point(806, 38);
            this.comboBoxMainProbaFiltrare.Name = "comboBoxMainProbaFiltrare";
            this.comboBoxMainProbaFiltrare.Size = new System.Drawing.Size(161, 24);
            this.comboBoxMainProbaFiltrare.TabIndex = 17;
            this.comboBoxMainProbaFiltrare.SelectedIndexChanged += new System.EventHandler(this.comboBoxMainProbaFiltrare_SelectedIndexChanged);
            // 
            // checkBoxMainProba
            // 
            this.checkBoxMainProba.AutoSize = true;
            this.checkBoxMainProba.BackColor = System.Drawing.Color.MediumVioletRed;
            this.checkBoxMainProba.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMainProba.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBoxMainProba.Location = new System.Drawing.Point(716, 41);
            this.checkBoxMainProba.Name = "checkBoxMainProba";
            this.checkBoxMainProba.Size = new System.Drawing.Size(73, 21);
            this.checkBoxMainProba.TabIndex = 16;
            this.checkBoxMainProba.Text = "Proba";
            this.checkBoxMainProba.UseVisualStyleBackColor = false;
            this.checkBoxMainProba.CheckedChanged += new System.EventHandler(this.checkBoxMainProba_CheckedChanged);
            // 
            // labelMainFiltrare
            // 
            this.labelMainFiltrare.AutoSize = true;
            this.labelMainFiltrare.BackColor = System.Drawing.Color.MediumVioletRed;
            this.labelMainFiltrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainFiltrare.ForeColor = System.Drawing.SystemColors.Info;
            this.labelMainFiltrare.Location = new System.Drawing.Point(598, 57);
            this.labelMainFiltrare.Name = "labelMainFiltrare";
            this.labelMainFiltrare.Size = new System.Drawing.Size(101, 17);
            this.labelMainFiltrare.TabIndex = 15;
            this.labelMainFiltrare.Text = "Filtrare dupa";
            // 
            // numericUpDownVarsta
            // 
            this.numericUpDownVarsta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numericUpDownVarsta.Location = new System.Drawing.Point(295, 499);
            this.numericUpDownVarsta.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownVarsta.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownVarsta.Name = "numericUpDownVarsta";
            this.numericUpDownVarsta.Size = new System.Drawing.Size(77, 22);
            this.numericUpDownVarsta.TabIndex = 14;
            this.numericUpDownVarsta.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownVarsta.ValueChanged += new System.EventHandler(this.numericUpDownVarsta_ValueChanged);
            // 
            // textBoxMainNrPartic
            // 
            this.textBoxMainNrPartic.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxMainNrPartic.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxMainNrPartic.Location = new System.Drawing.Point(477, 52);
            this.textBoxMainNrPartic.Name = "textBoxMainNrPartic";
            this.textBoxMainNrPartic.ReadOnly = true;
            this.textBoxMainNrPartic.Size = new System.Drawing.Size(100, 22);
            this.textBoxMainNrPartic.TabIndex = 13;
            // 
            // comboBoxMainProbaNrPart
            // 
            this.comboBoxMainProbaNrPart.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxMainProbaNrPart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMainProbaNrPart.FormattingEnabled = true;
            this.comboBoxMainProbaNrPart.Items.AddRange(new object[] {
            "Desen",
            "Cautare comoara",
            "Poezie"});
            this.comboBoxMainProbaNrPart.Location = new System.Drawing.Point(317, 52);
            this.comboBoxMainProbaNrPart.Name = "comboBoxMainProbaNrPart";
            this.comboBoxMainProbaNrPart.Size = new System.Drawing.Size(154, 24);
            this.comboBoxMainProbaNrPart.TabIndex = 12;
            this.comboBoxMainProbaNrPart.SelectedIndexChanged += new System.EventHandler(this.comboBoxMainProbaNrPart_SelectedIndexChanged);
            // 
            // labelMainNrParticipanti
            // 
            this.labelMainNrParticipanti.AutoSize = true;
            this.labelMainNrParticipanti.BackColor = System.Drawing.Color.Yellow;
            this.labelMainNrParticipanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainNrParticipanti.Location = new System.Drawing.Point(119, 55);
            this.labelMainNrParticipanti.Name = "labelMainNrParticipanti";
            this.labelMainNrParticipanti.Size = new System.Drawing.Size(182, 17);
            this.labelMainNrParticipanti.TabIndex = 11;
            this.labelMainNrParticipanti.Text = "Nr. Participanti la proba";
            // 
            // buttonMainAdaugaParticipare
            // 
            this.buttonMainAdaugaParticipare.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonMainAdaugaParticipare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMainAdaugaParticipare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMainAdaugaParticipare.ForeColor = System.Drawing.Color.Black;
            this.buttonMainAdaugaParticipare.Location = new System.Drawing.Point(791, 495);
            this.buttonMainAdaugaParticipare.Name = "buttonMainAdaugaParticipare";
            this.buttonMainAdaugaParticipare.Size = new System.Drawing.Size(176, 30);
            this.buttonMainAdaugaParticipare.TabIndex = 10;
            this.buttonMainAdaugaParticipare.Text = "Adauga Participare";
            this.buttonMainAdaugaParticipare.UseVisualStyleBackColor = false;
            this.buttonMainAdaugaParticipare.Click += new System.EventHandler(this.buttonMainAdaugaParticipare_Click);
            // 
            // buttonMainAdaugaParticipant
            // 
            this.buttonMainAdaugaParticipant.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonMainAdaugaParticipant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMainAdaugaParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMainAdaugaParticipant.Location = new System.Drawing.Point(389, 495);
            this.buttonMainAdaugaParticipant.Name = "buttonMainAdaugaParticipant";
            this.buttonMainAdaugaParticipant.Size = new System.Drawing.Size(172, 30);
            this.buttonMainAdaugaParticipant.TabIndex = 9;
            this.buttonMainAdaugaParticipant.Text = "Adauga participant";
            this.buttonMainAdaugaParticipant.UseVisualStyleBackColor = false;
            this.buttonMainAdaugaParticipant.Click += new System.EventHandler(this.buttonMainAdaugaParticipant_Click);
            // 
            // comboBoxMainProba
            // 
            this.comboBoxMainProba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.comboBoxMainProba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxMainProba.Items.AddRange(new object[] {
            "Desen",
            "Cautare comoara",
            "Poezie"});
            this.comboBoxMainProba.Location = new System.Drawing.Point(639, 499);
            this.comboBoxMainProba.Name = "comboBoxMainProba";
            this.comboBoxMainProba.Size = new System.Drawing.Size(137, 24);
            this.comboBoxMainProba.TabIndex = 8;
            this.comboBoxMainProba.SelectedIndexChanged += new System.EventHandler(this.comboBoxProba_SelectedIndexChanged);
            // 
            // labelMainProba
            // 
            this.labelMainProba.AutoSize = true;
            this.labelMainProba.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainProba.Location = new System.Drawing.Point(582, 502);
            this.labelMainProba.Name = "labelMainProba";
            this.labelMainProba.Size = new System.Drawing.Size(51, 17);
            this.labelMainProba.TabIndex = 7;
            this.labelMainProba.Text = "Proba";
            // 
            // labelMainVarsta
            // 
            this.labelMainVarsta.AutoSize = true;
            this.labelMainVarsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainVarsta.Location = new System.Drawing.Point(231, 502);
            this.labelMainVarsta.Name = "labelMainVarsta";
            this.labelMainVarsta.Size = new System.Drawing.Size(55, 17);
            this.labelMainVarsta.TabIndex = 5;
            this.labelMainVarsta.Text = "Varsta";
            // 
            // textBoxMainNume
            // 
            this.textBoxMainNume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxMainNume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxMainNume.Location = new System.Drawing.Point(76, 499);
            this.textBoxMainNume.Name = "textBoxMainNume";
            this.textBoxMainNume.Size = new System.Drawing.Size(150, 22);
            this.textBoxMainNume.TabIndex = 4;
            this.textBoxMainNume.TextChanged += new System.EventHandler(this.textBoxMainNume_TextChanged);
            // 
            // labelMainNume
            // 
            this.labelMainNume.AutoSize = true;
            this.labelMainNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainNume.Location = new System.Drawing.Point(21, 502);
            this.labelMainNume.Name = "labelMainNume";
            this.labelMainNume.Size = new System.Drawing.Size(49, 17);
            this.labelMainNume.TabIndex = 3;
            this.labelMainNume.Text = "Nume";
            // 
            // dataGridViewParticipari
            // 
            this.dataGridViewParticipari.AllowUserToAddRows = false;
            this.dataGridViewParticipari.AllowUserToDeleteRows = false;
            this.dataGridViewParticipari.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridViewParticipari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDParticipari,
            this.ColumnIDParticipantParticipari,
            this.ColumnProbaParticipari,
            this.ColumnCategorie});
            this.dataGridViewParticipari.Location = new System.Drawing.Point(497, 107);
            this.dataGridViewParticipari.Name = "dataGridViewParticipari";
            this.dataGridViewParticipari.RowHeadersWidth = 51;
            this.dataGridViewParticipari.RowTemplate.Height = 24;
            this.dataGridViewParticipari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewParticipari.Size = new System.Drawing.Size(470, 370);
            this.dataGridViewParticipari.TabIndex = 2;
            // 
            // dataGridViewParticipanti
            // 
            this.dataGridViewParticipanti.AllowUserToAddRows = false;
            this.dataGridViewParticipanti.AllowUserToDeleteRows = false;
            this.dataGridViewParticipanti.BackgroundColor = System.Drawing.Color.Plum;
            this.dataGridViewParticipanti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipanti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDParticipanti,
            this.ColumnNumeParticipanti,
            this.ColumnVarstaParticipanti,
            this.ColumnNrParticipariParticipanti});
            this.dataGridViewParticipanti.Location = new System.Drawing.Point(21, 107);
            this.dataGridViewParticipanti.MultiSelect = false;
            this.dataGridViewParticipanti.Name = "dataGridViewParticipanti";
            this.dataGridViewParticipanti.ReadOnly = true;
            this.dataGridViewParticipanti.RowHeadersWidth = 51;
            this.dataGridViewParticipanti.RowTemplate.Height = 24;
            this.dataGridViewParticipanti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewParticipanti.Size = new System.Drawing.Size(470, 370);
            this.dataGridViewParticipanti.TabIndex = 1;
            this.dataGridViewParticipanti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParticipanti_CellContentClick);
            // 
            // ColumnIDParticipanti
            // 
            this.ColumnIDParticipanti.HeaderText = "ID";
            this.ColumnIDParticipanti.MinimumWidth = 6;
            this.ColumnIDParticipanti.Name = "ColumnIDParticipanti";
            this.ColumnIDParticipanti.ReadOnly = true;
            this.ColumnIDParticipanti.Width = 60;
            // 
            // ColumnNumeParticipanti
            // 
            this.ColumnNumeParticipanti.HeaderText = "Nume";
            this.ColumnNumeParticipanti.MinimumWidth = 6;
            this.ColumnNumeParticipanti.Name = "ColumnNumeParticipanti";
            this.ColumnNumeParticipanti.ReadOnly = true;
            this.ColumnNumeParticipanti.Width = 125;
            // 
            // ColumnVarstaParticipanti
            // 
            this.ColumnVarstaParticipanti.HeaderText = "Varsta";
            this.ColumnVarstaParticipanti.MinimumWidth = 6;
            this.ColumnVarstaParticipanti.Name = "ColumnVarstaParticipanti";
            this.ColumnVarstaParticipanti.ReadOnly = true;
            this.ColumnVarstaParticipanti.Width = 60;
            // 
            // ColumnNrParticipariParticipanti
            // 
            this.ColumnNrParticipariParticipanti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnNrParticipariParticipanti.HeaderText = "Nr. Participari";
            this.ColumnNrParticipariParticipanti.MinimumWidth = 6;
            this.ColumnNrParticipariParticipanti.Name = "ColumnNrParticipariParticipanti";
            this.ColumnNrParticipariParticipanti.ReadOnly = true;
            this.ColumnNrParticipariParticipanti.Width = 123;
            // 
            // buttonJumpToExit
            // 
            this.buttonJumpToExit.BackColor = System.Drawing.Color.Crimson;
            this.buttonJumpToExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonJumpToExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJumpToExit.ForeColor = System.Drawing.Color.Gold;
            this.buttonJumpToExit.Location = new System.Drawing.Point(21, 33);
            this.buttonJumpToExit.Name = "buttonJumpToExit";
            this.buttonJumpToExit.Size = new System.Drawing.Size(75, 28);
            this.buttonJumpToExit.TabIndex = 0;
            this.buttonJumpToExit.Text = "Iesire";
            this.buttonJumpToExit.UseVisualStyleBackColor = false;
            this.buttonJumpToExit.Click += new System.EventHandler(this.buttonJumpToExit_Click);
            // 
            // tabPageExit
            // 
            this.tabPageExit.BackgroundImage = global::Client.Properties.Resources.background_login_logout;
            this.tabPageExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageExit.Controls.Add(this.buttonJumpToLogin);
            this.tabPageExit.Controls.Add(this.labelExitMessage);
            this.tabPageExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tabPageExit.Location = new System.Drawing.Point(4, 25);
            this.tabPageExit.Name = "tabPageExit";
            this.tabPageExit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExit.Size = new System.Drawing.Size(988, 569);
            this.tabPageExit.TabIndex = 2;
            this.tabPageExit.Text = "Exit";
            this.tabPageExit.UseVisualStyleBackColor = true;
            // 
            // buttonJumpToLogin
            // 
            this.buttonJumpToLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonJumpToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonJumpToLogin.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJumpToLogin.ForeColor = System.Drawing.Color.Yellow;
            this.buttonJumpToLogin.Location = new System.Drawing.Point(348, 378);
            this.buttonJumpToLogin.Name = "buttonJumpToLogin";
            this.buttonJumpToLogin.Size = new System.Drawing.Size(293, 44);
            this.buttonJumpToLogin.TabIndex = 1;
            this.buttonJumpToLogin.Text = "Inapoi la pagina de login";
            this.buttonJumpToLogin.UseVisualStyleBackColor = false;
            this.buttonJumpToLogin.Click += new System.EventHandler(this.buttonJumpToLogin_Click);
            // 
            // labelExitMessage
            // 
            this.labelExitMessage.AutoSize = true;
            this.labelExitMessage.BackColor = System.Drawing.Color.Salmon;
            this.labelExitMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExitMessage.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExitMessage.ForeColor = System.Drawing.Color.Purple;
            this.labelExitMessage.Location = new System.Drawing.Point(375, 287);
            this.labelExitMessage.Name = "labelExitMessage";
            this.labelExitMessage.Size = new System.Drawing.Size(233, 59);
            this.labelExitMessage.TabIndex = 0;
            this.labelExitMessage.Text = "La revedere!";
            // 
            // ColumnIDParticipari
            // 
            this.ColumnIDParticipari.HeaderText = "ID";
            this.ColumnIDParticipari.MinimumWidth = 6;
            this.ColumnIDParticipari.Name = "ColumnIDParticipari";
            this.ColumnIDParticipari.Width = 40;
            // 
            // ColumnIDParticipantParticipari
            // 
            this.ColumnIDParticipantParticipari.HeaderText = "ID participant";
            this.ColumnIDParticipantParticipari.MinimumWidth = 6;
            this.ColumnIDParticipantParticipari.Name = "ColumnIDParticipantParticipari";
            this.ColumnIDParticipantParticipari.Width = 80;
            // 
            // ColumnProbaParticipari
            // 
            this.ColumnProbaParticipari.HeaderText = "Proba";
            this.ColumnProbaParticipari.MinimumWidth = 6;
            this.ColumnProbaParticipari.Name = "ColumnProbaParticipari";
            this.ColumnProbaParticipari.Width = 110;
            // 
            // ColumnCategorie
            // 
            this.ColumnCategorie.HeaderText = "Categorie Varsta";
            this.ColumnCategorie.MinimumWidth = 6;
            this.ColumnCategorie.Name = "ColumnCategorie";
            this.ColumnCategorie.Width = 110;
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 543);
            this.Controls.Add(this.tabControl);
            this.Name = "Controller";
            this.Text = "Problema5";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageLogin.PerformLayout();
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVarsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipanti)).EndInit();
            this.tabPageExit.ResumeLayout(false);
            this.tabPageExit.PerformLayout();
            this.ResumeLayout(false);

        }

        private void CustomizeComponents()
        {

            this.dataGridViewParticipanti.SelectionChanged += new EventHandler(DataGridViewParticipanti_SelectionChanged);
            this.buttonMainAdaugaParticipant.Enabled = false;
            this.buttonMainAdaugaParticipare.Enabled = false;
            this.comboBoxMainVarstaFiltrare.Enabled = false;
            this.comboBoxMainProbaFiltrare.Enabled = false;
            this.textBoxMainNrPartic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        }



        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageExit;
        private System.Windows.Forms.Button buttonJumpToLogin;
        private System.Windows.Forms.Label labelExitMessage;
        private System.Windows.Forms.Label labelLoginError;
        private System.Windows.Forms.Button buttonJumpToMain;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.TextBox textBoxLoginUser;
        private System.Windows.Forms.Label labelLoginUser;
        private System.Windows.Forms.Button buttonJumpToExit;
        private System.Windows.Forms.Label labelLoginBunVenit;
        private System.Windows.Forms.Button buttonMainAdaugaParticipare;
        private System.Windows.Forms.Button buttonMainAdaugaParticipant;
        private System.Windows.Forms.ComboBox comboBoxMainProba;
        private System.Windows.Forms.Label labelMainProba;
        private System.Windows.Forms.Label labelMainVarsta;
        private System.Windows.Forms.TextBox textBoxMainNume;
        private System.Windows.Forms.Label labelMainNume;
        private System.Windows.Forms.DataGridView dataGridViewParticipari;
        private System.Windows.Forms.DataGridView dataGridViewParticipanti;
        private System.Windows.Forms.TextBox textBoxMainNrPartic;
        private System.Windows.Forms.ComboBox comboBoxMainProbaNrPart;
        private System.Windows.Forms.Label labelMainNrParticipanti;
        private System.Windows.Forms.NumericUpDown numericUpDownVarsta;
        private System.Windows.Forms.Label labelMainFiltrare;
        private System.Windows.Forms.ComboBox comboBoxMainProbaFiltrare;
        private System.Windows.Forms.CheckBox checkBoxMainProba;
        private System.Windows.Forms.ComboBox comboBoxMainVarstaFiltrare;
        private System.Windows.Forms.CheckBox checkBoxMainVarsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDParticipanti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumeParticipanti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVarstaParticipanti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNrParticipariParticipanti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDParticipari;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDParticipantParticipari;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProbaParticipari;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategorie;
    }
}

