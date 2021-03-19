using System;

namespace HttpSecurePayload.Common.Exceptions
{
    public class CorruptedPackageException : Exception
    {
        public readonly string PackageName;

        public CorruptedPackageException(string packageName)
            : base("The " + packageName + " has corrupted and should not be used")
        {
            PackageName = packageName;
        }
    }
}
