using System.Diagnostics;
using System.Text.Json;

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

            this.Text = $"BoxRoom Helper (ALPHA) v{Application.ProductVersion}";

            GameBoxListUpdate();

            GameBoxList.Enabled = false;
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

        private async Task GameBoxListUpdate(string search = "")
        {
            try
            {
                GameBoxList.BeginUpdate();
                GameBoxList.Items.Clear();
                GameBoxList.Sorted = false;
                GameBoxList.Enabled = false;

                foreach (string dir in Directory.EnumerateDirectories(BoxRoomCachePath.Text))
                {
                    string helperPath = Path.Combine(dir, "meta.helper.json");
                    string metaPath = Path.Combine(dir, "meta.json");

                    // Must have metadata
                    if (!File.Exists(metaPath))
                        continue;

                    // Filter Custom titles
                    if (EditCustomOnlyBox.Checked)
                    {
                        if (!File.Exists(helperPath))
                            continue;

                        MetaHelper? helper =
                            JsonSerializer.Deserialize<MetaHelper>(
                                await File.ReadAllTextAsync(helperPath));

                        if (helper == null || helper.Type != "Custom")
                            continue;
                    }

                    SteamMeta? game =
                        JsonSerializer.Deserialize<SteamMeta>(
                            await File.ReadAllTextAsync(metaPath));

                    if (search != "" && (game == null || !game.Name.ToLower().Contains(search.ToLower())))
                        continue;

                    GameBoxList.Items.Add(new GameEntry
                    {
                        AppId = Path.GetFileName(dir),
                        Name = game.Name
                    });
                }

                GameBoxList.Sorted = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error updating game list: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                GameBoxList.EndUpdate();
                GameBoxList.Enabled = true;
            }
        }

        private void EditCustomOnlyBox_CheckedChanged(object sender, EventArgs e)
        {
            GameBoxListUpdate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GameBoxListUpdate(textBox1.Text);
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            await fetcher.RebuildOwnedGamesAsync(
                BoxRoomCachePath.Text,
                GAMESCB.Checked,
                DLCCB.Checked,
                SOFTWARECB.Checked,
                AUDIOCB.Checked,
                CUSTOMCB.Checked);

            MessageBox.Show(
                "owned_games.json updated.",
                "Done",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        private async void GetScreenShotsBTN_Click(object sender, EventArgs e)
        {
            await fetcher.DownloadScreenshotsAsync(BoxRoomCachePath.Text);
        }

        private void txtCustomName_TextChanged(object sender, EventArgs e)
        {
                btnCreateCustom.Enabled = true;
                IGDB_Btn.Enabled = true;
        }

        private void IGDB_Btn_Click(object sender, EventArgs e)
        {
            using var lookup = new IGDB_Lookup(txtCustomName.Text);

            if (lookup.ShowDialog() != DialogResult.OK)
                return;

            if (lookup.SelectedGame == null)
                return;

            var game = lookup.SelectedGame;

            txtCustomName.Text = game.Name;
            txtShortDescription.Text = game.Summary;
            rtbAboutGame.Text = game.Summary;

            if (game.FirstReleaseDate != 0)
            {
                dtpReleaseDate.Value =
                    DateTimeOffset
                        .FromUnixTimeSeconds(game.FirstReleaseDate)
                        .DateTime;
            }

            txtGenre.Text = string.Join(", ",
                game.Genres.Select(x => x.Name));

            txtDeveloper.Text = string.Join(", ",
                game.InvolvedCompanies
                    .Where(x => x.Developer)
                    .Select(x => x.Company.Name));

            txtPublisher.Text = string.Join(", ",
                game.InvolvedCompanies
                    .Where(x => x.Publisher)
                    .Select(x => x.Company.Name));
        }
    }
}
