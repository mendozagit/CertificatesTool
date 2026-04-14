using System.Text.Json;
using System.Text.Json.Serialization;

using CertificatesTool.Models;

namespace CertificatesTool.Services
{
    internal sealed class CredentialRepository
    {
        private const string FileName = "credentials.json";

        private static readonly JsonSerializerOptions JsonOptions = new()
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Converters = { new JsonStringEnumConverter() }
        };

        public List<Credential> LoadAll()
        {
            if (!File.Exists(FileName))
                return new List<Credential>();

            try
            {
                var json = File.ReadAllText(FileName);
                return JsonSerializer.Deserialize<List<Credential>>(json, JsonOptions)
                       ?? new List<Credential>();
            }
            catch (JsonException)
            {
                var backup = $"{FileName}.corrupt-{DateTime.UtcNow:yyyyMMddHHmmss}";
                File.Move(FileName, backup, overwrite: true);
                return new List<Credential>();
            }
        }

        public void SaveAll(IEnumerable<Credential> credentials)
        {
            var temp = FileName + ".tmp";
            var json = JsonSerializer.Serialize(credentials, JsonOptions);
            File.WriteAllText(temp, json);
            File.Move(temp, FileName, overwrite: true);
        }
    }
}
