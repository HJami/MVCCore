using Microsoft.AspNetCore.Mvc;
using Microsoft.WindowsAzure.Storage.Table;
using WebApplication1.Services;
using Microsoft.Azure.ServiceBus;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1
{
    public class HomeController : Controller
    {
        private readonly IStorageService _storageService;

        public HomeController([FromServices] IStorageService __storageService)
        {
            _storageService = __storageService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var tbl = _storageService.GetTableClient().GetTableReference("MyTb1");
            var query = new TableQuery();
            query.Where("PartitionKey eq 'Aus' ");
            var seg = tbl.ExecuteQuerySegmentedAsync(query, null).Result;
            ViewData["A1"] = seg.Results[0].Properties["Prop1"].StringValue;
            return View();
        }

        public IActionResult AddToQueue(string item)
        {
            var bt = Encoding.Unicode.GetBytes(item);
              new QueueClient("Endpoint=sb://hjnamespace.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=QlVpxHO+t8ICpzjpW0qZ8eDU0fKW7zbDEvO2ROxClRs=", "hjqueue")
                    .SendAsync(new Message(bt));
            ViewData["A1"] = item;
            return View("Index");
        }
    }

    
}
