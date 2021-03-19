using HttpSecurePayload.Common;
using HttpSecurePayload.Common.Packages;
using System;
using System.Security.Cryptography;

namespace HttpSecurePayload.Tests.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid identifier = Guid.NewGuid();
            RSAParameters privateAndPublicKey, publicKey;
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                privateAndPublicKey = rsa.ExportParameters(includePrivateParameters: true);
                publicKey = rsa.ExportParameters(includePrivateParameters: false);
            }

            var package = new RSAParametersPackage(identifier, privateAndPublicKey);

            var bytes = package.Bytes;

            var passworkProtectedPackage = new PasswordProtectedPackage(bytes);

            var encryptedBytes = passworkProtectedPackage.Encrypt("teste 123456");

            var cryptografedPassworkProtectedPackage = new PasswordProtectedPackage(encryptedBytes);

            var decryptedBytes = cryptografedPassworkProtectedPackage.Decrypt("teste 123456");

            var deserializedPackage = new RSAParametersPackage(decryptedBytes);

            var deserializedPrivateAndPublicKey = deserializedPackage.Bytes;
        }
    }
}
