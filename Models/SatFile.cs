using Credencials.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificatesTool.Models
{
    internal class SatFile
    {
        /// <summary>
        /// Gets or sets file encoded in base 64
        /// 1- https://stackoverflow.com/questions/2030847/best-way-to-read-a-large-file-into-a-byte-array-in-c
        /// 2- https://stackoverflow.com/questions/11743160/how-do-i-encode-and-decode-a-base64-string
        /// </summary>
        public string? Base64File { get; set; }

        /// <summary>
        /// Gets or sets the file type.
        /// The tax authority in Mexico always issues a .cer and .key file.
        /// The .key file is password protected, it must be specified in the password property of this object.
        /// Accepts two values. 'cer' and 'key' (without apostrophes).
        /// 0=CertificateCsd,
        /// 1=PrivateKeyCsd,
        /// 2=CertificateFiel,
        /// 3=PrivateKeyFiel,
        /// 4=Pfx,
        /// </summary>
        public FileType FileType { get; set; }

        /// <summary>
        /// Gets or sets the password to access the .key file
        /// Must be base 64 encoded.
        /// </summary>
        public string? Password { get; set; }

        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string? Rfc { get; set; }
        public string? RazonSocial { get; set; }
    }
}