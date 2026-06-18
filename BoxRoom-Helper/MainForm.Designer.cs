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
            StatusProgress = new ProgressBar();
            StatusLabel = new Label();
            button5 = new Button();
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
            BoxRoomCachePath = new TextBox();
            button1 = new Button();
            BoxRoomPathBox = new Label();
            tabControl1.SuspendLayout();
            AutoScrapeTab.SuspendLayout();
            BasicAddTab.SuspendLayout();
            CustomGameTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(AutoScrapeTab);
            tabControl1.Controls.Add(BasicAddTab);
            tabControl1.Controls.Add(CustomGameTab);
            tabControl1.Location = new Point(12, 63);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(454, 489);
            tabControl1.TabIndex = 0;
            // 
            // AutoScrapeTab
            // 
            AutoScrapeTab.Controls.Add(StatusProgress);
            AutoScrapeTab.Controls.Add(StatusLabel);
            AutoScrapeTab.Controls.Add(button5);
            AutoScrapeTab.Controls.Add(CoverGetter);
            AutoScrapeTab.Controls.Add(button4);
            AutoScrapeTab.Controls.Add(label2);
            AutoScrapeTab.Controls.Add(button3);
            AutoScrapeTab.Controls.Add(SteamCachePathBox);
            AutoScrapeTab.Location = new Point(4, 24);
            AutoScrapeTab.Name = "AutoScrapeTab";
            AutoScrapeTab.Padding = new Padding(3);
            AutoScrapeTab.Size = new Size(446, 461);
            AutoScrapeTab.TabIndex = 2;
            AutoScrapeTab.Text = "AutoScrape";
            AutoScrapeTab.UseVisualStyleBackColor = true;
            // 
            // StatusProgress
            // 
            StatusProgress.Location = new Point(12, 417);
            StatusProgress.Name = "StatusProgress";
            StatusProgress.Size = new Size(428, 23);
            StatusProgress.TabIndex = 9;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(143, 443);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(150, 15);
            StatusLabel.TabIndex = 8;
            StatusLabel.Text = "StatusLabelTEXTGOESHERE";
            // 
            // button5
            // 
            button5.Location = new Point(6, 193);
            button5.Name = "button5";
            button5.Size = new Size(434, 61);
            button5.TabIndex = 7;
            button5.Text = "Get Remote Covers";
            button5.UseVisualStyleBackColor = true;
            // 
            // CoverGetter
            // 
            CoverGetter.Location = new Point(6, 126);
            CoverGetter.Name = "CoverGetter";
            CoverGetter.Size = new Size(434, 61);
            CoverGetter.TabIndex = 6;
            CoverGetter.Text = "Get Local Covers";
            CoverGetter.UseVisualStyleBackColor = true;
            CoverGetter.Click += CoverGetter_Click;
            // 
            // button4
            // 
            button4.Location = new Point(6, 59);
            button4.Name = "button4";
            button4.Size = new Size(434, 61);
            button4.TabIndex = 5;
            button4.Text = "Basic Scrape";
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
            BasicAddTab.Size = new Size(446, 461);
            BasicAddTab.TabIndex = 0;
            BasicAddTab.Text = "Basic ID Add";
            BasicAddTab.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 21);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(434, 405);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(365, 432);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
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
            CustomGameTab.Size = new Size(446, 461);
            CustomGameTab.TabIndex = 1;
            CustomGameTab.Text = "Custom Game";
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
            lblShortDescription.Location = new Point(6, 202);
            lblShortDescription.Name = "lblShortDescription";
            lblShortDescription.Size = new Size(100, 15);
            lblShortDescription.TabIndex = 12;
            lblShortDescription.Text = "Short Description";
            // 
            // txtShortDescription
            // 
            txtShortDescription.Location = new Point(6, 220);
            txtShortDescription.Name = "txtShortDescription";
            txtShortDescription.Size = new Size(434, 23);
            txtShortDescription.TabIndex = 13;
            // 
            // lblAboutGame
            // 
            lblAboutGame.Location = new Point(6, 250);
            lblAboutGame.Name = "lblAboutGame";
            lblAboutGame.Size = new Size(100, 15);
            lblAboutGame.TabIndex = 14;
            lblAboutGame.Text = "About The Game";
            // 
            // rtbAboutGame
            // 
            rtbAboutGame.Location = new Point(6, 268);
            rtbAboutGame.Name = "rtbAboutGame";
            rtbAboutGame.Size = new Size(434, 150);
            rtbAboutGame.TabIndex = 15;
            rtbAboutGame.Text = "";
            // 
            // btnCreateCustom
            // 
            btnCreateCustom.Location = new Point(320, 430);
            btnCreateCustom.Name = "btnCreateCustom";
            btnCreateCustom.Size = new Size(120, 25);
            btnCreateCustom.TabIndex = 16;
            btnCreateCustom.Text = "Create Entry";
            btnCreateCustom.Click += btnCreateCustom_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 564);
            Controls.Add(BoxRoomPathBox);
            Controls.Add(button1);
            Controls.Add(BoxRoomCachePath);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            AutoScrapeTab.ResumeLayout(false);
            AutoScrapeTab.PerformLayout();
            BasicAddTab.ResumeLayout(false);
            BasicAddTab.PerformLayout();
            CustomGameTab.ResumeLayout(false);
            CustomGameTab.PerformLayout();
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
        private Button button5;
        private Button CoverGetter;
        private ProgressBar StatusProgress;
        private Label StatusLabel;
    }
}
