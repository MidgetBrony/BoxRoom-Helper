namespace BoxRoom_Helper
{
    public partial class MainForm : Form
    {
        string cachePath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
    "..",
    "LocalLow",
    "NestedLoop",
    "BOXROOM",
    "steam_cache_v2"
);

        string SteamCachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Steam", "AppCache", "LibraryCache");

        public Fetcher fetcher = new Fetcher();
        public MainForm()
        {
            InitializeComponent();

            BoxRoomCachePath.Text = cachePath;
            SteamCachePathBox.Text = SteamCachePath;
            StatusLabel.Text = "";
            StatusProgress.Visible = false;

            fetcher.ProgressChanged += Fetcher_ProgressChanged;

            this.Text = $"BoxRoom Helper v{Application.ProductVersion}";

            tabControl1.TabPages.Remove(AutoScrapeTab);
        }

        private void Fetcher_ProgressChanged(
            int current,
            int total,
            string status)
        {
            if (InvokeRequired)
            {
                Invoke(() => Fetcher_ProgressChanged(current, total, status));
                return;
            }

            StatusProgress.Visible = true;
            StatusProgress.Maximum = total;
            StatusProgress.Value = current;

            StatusLabel.Text = status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            if (!string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
            {
                BoxRoomCachePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await fetcher.ScrapeGamesAsync(richTextBox1.Text, BoxRoomCachePath.Text);
        }

        private async void btnCreateCustom_Click(object sender, EventArgs e)
        {
            await fetcher.CreateCustomGameAsync(
                txtCustomName.Text,
                txtShortDescription.Text,
                rtbAboutGame.Text,
                rtbAboutGame.Text,
                dtpReleaseDate.Value.ToString("MMM d, yyyy"),
                txtDeveloper.Text,
                txtPublisher.Text,
                txtGenre.Text,
                BoxRoomCachePath.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await fetcher.BasicFetch(SteamCachePathBox.Text, BoxRoomCachePath.Text);
        }

        private async void CoverGetter_Click(object sender, EventArgs e)
        {
            await fetcher.UpdateBoxArtAsync(SteamCachePathBox.Text, BoxRoomCachePath.Text);
        }
    }
}
