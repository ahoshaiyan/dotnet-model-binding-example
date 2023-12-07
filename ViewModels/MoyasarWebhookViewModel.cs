using System;
using System.Text.Json.Serialization;

namespace JsonTest.ViewModels;

public class MoyasarWebhookViewModel {
    public string Id { get; set; }
    public string Type { get; set; }

    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; }

    [JsonPropertyName("secret_token")]
    public string SecretToken { get; set; }

    [JsonPropertyName("account_name")]
    public string AccountName { get; set; }

    public bool Live { get; set; }

    // Data is left out
}
