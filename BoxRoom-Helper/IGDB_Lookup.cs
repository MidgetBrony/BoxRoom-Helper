using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace BoxRoom_Helper
{
    public partial class IGDB_Lookup : Form
    {
        public IGDBGame? SelectedGame { get; private set; }

        private IGDBGame? _currentGame;

        private readonly string _searchText;
        public IGDB_Lookup(string text)
        {
            InitializeComponent();
            _searchText = text;

            SearchIGDB(_searchText);
        }
        public static async Task<string> GetAccessTokenAsync()
        {
            using HttpClient client = new();

            string url =
                $"https://id.twitch.tv/oauth2/token" +
                $"?client_id={Helper.Default.IDGB_CLIENT_ID}" +
                $"&client_secret={Helper.Default.IDGB_API_KEY}" +
                $"&grant_type=client_credentials";

            var response = await client.PostAsync(url, null);

            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            var token =
                JsonSerializer.Deserialize<TwitchTokenResponse>(json);

            Helper.Default.TOKEN = token?.access_token ?? "";
            Helper.Default.EXPIRES_IN = token?.expires_in ?? 0;
            Helper.Default.Save();

            return Helper.Default.TOKEN;
        }
        private async void SearchIGDB(string text)
        {
            if (string.IsNullOrWhiteSpace(Helper.Default.TOKEN))
            {
                await GetAccessTokenAsync();
            }

            string query = $"""
        search "{text}";
        fields id,name;
        limit 50;
        """;

            using HttpClient client = new();

            client.DefaultRequestHeaders.Add(
                "Client-ID",
                Helper.Default.IDGB_CLIENT_ID);

            client.DefaultRequestHeaders.Add(
                "Authorization",
                $"Bearer {Helper.Default.TOKEN}");

            StringContent content =
                new(query, Encoding.UTF8, "text/plain");

            HttpResponseMessage response =
                await client.PostAsync(
                    "https://api.igdb.com/v4/games",
                    content);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(await response.Content.ReadAsStringAsync());
                return;
            }

            string json =
                await response.Content.ReadAsStringAsync();

            var games =
                JsonSerializer.Deserialize<List<GameResult>>(json);

            GameListBox.Items.Clear();

            if (games == null)
                return;

            foreach (var game in games)
            {
                GameListBox.Items.Add(game);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnUseSelected_Click(object sender, EventArgs e)
        {
            if (_currentGame == null)
                return;

            SelectedGame = _currentGame;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private async void GameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GameListBox.SelectedItem is not GameResult game)
                return;

            IGDBGame? result = await LoadGameDetails(game.Id);

            if (result == null)
                return;

            _currentGame = result; // <-- missing line

            txtPreview.Text =
        $"""
Console:
{string.Join(", ", result.Platforms.Select(p => p.Name))}

Name:
{result.Name}

Summary:
{result.Summary}
""";
        }

        private async Task<IGDBGame?> LoadGameDetails(int id)
        {
            string query = $"""
fields
name,
summary,
first_release_date,
involved_companies.company.name,
involved_companies.developer,
involved_companies.publisher,
genres.name,
platforms.name,
screenshots.image_id,
cover.image_id;

where id = {id};
""";

            using HttpClient client = new();

            client.DefaultRequestHeaders.Add("Client-ID", Helper.Default.IDGB_CLIENT_ID);
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Helper.Default.TOKEN}");

            var content = new StringContent(query, Encoding.UTF8, "text/plain");

            HttpResponseMessage response =
                await client.PostAsync("https://api.igdb.com/v4/games", content);

            if (!response.IsSuccessStatusCode)
                return null;

            string json = await response.Content.ReadAsStringAsync();

            var games = JsonSerializer.Deserialize<List<IGDBGame>>(json);

            return games?.FirstOrDefault();
        }
    }
}
