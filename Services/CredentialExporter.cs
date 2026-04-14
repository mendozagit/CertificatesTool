using CertificatesTool.Models;

namespace CertificatesTool.Services
{
    internal sealed class CredentialExporter
    {
        public string ExportCertificate(Credential credential, string directory)
        {
            var path = Path.Combine(directory, $"{credential.Rfc}.cer");
            File.WriteAllBytes(path, Convert.FromBase64String(credential.CertificateBase64));
            return path;
        }

        public string ExportPrivateKey(Credential credential, string directory)
        {
            var path = Path.Combine(directory, $"{credential.Rfc}.key");
            File.WriteAllBytes(path, Convert.FromBase64String(credential.PrivateKeyBase64));
            return path;
        }

        public string ExportPairText(Credential credential, string directory)
        {
            var path = Path.Combine(directory, $"{credential.Rfc}.txt");
            var content = string.Concat(
                "cer:", credential.CertificateBase64, "\n",
                "key:", credential.PrivateKeyBase64, "\n",
                "pass:", credential.Password, "\n",
                "type:", credential.Type.ToString());
            File.WriteAllText(path, content);
            return path;
        }

        public string SaveBase64ToFile(string base64, string extension, string directory)
        {
            if (string.IsNullOrWhiteSpace(base64))
                throw new ArgumentException("Base64 content is required.", nameof(base64));
            if (string.IsNullOrWhiteSpace(extension))
                throw new ArgumentException("Extension is required.", nameof(extension));

            if (!extension.StartsWith('.'))
                extension = "." + extension;

            var extensionName = extension.TrimStart('.').ToUpperInvariant();
            var fileName = $"{extensionName}{extension.ToLowerInvariant()}";
            var path = Path.Combine(directory, fileName);

            File.WriteAllBytes(path, Convert.FromBase64String(base64));
            return path;
        }
    }
}
