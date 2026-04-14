using System.Text;

using Fiscalapi.Credentials.Core;

using FiscalapiCredential = Fiscalapi.Credentials.Core.Credential;
using AppCredential = CertificatesTool.Models.Credential;

namespace CertificatesTool.Services
{
    internal sealed class CryptoService
    {
        public (byte[] Signed, bool IsValid) SignAndVerify(AppCredential credential, string data)
        {
            var certificate = new Certificate(credential.CertificateBase64);
            var privateKey = new PrivateKey(credential.PrivateKeyBase64, credential.Password);
            var fiel = new FiscalapiCredential(certificate, privateKey);

            var signed = fiel.SignData(data);
            var isValid = fiel.VerifyData(Encoding.UTF8.GetBytes(data), signed);
            return (signed, isValid);
        }
    }
}
