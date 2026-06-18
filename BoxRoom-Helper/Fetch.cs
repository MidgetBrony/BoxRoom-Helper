using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

public class SteamMeta
{
    public int PlayTimeMinutes { get; set; }
    public string Name { get; set; } = "";
    public string ShortDescription { get; set; } = "";
    public string Type { get; set; } = "";
    public string DetailedDescription { get; set; } = "";
    public string AboutTheGame { get; set; } = "";
    public string BoxArtUrlBase { get; set; } = "";
    public string FallbackHeaderUrl { get; set; } = "";
    public string ReleaseDate { get; set; } = "";
    public List<string> Developers { get; set; } = new();
    public List<string> Publishers { get; set; } = new();
    public List<string> Genres { get; set; } = new();
    public List<string> ScreenshotUrls { get; set; } = new();
}
public class MetaHelper
{
    public string Type { get; set; } = "";
}

public class Fetcher
{
    public event Action<int, int, string>? ProgressChanged;

    private readonly HttpClient _client = new();

    private async Task WriteMetaAsync(string folder, SteamMeta meta)
    {
        Directory.CreateDirectory(folder);

        await File.WriteAllTextAsync(
            Path.Combine(folder, "meta.json"),
            JsonSerializer.Serialize(
                meta,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }));
    }

    public async Task<SteamMeta?> GetSteamData(int steamId)
    {
        string steamUrl =
            $"https://store.steampowered.com/api/appdetails?appids={steamId}";

        while (true)
        {
            HttpResponseMessage response = await _client.GetAsync(steamUrl);

            // Steam is telling us to slow down.
            if (response.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
            {
                TimeSpan waitTime =
                    response.Headers.RetryAfter?.Delta
                    ?? TimeSpan.FromMinutes(1);

                ProgressChanged?.Invoke(
                    0,
                    0,
                    $"Steam rate limit reached. Waiting {waitTime.TotalSeconds:0} seconds...");

                await Task.Delay(waitTime);
                continue;
            }

            // Throw for anything else (404, 500, etc.)
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            JsonNode? root = JsonNode.Parse(json);

            if (root?[steamId.ToString()]?["success"]?.GetValue<bool>() != true)
                return null;

            JsonNode gameData = root[steamId.ToString()]!["data"]!;

            return new SteamMeta
            {
                PlayTimeMinutes = 0,
                Name = gameData["name"]?.ToString() ?? "",
                Type = gameData["type"]?.ToString() ?? "",
                ShortDescription = gameData["short_description"]?.ToString() ?? "",
                DetailedDescription = gameData["detailed_description"]?.ToString() ?? "",
                AboutTheGame = gameData["about_the_game"]?.ToString() ?? "",
                BoxArtUrlBase = $"https://cdn.cloudflare.steamstatic.com/steam/apps/{steamId}/",
                FallbackHeaderUrl = gameData["header_image"]?.ToString() ?? "",
                ReleaseDate = gameData["release_date"]?["date"]?.ToString() ?? "",

                Developers = gameData["developers"]?
                    .AsArray()
                    .Select(x => x?.ToString() ?? "")
                    .ToList() ?? new(),

                Publishers = gameData["publishers"]?
                    .AsArray()
                    .Select(x => x?.ToString() ?? "")
                    .ToList() ?? new(),

                Genres = gameData["genres"]?
                    .AsArray()
                    .Select(x => x?["description"]?.ToString() ?? "")
                    .Where(x => !string.IsNullOrWhiteSpace(x))
                    .ToList() ?? new(),

                ScreenshotUrls = gameData["screenshots"]?
                    .AsArray()
                    .Select(x => x?["path_full"]?.ToString() ?? "")
                    .Where(x => !string.IsNullOrWhiteSpace(x))
                    .ToList() ?? new()
            };
        }
    }
    public async Task UpdateOwnedGamesAsync(
    string baseDir,
    IEnumerable<int> appIdsToAdd)
    {
        string ownedGamesPath =
            Path.Combine(baseDir, "owned_games.json");

        JsonObject ownedData;

        if (File.Exists(ownedGamesPath))
        {
            string existingJson =
                await File.ReadAllTextAsync(ownedGamesPath);

            ownedData =
                JsonNode.Parse(existingJson)?.AsObject()
                ?? new JsonObject();
        }
        else
        {
            ownedData = new JsonObject();
        }

        JsonArray appIds;

        if (ownedData["AppIds"] is JsonArray existingArray)
        {
            appIds = existingArray;
        }
        else
        {
            appIds = new JsonArray();
            ownedData["AppIds"] = appIds;
        }

        HashSet<int> existingIds =
            appIds
                .Select(x => x?.GetValue<int>() ?? 0)
                .ToHashSet();

        foreach (int id in appIdsToAdd)
        {
            if (!existingIds.Contains(id))
            {
                appIds.Add(id);
                existingIds.Add(id);
            }
        }

        await File.WriteAllTextAsync(
            ownedGamesPath,
            ownedData.ToJsonString(
                new JsonSerializerOptions
                {
                    WriteIndented = false
                }));
    }
    private async Task WriteMetaHelperAsync(
    string folder,
    SteamMeta meta)
    {
        Directory.CreateDirectory(folder);

        MetaHelper helper = new()
        {
            Type = meta.Type
        };

        await File.WriteAllTextAsync(
            Path.Combine(folder, "meta.helper.json"),
            JsonSerializer.Serialize(
                helper,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }));
    }
    public async Task CreateCustomGameAsync(
        string name,
        string shortDescription,
        string detailedDescription,
        string aboutTheGame,
        string releaseDate,
        string developer,
        string publisher,
        string genre,
        string headerUrl,
        string baseDir
        )
    {
        Directory.CreateDirectory(baseDir);

        string ownedGamesPath =
            Path.Combine(baseDir, "owned_games.json");

        int customAppId = 900000000;

        JsonObject ownedData;

        if (File.Exists(ownedGamesPath))
        {
            ownedData = JsonNode.Parse(
                await File.ReadAllTextAsync(ownedGamesPath))
                ?.AsObject() ?? new JsonObject();
        }
        else
        {
            ownedData = new JsonObject();
        }

        JsonArray appIds;

        if (ownedData["AppIds"] is JsonArray existing)
        {
            appIds = existing;
        }
        else
        {
            appIds = new JsonArray();
            ownedData["AppIds"] = appIds;
        }

        HashSet<int> existingIds =
            appIds.Select(x => x?.GetValue<int>() ?? 0)
                  .ToHashSet();

        while (existingIds.Contains(customAppId))
        {
            customAppId++;
        }

        SteamMeta meta = new()
        {
            PlayTimeMinutes = 0,
            Name = name,
            Type = "Custom",
            ShortDescription = shortDescription,
            DetailedDescription = detailedDescription,
            AboutTheGame = aboutTheGame,
            BoxArtUrlBase = "",
            FallbackHeaderUrl = headerUrl,
            ReleaseDate = releaseDate,
            Developers = new() { developer },
            Publishers = new() { publisher },
            Genres = new() { genre },
            ScreenshotUrls = new()
        };


        string gameFolder =
            Path.Combine(baseDir, customAppId.ToString());

        Directory.CreateDirectory(gameFolder);

        await WriteMetaAsync(baseDir, meta);
        await WriteMetaHelperAsync(baseDir, meta);

        appIds.Add(customAppId);

        await File.WriteAllTextAsync(
            ownedGamesPath,
            ownedData.ToJsonString());

        MessageBox.Show(
            $"Custom title created.\nAppID: {customAppId}",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    internal async Task BasicFetch(string sourceFolder, string targetFolder)
    {
        if (!Directory.Exists(sourceFolder))
        {
            MessageBox.Show("Source folder does not exist.");
            return;
        }

        Directory.CreateDirectory(targetFolder);

        List<int> appIds = new();

        foreach (string dir in Directory.GetDirectories(sourceFolder))
        {
            string folderName = Path.GetFileName(dir);

            Directory.CreateDirectory(Path.Combine(targetFolder, folderName));

            if (int.TryParse(folderName, out int appId))
            {
                appIds.Add(appId);
            }
        }

        if (appIds.Count == 0)
        {
            MessageBox.Show("No Steam AppID folders found.");
            return;
        }

        await ScrapeGamesAsync(string.Join(Environment.NewLine, appIds), targetFolder);
    }
    public async Task ScrapeGamesAsync(string inputText, string targetFolder)
    {
        string[] lines = inputText.Split(
            new[] { Environment.NewLine },
            StringSplitOptions.RemoveEmptyEntries);

        int total = lines.Length;
        int current = 0;

        int downloaded = 0;
        int skipped = 0;
        int failed = 0;

        List<int> successfulIds = new();

        foreach (string line in lines)
        {
            current++;

            if (!int.TryParse(line.Trim(), out int appId))
            {
                failed++;

                ProgressChanged?.Invoke(
                    current,
                    total,
                    $"Invalid AppID: {line}");

                continue;
            }

            string targetDir = Path.Combine(
                targetFolder,
                appId.ToString());

            string metaPath = Path.Combine(
                targetDir,
                "meta.json");

            // Already scraped
            if (File.Exists(metaPath))
            {
                skipped++;

                ProgressChanged?.Invoke(
                    current,
                    total,
                    $"Skipping {appId} (already exists)");

                continue;
            }

            ProgressChanged?.Invoke(
                current,
                total,
                $"Fetching {appId}...");

            SteamMeta? meta = await GetSteamData(appId);

            if (meta == null)
            {
                failed++;

                ProgressChanged?.Invoke(
                    current,
                    total,
                    $"Failed {appId}");

                continue;
            }
            await WriteMetaAsync(targetDir, meta);
            await WriteMetaHelperAsync(targetDir, meta);

            downloaded++;
            successfulIds.Add(appId);

            ProgressChanged?.Invoke(
                current,
                total,
                $"Saved {meta.Name}");

            // Be nice to Steam
            await Task.Delay(Random.Shared.Next(200, 500));
        }

        if (successfulIds.Count > 0)
        {
            ProgressChanged?.Invoke(
                total,
                total,
                "Updating owned_games.json...");

            await UpdateOwnedGamesAsync(
                targetFolder,
                successfulIds);
        }

        ProgressChanged?.Invoke(
            total,
            total,
            $"Done! Downloaded: {downloaded}  Skipped: {skipped}  Failed: {failed}");
    }


    public async Task UpdateBoxArtAsync(
    string steamCachePath,
    string boxRoomCachePath)
    {
        if (!Directory.Exists(steamCachePath))
        {
            MessageBox.Show("Steam cache folder not found.");
            return;
        }

        if (!Directory.Exists(boxRoomCachePath))
        {
            MessageBox.Show("BOXROOM cache folder not found.");
            return;
        }

        int copied = 0;
        int skipped = 0;
        int missing = 0;

        foreach (string gameFolder in Directory.GetDirectories(boxRoomCachePath))
        {
            string appId = Path.GetFileName(gameFolder);

            string boxArt =
                Path.Combine(gameFolder, "boxart.jpg");

            // Already has artwork
            if (File.Exists(boxArt))
            {
                skipped++;
                continue;
            }

            string steamFolder =
                Path.Combine(steamCachePath, appId);

            if (!Directory.Exists(steamFolder))
            {
                missing++;
                continue;
            }

            string? cover = Directory
                .EnumerateFiles(
                    steamFolder,
                    "library_600x900.jpg",
                    SearchOption.AllDirectories)
                .FirstOrDefault();

            if (cover == null)
            {
                missing++;
                continue;
            }

            File.Copy(cover, boxArt);

            copied++;
        }

        MessageBox.Show(
            $"Copied : {copied}\n" +
            $"Skipped: {skipped}\n" +
            $"Missing: {missing}",
            "Artwork Update Complete",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }
}