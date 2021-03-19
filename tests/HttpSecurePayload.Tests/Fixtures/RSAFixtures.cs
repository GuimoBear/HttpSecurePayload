using System.Security.Cryptography;

namespace HttpSecurePayload.Tests.Fixtures
{
    public class RSAFixtures
    {
        public RSAParameters PublicAndPrivateRSA2048Parameters;
        public RSAParameters PublicRSA2048Parameters;

        public RSAParameters PublicAndPrivateRSA1024Parameters;
        public RSAParameters PublicRSA1024Parameters;

        public RSAParameters PublicAndPrivateRSA512Parameters;
        public RSAParameters PublicRSA512Parameters;

        public RSAParameters PublicAndPrivateRSA256Parameters;
        public RSAParameters PublicRSA256Parameters;

        public RSAFixtures()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                PublicAndPrivateRSA2048Parameters = rsa.ExportParameters(includePrivateParameters: true);
                PublicRSA2048Parameters = rsa.ExportParameters(includePrivateParameters: false);
            }
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                PublicAndPrivateRSA1024Parameters = rsa.ExportParameters(includePrivateParameters: true);
                PublicRSA1024Parameters = rsa.ExportParameters(includePrivateParameters: false);
            }
            using (var rsa = new RSACryptoServiceProvider(512))
            {
                PublicAndPrivateRSA512Parameters = rsa.ExportParameters(includePrivateParameters: true);
                PublicRSA512Parameters = rsa.ExportParameters(includePrivateParameters: false);
            }
            using (var rsa = new RSACryptoServiceProvider(256))
            {
                PublicAndPrivateRSA256Parameters = rsa.ExportParameters(includePrivateParameters: true);
                PublicRSA256Parameters = rsa.ExportParameters(includePrivateParameters: false);
            }
        }
    }
}
