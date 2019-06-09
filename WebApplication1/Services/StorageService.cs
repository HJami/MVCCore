using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace WebApplication1.Services
{
    public class StorageService: IStorageService
    {
        public CloudStorageAccount stAcc;
        public StorageService()
        {
            stAcc = new CloudStorageAccount(
            new Microsoft.WindowsAzure.Storage.Auth.StorageCredentials
               ("hjstorageacc", "KxoXGHJTTvlGCEjVUsEfcC/iFE5CVLGqdHyjhvY5x5rLSbuh6UtrStk5x0QjVXF9cgg8CMDxIWWcLXXSMD/QmQ=="),
             true);

        }

        public CloudTableClient GetTableClient()
        {
            return stAcc.CreateCloudTableClient();
        }
    }
}
