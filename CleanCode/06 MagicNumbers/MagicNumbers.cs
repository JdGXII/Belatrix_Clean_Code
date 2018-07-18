
namespace CleanCode.MagicNumbers
{
    public class MagicNumbers
    {
        public void ApproveDocument(int status)
        {
            if (status == DocumentStatus.documentApprovedAsInt)
            {
                // ...
            }
            else if (status == DocumentStatus.documentDeniedAsInt)
            {
                // ...
            }
        }

        public void RejectDoument(string status)
        {

            switch (status)
            {
                case DocumentStatus.documentApprovedAsString:
                    // ...
                    break;
                case DocumentStatus.documentDeniedAsString:
                    // ...
                    break;
            }
        }
    }

    public static class DocumentStatus
    {
        public const string documentApprovedAsString = "1";
        public const string documentDeniedAsString = "2";
        public const int documentApprovedAsInt = 1;
        public const int documentDeniedAsInt = 2;
    }
}
