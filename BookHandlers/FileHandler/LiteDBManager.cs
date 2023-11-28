using LiteDB;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHandlers.FileHandler
{
    public class LiteDBManager : LiteRepository
    {
        //private UserConfig _config;
        /// <summary>
        /// 数据库操作
        /// </summary>
        public LiteDBManager(IConfiguration configuration) : base(new ConnectionString()
        {
            Filename = configuration.GetSection("DataBase.ConnectionString").Value ?? "datas/litedb.db",
            Upgrade = true
        })
        {
        }

    }
}
