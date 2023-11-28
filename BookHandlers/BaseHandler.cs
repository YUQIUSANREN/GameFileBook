using BookHandlers.FileHandler;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHandlers
{
    public class BaseHandler
    {
        public IConfiguration _configuration;

        public LiteDBManager liteDb;
        public BaseHandler() {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            _configuration = builder.Build();
            liteDb = new LiteDBManager(_configuration);
        }
    }
}
