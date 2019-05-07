using Microsoft.WindowsAzure.Storage.Table;

namespace WebApplication1.Services
{
    public interface IStorageService
    {
        CloudTableClient GetTableClient();
    }
}
