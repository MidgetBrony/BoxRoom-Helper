using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BoxRoom_Helper
{
    class GameEntry
    {
        public string AppId { get; set; }
        public string Name { get; set; }

        public override string ToString()
            => Name;
    }

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

    public class GameResult
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        public override string ToString() => Name;
    }

    public class IGDBGame
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("summary")]
        public string Summary { get; set; } = "";

        [JsonPropertyName("first_release_date")]
        public long FirstReleaseDate { get; set; }

        [JsonPropertyName("platforms")]
        public List<IGDBPlatform> Platforms { get; set; } = new();

        [JsonPropertyName("involved_companies")]
        public List<IGDBCompanyLink> InvolvedCompanies { get; set; } = new();

        [JsonPropertyName("genres")]
        public List<IGDBGenre> Genres { get; set; } = new();

        [JsonPropertyName("screenshots")]
        public List<IGDBScreenshot> Screenshots { get; set; } = new();

        [JsonPropertyName("cover")]
        public IGDBCover? Cover { get; set; }
    }


    public class IGDBPlatform
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";
    }

    public class IGDBGenre
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";
    }

    public class IGDBCompanyLink
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("developer")]
        public bool Developer { get; set; }

        [JsonPropertyName("publisher")]
        public bool Publisher { get; set; }

        [JsonPropertyName("company")]
        public IGDBCompany Company { get; set; } = new();
    }

    public class IGDBCompany
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";
    }

    public class IGDBScreenshot
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("image_id")]
        public string ImageId { get; set; } = "";
    }

    public class IGDBCover
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("image_id")]
        public string ImageId { get; set; } = "";
    }
    public class TwitchTokenResponse
    {
        public string access_token { get; set; } = "";
        public int expires_in { get; set; }
        public string token_type { get; set; } = "";
    }
}
