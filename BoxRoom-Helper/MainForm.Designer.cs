namespace BoxRoom_Helper
{
    partial class MainForm
    {
        private Label lblCustomName;
        private TextBox txtCustomName;

        private Label lblDeveloper;
        private TextBox txtDeveloper;

        private Label lblPublisher;
        private TextBox txtPublisher;

        private Label lblGenre;
        private TextBox txtGenre;

        private Label lblReleaseDate;
        private DateTimePicker dtpReleaseDate;

        private Label lblShortDescription;
        private TextBox txtShortDescription;

        private Label lblAboutGame;
        private RichTextBox rtbAboutGame;

        private Button btnCreateCustom;

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
            tabControl1 = new TabControl();
            AutoScrapeTab = new TabPage();
            GetScreenShotsBTN = new Button();
            groupBox1 = new GroupBox();
            CUSTOMCB = new CheckBox();
            button6 = new Button();
            AUDIOCB = new CheckBox();
            SOFTWARECB = new CheckBox();
            DLCCB = new CheckBox();
            GAMESCB = new CheckBox();
            StatusProgress = new ProgressBar();
            StatusLabel = new Label();
            CoverGetter = new Button();
            button4 = new Button();
            label2 = new Label();
            button3 = new Button();
            SteamCachePathBox = new TextBox();
            BasicAddTab = new TabPage();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            label1 = new Label();
            CustomGameTab = new TabPage();
            button8 = new Button();
            button5 = new Button();
            IGDB_Btn = new Button();
            lblCustomName = new Label();
            txtCustomName = new TextBox();
            lblDeveloper = new Label();
            txtDeveloper = new TextBox();
            lblPublisher = new Label();
            txtPublisher = new TextBox();
            lblGenre = new Label();
            txtGenre = new TextBox();
            lblReleaseDate = new Label();
            dtpReleaseDate = new DateTimePicker();
            lblShortDescription = new Label();
            txtShortDescription = new TextBox();
            lblAboutGame = new Label();
            rtbAboutGame = new RichTextBox();
            btnCreateCustom = new Button();
            GameEditorTab = new TabPage();
            EditCustomOnlyBox = new CheckBox();
            textBox1 = new TextBox();
            label3 = new Label();
            GameBoxList = new ListBox();
            BoxRoomCachePath = new TextBox();
            button1 = new Button();
            BoxRoomPathBox = new Label();
            tabControl1.SuspendLayout();
            AutoScrapeTab.SuspendLayout();
            groupBox1.SuspendLayout();
            BasicAddTab.SuspendLayout();
            CustomGameTab.SuspendLayout();
            GameEditorTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(AutoScrapeTab);
            tabControl1.Controls.Add(BasicAddTab);
            tabControl1.Controls.Add(CustomGameTab);
            tabControl1.Controls.Add(GameEditorTab);
            tabControl1.Location = new Point(12, 63);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(454, 558);
            tabControl1.TabIndex = 0;
            // 
            // AutoScrapeTab
            // 
            AutoScrapeTab.Controls.Add(GetScreenShotsBTN);
            AutoScrapeTab.Controls.Add(groupBox1);
            AutoScrapeTab.Controls.Add(StatusProgress);
            AutoScrapeTab.Controls.Add(StatusLabel);
            AutoScrapeTab.Controls.Add(CoverGetter);
            AutoScrapeTab.Controls.Add(button4);
            AutoScrapeTab.Controls.Add(label2);
            AutoScrapeTab.Controls.Add(button3);
            AutoScrapeTab.Controls.Add(SteamCachePathBox);
            AutoScrapeTab.Location = new Point(4, 24);
            AutoScrapeTab.Name = "AutoScrapeTab";
            AutoScrapeTab.Padding = new Padding(3);
            AutoScrapeTab.Size = new Size(446, 530);
            AutoScrapeTab.TabIndex = 2;
            AutoScrapeTab.Text = "AutoScrape";
            AutoScrapeTab.UseVisualStyleBackColor = true;
            // 
            // GetScreenShotsBTN
            // 
            GetScreenShotsBTN.Location = new Point(9, 193);
            GetScreenShotsBTN.Name = "GetScreenShotsBTN";
            GetScreenShotsBTN.Size = new Size(434, 61);
            GetScreenShotsBTN.TabIndex = 12;
            GetScreenShotsBTN.Text = "Get Screenshots";
            GetScreenShotsBTN.UseVisualStyleBackColor = true;
            GetScreenShotsBTN.Click += GetScreenShotsBTN_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CUSTOMCB);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(AUDIOCB);
            groupBox1.Controls.Add(SOFTWARECB);
            groupBox1.Controls.Add(DLCCB);
            groupBox1.Controls.Add(GAMESCB);
            groupBox1.Location = new Point(9, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 75);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Owned Games  Updater/Repair";
            // 
            // CUSTOMCB
            // 
            CUSTOMCB.AutoSize = true;
            CUSTOMCB.Checked = true;
            CUSTOMCB.CheckState = CheckState.Checked;
            CUSTOMCB.Location = new Point(354, 22);
            CUSTOMCB.Name = "CUSTOMCB";
            CUSTOMCB.Size = new Size(68, 19);
            CUSTOMCB.TabIndex = 15;
            CUSTOMCB.Text = "Custom";
            CUSTOMCB.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(347, 46);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 14;
            button6.Text = "Update";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // AUDIOCB
            // 
            AUDIOCB.AutoSize = true;
            AUDIOCB.Location = new Point(209, 22);
            AUDIOCB.Name = "AUDIOCB";
            AUDIOCB.Size = new Size(58, 19);
            AUDIOCB.TabIndex = 13;
            AUDIOCB.Text = "Audio";
            AUDIOCB.UseVisualStyleBackColor = true;
            // 
            // SOFTWARECB
            // 
            SOFTWARECB.AutoSize = true;
            SOFTWARECB.Location = new Point(131, 22);
            SOFTWARECB.Name = "SOFTWARECB";
            SOFTWARECB.Size = new Size(72, 19);
            SOFTWARECB.TabIndex = 12;
            SOFTWARECB.Text = "Software";
            SOFTWARECB.UseVisualStyleBackColor = true;
            // 
            // DLCCB
            // 
            DLCCB.AutoSize = true;
            DLCCB.Location = new Point(77, 22);
            DLCCB.Name = "DLCCB";
            DLCCB.Size = new Size(48, 19);
            DLCCB.TabIndex = 11;
            DLCCB.Text = "DLC";
            DLCCB.UseVisualStyleBackColor = true;
            // 
            // GAMESCB
            // 
            GAMESCB.AutoSize = true;
            GAMESCB.Checked = true;
            GAMESCB.CheckState = CheckState.Checked;
            GAMESCB.Location = new Point(6, 22);
            GAMESCB.Name = "GAMESCB";
            GAMESCB.Size = new Size(65, 19);
            GAMESCB.TabIndex = 10;
            GAMESCB.Text = "GAMES";
            GAMESCB.UseVisualStyleBackColor = true;
            // 
            // StatusProgress
            // 
            StatusProgress.Location = new Point(10, 486);
            StatusProgress.Name = "StatusProgress";
            StatusProgress.Size = new Size(428, 23);
            StatusProgress.TabIndex = 9;
            // 
            // StatusLabel
            // 
            StatusLabel.Location = new Point(9, 512);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(431, 18);
            StatusLabel.TabIndex = 8;
            StatusLabel.Text = "StatusLabelTEXTGOESHERE";
            StatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CoverGetter
            // 
            CoverGetter.Location = new Point(6, 126);
            CoverGetter.Name = "CoverGetter";
            CoverGetter.Size = new Size(434, 61);
            CoverGetter.TabIndex = 6;
            CoverGetter.Text = "Get Covers";
            CoverGetter.UseVisualStyleBackColor = true;
            CoverGetter.Click += CoverGetter_Click;
            // 
            // button4
            // 
            button4.Location = new Point(6, 59);
            button4.Name = "button4";
            button4.Size = new Size(434, 61);
            button4.TabIndex = 5;
            button4.Text = "Fetch Game Metadata";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 12);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 4;
            label2.Text = "Steam Cache Path:";
            // 
            // button3
            // 
            button3.Location = new Point(365, 30);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Browse";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SteamCachePathBox
            // 
            SteamCachePathBox.Location = new Point(6, 30);
            SteamCachePathBox.Name = "SteamCachePathBox";
            SteamCachePathBox.Size = new Size(353, 23);
            SteamCachePathBox.TabIndex = 3;
            // 
            // BasicAddTab
            // 
            BasicAddTab.Controls.Add(richTextBox1);
            BasicAddTab.Controls.Add(button2);
            BasicAddTab.Controls.Add(label1);
            BasicAddTab.Location = new Point(4, 24);
            BasicAddTab.Name = "BasicAddTab";
            BasicAddTab.Padding = new Padding(3);
            BasicAddTab.Size = new Size(446, 530);
            BasicAddTab.TabIndex = 0;
            BasicAddTab.Text = "Basic ID Add";
            BasicAddTab.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 21);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(434, 444);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(331, 471);
            button2.Name = "button2";
            button2.Size = new Size(109, 53);
            button2.TabIndex = 1;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "New Line Per ID";
            // 
            // CustomGameTab
            // 
            CustomGameTab.Controls.Add(button8);
            CustomGameTab.Controls.Add(button5);
            CustomGameTab.Controls.Add(IGDB_Btn);
            CustomGameTab.Controls.Add(lblCustomName);
            CustomGameTab.Controls.Add(txtCustomName);
            CustomGameTab.Controls.Add(lblDeveloper);
            CustomGameTab.Controls.Add(txtDeveloper);
            CustomGameTab.Controls.Add(lblPublisher);
            CustomGameTab.Controls.Add(txtPublisher);
            CustomGameTab.Controls.Add(lblGenre);
            CustomGameTab.Controls.Add(txtGenre);
            CustomGameTab.Controls.Add(lblReleaseDate);
            CustomGameTab.Controls.Add(dtpReleaseDate);
            CustomGameTab.Controls.Add(lblShortDescription);
            CustomGameTab.Controls.Add(txtShortDescription);
            CustomGameTab.Controls.Add(lblAboutGame);
            CustomGameTab.Controls.Add(rtbAboutGame);
            CustomGameTab.Controls.Add(btnCreateCustom);
            CustomGameTab.Location = new Point(4, 24);
            CustomGameTab.Name = "CustomGameTab";
            CustomGameTab.Size = new Size(446, 530);
            CustomGameTab.TabIndex = 1;
            CustomGameTab.Text = "Custom Game";
            // 
            // button8
            // 
            button8.Location = new Point(234, 502);
            button8.Name = "button8";
            button8.Size = new Size(96, 25);
            button8.TabIndex = 20;
            button8.Text = "Preview Game";
            // 
            // button5
            // 
            button5.Location = new Point(113, 502);
            button5.Name = "button5";
            button5.Size = new Size(103, 25);
            button5.TabIndex = 19;
            button5.Text = "Launch Settings";
            // 
            // IGDB_Btn
            // 
            IGDB_Btn.Enabled = false;
            IGDB_Btn.Location = new Point(6, 502);
            IGDB_Btn.Name = "IGDB_Btn";
            IGDB_Btn.Size = new Size(100, 25);
            IGDB_Btn.TabIndex = 18;
            IGDB_Btn.Text = "Search IGDB";
            IGDB_Btn.Click += IGDB_Btn_Click;
            // 
            // lblCustomName
            // 
            lblCustomName.Location = new Point(6, 10);
            lblCustomName.Name = "lblCustomName";
            lblCustomName.Size = new Size(80, 15);
            lblCustomName.TabIndex = 0;
            lblCustomName.Text = "Name";
            // 
            // txtCustomName
            // 
            txtCustomName.Location = new Point(6, 28);
            txtCustomName.Name = "txtCustomName";
            txtCustomName.Size = new Size(434, 23);
            txtCustomName.TabIndex = 1;
            txtCustomName.TextChanged += txtCustomName_TextChanged;
            // 
            // lblDeveloper
            // 
            lblDeveloper.Location = new Point(6, 58);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(100, 15);
            lblDeveloper.TabIndex = 2;
            lblDeveloper.Text = "Developer";
            // 
            // txtDeveloper
            // 
            txtDeveloper.Location = new Point(6, 76);
            txtDeveloper.Name = "txtDeveloper";
            txtDeveloper.Size = new Size(210, 23);
            txtDeveloper.TabIndex = 3;
            // 
            // lblPublisher
            // 
            lblPublisher.Location = new Point(230, 58);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(100, 15);
            lblPublisher.TabIndex = 4;
            lblPublisher.Text = "Publisher";
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(230, 76);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(210, 23);
            txtPublisher.TabIndex = 5;
            // 
            // lblGenre
            // 
            lblGenre.Location = new Point(6, 106);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(100, 15);
            lblGenre.TabIndex = 6;
            lblGenre.Text = "Genre";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(6, 124);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(210, 23);
            txtGenre.TabIndex = 7;
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.Location = new Point(230, 106);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(100, 15);
            lblReleaseDate.TabIndex = 8;
            lblReleaseDate.Text = "Release Date";
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(230, 124);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(210, 23);
            dtpReleaseDate.TabIndex = 9;
            // 
            // lblShortDescription
            // 
            lblShortDescription.Location = new Point(6, 150);
            lblShortDescription.Name = "lblShortDescription";
            lblShortDescription.Size = new Size(100, 15);
            lblShortDescription.TabIndex = 12;
            lblShortDescription.Text = "Short Description";
            // 
            // txtShortDescription
            // 
            txtShortDescription.Location = new Point(6, 168);
            txtShortDescription.Name = "txtShortDescription";
            txtShortDescription.Size = new Size(434, 23);
            txtShortDescription.TabIndex = 13;
            // 
            // lblAboutGame
            // 
            lblAboutGame.Location = new Point(6, 194);
            lblAboutGame.Name = "lblAboutGame";
            lblAboutGame.Size = new Size(100, 15);
            lblAboutGame.TabIndex = 14;
            lblAboutGame.Text = "About The Game";
            // 
            // rtbAboutGame
            // 
            rtbAboutGame.Location = new Point(6, 212);
            rtbAboutGame.Name = "rtbAboutGame";
            rtbAboutGame.Size = new Size(434, 284);
            rtbAboutGame.TabIndex = 15;
            rtbAboutGame.Text = "";
            // 
            // btnCreateCustom
            // 
            btnCreateCustom.Enabled = false;
            btnCreateCustom.Location = new Point(360, 502);
            btnCreateCustom.Name = "btnCreateCustom";
            btnCreateCustom.Size = new Size(80, 25);
            btnCreateCustom.TabIndex = 16;
            btnCreateCustom.Text = "Create Entry";
            btnCreateCustom.Click += btnCreateCustom_Click;
            // 
            // GameEditorTab
            // 
            GameEditorTab.Controls.Add(EditCustomOnlyBox);
            GameEditorTab.Controls.Add(textBox1);
            GameEditorTab.Controls.Add(label3);
            GameEditorTab.Controls.Add(GameBoxList);
            GameEditorTab.Location = new Point(4, 24);
            GameEditorTab.Name = "GameEditorTab";
            GameEditorTab.Padding = new Padding(3);
            GameEditorTab.Size = new Size(446, 530);
            GameEditorTab.TabIndex = 3;
            GameEditorTab.Text = "Edit Game";
            GameEditorTab.UseVisualStyleBackColor = true;
            // 
            // EditCustomOnlyBox
            // 
            EditCustomOnlyBox.AutoSize = true;
            EditCustomOnlyBox.Checked = true;
            EditCustomOnlyBox.CheckState = CheckState.Checked;
            EditCustomOnlyBox.Location = new Point(344, 9);
            EditCustomOnlyBox.Name = "EditCustomOnlyBox";
            EditCustomOnlyBox.Size = new Size(96, 19);
            EditCustomOnlyBox.TabIndex = 3;
            EditCustomOnlyBox.Text = "Custom Only";
            EditCustomOnlyBox.UseVisualStyleBackColor = true;
            EditCustomOnlyBox.CheckedChanged += EditCustomOnlyBox_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 6);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Game Name...";
            textBox1.Size = new Size(262, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 10);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 1;
            label3.Text = "Search:";
            // 
            // GameBoxList
            // 
            GameBoxList.FormattingEnabled = true;
            GameBoxList.Location = new Point(6, 36);
            GameBoxList.Name = "GameBoxList";
            GameBoxList.Size = new Size(434, 484);
            GameBoxList.TabIndex = 0;
            // 
            // BoxRoomCachePath
            // 
            BoxRoomCachePath.Location = new Point(12, 34);
            BoxRoomCachePath.Name = "BoxRoomCachePath";
            BoxRoomCachePath.Size = new Size(373, 23);
            BoxRoomCachePath.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(391, 34);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BoxRoomPathBox
            // 
            BoxRoomPathBox.AutoSize = true;
            BoxRoomPathBox.Location = new Point(12, 9);
            BoxRoomPathBox.Name = "BoxRoomPathBox";
            BoxRoomPathBox.Size = new Size(88, 15);
            BoxRoomPathBox.TabIndex = 3;
            BoxRoomPathBox.Text = "BoxRoom Path:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 633);
            Controls.Add(BoxRoomPathBox);
            Controls.Add(button1);
            Controls.Add(BoxRoomCachePath);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            AutoScrapeTab.ResumeLayout(false);
            AutoScrapeTab.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            BasicAddTab.ResumeLayout(false);
            BasicAddTab.PerformLayout();
            CustomGameTab.ResumeLayout(false);
            CustomGameTab.PerformLayout();
            GameEditorTab.ResumeLayout(false);
            GameEditorTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage BasicAddTab;
        private TabPage CustomGameTab;
        private TextBox BoxRoomCachePath;
        private Button button1;
        private RichTextBox richTextBox1;
        private Button button2;
        private Label label1;
        private TabPage AutoScrapeTab;
        private Button button3;
        private TextBox SteamCachePathBox;
        private Label BoxRoomPathBox;
        private Label label2;
        private Button button4;
        private Button CoverGetter;
        private ProgressBar StatusProgress;
        private Label StatusLabel;
        private Button IGDB_Btn;
        private GroupBox groupBox1;
        private Button button6;
        private CheckBox AUDIOCB;
        private CheckBox SOFTWARECB;
        private CheckBox DLCCB;
        private CheckBox GAMESCB;
        private Button GetScreenShotsBTN;
        private CheckBox CUSTOMCB;
        private Button button5;
        private TabPage GameEditorTab;
        private Button button8;
        private ListBox GameBoxList;
        private TextBox textBox1;
        private Label label3;
        private CheckBox EditCustomOnlyBox;
    }
}
