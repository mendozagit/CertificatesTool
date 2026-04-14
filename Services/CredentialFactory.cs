using Fiscalapi.Credentials.Core;

using Credential = CertificatesTool.Models.Credential;

namespace CertificatesTool.Services
{
    internal sealed class CredentialFactory
    {
        public Credential CreateFromFiles(string cerPath, string keyPath, string password)
        {
            if (!File.Exists(cerPath))
                throw new FileNotFoundException("Certificate file not found.", cerPath);
            if (!File.Exists(keyPath))
                throw new FileNotFoundException("Private key file not found.", keyPath);
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password is required.", nameof(password));

            var cerBase64 = Convert.ToBase64String(File.ReadAllBytes(cerPath));
            var keyBase64 = Convert.ToBase64String(File.ReadAllBytes(keyPath));

            var certificate = new Certificate(cerBase64);
            var privateKey = new PrivateKey(keyBase64, password);

            var now = DateTime.UtcNow;
            return new Credential
            {
                Id = Guid.NewGuid(),
                Rfc = certificate.Rfc,
                RazonSocial = certificate.Organization,
                ValidFrom = certificate.ValidFrom,
                ValidTo = certificate.ValidTo,
                CertificateBase64 = certificate.PlainBase64,
                PrivateKeyBase64 = privateKey.Base64,
                Password = password,
                CreatedAt = now,
                UpdatedAt = now
            };
        }
    }
}
