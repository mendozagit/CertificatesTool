using System.ComponentModel;
using System.Diagnostics;
using System.Text.Json.Serialization;

using Fiscalapi.Credentials.Core;

namespace CertificatesTool.Models
{
    internal enum CredentialType
    {
        CSD,
        FIEL
    }

    internal sealed class Credential
    {
        private string _certificateBase64 = string.Empty;
        private string _privateKeyBase64 = string.Empty;
        private CredentialType? _cachedType;

        [Browsable(false)]
        public Guid Id { get; set; } = Guid.NewGuid();

        [DisplayName("LEGAL NAME")]
        public string? RazonSocial { get; set; }

        [DisplayName("RFC")]
        public string Rfc { get; set; } = string.Empty;

        [DisplayName("KEY PASSWORD")]
        public string Password { get; set; } = string.Empty;

        [DisplayName("TYPE")]
        [JsonIgnore]
        public CredentialType Type
        {
            get
            {
                if (_cachedType.HasValue)
                    return _cachedType.Value;

                if (string.IsNullOrEmpty(_certificateBase64))
                    return CredentialType.CSD;

                try
                {
                    var certificate = new Certificate(_certificateBase64);
                    _cachedType = certificate.IsFiel()
                        ? CredentialType.FIEL
                        : CredentialType.CSD;
                }
                catch
                {
                    _cachedType = CredentialType.CSD;
                }

                return _cachedType.Value;
            }
        }

        [DisplayName("VALID FROM")]
        public DateTime ValidFrom { get; set; }

        [DisplayName("VALID TO")]
        public DateTime ValidTo { get; set; }

        [Browsable(false)]
        public string CertificateBase64
        {
            get => _certificateBase64;
            set
            {
                Debug.Assert(value is not null && value == value.Trim(),
                    "CertificateBase64 must not contain leading or trailing whitespace.");
                _certificateBase64 = value ?? string.Empty;
                _cachedType = null;
            }
        }

        [Browsable(false)]
        public string PrivateKeyBase64
        {
            get => _privateKeyBase64;
            set
            {
                Debug.Assert(value is not null && value == value.Trim(),
                    "PrivateKeyBase64 must not contain leading or trailing whitespace.");
                _privateKeyBase64 = value ?? string.Empty;
            }
        }

        [Browsable(false)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Browsable(false)]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
